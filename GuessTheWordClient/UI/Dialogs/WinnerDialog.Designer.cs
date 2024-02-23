namespace GuessTheWordClient
{
    partial class WinnerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerDialog));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            winlose = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            noBtn = new Guna.UI2.WinForms.Guna2Button();
            yesBtn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            winlose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // winlose
            // 
            winlose.BackColor = Color.FromArgb(203, 177, 136);
            winlose.Controls.Add(pictureBox1);
            winlose.Controls.Add(label2);
            winlose.Controls.Add(noBtn);
            winlose.Controls.Add(yesBtn);
            winlose.Controls.Add(label1);
            winlose.Controls.Add(closeBtn);
            winlose.Dock = DockStyle.Fill;
            winlose.Location = new Point(0, 0);
            winlose.Name = "winlose";
            winlose.Size = new Size(653, 339);
            winlose.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(177, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(174, 233);
            label2.Name = "label2";
            label2.Size = new Size(316, 35);
            label2.TabIndex = 6;
            label2.Text = "Do You Want To Play Again ?";
            // 
            // noBtn
            // 
            noBtn.BorderRadius = 25;
            noBtn.CustomizableEdges = customizableEdges1;
            noBtn.DisabledState.BorderColor = Color.DarkGray;
            noBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            noBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            noBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            noBtn.FillColor = Color.FromArgb(94, 6, 71);
            noBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noBtn.ForeColor = Color.White;
            noBtn.Location = new Point(377, 280);
            noBtn.Name = "noBtn";
            noBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            noBtn.Size = new Size(100, 56);
            noBtn.TabIndex = 5;
            noBtn.Text = "No";
            noBtn.Click += OnNoBtnClick;
            // 
            // yesBtn
            // 
            yesBtn.BorderRadius = 25;
            yesBtn.CustomizableEdges = customizableEdges3;
            yesBtn.DisabledState.BorderColor = Color.DarkGray;
            yesBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            yesBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            yesBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            yesBtn.FillColor = Color.FromArgb(94, 6, 71);
            yesBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(177, 280);
            yesBtn.Name = "yesBtn";
            yesBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            yesBtn.Size = new Size(100, 56);
            yesBtn.TabIndex = 4;
            yesBtn.Text = "Yes";
            yesBtn.Click += OnYesBtnClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(92, -4);
            label1.Name = "label1";
            label1.Size = new Size(473, 79);
            label1.TabIndex = 3;
            label1.Text = "You Won The Game";
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
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges5;
            closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeBtn.Size = new Size(64, 63);
            closeBtn.TabIndex = 2;
            closeBtn.Click += OnCloseBtnClick;
            // 
            // WinnerDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 339);
            Controls.Add(winlose);
            Name = "WinnerDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winner";
            winlose.ResumeLayout(false);
            winlose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel winlose;
        private Guna.UI2.WinForms.Guna2Button yesBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button noBtn;
        private PictureBox pictureBox1;
    }
}