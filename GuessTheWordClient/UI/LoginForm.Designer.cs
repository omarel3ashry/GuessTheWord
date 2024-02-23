namespace GuessTheWordClient
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Main = new Panel();
            connectBtn = new Guna.UI2.WinForms.Guna2Button();
            playBtn = new Guna.UI2.WinForms.Guna2Button();
            nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            Main.SuspendLayout();
            SuspendLayout();
            // 
            // Main
            // 
            Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main.BackColor = Color.White;
            Main.BackgroundImage = (Image)resources.GetObject("Main.BackgroundImage");
            Main.Controls.Add(connectBtn);
            Main.Controls.Add(playBtn);
            Main.Controls.Add(nameTextBox);
            Main.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Main.Location = new Point(0, 0);
            Main.Name = "Main";
            Main.Size = new Size(1147, 801);
            Main.TabIndex = 3;
            // 
            // connectBtn
            // 
            connectBtn.BackColor = Color.FromArgb(94, 6, 116);
            connectBtn.BorderRadius = 25;
            connectBtn.CustomizableEdges = customizableEdges1;
            connectBtn.DisabledState.BorderColor = Color.DarkGray;
            connectBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            connectBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            connectBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            connectBtn.FillColor = Color.FromArgb(51, 169, 180);
            connectBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            connectBtn.ForeColor = Color.White;
            connectBtn.Location = new Point(776, 680);
            connectBtn.Name = "connectBtn";
            connectBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            connectBtn.Size = new Size(170, 56);
            connectBtn.TabIndex = 6;
            connectBtn.Text = "Connect";
            connectBtn.Click += OnConnectBtnClick;
            // 
            // playBtn
            // 
            playBtn.BackColor = Color.FromArgb(94, 6, 116);
            playBtn.BorderRadius = 25;
            playBtn.CustomizableEdges = customizableEdges3;
            playBtn.DisabledState.BorderColor = Color.DarkGray;
            playBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            playBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            playBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            playBtn.Enabled = false;
            playBtn.FillColor = Color.FromArgb(51, 169, 180);
            playBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playBtn.ForeColor = Color.White;
            playBtn.Location = new Point(952, 680);
            playBtn.Name = "playBtn";
            playBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            playBtn.Size = new Size(170, 56);
            playBtn.TabIndex = 5;
            playBtn.Text = "Play";
            playBtn.Click += OnPlayClick;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(94, 6, 116);
            nameTextBox.BorderColor = Color.White;
            nameTextBox.BorderRadius = 20;
            nameTextBox.BorderThickness = 0;
            nameTextBox.CustomizableEdges = customizableEdges5;
            nameTextBox.DefaultText = "";
            nameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameTextBox.Enabled = false;
            nameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTextBox.ForeColor = Color.Black;
            nameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTextBox.Location = new Point(770, 629);
            nameTextBox.Margin = new Padding(3, 9, 3, 9);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PlaceholderText = "";
            nameTextBox.SelectedText = "";
            nameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            nameTextBox.Size = new Size(350, 39);
            nameTextBox.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 170, 182);
            ClientSize = new Size(1147, 801);
            Controls.Add(Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1163, 838);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "guess form";
            Main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Main;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2Button playBtn;
        private Guna.UI2.WinForms.Guna2Button connectBtn;
    }
}
