
namespace Testing
{
    internal class Server
    {
        public List<Player> Players { get; }
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
            Rooms = new List<Room>();
            /*Rooms =
                [
                    new Room(10, Players[0]),
                    new Room(20, Players[1]),
                    new Room(30, Players[2], Players[3], Players, RoomState.InGame)
                ];*/
        }

        public void NewPlayerConnected(Player p)
        {

        }

        public int RequestCreateRoom(Player p)
        {
            return 0;
        }

        public void RequestJoin(Player p, Room r)
        {

        }

        public void RequestWatch(Player p, Room r)
        {

        }

        public void RequestStartGame(Player p)
        {

        }

        public void RequestLeave(Player p)
        {

        }

    }
}
