namespace Testing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playersRichTB = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            roomsRichTB = new RichTextBox();
            newPlayerTB = new TextBox();
            newPlayerBtn = new Button();
            createRoomBtn = new Button();
            createRoomTB = new TextBox();
            JoinRoomBtn = new Button();
            joinRoomIdTB = new TextBox();
            joinPlayerIdTB = new TextBox();
            watchPlayerIdTB = new TextBox();
            watchRoomBtn = new Button();
            watchRoomIdTB = new TextBox();
            startPlayerIdTB = new TextBox();
            startGameBtn = new Button();
            startRoomIdTB = new TextBox();
            leavePlayerIdTB = new TextBox();
            leaveRoomBtn = new Button();
            leaveRoomIdTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            refreshBtn = new Button();
            SuspendLayout();
            // 
            // playersRichTB
            // 
            playersRichTB.Location = new Point(12, 27);
            playersRichTB.Name = "playersRichTB";
            playersRichTB.ReadOnly = true;
            playersRichTB.Size = new Size(452, 243);
            playersRichTB.TabIndex = 0;
            playersRichTB.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Players";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 273);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Rooms";
            // 
            // roomsRichTB
            // 
            roomsRichTB.Location = new Point(12, 291);
            roomsRichTB.Name = "roomsRichTB";
            roomsRichTB.ReadOnly = true;
            roomsRichTB.Size = new Size(452, 243);
            roomsRichTB.TabIndex = 2;
            roomsRichTB.Text = "";
            // 
            // newPlayerTB
            // 
            newPlayerTB.Location = new Point(592, 36);
            newPlayerTB.Name = "newPlayerTB";
            newPlayerTB.Size = new Size(203, 23);
            newPlayerTB.TabIndex = 4;
            // 
            // newPlayerBtn
            // 
            newPlayerBtn.Location = new Point(801, 36);
            newPlayerBtn.Name = "newPlayerBtn";
            newPlayerBtn.Size = new Size(103, 23);
            newPlayerBtn.TabIndex = 5;
            newPlayerBtn.Text = "New Player";
            newPlayerBtn.UseVisualStyleBackColor = true;
            newPlayerBtn.Click += newPlayerBtn_Click;
            // 
            // createRoomBtn
            // 
            createRoomBtn.Location = new Point(801, 120);
            createRoomBtn.Name = "createRoomBtn";
            createRoomBtn.Size = new Size(103, 23);
            createRoomBtn.TabIndex = 7;
            createRoomBtn.Text = "Create Room";
            createRoomBtn.UseVisualStyleBackColor = true;
            createRoomBtn.Click += createRoomBtn_Click;
            // 
            // createRoomTB
            // 
            createRoomTB.Location = new Point(592, 120);
            createRoomTB.Name = "createRoomTB";
            createRoomTB.Size = new Size(203, 23);
            createRoomTB.TabIndex = 6;
            // 
            // JoinRoomBtn
            // 
            JoinRoomBtn.Location = new Point(801, 193);
            JoinRoomBtn.Name = "JoinRoomBtn";
            JoinRoomBtn.Size = new Size(103, 23);
            JoinRoomBtn.TabIndex = 9;
            JoinRoomBtn.Text = "Join Room";
            JoinRoomBtn.UseVisualStyleBackColor = true;
            JoinRoomBtn.Click += JoinRoomBtn_Click;
            // 
            // joinRoomIdTB
            // 
            joinRoomIdTB.Location = new Point(713, 193);
            joinRoomIdTB.Name = "joinRoomIdTB";
            joinRoomIdTB.Size = new Size(82, 23);
            joinRoomIdTB.TabIndex = 8;
            // 
            // joinPlayerIdTB
            // 
            joinPlayerIdTB.Location = new Point(592, 193);
            joinPlayerIdTB.Name = "joinPlayerIdTB";
            joinPlayerIdTB.Size = new Size(115, 23);
            joinPlayerIdTB.TabIndex = 10;
            // 
            // watchPlayerIdTB
            // 
            watchPlayerIdTB.Location = new Point(592, 272);
            watchPlayerIdTB.Name = "watchPlayerIdTB";
            watchPlayerIdTB.Size = new Size(115, 23);
            watchPlayerIdTB.TabIndex = 13;
            // 
            // watchRoomBtn
            // 
            watchRoomBtn.Location = new Point(801, 272);
            watchRoomBtn.Name = "watchRoomBtn";
            watchRoomBtn.Size = new Size(103, 23);
            watchRoomBtn.TabIndex = 12;
            watchRoomBtn.Text = "Watch Room";
            watchRoomBtn.UseVisualStyleBackColor = true;
            watchRoomBtn.Click += watchRoomBtn_Click;
            // 
            // watchRoomIdTB
            // 
            watchRoomIdTB.Location = new Point(713, 272);
            watchRoomIdTB.Name = "watchRoomIdTB";
            watchRoomIdTB.Size = new Size(82, 23);
            watchRoomIdTB.TabIndex = 11;
            // 
            // startPlayerIdTB
            // 
            startPlayerIdTB.Location = new Point(592, 352);
            startPlayerIdTB.Name = "startPlayerIdTB";
            startPlayerIdTB.Size = new Size(115, 23);
            startPlayerIdTB.TabIndex = 16;
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(801, 352);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(103, 23);
            startGameBtn.TabIndex = 15;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // startRoomIdTB
            // 
            startRoomIdTB.Location = new Point(713, 352);
            startRoomIdTB.Name = "startRoomIdTB";
            startRoomIdTB.Size = new Size(82, 23);
            startRoomIdTB.TabIndex = 14;
            // 
            // leavePlayerIdTB
            // 
            leavePlayerIdTB.Location = new Point(592, 431);
            leavePlayerIdTB.Name = "leavePlayerIdTB";
            leavePlayerIdTB.Size = new Size(115, 23);
            leavePlayerIdTB.TabIndex = 19;
            // 
            // leaveRoomBtn
            // 
            leaveRoomBtn.Location = new Point(801, 431);
            leaveRoomBtn.Name = "leaveRoomBtn";
            leaveRoomBtn.Size = new Size(103, 23);
            leaveRoomBtn.TabIndex = 18;
            leaveRoomBtn.Text = "Leave Room";
            leaveRoomBtn.UseVisualStyleBackColor = true;
            leaveRoomBtn.Click += leaveRoomBtn_Click;
            // 
            // leaveRoomIdTB
            // 
            leaveRoomIdTB.Location = new Point(713, 431);
            leaveRoomIdTB.Name = "leaveRoomIdTB";
            leaveRoomIdTB.Size = new Size(82, 23);
            leaveRoomIdTB.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(592, 18);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 20;
            label3.Text = "Player Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(592, 102);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 21;
            label4.Text = "Player Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(592, 175);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 22;
            label5.Text = "Player Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(713, 175);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 23;
            label6.Text = "Room Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(592, 254);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 24;
            label7.Text = "Player Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(592, 334);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 25;
            label8.Text = "Player Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(713, 254);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 26;
            label9.Text = "Room Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(713, 334);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 27;
            label10.Text = "Room Id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(713, 413);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 28;
            label11.Text = "Room Id";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(592, 413);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 29;
            label12.Text = "Player Id";
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(592, 488);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(312, 34);
            refreshBtn.TabIndex = 30;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 544);
            Controls.Add(refreshBtn);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(leavePlayerIdTB);
            Controls.Add(leaveRoomBtn);
            Controls.Add(leaveRoomIdTB);
            Controls.Add(startPlayerIdTB);
            Controls.Add(startGameBtn);
            Controls.Add(startRoomIdTB);
            Controls.Add(watchPlayerIdTB);
            Controls.Add(watchRoomBtn);
            Controls.Add(watchRoomIdTB);
            Controls.Add(joinPlayerIdTB);
            Controls.Add(JoinRoomBtn);
            Controls.Add(joinRoomIdTB);
            Controls.Add(createRoomBtn);
            Controls.Add(createRoomTB);
            Controls.Add(newPlayerBtn);
            Controls.Add(newPlayerTB);
            Controls.Add(label2);
            Controls.Add(roomsRichTB);
            Controls.Add(label1);
            Controls.Add(playersRichTB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox playersRichTB;
        private Label label1;
        private Label label2;
        private RichTextBox roomsRichTB;
        private TextBox newPlayerTB;
        private Button newPlayerBtn;
        private Button createRoomBtn;
        private TextBox createRoomTB;
        private Button JoinRoomBtn;
        private TextBox joinRoomIdTB;
        private TextBox joinPlayerIdTB;
        private TextBox watchPlayerIdTB;
        private Button watchRoomBtn;
        private TextBox watchRoomIdTB;
        private TextBox startPlayerIdTB;
        private Button startGameBtn;
        private TextBox startRoomIdTB;
        private TextBox leavePlayerIdTB;
        private Button leaveRoomBtn;
        private TextBox leaveRoomIdTB;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button refreshBtn;
    }
}
