using System.Diagnostics;

namespace GuessTheWordClient
{
    internal partial class NewRoomForm : UserControl
    {
        public static int count = 0;
        private List<CurvedButton> boardButtons;
        private List<CurvedButton> wordButtons;

        private readonly Color mColor = Color.FromArgb(203, 177, 136);

        private Client _client;
        private Room _room;
        private PlayerState thisPlayer;
        private WinnerDialog? winnerDialog;
        private LoserDialog? loserDialog;

        private LeaveAlertDialog leaveAlertDialog;

        public NewRoomForm(Client client, Room room)
        {
            count++;
            Debug.WriteLine($"{count} instance");

            boardButtons = new List<CurvedButton>();
            wordButtons = new List<CurvedButton>();

            CreateBoardBtnList();

            InitializeComponent();

            leaveAlertDialog = new LeaveAlertDialog();

            _room = room;
            _client = client;
            _client.OnRoomResponse = OnRoomServerResponse;
            thisPlayer = _client.ThePlayer.Id.Equals(_room.PlayerOne.Id) ? PlayerState.One :
                _room.PlayerTwo != null && _client.ThePlayer.Id.Equals(_room.PlayerTwo.Id) ? PlayerState.Two :
                PlayerState.Spectating;

            ValidateBtns();
            UpdateRoomUI();
            GenerateSpecLabelList(_room.Spectators);
            //CreateWordBtnList(_room.TheGame.ShowingChars);
        }

        private void OnDispose(object sender, EventArgs e)
        {
            leaveAlertDialog.Dispose();
        }

        private void UpdateRoomUI()
        {
            p1NameLabel.Text = _room.PlayerOne.Id;
            p1ScoreLabel.Text = string.Concat("Score: ", _room.PlayerOne.Score);
            p2NameLabel.Text = _room.PlayerTwo == null ? "-" : _room.PlayerTwo.Id;
            string p2Score = _room.PlayerTwo == null ? "0" : _room.PlayerTwo.Score.ToString();
            p2ScoreLabel.Text = string.Concat("Score: ", p2Score);

            if (_room.State == RoomState.Waiting)
            {
                statusBarBtn.Text = "Waiting For Player 2";
                startGameBtn.Enabled = false;
                startGameBtn.BackColor = Color.Gray;
                LockBoardButtons();
            }
            else if (_room.State == RoomState.Idle)
            {
                statusBarBtn.Text = "Ready To Start";
                startGameBtn.Enabled = true;
                startGameBtn.BackColor = mColor;

                LockBoardButtons();
            }
            else if (_room.State == RoomState.InGame)
            {
                statusBarBtn.Text = "In-Game";
                if (thisPlayer == PlayerState.One)
                {
                    startGameBtn.Enabled = false;
                    startGameBtn.BackColor = Color.Gray;
                    UnlockBoardButtons();
                }
                else LockBoardButtons();
            }
            ShowLetters(Enumerable.Repeat('_', wordButtons.Count).ToArray());
            Debug.WriteLine("UpdateRoomUI Called");

        }

        private void OnRoomServerResponse(ResponseMessage response)
        {
            Invoke(() =>
            {
                switch (response.MType)
                {
                    case MessageType.JoinRoomResponse:
                        _room = response.Rooms![response.CurrentRoomId];
                        UpdateRoomUI();
                        break;
                    case MessageType.StartGameResponse:
                        _room = response.Rooms![response.CurrentRoomId];
                        UpdateRoomUI();
                        CreateWordBtnList(_room.TheGame.ShowingChars);
                        break;
                    case MessageType.SelectCharResponse:
                        _room = response.Rooms![response.CurrentRoomId];
                        SelectedCharResult(response.Status);
                        break;
                    case MessageType.GameWin:
                        _room = response.Rooms![response.CurrentRoomId];
                        LockBoardButtons();
                        ShowWinnerDialog(response.Word);
                        break;
                    case MessageType.GameLose:
                        _room = response.Rooms![response.CurrentRoomId];
                        LockBoardButtons();
                        ShowLoserDialog(response.Word);
                        break;
                    case MessageType.NewWatcherNotification:
                        _room = response.Rooms![response.CurrentRoomId];
                        GenerateSpecLabelList(_room.Spectators);
                        break;
                    case MessageType.Kick:
                        if (response.Status == 1)
                            SweetKick(response.Rooms!);
                        else KickNotification();
                        break;
                    case MessageType.LeaveRoomResponse:
                        LeaveRoom();
                        break;
                }
            });
        }

        private void SelectedCharResult(ushort turn)
        {
            if ((ushort)thisPlayer == turn)
            {
                UnlockBoardButtons();
            }
            else
            {
                LockBoardButtons();
            }
            ShowLetters(_room.TheGame.ShowingChars);

            for (int i = 0; i < wordButtons.Count; i++)
            {
                if (_room.TheGame.Result[i] == 1)
                {
                    wordButtons[i].BackColor = Color.Blue;
                    wordButtons[i].BackgroundColor = Color.Blue;
                }
                else if (_room.TheGame.Result[i] == 1)
                {
                    wordButtons[i].BackColor = Color.Yellow;
                    wordButtons[i].BackgroundColor = Color.Yellow;
                }
            }
        }

