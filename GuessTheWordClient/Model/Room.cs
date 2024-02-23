
namespace GuessTheWordClient
{
    enum RoomState { Waiting, Idle, InGame }

    internal class Room
    {
        public ushort RoomId { get; set; }
        public Player PlayerOne { get; set; }
        public Player? PlayerTwo { get; set; }
        public List<string> Spectators { get; set; }
        public RoomState State { get; set; }
        public Game TheGame { get; set; }

        public Room(ushort roomId, Player p1, Player? p2, List<string> spectators,
                    RoomState state, Game theGame)
        {
            RoomId = roomId;
            PlayerOne = p1;
            PlayerTwo = p2;
            Spectators = spectators;
            State = state;
            TheGame = theGame;
        }
    }
}
