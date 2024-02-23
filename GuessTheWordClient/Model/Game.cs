
namespace GuessTheWordClient
{
    internal class Game
    {
        public string ShowingWord { get; set; }
        public char[] ShowingChars { get; set; }
        public string ChoosedChars { get; set; }
        public ushort[] Result { get; set; }


        public Game(char[] showingChars, string choosedChars, ushort[] result)
        {
            ShowingChars = showingChars;
            ShowingWord = new string(showingChars).ToLower();
            ChoosedChars = choosedChars;
            Result = result;
        }
    }
}
