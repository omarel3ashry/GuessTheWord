
namespace Testing
{
    internal class Game
    {
        public int P1Id { get; set; }
        public int P2Id { get; set; }
        public string WordToView { get => _showingChars.ToString(); }


        private bool _p1Turn = true;
        private string _secretWord;
        private char[] _showingChars;
        private int[] _state;

        

class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Guess Word Game!");

            string word = "food";
            Console.WriteLine($"The word has {word.Length} letters.");

            char[] wordToGuess = word.ToLower().ToCharArray();
            char[] guessedLetters = Enumerable.Repeat('_', word.Length).ToArray();

            int currentPlayer = 1;

            Dictionary<int, int> playerScores = new Dictionary<int, int>
        {
            { 1, 0 },
            { 2, 0 }
        };

            HashSet<char> guessedChars = new HashSet<char>();

            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine($"Current word: {string.Join(" ", guessedLetters)}");
                Console.WriteLine($"Player {currentPlayer} guess a letter:");
                ConsoleKeyInfo key = Console.ReadKey();
                char guess = Char.ToLower(key.KeyChar);

                if (!char.IsLetter(guess))
                {
                    Console.WriteLine("Please enter a valid letter.");
                }
                else if (guessedChars.Contains(guess))
                {
                    Console.WriteLine(" ---> You already guessed this letter!");
                }
                else if (wordToGuess.Contains(guess))
                {
                    Console.WriteLine(" --->Correct guess!");

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            guessedLetters[i] = word[i];
                        }
                    }
                    if (string.Join("", guessedLetters) == word)
                    {
                        Console.WriteLine($"Congratulations! Player {currentPlayer} has guessed the word: [{word}]");
                        playerScores[currentPlayer]++; // Increment score
                        gameOver = true; // End the game
                    }
                    else
                    {
                        Console.WriteLine($"Player {currentPlayer} gets to play again!");
                        guessedChars.Add(guess); // Add the guessed character to the set
                    }
                }
                else
                {
                    Console.WriteLine(" ---> Wrong guess!");
                    currentPlayer = currentPlayer == 1 ? 2 : 1; // Switch to the other player
                }
            }

            Console.WriteLine($"Player 1 Score: {playerScores[1]}\nPlayer 2 Score: {playerScores[2]}");
        }
    }

}
}
