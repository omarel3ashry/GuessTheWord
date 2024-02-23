using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Diagnostics;

namespace GuessTheWordClient
{
    internal partial class LobbyForm : UserControl
    {
        private Client _client;

        private Dictionary<ushort, Room> _rooms;

        public LobbyForm(Client client, Dictionary<ushort, Room> rooms)
        {
            InitializeComponent();

            _client = client;
            _client.OnLobbyResponse = OnLobbyServerResponse;
            _rooms = rooms;
            lLabel1.Text = "Room: ";
            lLabel2.Text = "Player 1 \nPlayer 2\nSpectators: ";
            nameLabel.Text = "Name: " + _client.ThePlayer.Id;

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            UpdateRooms(_rooms!);
        }

        private void OnLobbyServerResponse(ResponseMessage response)
        {
            switch (response.MType)
            {
                case MessageType.CreateRoomResponse:
                case MessageType.JoinRoomResponse:
                case MessageType.WatchRoomResponse:
                    if (response.Status == 1)
                    {
                        OpenRoom(response);
                    }
                    break;
                case MessageType.MsgResponse:
                    if (IsHandleCreated)
                        Invoke(() => UpdateChat(response.Word));
                    break;
                case MessageType.Update:
                    _rooms = response.Rooms!;
                    if (IsHandleCreated)
                        Invoke(() => UpdateRooms(response.Rooms!));
                    break;
            }
        }

        private void joinbutton_Click(object sender, EventArgs e)
        {
        }

        private void OnCreateRoomBtnClick(object sender, EventArgs e)
        {
            ShowCategoryDialog();
        }

        private void ShowCategoryDialog()
        {
            var request = new RequestMessage(MessageType.CreateRoomRequest, _client.ThePlayer.Id);
            CategoryDialog categoryDialog = new CategoryDialog(request);
            if (categoryDialog.ShowDialog() == DialogResult.OK)
            {
                _client.RequestCreateRoom(request.Category);
            }
        }

        private void JoinRoomRequest(ushort roomId)
        {
            _client.RequestJoinRoom(roomId);
        }

        private void WatchRoomRequest(ushort roomId)
        {
            _client.RequestWatchRoom(roomId);
        }

        private void OpenRoom(ResponseMessage response)
        {
            if (response.Status == 1 && response.Rooms != null)
            {
                Invoke(() =>
                {
                    NewRoomForm newRoomForm = new NewRoomForm(_client, response.Rooms[response.CurrentRoomId]);
                    MainControl.replaceControl(lobbyPanel, newRoomForm);

                });
            }
        }

        private void UpdateRooms(Dictionary<ushort, Room> rooms)
        {
            lFlowLayoutPanel1.Controls.Clear();
            Debug.WriteLine("flowLayoutPanel1 Clear Called");
            if (rooms != null)
                foreach (var pair in rooms)
                {
                    AddRoom(pair.Value);
                }
        }

        private void AddRoom(Room room)
        {
            Panel panel = new Panel();
            panel.SuspendLayout();

            CurvedButton curvedBtn = new CurvedButton();
            Guna2Button joinBtn = new Guna2Button(); ;
            CustomizableEdges mCustomizableEdges = new CustomizableEdges();
            Label label1 = new Label();
            Label label2 = new Label();
            // label1
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(203, 177, 136);
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 8);
            label1.Name = "label11";
            label1.Size = new Size(86, 40);
            label1.TabIndex = 2;
            label1.Text = string.Concat("Room: ", Convert.ToString(room.RoomId));
            // label2
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(203, 177, 136);
            label2.Font = new Font("Segoe Print", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 53);
            label2.Name = "label22";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 3;
            string p2Id = room.PlayerTwo != null ? room.PlayerTwo.Id : "-";
            string text = $"Player 1: {room.PlayerOne.Id}\nPlayer 2: {p2Id}\nSpectators: {room.Spectators.Count}";
            label2.Text = text;
            // CurvedButton
            curvedBtn.BackColor = Color.FromArgb(203, 177, 136);
            curvedBtn.BackgroundColor = Color.FromArgb(203, 177, 136);
            curvedBtn.BorderColor = Color.PaleVioletRed;
            curvedBtn.BorderRadius = 20;
            curvedBtn.BorderSize = 0;
            curvedBtn.Enabled = false;
            curvedBtn.FlatAppearance.BorderSize = 0;
            curvedBtn.FlatStyle = FlatStyle.Flat;
            curvedBtn.ForeColor = Color.White;
            curvedBtn.Location = new Point(17, 3);
            curvedBtn.Name = "curvedButton1";
            curvedBtn.Size = new Size(217, 187);
            curvedBtn.TabIndex = 1;
            curvedBtn.TextColor = Color.White;
            curvedBtn.UseVisualStyleBackColor = false;
            // JoinButton
            joinBtn.BackColor = Color.FromArgb(203, 177, 136);
            joinBtn.BorderRadius = 25;
            joinBtn.CustomizableEdges = mCustomizableEdges;
            joinBtn.DisabledState.BorderColor = Color.DarkGray;
            joinBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            joinBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            joinBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            joinBtn.FillColor = Color.FromArgb(94, 6, 116);
            joinBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            joinBtn.ForeColor = Color.White;
            joinBtn.Location = new Point(32, 133);
            joinBtn.Name = "joinbutton";
            joinBtn.ShadowDecoration.CustomizableEdges = mCustomizableEdges;
            joinBtn.Size = new Size(187, 51);
            joinBtn.TabIndex = 4;
            joinBtn.Text = room.PlayerTwo != null ? "Watch" : "Join";
            joinBtn.Click += (sender, args) =>
            {
                if (room.PlayerTwo == null) JoinRoomRequest(room.RoomId);
                else WatchRoomRequest(room.RoomId);
            };
            // Panel

            panel.Controls.Add(joinBtn);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Controls.Add(curvedBtn);
            panel.Location = new Point(3, 3);
            panel.Name = "panel99";
            panel.Size = new Size(234, 192);
            panel.TabIndex = 0;
            //flowLayoutPanel1.SuspendLayout();
            lFlowLayoutPanel1.Controls.Add(panel);
            //flowLayoutPanel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
        }

        private void OnSendMsgBtnClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputMsgTB.Text))
            {
                string msg = inputMsgTB.Text;
                inputMsgTB.Text = "";
                _client.RequestSendMsg(msg);
            }
        }

        private void OnInputTextKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(inputMsgTB.Text))
                {
                    string msg = inputMsgTB.Text;
                    inputMsgTB.Text = "";
                    _client.RequestSendMsg(msg);
                }
                e.SuppressKeyPress = true;
            }
        }

        private void UpdateChat(string msg)
        {
            chatRichTB.AppendText(msg + "\n");
        }
        


    }
}