        private void ShowLetters(char[] letters)
        {
            for (int i = 0; i < wordButtons.Count; i++)
            {
                wordButtons[i].Text = letters[i].ToString();
            }
        }

        private void OnCharBtnClick(object? sender, EventArgs e)
        {
            if (sender is CurvedButton clickedButton)
            {
                _client.RequestSelectChar(char.Parse(clickedButton.Text));
                clickedButton.Choosed = true;
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.Gray;
            }
        }

        private void ValidateBtns()
        {
            if (thisPlayer == PlayerState.Spectating)
            {
                foreach (var btn in boardButtons)
                {
                    btn.Visible = false;
                }
            }

            if (thisPlayer != PlayerState.One)
            {
                startGameBtn.Visible = false;
            }
        }

        private void LockBoardButtons()
        {
            foreach (var btn in boardButtons)
            {
                btn.Enabled = false;
                btn.BackColor = Color.Gray;
            }
        }

        private void UnlockBoardButtons()
        {
            foreach (var btn in boardButtons)
            {
                string word = _room.TheGame.ChoosedChars;
                if (!word.Contains(btn.Text.ToLower()))
                {
                    btn.Enabled = true;
                    btn.BackColor = mColor;
                }
            }
        }

        private void OnLeaveBtnClicked(object sender, EventArgs e)
        {
            if (leaveAlertDialog.ShowDialog() == DialogResult.OK)
            {
                _client.RequestLeaveRoom();
            }
        }

        private void LeaveRoom()
        {
            MessageBox.Show("Leave Room Called");
        }


        private void ShowWinnerDialog(string word)
        {
            ShowLetters(word.ToCharArray());
            string winner = thisPlayer == PlayerState.One ? "One" : "Two";
            string loser = thisPlayer == PlayerState.One ? "Two" : "One";
            if (thisPlayer != PlayerState.Spectating)
            {
                RequestMessage request;
                using (winnerDialog = new WinnerDialog())
                {
                    winnerDialog.ShowDialog();
                    if (winnerDialog.DialogResult == DialogResult.OK)
                    {
                        Debug.WriteLine("Winner DloagResult OK");
                        request = new RequestMessage(MessageType.AcceptPlayAgainRequest, _client.ThePlayer.Id, "", _room.RoomId, '\0', 0);
                        statusBarBtn.Text = $"Waiting For Player {loser} Response";
                        _client.SendRequest(request);
                    }
                    else if (winnerDialog.DialogResult == DialogResult.Cancel)
                    {
                        Debug.WriteLine("Winner DloagResult Cancel");
                        request = new RequestMessage(MessageType.RefusePlayAgainRequest, _client.ThePlayer.Id, "", _room.RoomId, '\0', 0);
                        _client.SendRequest(request);
                    }

                }
            }
            else
            {
                statusBarBtn.Text = $"Player {winner} Won The Game";
            }
        }

        private void ShowLoserDialog(string word)
        {
            ShowLetters(word.ToCharArray());
            string winner = thisPlayer == PlayerState.One ? "One" : "Two";
            if (thisPlayer != PlayerState.Spectating)
            {
                RequestMessage request;
                using (loserDialog = new LoserDialog(_client))
                {
                    DialogResult result = loserDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Debug.WriteLine("Loser DloagResult OK");
                        request = new RequestMessage(MessageType.AcceptPlayAgainRequest, _client.ThePlayer.Id, "", _room.RoomId, '\0', 0);
                        statusBarBtn.Text = $"Waiting For Player {winner} Response";
                        _client.SendRequest(request);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        Debug.WriteLine("Loser DloagResult Cancel");
                        request = new RequestMessage(MessageType.RefusePlayAgainRequest, _client.ThePlayer.Id, "", _room.RoomId, '\0', 0);
                        _client.SendRequest(request);
                    }
                }
            }
            else
            {
                statusBarBtn.Text = $"Player {winner} Won The Game";
            }
        }

        private void RemoveControls()
        {
            foreach (CurvedButton button in boardButtons)
            {
                Controls.Remove(button);
            }
            boardButtons.Clear();
            foreach (CurvedButton button in wordButtons)
            {
                Controls.Remove(button);
            }
            wordButtons.Clear();
        }
        private void SweetKick(Dictionary<ushort, Room> rooms)
        {
            if (winnerDialog != null)
                winnerDialog.Close();
            if (loserDialog != null)
                loserDialog.Close();

            RemoveControls();

            LobbyForm lobbyForm = new LobbyForm(_client, rooms);
            MainControl.replaceControl(rPanel1, lobbyForm);
        }

        private void KickNotification()
        {
            ShowLetters(Enumerable.Repeat('_', wordButtons.Count).ToArray());
            statusBarBtn.Text = "Waiting For Player 2";
            p2NameLabel.Text = "-";
            p2ScoreLabel.Text = "0";
            startGameBtn.Enabled = false;
            LockBoardButtons();
        }

