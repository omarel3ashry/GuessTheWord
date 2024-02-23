
namespace GuessTheWordServer
{
    internal class Game
    {
        public string Word { get => _word; }
        public string WordToView { get => new string(_guessedLetters); }
        public ushort[] Result { get => _state; }
        public string ChoosedChars { get => string.Join("", guessedChars); }
        public bool IsGameOver { get => gameOver; }


        private string _word;
        private char[] _wordToGuess;
        private char[] _guessedLetters;
        private ushort[] _state;
        private ushort currentPlayer;
        private Dictionary<int, int> playerScores;
        private HashSet<char> guessedChars;
        private bool gameOver;

        private Dictionary<string, List<string>> Categories;

        public Game(ushort cat)
        {
            Categories = new Dictionary<string, List<string>>();
            string workingDirectory = Environment.CurrentDirectory;
            LoadCategories(Directory.GetParent(workingDirectory)!.Parent!.FullName + @"\catonefile.txt");

            _word = GetRandomWord(cat);
            //_word = "prova";
            _wordToGuess = _word.ToCharArray();
            _guessedLetters = Enumerable.Repeat('_', _word.Length).ToArray();
            _state = new ushort[_word.Length];
            currentPlayer = 1;

            playerScores = new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 }
            };

            guessedChars = new HashSet<char>();
            gameOver = false;
        }

        public ushort ChooseChar(char letter)
        {
            if (!gameOver)
            {
                if (_wordToGuess.Contains(char.ToLower(letter)))
                {
                    for (int i = 0; i < _wordToGuess.Length; i++)
                    {
                        if (_wordToGuess[i] == char.ToLower(letter))
                        {
                            _guessedLetters[i] = _word[i];
                            _state[i] = currentPlayer;
                        }
                    }
                    if (string.Join("", _guessedLetters) == _word)
                    {
                        playerScores[currentPlayer]++;
                        gameOver = true;
                    }
                    guessedChars.Add(char.ToLower(letter));
                }
                else
                {
                    guessedChars.Add(char.ToLower(letter));
                    currentPlayer = currentPlayer == 1 ? (ushort)2 : (ushort)1;
                }
            }
            return currentPlayer;
        }

        private void LoadCategories(string filePath)
        {


            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)//if each line contains exactly two parts (category,words)
                {
                    string categoryName = parts[0].Trim();
                    string[] words = parts[1].Trim().Split(' ');

                    List<string> wordList = new List<string>(words);
                    Categories.Add(categoryName, wordList);
                }
            }
        }
        private string GetRandomWord(ushort cat)
        {
            string category = cat == 1 ? "Animal" : cat == 2 ? "Sports" : "Food";
            if (Categories != null && Categories.ContainsKey(category))
            {
                List<string> selectedCategoryWords = Categories[category];

                if (selectedCategoryWords.Count > 0)
                {
                    return RandomWord(selectedCategoryWords);
                }
            }
            return "none";
        }

        private string RandomWord(List<string> words)
        {

            Random random = new Random();
            int index = random.Next(0, words.Count);
            return words[index];
        }
    }
}
