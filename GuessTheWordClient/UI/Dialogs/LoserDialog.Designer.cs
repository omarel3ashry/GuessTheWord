namespace GuessTheWordClient
{
    partial class LoserDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoserDialog));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            winlose = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            noBtn = new Guna.UI2.WinForms.Guna2Button();
            yesBtn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            panel1.SuspendLayout();
            winlose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 177, 136);
            panel1.Controls.Add(winlose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 339);
            panel1.TabIndex = 0;
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
            winlose.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(167, 233);
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
            noBtn.Location = new Point(401, 275);
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
            yesBtn.Location = new Point(163, 275);
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
            label1.Location = new Point(93, -16);
            label1.Name = "label1";
            label1.Size = new Size(468, 79);
            label1.TabIndex = 3;
            label1.Text = "You Lost The Game";
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
            // LoserDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 339);
            Controls.Add(panel1);
            Name = "LoserDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loser";
            panel1.ResumeLayout(false);
            winlose.ResumeLayout(false);
            winlose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel winlose;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button noBtn;
        private Guna.UI2.WinForms.Guna2Button yesBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private PictureBox pictureBox1;
    }
}