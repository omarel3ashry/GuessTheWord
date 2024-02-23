namespace GuessTheWordClient
{
    partial class EmptyNameDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyNameDialog));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            okBtn = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 177, 136);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(okBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 339);
            panel1.TabIndex = 0;
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
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeBtn.Size = new Size(64, 63);
            closeBtn.TabIndex = 8;
            closeBtn.Click += OnCloseBtnClick;
            // 
            // okBtn
            // 
            okBtn.BorderRadius = 25;
            okBtn.CustomizableEdges = customizableEdges5;
            okBtn.DisabledState.BorderColor = Color.DarkGray;
            okBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            okBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            okBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            okBtn.FillColor = Color.FromArgb(94, 6, 71);
            okBtn.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            okBtn.ForeColor = Color.White;
            okBtn.Location = new Point(287, 274);
            okBtn.Name = "okBtn";
            okBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            okBtn.Size = new Size(82, 56);
            okBtn.TabIndex = 6;
            okBtn.Text = "OK";
            okBtn.Click += guna2Button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, -7);
            label1.Name = "label1";
            label1.Size = new Size(539, 61);
            label1.TabIndex = 4;
            label1.Text = "Please Enter Your Name First";
            // 
            // EmptyNameDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 339);
            Controls.Add(panel1);
            Name = "EmptyNameDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "checkname";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button okBtn;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
    }
}