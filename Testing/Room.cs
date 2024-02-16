
namespace Testing
{
    enum RoomState { Waiting, Idle, InGame }

    internal class Room
    {
        public int RoomId { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public List<Player> Spectators { get; private set; }
        public RoomState State { get; set; }

        public Room(int roomId, Player playerOne)
        {
            RoomId = roomId;
            PlayerOne = playerOne;
            Spectators = new List<Player>();
            State = RoomState.Waiting;
        }

        // this constructor won't be used, it's just for filling all data at once and testing this data
        public Room(int roomId, Player playerOne, Player playerTwo, List<Player> spectators, RoomState state)
        {
            RoomId = roomId;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            Spectators = spectators;
            State = state;
        }
    }
}
