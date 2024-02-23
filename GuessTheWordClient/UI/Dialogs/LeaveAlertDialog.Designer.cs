namespace GuessTheWordClient
{
    partial class LeaveAlertDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveAlertDialog));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            noBtn = new Guna.UI2.WinForms.Guna2Button();
            yesBtn = new Guna.UI2.WinForms.Guna2Button();
            closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            titleLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 177, 136);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(noBtn);
            panel1.Controls.Add(yesBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(titleLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 339);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // noBtn
            // 
            noBtn.BorderRadius = 25;
            noBtn.CustomizableEdges = customizableEdges6;
            noBtn.DisabledState.BorderColor = Color.DarkGray;
            noBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            noBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            noBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            noBtn.FillColor = Color.FromArgb(94, 6, 71);
            noBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noBtn.ForeColor = Color.White;
            noBtn.Location = new Point(374, 288);
            noBtn.Name = "noBtn";
            noBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            noBtn.Size = new Size(160, 56);
            noBtn.TabIndex = 9;
            noBtn.Text = "No";
            noBtn.Click += OnNoBtnClick;
            // 
            // yesBtn
            // 
            yesBtn.BorderRadius = 25;
            yesBtn.CustomizableEdges = customizableEdges8;
            yesBtn.DisabledState.BorderColor = Color.DarkGray;
            yesBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            yesBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            yesBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            yesBtn.FillColor = Color.FromArgb(94, 6, 71);
            yesBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(123, 288);
            yesBtn.Name = "yesBtn";
            yesBtn.ShadowDecoration.CustomizableEdges = customizableEdges9;
            yesBtn.Size = new Size(160, 56);
            yesBtn.TabIndex = 8;
            yesBtn.Text = "Yes";
            yesBtn.Click += OnYesBtnClick;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = (Image)resources.GetObject("closeBtn.BackgroundImage");
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.DisabledState.BorderColor = Color.DarkGray;
            closeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            closeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeBtn.FillColor = Color.Transparent;
            closeBtn.Font = new Font("Segoe UI", 9F);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(589, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeBtn.Size = new Size(64, 63);
            closeBtn.TabIndex = 6;
            closeBtn.Click += OnCloseBtnClick;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(181, 2);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(298, 71);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Are You Sure";
            // 
            // AlertDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 339);
            Controls.Add(panel1);
            MaximumSize = new Size(671, 386);
            MinimumSize = new Size(671, 386);
            Name = "AlertDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "leavegame";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleLabel;
        private Guna.UI2.WinForms.Guna2Button noBtn;
        private Guna.UI2.WinForms.Guna2Button yesBtn;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private PictureBox pictureBox1;
    }
}