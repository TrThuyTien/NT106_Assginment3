namespace UDP_Client
{
    partial class UDP_Client
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
            btb_Clear = new Button();
            lbl_Message = new Label();
            lbl_Port = new Label();
            tb_Port = new TextBox();
            tb_Message = new TextBox();
            lbl_IPAddress = new Label();
            tb_IPAddress = new TextBox();
            btn_Send = new Button();
            lbl_Client = new Label();
            SuspendLayout();
            // 
            // btb_Clear
            // 
            btb_Clear.Cursor = Cursors.Hand;
            btb_Clear.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btb_Clear.Location = new Point(363, 429);
            btb_Clear.Name = "btb_Clear";
            btb_Clear.Size = new Size(86, 33);
            btb_Clear.TabIndex = 19;
            btb_Clear.Text = "Clear";
            btb_Clear.UseVisualStyleBackColor = true;
            btb_Clear.Click += btb_Clear_Click;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.Font = new Font("Cambria", 12F, FontStyle.Bold);
            lbl_Message.Location = new Point(12, 154);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(88, 23);
            lbl_Message.TabIndex = 18;
            lbl_Message.Text = "Message";
            // 
            // lbl_Port
            // 
            lbl_Port.AutoSize = true;
            lbl_Port.Font = new Font("Cambria", 12F, FontStyle.Bold);
            lbl_Port.Location = new Point(346, 106);
            lbl_Port.Name = "lbl_Port";
            lbl_Port.Size = new Size(49, 23);
            lbl_Port.TabIndex = 17;
            lbl_Port.Text = "Port";
            // 
            // tb_Port
            // 
            tb_Port.Location = new Point(401, 108);
            tb_Port.Multiline = true;
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(146, 30);
            tb_Port.TabIndex = 16;
            // 
            // tb_Message
            // 
            tb_Message.Location = new Point(12, 192);
            tb_Message.Multiline = true;
            tb_Message.Name = "tb_Message";
            tb_Message.ScrollBars = ScrollBars.Both;
            tb_Message.Size = new Size(535, 213);
            tb_Message.TabIndex = 15;
            // 
            // lbl_IPAddress
            // 
            lbl_IPAddress.AutoSize = true;
            lbl_IPAddress.Font = new Font("Cambria", 12F, FontStyle.Bold);
            lbl_IPAddress.Location = new Point(12, 108);
            lbl_IPAddress.Name = "lbl_IPAddress";
            lbl_IPAddress.Size = new Size(108, 23);
            lbl_IPAddress.TabIndex = 14;
            lbl_IPAddress.Text = "IP Address";
            // 
            // tb_IPAddress
            // 
            tb_IPAddress.Location = new Point(126, 108);
            tb_IPAddress.Multiline = true;
            tb_IPAddress.Name = "tb_IPAddress";
            tb_IPAddress.Size = new Size(172, 30);
            tb_IPAddress.TabIndex = 13;
            // 
            // btn_Send
            // 
            btn_Send.Cursor = Cursors.Hand;
            btn_Send.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btn_Send.Location = new Point(464, 429);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(82, 33);
            btn_Send.TabIndex = 12;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Listen_Click;
            // 
            // lbl_Client
            // 
            lbl_Client.AutoSize = true;
            lbl_Client.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Client.Location = new Point(218, 24);
            lbl_Client.Name = "lbl_Client";
            lbl_Client.Size = new Size(91, 33);
            lbl_Client.TabIndex = 20;
            lbl_Client.Text = "Client";
            // 
            // UDP_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(558, 474);
            Controls.Add(lbl_Client);
            Controls.Add(btb_Clear);
            Controls.Add(lbl_Message);
            Controls.Add(lbl_Port);
            Controls.Add(tb_Port);
            Controls.Add(tb_Message);
            Controls.Add(lbl_IPAddress);
            Controls.Add(tb_IPAddress);
            Controls.Add(btn_Send);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UDP_Client";
            Text = "UDP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btb_Clear;
        private Label lbl_Message;
        private Label lbl_Port;
        private TextBox tb_Port;
        private TextBox tb_Message;
        private Label lbl_IPAddress;
        private TextBox tb_IPAddress;
        private Button btn_Send;
        private Label lbl_Client;
    }
}