        private void OnStartBtnClick(object sender, EventArgs e)
        {
            _client.RequestStartGame();
        }

        // RoomForm Controls
        private void CreateBoardBtnList()
        {
            boardButtons.Clear();
            int x = 300, y = 370;
            char[][] chars =
            [
                ['Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P'],
                ['A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L'],
                ['Z', 'X', 'C', 'V', 'B', 'N', 'M'],
            ];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                int noOfBtns = i == 0 ? 10 : i == 1 ? 9 : 7;
                int xMargin = i == 0 ? 0 : i == 1 ? 40 : 120;

                for (int j = 0; j < noOfBtns; j++)
                {
                    //buttons.Add(CreateBtn((char)(65 + count), x + (80 * j) + xMargin, y + (80 * i)));
                    boardButtons.Add(CreateBoardBtn(chars[i][j], x + (80 * j) + xMargin, y + (80 * i)));
                    count++;
                }
            }
            Controls.AddRange(boardButtons.ToArray());
        }

        private void GenerateSpecLabelList(List<string> spectators)
        {
            rFlowLayout1.Controls.Clear();
            foreach (var spectator in spectators)
            {
                if (!string.IsNullOrEmpty(spectator))
                    CreateSpectatorsLabel(spectator);
            }
        }

        private void CreateSpectatorsLabel(string name)
        {
            Panel panel = new Panel();
            panel.SuspendLayout();
            // curvedButton
            CurvedButton curvedButton = new CurvedButton();
            curvedButton.BackColor = Color.FromArgb(203, 177, 136);
            curvedButton.BackgroundColor = Color.FromArgb(203, 177, 136);
            curvedButton.BorderColor = Color.PaleVioletRed;
            curvedButton.BorderRadius = 20;
            curvedButton.BorderSize = 0;
            curvedButton.Enabled = false;
            curvedButton.FlatAppearance.BorderSize = 0;
            curvedButton.FlatStyle = FlatStyle.Flat;
            curvedButton.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            curvedButton.ForeColor = Color.Black;
            curvedButton.Location = new Point(13, 3);
            curvedButton.Name = "curvedButtonN";
            curvedButton.Size = new Size(212, 50);
            curvedButton.TabIndex = 2;
            curvedButton.Text = name;
            curvedButton.TextColor = Color.Black;
            curvedButton.UseVisualStyleBackColor = false;
            // panel
            panel.Controls.Add(curvedButton);
            panel.Location = new Point(3, 70);
            panel.Name = "panelN";
            panel.Size = new Size(228, 61);
            panel.TabIndex = 1;

            rFlowLayout1.Controls.Add(panel);
            panel.ResumeLayout(false);
        }

        private CurvedButton CreateBoardBtn(char ch, int x, int y)
        {
            CurvedButton btn = new CurvedButton();

            btn.BackColor = Color.FromArgb(203, 177, 136);
            btn.BackgroundColor = Color.FromArgb(203, 177, 136);
            btn.BorderColor = Color.PaleVioletRed;
            btn.BorderRadius = 25;
            btn.BorderSize = 0;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.Location = new Point(x, y);
            btn.Size = new Size(76, 69);
            btn.Name = string.Concat("char", ch, "Btn");
            btn.Text = ch.ToString();
            btn.TabIndex = 1;
            btn.TextColor = Color.Black;
            btn.UseVisualStyleBackColor = false;
            btn.Click += OnCharBtnClick;
            return btn;

        }

        private void CreateWordBtnList(char[] chars)
        {
            foreach (CurvedButton button in wordButtons)
            {
                rPanel1.Controls.Remove(button);
            }
            wordButtons.Clear();
            int x = 300, y = 220;
            int count = chars.Length;
            int centerX = x + ((800 - (count * 75)) / 2);
            for (int i = 0; i < count; i++)
            {
                wordButtons.Add(CreateWordBtn(chars[i], centerX + (80 * i), y));
            }
            rPanel1.Controls.AddRange(wordButtons.ToArray());
        }

        private CurvedButton CreateWordBtn(char ch, int x, int y)
        {

            CurvedButton btn = new CurvedButton();

            btn.BackColor = Color.White;
            btn.BackgroundColor = Color.White;
            btn.BorderColor = Color.White;
            btn.BorderRadius = 24;
            btn.BorderSize = 3;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatStyle = FlatStyle.Standard;
            btn.ForeColor = Color.Black;
            btn.Location = new Point(x, y);
            btn.Size = new Size(70, 63);
            btn.Name = string.Concat("word", ch, "Btn");
            btn.Text = ch.ToString();
            btn.TabIndex = 1;
            btn.TextColor = Color.Black;
            btn.UseVisualStyleBackColor = false;

            return btn;
        }

        private void DrawText(Graphics g, string text, Font font, int x, int y)
        {
            g.DrawString(text, font, Brushes.White, x, y);
        }
    }
}
