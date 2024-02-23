/*
* @author 3ashry
*/

using System.Diagnostics;

namespace GuessTheWordServer
{
    internal class ControlRoom
    {
        private Dictionary<ushort, Room> _rooms;

        public ControlRoom(Dictionary<ushort, Room> rooms)
        {
            _rooms = rooms;
        }

        public void CreateRoomResponse(Player p, ushort roomId)
        {
            var response = new ResponseMessage(MessageType.CreateRoomResponse, 1, roomId, "", _rooms);
            p.Client.GetStream().Write(response.Serialize());
            p.Client.GetStream().Flush();

            Console.WriteLine(response.ToJsonString());
        }

        public void JoinRoomResponse(Player p, ushort roomId)
        {
            var response = new ResponseMessage(MessageType.JoinRoomResponse, 1, roomId, "", _rooms);

            Console.WriteLine(response.ToJsonString());

            Room room = _rooms[roomId];
            response.Status = 0;
            room.PlayerOne.Client.GetStream().Write(response.Serialize());
            room.PlayerOne.Client.GetStream().Flush();
            response.Status = 1;
            response.Status = response.MType == MessageType.JoinRoomResponse ? (ushort)1 : (ushort)0;
            room.PlayerTwo!.Client.GetStream().Write(response.Serialize());
            room.PlayerTwo.Client.GetStream().Flush();
        }

        public void StartGameResponse(ushort roomId)
        {
            var response = new ResponseMessage(MessageType.StartGameResponse, 1, roomId, "", _rooms);

            Room room = _rooms[roomId];
            room.PlayerOne.Client.GetStream().Write(response.Serialize());
            room.PlayerOne.Client.GetStream().Flush();
            room.PlayerTwo!.Client.GetStream().Write(response.Serialize());
            room.PlayerTwo.Client.GetStream().Flush();

            Console.WriteLine(response.ToJsonString());

            response.Status = 0;
            foreach (var player in room.Spectators)
            {
                player.Client.GetStream().Write(response.Serialize());
                player.Client.GetStream().Flush();
            }

        }

        public void SelectCharResponse(Player p, bool isCorrect)
        {
            ushort turn;
            if (p.State == PlayerState.One)
                turn = isCorrect ? (ushort)1 : (ushort)2;
            else turn = isCorrect ? (ushort)2 : (ushort)1;

            var response = new ResponseMessage(MessageType.SelectCharResponse, turn, p.RoomId, "", _rooms);

            Room room = _rooms[p.RoomId];
            room.PlayerOne.Client.GetStream().Write(response.Serialize());
            room.PlayerOne.Client.GetStream().Flush();

            room.PlayerTwo!.Client.GetStream().Write(response.Serialize());
            room.PlayerTwo.Client.GetStream().Flush();

            Console.WriteLine(response.ToJsonString());

            response.Status = 0;
            foreach (var player in room.Spectators)
            {
                player.Client.GetStream().Write(response.Serialize());
                player.Client.GetStream().Flush();
            }

        }

        public void GameEndedResponse(Player winner, Player loser, string word)
        {
            var winnerResponse = new ResponseMessage(MessageType.GameWin, 1, winner.RoomId, word, _rooms);
            var loserResponse = new ResponseMessage(MessageType.GameLose, 1, winner.RoomId, word, _rooms);
            winner.Client.GetStream().Write(winnerResponse.Serialize());
            winner.Client.GetStream().Flush();
            loser.Client.GetStream().Write(loserResponse.Serialize());
            loser.Client.GetStream().Flush();

            Console.WriteLine(winnerResponse.ToJsonString());
            Console.WriteLine(loserResponse.ToJsonString());

            Room room = _rooms[winner.RoomId];
            foreach (var player in room.Spectators)
            {
                player.Client.GetStream().Write(winnerResponse.Serialize());
                player.Client.GetStream().Flush();
            }
        }

        public void WatchRoomResponse(Player p, Room room)
        {
            var response = new ResponseMessage(MessageType.WatchRoomResponse, 1, room.RoomId, "", _rooms);
            p.Client.GetStream().Write(response.Serialize());
            p.Client.GetStream().Flush();
            Console.WriteLine(response.ToJsonString());
            NotifyMembersAboutWatcher(p.Id, room.RoomId);
        }

        public void NotifyMembersAboutWatcher(string newWatcherId, ushort roomId)
        {
            var response = new ResponseMessage(MessageType.NewWatcherNotification, 1, roomId, "", _rooms);
            Room? room;
            if (_rooms.TryGetValue(roomId, out room))
            {
                if (room.PlayerOne != null && room.PlayerTwo != null)
                {
                    try
                    {
                        room.PlayerOne.Client.GetStream().Write(response.Serialize());
                        room.PlayerOne.Client.GetStream().Flush();
                        room.PlayerTwo!.Client.GetStream().Write(response.Serialize());
                        room.PlayerTwo.Client.GetStream().Flush();
                        foreach (var player in room.Spectators)
                        {
                            if (player.Id != newWatcherId)
                            {
                                player.Client.GetStream().Write(response.Serialize());
                                player.Client.GetStream().Flush();
                            }
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                }

            }
        }

        public void Kick(Room room)
        {
            Kick(room.PlayerOne);
            Kick(room.PlayerTwo);
            Kick(room.Spectators);
        }

        public void Kick(List<Player> spectators)
        {
            foreach (var player in spectators)
            {
                Kick(player);
            }
        }

        public void Kick(Player? p, bool notifyP1 = false)
        {
            if (p != null)
            {
                var response = new ResponseMessage(MessageType.Kick, 1, _rooms);
                p.State = PlayerState.Idle;
                p.Client.GetStream().Write(response.Serialize());
                p.Client.GetStream().Flush();
                if (notifyP1)
                {
                    response.Status = 0;
                    _rooms[p.RoomId].PlayerOne.Client.GetStream().Write(response.Serialize());
                    _rooms[p.RoomId].PlayerOne.Client.GetStream().Flush();
                    Room room = _rooms[p.RoomId];
                    foreach (var player in room.Spectators)
                    {
                        player.Client.GetStream().Write(response.Serialize());
                        player.Client.GetStream().Flush();
                    }
                }
                p.RoomId = 0;
                p.State = PlayerState.Idle;
                Console.WriteLine(response.ToJsonString());
            }
        }
    }
}
