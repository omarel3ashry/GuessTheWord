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

        private void newPlayerBtn_Click(object sender, EventArgs e)
        {
            Player player = new Player(int.Parse(newPlayerTB.Text), "Rana");
            server.NewPlayerConnected(player);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ShowPlayersData(server.Players);
            ShowRoomsData(server.Rooms);
        }

        private void createRoomBtn_Click(object sender, EventArgs e)
        {
            foreach (Player player in server.Players)
            {
                if (player.Id == int.Parse(createRoomTB.Text))
                {
                    server.RequestCreateRoom(player);
                    MessageBox.Show("Room Created");
                }
            }
        }

        private void JoinRoomBtn_Click(object sender, EventArgs e)
        {
            bool rightPlayer = false;
            Player pl = new Player(1, "Reem");
            foreach (Player player in server.Players)
            {
                if (player.Id == int.Parse(joinPlayerIdTB.Text))
                {
                    pl = player;
                    rightPlayer = true;
                }
            }

            bool rightRoom = false;
            Room ro = new Room(1, pl);
            foreach (Room room in server.Rooms)
            {
                if (room.RoomId == int.Parse(joinRoomIdTB.Text))
                {
                    ro = room;
                    rightRoom = true;
                }
            }

            if (rightRoom && rightPlayer)
            {
                server.RequestJoin(pl, ro);
            }
        }

        private void watchRoomBtn_Click(object sender, EventArgs e)
        {
            bool rightPlayer = false;
            Player pl = new Player(1, "Reem");
            foreach (Player player in server.Players)
            {
                if (player.Id == int.Parse(watchPlayerIdTB.Text))
                {
                    pl = player;
                    rightPlayer = true;
                }
            }

            bool rightRoom = false;
            Room ro = new Room(1, pl);
            foreach (Room room in server.Rooms)
            {
                if (room.RoomId == int.Parse(watchRoomIdTB.Text))
                {
                    ro = room;
                    rightRoom = true;
                }
            }

            if (rightRoom && rightPlayer)
            {
                server.RequestWatch(pl, ro);
            }
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            foreach (Player player in server.Players)
            {
                if (player.Id == int.Parse(startPlayerIdTB.Text) && player.RoomId == int.Parse(startRoomIdTB.Text)
                    && player.State == PlayerState.One)
                {
                    server.RequestStartGame(player);
                }
            }
        }

        private void leaveRoomBtn_Click(object sender, EventArgs e)
        {
            foreach (Player player in server.Players)
            {
                if (player.Id == int.Parse(leavePlayerIdTB.Text) && player.RoomId == int.Parse(leaveRoomIdTB.Text))
                {
                    server.RequestLeave(player);
                }
            }
        }
    }
}
