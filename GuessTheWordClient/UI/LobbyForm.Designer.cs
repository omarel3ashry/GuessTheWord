namespace GuessTheWordClient
{
    partial class LobbyForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lobbyPanel = new Panel();
            sendMsgBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            inputMsgTB = new Guna.UI2.WinForms.Guna2TextBox();
            chatRichTB = new RichTextBox();
            lPanel5 = new Panel();
            createRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            nameLabel = new Label();
            lPicBox1 = new PictureBox();
            lCurvedBtn2 = new CurvedButton();
            lFlowLayoutPanel1 = new FlowLayoutPanel();
            lPanel1 = new Panel();
            lJoinBtn = new Guna.UI2.WinForms.Guna2Button();
            lLabel2 = new Label();
            lLabel1 = new Label();
            lCurvedBtn1 = new CurvedButton();
            lobbyPanel.SuspendLayout();
            lPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lPicBox1).BeginInit();
            lFlowLayoutPanel1.SuspendLayout();
            lPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lobbyPanel
            // 
            lobbyPanel.Controls.Add(sendMsgBtn);
            lobbyPanel.Controls.Add(inputMsgTB);
            lobbyPanel.Controls.Add(chatRichTB);
            lobbyPanel.Controls.Add(lPanel5);
            lobbyPanel.Controls.Add(lFlowLayoutPanel1);
            lobbyPanel.Dock = DockStyle.Fill;
            lobbyPanel.Location = new Point(0, 0);
            lobbyPanel.Name = "lobbyPanel";
            lobbyPanel.Size = new Size(1221, 740);
            lobbyPanel.TabIndex = 0;
            // 
            // sendMsgBtn
            // 
            sendMsgBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendMsgBtn.BackgroundImage = (Image)resources.GetObject("sendMsgBtn.BackgroundImage");
            sendMsgBtn.BackgroundImageLayout = ImageLayout.Stretch;
            sendMsgBtn.DisabledState.BorderColor = Color.DarkGray;
            sendMsgBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            sendMsgBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sendMsgBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sendMsgBtn.FillColor = Color.Transparent;
            sendMsgBtn.Font = new Font("Segoe UI", 9F);
            sendMsgBtn.ForeColor = Color.White;
            sendMsgBtn.Location = new Point(1122, 649);
            sendMsgBtn.Name = "sendMsgBtn";
            sendMsgBtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            sendMsgBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            sendMsgBtn.Size = new Size(79, 60);
            sendMsgBtn.TabIndex = 4;
            sendMsgBtn.Click += OnSendMsgBtnClick;
            // 
            // inputMsgTB
            // 
            inputMsgTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputMsgTB.BorderColor = Color.Black;
            inputMsgTB.BorderRadius = 25;
            inputMsgTB.BorderThickness = 0;
            inputMsgTB.CustomizableEdges = customizableEdges2;
            inputMsgTB.DefaultText = "";
            inputMsgTB.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputMsgTB.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputMsgTB.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputMsgTB.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputMsgTB.FillColor = Color.FromArgb(203, 177, 136);
            inputMsgTB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputMsgTB.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputMsgTB.ForeColor = Color.Black;
            inputMsgTB.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputMsgTB.Location = new Point(303, 677);
            inputMsgTB.Margin = new Padding(5);
            inputMsgTB.Name = "inputMsgTB";
            inputMsgTB.PasswordChar = '\0';
            inputMsgTB.PlaceholderText = "";
            inputMsgTB.SelectedText = "";
            inputMsgTB.ShadowDecoration.CustomizableEdges = customizableEdges3;
            inputMsgTB.Size = new Size(811, 57);
            inputMsgTB.TabIndex = 3;
            inputMsgTB.KeyDown += OnInputTextKeyDown;
            // 
            // chatRichTB
            // 
            chatRichTB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chatRichTB.BackColor = Color.FromArgb(94, 6, 116);
            chatRichTB.ForeColor = Color.White;
            chatRichTB.Location = new Point(290, 85);
            chatRichTB.Name = "chatRichTB";
            chatRichTB.ReadOnly = true;
            chatRichTB.Size = new Size(930, 583);
            chatRichTB.TabIndex = 2;
            chatRichTB.Text = "";
            // 
            // lPanel5
            // 
            lPanel5.Controls.Add(createRoomBtn);
            lPanel5.Controls.Add(nameLabel);
            lPanel5.Controls.Add(lPicBox1);
            lPanel5.Controls.Add(lCurvedBtn2);
            lPanel5.Dock = DockStyle.Top;
            lPanel5.Location = new Point(281, 0);
            lPanel5.Name = "lPanel5";
            lPanel5.Size = new Size(940, 79);
            lPanel5.TabIndex = 1;
            // 
            // createRoomBtn
            // 
            createRoomBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createRoomBtn.BackColor = Color.FromArgb(94, 6, 116);
            createRoomBtn.BorderRadius = 25;
            createRoomBtn.CustomizableEdges = customizableEdges4;
            createRoomBtn.DisabledState.BorderColor = Color.DarkGray;
            createRoomBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            createRoomBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            createRoomBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            createRoomBtn.FillColor = Color.FromArgb(203, 177, 136);
            createRoomBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createRoomBtn.ForeColor = Color.White;
            createRoomBtn.Location = new Point(732, 3);
            createRoomBtn.Name = "createRoomBtn";
            createRoomBtn.ShadowDecoration.CustomizableEdges = customizableEdges5;
            createRoomBtn.Size = new Size(187, 73);
            createRoomBtn.TabIndex = 2;
            createRoomBtn.Text = "Create";
            createRoomBtn.Click += OnCreateRoomBtnClick;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.FromArgb(203, 177, 136);
            nameLabel.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(90, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(68, 30);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // lPicBox1
            // 
            lPicBox1.Image = (Image)resources.GetObject("lPicBox1.Image");
            lPicBox1.Location = new Point(22, 5);
            lPicBox1.Name = "lPicBox1";
            lPicBox1.Size = new Size(71, 63);
            lPicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lPicBox1.TabIndex = 1;
            lPicBox1.TabStop = false;
            // 
            // lCurvedBtn2
            // 
            lCurvedBtn2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lCurvedBtn2.BackColor = Color.FromArgb(203, 177, 136);
            lCurvedBtn2.BackgroundColor = Color.FromArgb(203, 177, 136);
            lCurvedBtn2.BorderColor = Color.PaleVioletRed;
            lCurvedBtn2.BorderRadius = 20;
            lCurvedBtn2.BorderSize = 0;
            lCurvedBtn2.Choosed = false;
            lCurvedBtn2.Enabled = false;
            lCurvedBtn2.FlatAppearance.BorderSize = 0;
            lCurvedBtn2.FlatStyle = FlatStyle.Flat;
            lCurvedBtn2.ForeColor = Color.White;
            lCurvedBtn2.Location = new Point(3, -1);
            lCurvedBtn2.Name = "lCurvedBtn2";
            lCurvedBtn2.Size = new Size(723, 77);
            lCurvedBtn2.TabIndex = 0;
            lCurvedBtn2.TextColor = Color.White;
            lCurvedBtn2.UseVisualStyleBackColor = false;
            // 
            // lFlowLayoutPanel1
            // 
            lFlowLayoutPanel1.AutoScroll = true;
            lFlowLayoutPanel1.Controls.Add(lPanel1);
            lFlowLayoutPanel1.Dock = DockStyle.Left;
            lFlowLayoutPanel1.Location = new Point(0, 0);
            lFlowLayoutPanel1.Name = "lFlowLayoutPanel1";
            lFlowLayoutPanel1.Size = new Size(281, 740);
            lFlowLayoutPanel1.TabIndex = 0;
            // 
            // lPanel1
            // 
            lPanel1.Controls.Add(lJoinBtn);
            lPanel1.Controls.Add(lLabel2);
            lPanel1.Controls.Add(lLabel1);
            lPanel1.Controls.Add(lCurvedBtn1);
            lPanel1.Location = new Point(3, 3);
            lPanel1.Name = "lPanel1";
            lPanel1.Size = new Size(234, 192);
            lPanel1.TabIndex = 0;
            // 
            // lJoinBtn
            // 
            lJoinBtn.BackColor = Color.FromArgb(203, 177, 136);
            lJoinBtn.BorderRadius = 25;
            lJoinBtn.CustomizableEdges = customizableEdges6;
            lJoinBtn.DisabledState.BorderColor = Color.DarkGray;
            lJoinBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            lJoinBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lJoinBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lJoinBtn.FillColor = Color.FromArgb(94, 6, 116);
            lJoinBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lJoinBtn.ForeColor = Color.White;
            lJoinBtn.Location = new Point(32, 133);
            lJoinBtn.Name = "lJoinBtn";
            lJoinBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            lJoinBtn.Size = new Size(187, 51);
            lJoinBtn.TabIndex = 4;
            lJoinBtn.Text = "Join";
            lJoinBtn.Click += joinbutton_Click;
            // 
            // lLabel2
            // 
            lLabel2.AutoSize = true;
            lLabel2.BackColor = Color.FromArgb(203, 177, 136);
            lLabel2.Font = new Font("Segoe Print", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lLabel2.Location = new Point(32, 39);
            lLabel2.Name = "lLabel2";
            lLabel2.Size = new Size(50, 23);
            lLabel2.TabIndex = 3;
            lLabel2.Text = "label2";
            // 
            // lLabel1
            // 
            lLabel1.AutoSize = true;
            lLabel1.BackColor = Color.FromArgb(203, 177, 136);
            lLabel1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lLabel1.Location = new Point(27, 8);
            lLabel1.Name = "lLabel1";
            lLabel1.Size = new Size(86, 40);
            lLabel1.TabIndex = 2;
            lLabel1.Text = "label1";
            // 
            // lCurvedBtn1
            // 
            lCurvedBtn1.BackColor = Color.FromArgb(203, 177, 136);
            lCurvedBtn1.BackgroundColor = Color.FromArgb(203, 177, 136);
            lCurvedBtn1.BorderColor = Color.PaleVioletRed;
            lCurvedBtn1.BorderRadius = 20;
            lCurvedBtn1.BorderSize = 0;
            lCurvedBtn1.Choosed = false;
            lCurvedBtn1.Enabled = false;
            lCurvedBtn1.FlatAppearance.BorderSize = 0;
            lCurvedBtn1.FlatStyle = FlatStyle.Flat;
            lCurvedBtn1.ForeColor = Color.White;
            lCurvedBtn1.Location = new Point(17, 3);
            lCurvedBtn1.Name = "lCurvedBtn1";
            lCurvedBtn1.Size = new Size(217, 187);
            lCurvedBtn1.TabIndex = 0;
            lCurvedBtn1.TextColor = Color.White;
            lCurvedBtn1.UseVisualStyleBackColor = false;
            // 
            // LobbyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 6, 116);
            Controls.Add(lobbyPanel);
            Name = "LobbyForm";
            Size = new Size(1221, 740);
            lobbyPanel.ResumeLayout(false);
            lPanel5.ResumeLayout(false);
            lPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lPicBox1).EndInit();
            lFlowLayoutPanel1.ResumeLayout(false);
            lPanel1.ResumeLayout(false);
            lPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel lobbyPanel;
        private FlowLayoutPanel lFlowLayoutPanel1;
        private Panel lPanel1;
        private CurvedButton lCurvedBtn1;
        private Panel lPanel5;
        private Label lLabel2;
        private Label lLabel1;
        private Guna.UI2.WinForms.Guna2Button lJoinBtn;
        private CurvedButton lCurvedBtn2;
        private Label nameLabel;
        private PictureBox lPicBox1;
        private Guna.UI2.WinForms.Guna2Button createRoomBtn;
        private RichTextBox chatRichTB;
        private Guna.UI2.WinForms.Guna2TextBox inputMsgTB;
        private Guna.UI2.WinForms.Guna2CircleButton sendMsgBtn;
    }
}
