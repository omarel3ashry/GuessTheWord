namespace GuessTheWordServer
{
    enum RoomState { Waiting, Idle, InGame }

    internal class Room
    {
        public ushort RoomId { get; set; }
        public Player PlayerOne { get; set; }
        public Player? PlayerTwo { get; set; }
        public List<Player> Spectators { get; private set; }
        public RoomState State { get; set; }
        public Game TheGame { get; set; }
        public ushort Category { get; set; }

        public ushort CurrentPlayer { get => currentPlayer; }

        private ushort currentPlayer;

        public Room(ushort roomId, Player playerOne, ushort category)
        {
            RoomId = roomId;
            PlayerOne = playerOne;
            PlayerOne.Score = 0;
            Spectators = new List<Player>();
            State = RoomState.Waiting;
            Category = category;
            TheGame = new Game(category);
            currentPlayer = 1;
        }

        // this constructor won't be used, it's just for filling all data at once and testing this data
        public Room(ushort roomId, Player playerOne, Player playerTwo, List<Player> spectators, RoomState state, Game game)
        {
            RoomId = roomId;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            Spectators = spectators;
            State = state;
            TheGame = game;
            currentPlayer = 1;
        }

        public bool StartNewGame()
        {
            if (State == RoomState.Idle)
            {
                PlayerOne.WantToPlayAgain = 0;
                PlayerTwo!.WantToPlayAgain = 0;
                State = RoomState.InGame;
                TheGame = new Game(Category);
                currentPlayer = 1;
                return true;
            }
            return false;
        }

        public bool SelectChar(char ch, out bool isGameOver)
        {
            ushort playerTurn = TheGame.ChooseChar(ch);
            isGameOver = TheGame.IsGameOver;
            if (isGameOver)
            {
                currentPlayer = playerTurn;
                GameEnded(playerTurn);
            }
            if (currentPlayer != playerTurn)
            {
                currentPlayer = playerTurn;
                return false;
            }
            else return true;
        }

        private void GameEnded(int winner)
        {
            if (winner == 1)
            {
                PlayerOne.Score += 1;
                State = RoomState.Idle;

            }
            else if (winner == 2)
            {
                PlayerTwo!.Score += 1;
                State = RoomState.Idle;
            }
        }

        public void SaveGameResult()
        {
            string fileName = string.Concat(@"\", RoomId, "_result.txt");
            string workingDirectory = Environment.CurrentDirectory;
            string fPath = Directory.GetParent(workingDirectory)!.Parent!.FullName + fileName;
            try
            {
                using StreamWriter writer = new StreamWriter(fPath, append: true);
                writer.AutoFlush = true;
                writer.WriteLine($"player1 is {PlayerOne.Name} and score is {PlayerOne.Score}");
                writer.WriteLine($"player2 is {PlayerTwo!.Name} and score is {PlayerTwo.Score}");
                Console.WriteLine($"Game result saved successfully to \n {fPath}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving game result: {ex.Message}");
            }
        }
    }
}
