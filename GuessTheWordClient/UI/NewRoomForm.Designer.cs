namespace GuessTheWordClient
{
    partial class NewRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRoomForm));
            rPanel1 = new Panel();
            statusBarBtn = new CurvedButton();
            startGameBtn = new CurvedButton();
            leaveRoomBtn = new CurvedButton();
            rPanel2 = new Panel();
            rFlowLayout1 = new FlowLayoutPanel();
            rPanel4 = new Panel();
            rPicBox2 = new PictureBox();
            rCurvedBtn2 = new CurvedButton();
            rPicBox1 = new PictureBox();
            rPanel3 = new Panel();
            p2NameLabel = new Label();
            p2ScoreLabel = new Label();
            p2TagLabel = new Label();
            p1NameLabel = new Label();
            p1ScoreLabel = new Label();
            p1TagLabel = new Label();
            rCurvedBtn1 = new CurvedButton();
            rPanel1.SuspendLayout();
            rPanel2.SuspendLayout();
            rFlowLayout1.SuspendLayout();
            rPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rPicBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPicBox1).BeginInit();
            rPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // rPanel1
            // 
            rPanel1.BackColor = Color.FromArgb(94, 6, 116);
            rPanel1.Controls.Add(statusBarBtn);
            rPanel1.Controls.Add(startGameBtn);
            rPanel1.Controls.Add(leaveRoomBtn);
            rPanel1.Controls.Add(rPanel2);
            rPanel1.Dock = DockStyle.Fill;
            rPanel1.Location = new Point(0, 0);
            rPanel1.Name = "rPanel1";
            rPanel1.Size = new Size(1220, 740);
            rPanel1.TabIndex = 0;
            // 
            // statusBarBtn
            // 
            statusBarBtn.BackColor = Color.FromArgb(203, 177, 136);
            statusBarBtn.BackgroundColor = Color.FromArgb(203, 177, 136);
            statusBarBtn.BorderColor = Color.FromArgb(203, 177, 136);
            statusBarBtn.BorderRadius = 10;
            statusBarBtn.BorderSize = 0;
            statusBarBtn.Choosed = false;
            statusBarBtn.Enabled = false;
            statusBarBtn.FlatAppearance.BorderSize = 0;
            statusBarBtn.FlatStyle = FlatStyle.Flat;
            statusBarBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusBarBtn.ForeColor = Color.Black;
            statusBarBtn.Location = new Point(256, 15);
            statusBarBtn.Name = "statusBarBtn";
            statusBarBtn.Size = new Size(885, 50);
            statusBarBtn.TabIndex = 5;
            statusBarBtn.Text = "Room Status";
            statusBarBtn.TextColor = Color.Black;
            statusBarBtn.UseVisualStyleBackColor = false;
            // 
            // startGameBtn
            // 
            startGameBtn.BackColor = Color.FromArgb(203, 177, 136);
            startGameBtn.BackgroundColor = Color.FromArgb(203, 177, 136);
            startGameBtn.BorderColor = Color.PaleVioletRed;
            startGameBtn.BorderRadius = 20;
            startGameBtn.BorderSize = 0;
            startGameBtn.Choosed = false;
            startGameBtn.Enabled = false;
            startGameBtn.FlatAppearance.BorderSize = 0;
            startGameBtn.FlatStyle = FlatStyle.Flat;
            startGameBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startGameBtn.ForeColor = Color.Black;
            startGameBtn.Location = new Point(256, 670);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(160, 50);
            startGameBtn.TabIndex = 4;
            startGameBtn.Text = "Start";
            startGameBtn.TextColor = Color.Black;
            startGameBtn.UseVisualStyleBackColor = false;
            startGameBtn.Click += OnStartBtnClick;
            // 
            // leaveRoomBtn
            // 
            leaveRoomBtn.BackColor = Color.FromArgb(203, 177, 136);
            leaveRoomBtn.BackgroundColor = Color.FromArgb(203, 177, 136);
            leaveRoomBtn.BorderColor = Color.PaleVioletRed;
            leaveRoomBtn.BorderRadius = 20;
            leaveRoomBtn.BorderSize = 0;
            leaveRoomBtn.Choosed = false;
            leaveRoomBtn.FlatAppearance.BorderSize = 0;
            leaveRoomBtn.FlatStyle = FlatStyle.Flat;
            leaveRoomBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leaveRoomBtn.ForeColor = Color.Black;
            leaveRoomBtn.Location = new Point(970, 670);
            leaveRoomBtn.Name = "leaveRoomBtn";
            leaveRoomBtn.Size = new Size(160, 50);
            leaveRoomBtn.TabIndex = 3;
            leaveRoomBtn.Text = "Leave";
            leaveRoomBtn.TextColor = Color.Black;
            leaveRoomBtn.UseVisualStyleBackColor = false;
            leaveRoomBtn.Click += OnLeaveBtnClicked;
            // 
            // rPanel2
            // 
            rPanel2.Controls.Add(rFlowLayout1);
            rPanel2.Controls.Add(rPanel3);
            rPanel2.Dock = DockStyle.Left;
            rPanel2.Location = new Point(0, 0);
            rPanel2.Name = "rPanel2";
            rPanel2.Size = new Size(250, 740);
            rPanel2.TabIndex = 0;
            // 
            // rFlowLayout1
            // 
            rFlowLayout1.AutoScroll = true;
            rFlowLayout1.Controls.Add(rPanel4);
            rFlowLayout1.Location = new Point(3, 255);
            rFlowLayout1.Name = "rFlowLayout1";
            rFlowLayout1.Size = new Size(244, 482);
            rFlowLayout1.TabIndex = 1;
            // 
            // rPanel4
            // 
            rPanel4.Controls.Add(rPicBox2);
            rPanel4.Controls.Add(rCurvedBtn2);
            rPanel4.Controls.Add(rPicBox1);
            rPanel4.Location = new Point(3, 3);
            rPanel4.Name = "rPanel4";
            rPanel4.Size = new Size(228, 61);
            rPanel4.TabIndex = 0;
            // 
            // rPicBox2
            // 
            rPicBox2.Image = (Image)resources.GetObject("rPicBox2.Image");
            rPicBox2.Location = new Point(156, 7);
            rPicBox2.Name = "rPicBox2";
            rPicBox2.Size = new Size(54, 44);
            rPicBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            rPicBox2.TabIndex = 3;
            rPicBox2.TabStop = false;
            // 
            // rCurvedBtn2
            // 
            rCurvedBtn2.BackColor = Color.FromArgb(203, 177, 136);
            rCurvedBtn2.BackgroundColor = Color.FromArgb(203, 177, 136);
            rCurvedBtn2.BorderColor = Color.PaleVioletRed;
            rCurvedBtn2.BorderRadius = 20;
            rCurvedBtn2.BorderSize = 0;
            rCurvedBtn2.Choosed = false;
            rCurvedBtn2.Enabled = false;
            rCurvedBtn2.FlatAppearance.BorderSize = 0;
            rCurvedBtn2.FlatStyle = FlatStyle.Flat;
            rCurvedBtn2.Font = new Font("Segoe Print", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rCurvedBtn2.ForeColor = Color.Black;
            rCurvedBtn2.Location = new Point(13, 3);
            rCurvedBtn2.Name = "rCurvedBtn2";
            rCurvedBtn2.Size = new Size(212, 50);
            rCurvedBtn2.TabIndex = 2;
            rCurvedBtn2.Text = "Spectators ";
            rCurvedBtn2.TextAlign = ContentAlignment.MiddleLeft;
            rCurvedBtn2.TextColor = Color.Black;
            rCurvedBtn2.UseVisualStyleBackColor = false;
            // 
            // rPicBox1
            // 
            rPicBox1.Image = (Image)resources.GetObject("rPicBox1.Image");
            rPicBox1.Location = new Point(160, 8);
            rPicBox1.Name = "rPicBox1";
            rPicBox1.Size = new Size(44, 39);
            rPicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rPicBox1.TabIndex = 1;
            rPicBox1.TabStop = false;
            // 
            // rPanel3
            // 
            rPanel3.Controls.Add(p2NameLabel);
            rPanel3.Controls.Add(p2ScoreLabel);
            rPanel3.Controls.Add(p2TagLabel);
            rPanel3.Controls.Add(p1NameLabel);
            rPanel3.Controls.Add(p1ScoreLabel);
            rPanel3.Controls.Add(p1TagLabel);
            rPanel3.Controls.Add(rCurvedBtn1);
            rPanel3.Location = new Point(0, 3);
            rPanel3.Name = "rPanel3";
            rPanel3.Size = new Size(250, 246);
            rPanel3.TabIndex = 0;
            // 
            // p2NameLabel
            // 
            p2NameLabel.AutoSize = true;
            p2NameLabel.BackColor = Color.FromArgb(203, 177, 136);
            p2NameLabel.Font = new Font("Segoe Print", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p2NameLabel.Location = new Point(56, 155);
            p2NameLabel.Name = "p2NameLabel";
            p2NameLabel.Size = new Size(63, 30);
            p2NameLabel.TabIndex = 8;
            p2NameLabel.Text = "Name";
            // 
            // p2ScoreLabel
            // 
            p2ScoreLabel.AutoSize = true;
            p2ScoreLabel.BackColor = Color.FromArgb(203, 177, 136);
            p2ScoreLabel.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p2ScoreLabel.Location = new Point(45, 185);
            p2ScoreLabel.Name = "p2ScoreLabel";
            p2ScoreLabel.Size = new Size(66, 30);
            p2ScoreLabel.TabIndex = 7;
            p2ScoreLabel.Text = "Score:";
            // 
            // p2TagLabel
            // 
            p2TagLabel.AutoSize = true;
            p2TagLabel.BackColor = Color.FromArgb(203, 177, 136);
            p2TagLabel.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p2TagLabel.Location = new Point(45, 122);
            p2TagLabel.Name = "p2TagLabel";
            p2TagLabel.Size = new Size(103, 33);
            p2TagLabel.TabIndex = 6;
            p2TagLabel.Text = "Player 2:";
            // 
            // p1NameLabel
            // 
            p1NameLabel.AutoSize = true;
            p1NameLabel.BackColor = Color.FromArgb(203, 177, 136);
            p1NameLabel.Font = new Font("Segoe Print", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p1NameLabel.Location = new Point(56, 54);
            p1NameLabel.Name = "p1NameLabel";
            p1NameLabel.Size = new Size(63, 30);
            p1NameLabel.TabIndex = 5;
            p1NameLabel.Text = "Name";
            // 
            // p1ScoreLabel
            // 
            p1ScoreLabel.AutoSize = true;
            p1ScoreLabel.BackColor = Color.FromArgb(203, 177, 136);
            p1ScoreLabel.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p1ScoreLabel.Location = new Point(45, 84);
            p1ScoreLabel.Name = "p1ScoreLabel";
            p1ScoreLabel.Size = new Size(66, 30);
            p1ScoreLabel.TabIndex = 2;
            p1ScoreLabel.Text = "Score:";
            // 
            // p1TagLabel
            // 
            p1TagLabel.AutoSize = true;
            p1TagLabel.BackColor = Color.FromArgb(203, 177, 136);
            p1TagLabel.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p1TagLabel.Location = new Point(45, 21);
            p1TagLabel.Name = "p1TagLabel";
            p1TagLabel.Size = new Size(103, 33);
            p1TagLabel.TabIndex = 1;
            p1TagLabel.Text = "Player 1:";
            // 
            // rCurvedBtn1
            // 
            rCurvedBtn1.BackColor = Color.FromArgb(203, 177, 136);
            rCurvedBtn1.BackgroundColor = Color.FromArgb(203, 177, 136);
            rCurvedBtn1.BorderColor = Color.PaleVioletRed;
            rCurvedBtn1.BorderRadius = 20;
            rCurvedBtn1.BorderSize = 0;
            rCurvedBtn1.Choosed = false;
            rCurvedBtn1.Enabled = false;
            rCurvedBtn1.FlatAppearance.BorderSize = 0;
            rCurvedBtn1.FlatStyle = FlatStyle.Flat;
            rCurvedBtn1.ForeColor = Color.White;
            rCurvedBtn1.Location = new Point(19, 12);
            rCurvedBtn1.Name = "rCurvedBtn1";
            rCurvedBtn1.Size = new Size(215, 225);
            rCurvedBtn1.TabIndex = 0;
            rCurvedBtn1.TextColor = Color.White;
            rCurvedBtn1.UseVisualStyleBackColor = false;
            // 
            // NewRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(rPanel1);
            Name = "NewRoomForm";
            Size = new Size(1220, 740);
            rPanel1.ResumeLayout(false);
            rPanel2.ResumeLayout(false);
            rFlowLayout1.ResumeLayout(false);
            rPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rPicBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPicBox1).EndInit();
            rPanel3.ResumeLayout(false);
            rPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel rPanel1;
        private Panel rPanel2;
        private Panel rPanel3;
        private Label p1TagLabel;
        private CurvedButton rCurvedBtn1;
        private Label p1ScoreLabel;
        private FlowLayoutPanel rFlowLayout1;
        private Panel rPanel4;
        private PictureBox rPicBox1;
        private CurvedButton rCurvedBtn2;
        private PictureBox rPicBox2;
        private CurvedButton leaveRoomBtn;
        private Label p1NameLabel;
        private Label p2NameLabel;
        private Label p2ScoreLabel;
        private Label p2TagLabel;
        private CurvedButton startGameBtn;
        private CurvedButton statusBarBtn;
    }
}
