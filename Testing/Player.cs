
namespace Testing
{
    enum PlayerState { Idle, One, Two, Spectating }

    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlayerState State { get; set; }
        public int RoomId { get; set; }
        public int Score { get; set; }

        // just for testing
        public Server DummyServer;

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            State = PlayerState.Idle;
            RoomId = 0;
            Score = 0;
        }
    }
}
