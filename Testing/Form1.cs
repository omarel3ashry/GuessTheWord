using System.Text;

namespace Testing
{
    public partial class Form1 : Form
    {
        private Server server;

        public Form1()
        {
            InitializeComponent();

            server = new Server();
            ShowPlayersData(server.Players);
            ShowRoomsData(server.Rooms);
        }


        private void ShowPlayersData(List<Player> players)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Player player in players)
            {
                builder.Append($"Id: {player.Id}").Append("\n");
                builder.Append($"Name: {player.Name}").Append("\n");
                builder.Append($"PlayerState: {player.State}").Append("\n");
                builder.Append($"RoomId: {player.RoomId}").Append("\n");
                builder.Append("-----------------------------\n");
            }
            playersRichTB.Text = builder.ToString();
        }

        private void ShowRoomsData(List<Room> rooms)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Room room in rooms)
            {
                builder.Append($"RoomId: {room.RoomId}").Append("\n");
                builder.Append($"Player 1: {room.PlayerOne.Name}").Append("\n");
                string p2Name = room.PlayerTwo == null ? "none" : room.PlayerTwo.Name;
                builder.Append($"Player 2: {p2Name}").Append("\n");
                builder.Append($"RoomState: {room.State}").Append("\n");
                builder.Append($"Spectators:").Append("\n");
                foreach (Player player in room.Spectators)
                {
                    builder.Append($"  {player.Name}").Append("\n");
                }
                builder.Append("-----------------------------\n");
            }
            roomsRichTB.Text = builder.ToString();
        }
    }
}
