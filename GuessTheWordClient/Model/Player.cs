using System.Net;

namespace GuessTheWordClient
{
    enum PlayerState { Idle = 0, One = 1, Two = 2, Spectating = 3 }

    internal class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public PlayerState State { get; set; }
        public ushort RoomId { get; set; }
        public ushort Score { get; set; }
        public ushort WantToPlayAgain { get; set; }

        public Player(IPAddress ip, string name)
        {
            Id = string.Concat(name, '#', ip.ToString().Split('.', 4)[3]);
            Name = name;
            State = PlayerState.Idle;
            RoomId = 0;
            Score = 0;
        }

        public Player(string id, string name, PlayerState state,
                      ushort roomId, ushort score, ushort wantToPlayAgain)
        {
            Id = id;
            Name = name;
            State = state;
            RoomId = roomId;
            Score = score;
            WantToPlayAgain = wantToPlayAgain;
        }

    }
}
