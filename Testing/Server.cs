
namespace Testing
{
    internal class Server
    {
        public List<Player> Players;
        public List<Room> Rooms { get; }

        public Server()
        {
            Players =
                [
                    new Player(1, "John"),
                    new Player(2, "Dan"),
                    new Player(3, "Morgan"),
                    new Player(4, "Reyan"),
                    new Player(5, "Samoul"),
                ];
            //Rooms = new List<Room>();
            Rooms =
                [
                    new Room(10, Players[0]),
                    new Room(20, Players[1]),
                    new Room(30, Players[2], Players[3], Players, RoomState.InGame)
                ];
        }

        public void NewPlayerConnected(Player p)
        {
            // check if the player doesn't exist, so add to the list
            
            bool idExists = false;

            foreach (Player player in Players)
            {
                if (player.Id == p.Id)
                {
                    idExists = true;
                    MessageBox.Show("Player existed");
                    break;
                }
            }

            if (!idExists)
            {
                p.State = PlayerState.Idle;
                p.RoomId = 0;
                Players.Add(p);
                MessageBox.Show("Player is added");
            }
        }

        public void RequestCreateRoom(Player p)
        {
            // check if the player state is idle, create a room and make him wait
            if(p.State == PlayerState.Idle)
            {
                int RoomCreated = p.Id;
                p.State = PlayerState.One;
                p.RoomId = RoomCreated;
                Room r = new Room(RoomCreated, p);
                r.State = RoomState.Waiting;
                r.PlayerOne = p;
                Rooms.Add(r);
            }
        }

        public void RequestJoin(Player p, Room r)
        {
            // check if the room exists and has a place then join and update room and player data
            if(r.PlayerTwo == null)
            {
                p.RoomId = r.RoomId;
                p.State = PlayerState.Two;
                r.PlayerTwo = p;
                r.State = RoomState.Idle;
            }
            else
            {
                RequestWatch(p, r);
            }
        }

        public void RequestWatch(Player p, Room r)
        {
            // check if the room existsthen add him as a watcher and update his state
            if(r.State == RoomState.InGame)
            {
                p.State = PlayerState.Spectating;
                p.RoomId = r.RoomId;
                r.Spectators.Add(p);
            }
        }

        public void RequestStartGame(Player p)
        {
            // check if the room exists and he is the owner and p2 exists and the game is not already started 
            foreach (Room room in Rooms)
            {
                if(room.RoomId == p.RoomId && room.State == RoomState.Idle)
                {
                    room.State = RoomState.InGame;
                }
            }
        }

        public void RequestLeave(Player p)
        {
            // check if the room exists and he is a member of the room if he is p2 make p1 winner and kick p2,
            // if he is p1 make p2 winner and kick everyone and remove the room
            if(p.State == PlayerState.Two)
            {
                foreach (Room room in Rooms)
                {
                    if(room.RoomId == p.RoomId) 
                    {
                        if (room.State == RoomState.InGame)
                        {
                            foreach (Player player in Players)
                            {
                                if (player.Id == room.PlayerOne.Id)
                                {
                                    player.Score++;
                                }
                            }
                        }
                        room.State = RoomState.Waiting;
                        room.PlayerTwo = null;
                        List<Player> Play = [null];
                        foreach (Player spec in room.Spectators)
                        {
                            spec.State = PlayerState.Idle;
                            spec.RoomId = 0;

                            Play.Add(spec);
                        }
                        foreach(Player pl in Play)
                        {
                            room.Spectators.Remove(pl);
                        }
                    }
                }

                p.State = PlayerState.Idle;
                p.RoomId = 0;
            }
            else if(p.State == PlayerState.One)
            {
                Room r = new Room(p.RoomId, p);
                foreach (Room room in Rooms)
                {
                    if (room.RoomId == p.RoomId)
                    {
                        if (room.PlayerTwo != null)
                        {
                            foreach (Player player in Players)
                            {
                                if (player.Id == room.PlayerTwo.Id)
                                {
                                    player.State = PlayerState.Idle;
                                    if(room.State == RoomState.InGame)
                                    {
                                        player.Score++;
                                    }
                                    player.RoomId = 0;
                                }
                            }
                        }
                        r = room;
                    }
                }
                foreach(Player spec in r.Spectators)
                {
                    spec.State = PlayerState.Idle;
                    spec.RoomId = 0;
                }
                
                Rooms.Remove(r);
                p.State= PlayerState.Idle;
                p.RoomId= 0;
            }
        }

    }
}
