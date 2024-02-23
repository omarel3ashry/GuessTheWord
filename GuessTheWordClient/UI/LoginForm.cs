using System.Net;

namespace GuessTheWordClient
{
    public partial class LoginForm : Form
    {
        private Client? client;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnConnectBtnClick(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            client = new Client(IPAddress.Loopback, 1414);
            client.OnConnectionChange += (msg) =>
            {
                Invoke(() =>
                {
                    connectBtn.Enabled = false;
                    playBtn.Enabled = true;
                    nameTextBox.Enabled = true;
                });
            };
            client.OnLoginResponse += OnLoginServerResponse;
            client.Connect();
        }



        private void OnPlayClick(object sender, EventArgs e)
        {
            string text = nameTextBox.Text;
            if (!string.IsNullOrEmpty(text.Trim()))
            {
                nameTextBox.Text = "";
                client!.ThePlayer = new Player(IPAddress.Loopback, text);
                var request = new RequestMessage(MessageType.LoginRequest, client.ThePlayer.Id);
                client.SendRequest(request);
            }
            else
            {
                using EmptyNameDialog dialog = new EmptyNameDialog();
                dialog.ShowDialog();
            }
        }

        private void OnLoginServerResponse(ResponseMessage response)
        {
            if (response != null && response.MType == MessageType.LoginResponse && response.Status == 1)
            {
                Invoke(() => EnterLobby(response.Rooms!));
            }
        }

        private void EnterLobby(Dictionary<ushort, Room> rooms)
        {

            LobbyForm lobbyForm = new LobbyForm(client!, rooms);
            MainControl.replaceControl(Main, lobbyForm);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (client != null) client.Disconnect();
        }
    }
}
