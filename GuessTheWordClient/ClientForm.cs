using System.Diagnostics;
using System.Net;
using System.Text;

namespace GuessTheWordClient
{
    public partial class ClientForm : Form
    {
        private Client client;
        Stopwatch watch = new Stopwatch();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void OnConnectBtnClick(object sender, EventArgs e)
        {
            Player player = new Player(IPAddress.Loopback, "Joo");
            client = new Client(IPAddress.Loopback, 1414);
            client.OnConnectionChange += (msg) =>
            {
                Invoke(() =>
                {
                    inputTextBox.Enabled = true;
                    sendBtn.Enabled = true;
                    connectBtn.Enabled = false;
                    disconnectBtn.Enabled = true;
                });
            };
            //client.OnResponse += OnServerResponse;
            //client.OnMessageRecieved += (msg) => richTextBox.Invoke(() => richTextBox.AppendText("\n" + msg));
            client.Connect();
        }
        private void OnDisconnectBtnClick(object sender, EventArgs e)
        {
            client.Disconnect();
            inputTextBox.Enabled = false;
            sendBtn.Enabled = false;
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
        }

        /*  send msg for both client & server  */
        private void SendMessage()
        {
            int request;
            string text = inputTextBox.Text;
            if (!string.IsNullOrEmpty(text) && int.TryParse(text, out request))
            {
                inputTextBox.Text = "";
                watch.Restart();
                //client.SendRequest(request);
                //richTextBox.AppendText("\nYou: " + text);
            }
        }
        
     /*   private void ShowRoomsData(Dictionary<ushort, Room> rooms)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var pair in rooms)
            {
                Room room = pair.Value;
                builder.Append($"RoomId: {pair.Key}").Append("\n");
                builder.Append($"Player 1: {room.PlayerOneId}").Append("\n");
                string p2Name = room.PlayerTwoId == null ? "none" : room.PlayerTwoId;
                builder.Append($"Player 2: {p2Name}").Append("\n");
                builder.Append($"RoomState: {room.State}").Append("\n");
                builder.Append($"Spectators:").Append("\n");
                foreach (var spectatorName in room.Spectators)
                {
                    builder.Append($"  {spectatorName}").Append("\n");
                }
                builder.Append("-----------------------------\n");
            }
            responseRTB.Invoke(() => responseRTB.Text = builder.ToString() + "\n" + watch.ElapsedMilliseconds);
        }*/

     /*   private void OnSendBtnClick(object sender, EventArgs e)
        {
            SendMessage();
        }*/

        private void OnInputTextKeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SendMessage();
            //    e.SuppressKeyPress = true;
            //}
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (client != null) client.Disconnect();
        }
    }
}
