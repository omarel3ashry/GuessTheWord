namespace GuessTheWordClient
{
    partial class ClientForm
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
            connectBtn = new Button();
            sendBtn = new Button();
            inputTextBox = new TextBox();
            disconnectBtn = new Button();
            responseRTB = new RichTextBox();
            SuspendLayout();
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(907, 435);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(207, 29);
            connectBtn.TabIndex = 0;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += OnConnectBtnClick;
            // 
            // sendBtn
            // 
            sendBtn.Enabled = false;
            sendBtn.Location = new Point(907, 252);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(207, 29);
            sendBtn.TabIndex = 1;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            //sendBtn.Click += OnSendBtnClick;
            // 
            // inputTextBox
            // 
            inputTextBox.Enabled = false;
            inputTextBox.Location = new Point(907, 219);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(207, 27);
            inputTextBox.TabIndex = 2;
            inputTextBox.KeyDown += OnInputTextKeyDown;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Enabled = false;
            disconnectBtn.Location = new Point(907, 470);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(207, 29);
            disconnectBtn.TabIndex = 3;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += OnDisconnectBtnClick;
            // 
            // responseRTB
            // 
            responseRTB.Location = new Point(12, 12);
            responseRTB.Name = "responseRTB";
            responseRTB.ReadOnly = true;
            responseRTB.Size = new Size(625, 721);
            responseRTB.TabIndex = 4;
            responseRTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 745);
            Controls.Add(responseRTB);
            Controls.Add(disconnectBtn);
            Controls.Add(inputTextBox);
            Controls.Add(sendBtn);
            Controls.Add(connectBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectBtn;
        private Button sendBtn;
        private TextBox inputTextBox;
        private Button disconnectBtn;
        private RichTextBox responseRTB;
    }
}
