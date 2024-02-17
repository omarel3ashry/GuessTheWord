    
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
    }
}
