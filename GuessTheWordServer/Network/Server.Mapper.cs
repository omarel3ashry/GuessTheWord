using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

/*
* @author 3ashry
*/

namespace GuessTheWordServer
{
    internal partial class Server
    {
        private ushort GenerateId()
        {
            ushort id;
            do
            {
                id = (ushort)_random.Next(1, 60000);
            } while (_rooms.ContainsKey(id));
            return id;
        }

        private void BroadcastMsg(string senderId, string msg)
        {
            foreach (var pair in _players)
            {
                if (pair.Value.State == PlayerState.Idle)
                {
                    string fullMsg = senderId + ": " + msg;
                    var response = new ResponseMessage(MessageType.MsgResponse, 1, fullMsg);
                    try
                    {
                        pair.Value.Client.GetStream().Write(response.Serialize());
                        pair.Value.Client.GetStream().Flush();
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("-----\n" + e.Message + "\n-----");
                    }

                    Console.WriteLine(response.ToJsonString());
                }
            }
        }

        private void BroadcastToIdle()
        {
            foreach (var pair in _players)
            {
                if (pair.Value.State == PlayerState.Idle)
                {
                    var response = new ResponseMessage(MessageType.Update, 1, _rooms);
                    try
                    {
                        pair.Value.Client.GetStream().Write(response.Serialize());
                        pair.Value.Client.GetStream().Flush();
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("-----\n" + e.Message + "\n-----");
                    }

                    Console.WriteLine(response.ToJsonString());
                }
            }
        }

        private void SendResponse(NetworkStream stream, ResponseMessage response)
        {
            stream.Write(response.Serialize());
            stream.Flush();
        }


        private void RequestSwitcher(RequestMessage request)
        {
            switch (request.MType)
            {
                case MessageType.MsgRequest:
                    RequestSendMsg(_players[request.PlayerId], request.Message);
                    break;
                case MessageType.CreateRoomRequest:
                    RequestCreateRoom(_players[request.PlayerId], request.Category);
                    break;
                case MessageType.JoinRoomRequest:
                    RequestJoin(_players[request.PlayerId], _rooms[request.RoomId]);
                    break;
                case MessageType.WatchRoomRequest:
                    RequestWatch(_players[request.PlayerId], _rooms[request.RoomId]);
                    break;
                case MessageType.StartGameRequest:
                    RequestStartGame(_players[request.PlayerId]);
                    break;
                case MessageType.SelectCharRequest:
                    RequestSelectChar(_players[request.PlayerId], request.SelectedChar);
                    break;
                case MessageType.AcceptPlayAgainRequest:
                    RequestAcceptPlayAgain(_players[request.PlayerId]);
                    break;
                case MessageType.RefusePlayAgainRequest:
                    RequestRefusePlayAgain(_players[request.PlayerId]);
                    break;
                case MessageType.LeaveRoomRequest:
                    RequestLeave(_players[request.PlayerId]);
                    break;
            }
        }

        private void RequestSendMsg(Player p, string msg)
        {
            if (p.State == PlayerState.Idle)
            {
                BroadcastMsg(p.Id, msg);
            }
        }

        private void RequestCreateRoom(Player p, ushort category)
        {
            if (p.State == PlayerState.Idle)
            {
                ushort roomId = GenerateId();
                p.State = PlayerState.One;
                p.RoomId = roomId;
                Room room = new Room(roomId, p, category);
                _rooms.Add(roomId, room);
                _controlRoom.CreateRoomResponse(p, roomId);
                BroadcastToIdle();
            }
        }

        private void RequestJoin(Player p, Room r)
        {
            if (r.PlayerTwo == null)
            {
                p.RoomId = r.RoomId;
                p.State = PlayerState.Two;
                r.PlayerTwo = p;
                r.PlayerTwo.Score = 0;
                r.State = RoomState.Idle;
                _controlRoom.JoinRoomResponse(p, r.RoomId);
                BroadcastToIdle();
            }
            else
            {
                RequestWatch(p, r);
            }
        }

        private void RequestWatch(Player p, Room r)
        {
            if (r.State == RoomState.InGame || r.State == RoomState.Idle)
            {
                p.State = PlayerState.Spectating;
                p.RoomId = r.RoomId;
                r.Spectators.Add(p);
                _controlRoom.WatchRoomResponse(p, r);
            }
        }

        private void RequestStartGame(Player p)
        {
            Room? room;
            if (_rooms.TryGetValue(p.RoomId, out room))
            {
                if (room.PlayerTwo != null)
                {
                    room.StartNewGame();
                    _controlRoom.StartGameResponse(room.RoomId);
                }
            }
        }

        private void RequestSelectChar(Player p, char c)
        {
            Room? room;
            if (_rooms.TryGetValue(p.RoomId, out room))
            {
                if (room.State == RoomState.InGame && room.PlayerTwo != null)
                {
                    bool gameOver;
                    bool isCorrect = room.SelectChar(c, out gameOver);
                    if (!gameOver)
                    {
                        _controlRoom.SelectCharResponse(p, isCorrect);
                    }
                    else
                    {
                        string word = room.TheGame.Word;
                        switch (room.CurrentPlayer)
                        {
                            case 1:
                                _controlRoom.GameEndedResponse(room.PlayerOne, room.PlayerTwo, word);
                                break;
                            case 2:
                                _controlRoom.GameEndedResponse(room.PlayerTwo, room.PlayerOne, word);
                                break;
                        }
                    }
                }
            }
        }

        private void RequestAcceptPlayAgain(Player p)
        {
            Room? room;
            if (_rooms.TryGetValue(p.RoomId, out room))
            {
                p.WantToPlayAgain = 1;
                if (room.PlayerOne.WantToPlayAgain == 1 && room.PlayerTwo != null && room.PlayerTwo!.WantToPlayAgain == 1)
                {
                    RequestStartGame(p);
                }
                //else _controlRoom.AcceptPlayAgainResponse(p);
            }
        }

        private void RequestRefusePlayAgain(Player p)
        {
            Room? room;
            if (_rooms.TryGetValue(p.RoomId, out room))
            {
                if (p.RoomId != 0)
                {
                    if (room.PlayerOne != null && room.PlayerTwo != null)
                    {
                        room.SaveGameResult();
                    }
                    _controlRoom.Kick(room.PlayerTwo, true);
                    room.State = RoomState.Waiting;
                    room.PlayerTwo = null;
                    //room.Spectators.Clear();
                }
                BroadcastToIdle();
            }
        }

        private void RequestLeave(Player p)
        {
            Room? room;
            if (_rooms.TryGetValue(p.RoomId, out room))
            {

                if (p.State == PlayerState.Two)
                {
                    if (room.State == RoomState.InGame)
                    {
                        _players[room.PlayerOne.Id].Score++;
                        room.SaveGameResult();
                    }
                    _controlRoom.Kick(room.PlayerTwo, true);
                    _controlRoom.Kick(room.Spectators);
                    room.State = RoomState.Waiting;
                    room.PlayerTwo = null;
                    room.Spectators.Clear();
                }
                else if (p.State == PlayerState.One)
                {
                    if (room.PlayerTwo != null && room.State == RoomState.InGame)
                    {
                        _players[room.PlayerTwo.Id].Score++;
                        room.SaveGameResult();
                    }
                    _controlRoom.Kick(room);
                    _rooms.Remove(room.RoomId);
                }
                else
                {
                    ushort roomId = p.RoomId;
                    _controlRoom.Kick(p);
                    _controlRoom.NotifyMembersAboutWatcher(p.Id, roomId);
                }
                BroadcastToIdle();
            }
        }
    }
}
