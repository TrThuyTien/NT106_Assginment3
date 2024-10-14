namespace BT5_UDPSocket
{
    partial class UDP_Server
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
            lbl_Port = new Label();
            tb_Port = new TextBox();
            btn_Listen = new Button();
            tb_Status = new TextBox();
            lbl_Title = new Label();
            btn_Stop = new Button();
            SuspendLayout();
            // 
            // lbl_Port
            // 
            lbl_Port.AutoSize = true;
            lbl_Port.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Port.Location = new Point(23, 93);
            lbl_Port.Name = "lbl_Port";
            lbl_Port.Size = new Size(49, 23);
            lbl_Port.TabIndex = 0;
            lbl_Port.Text = "Port";
            // 
            // tb_Port
            // 
            tb_Port.Font = new Font("Cambria", 12F);
            tb_Port.Location = new Point(89, 84);
            tb_Port.Multiline = true;
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(155, 39);
            tb_Port.TabIndex = 1;
            // 
            // btn_Listen
            // 
            btn_Listen.Font = new Font("Cambria", 12F);
            btn_Listen.Location = new Point(260, 84);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(110, 41);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // tb_Status
            // 
            tb_Status.Font = new Font("Cambria", 12F);
            tb_Status.Location = new Point(24, 151);
            tb_Status.Multiline = true;
            tb_Status.Name = "tb_Status";
            tb_Status.ScrollBars = ScrollBars.Both;
            tb_Status.Size = new Size(440, 304);
            tb_Status.TabIndex = 3;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(182, 28);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(99, 33);
            lbl_Title.TabIndex = 4;
            lbl_Title.Text = "Server";
            // 
            // btn_Stop
            // 
            btn_Stop.Font = new Font("Cambria", 12F);
            btn_Stop.Location = new Point(385, 84);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(79, 41);
            btn_Stop.TabIndex = 5;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // UDP_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(485, 483);
            Controls.Add(btn_Stop);
            Controls.Add(lbl_Title);
            Controls.Add(tb_Status);
            Controls.Add(btn_Listen);
            Controls.Add(tb_Port);
            Controls.Add(lbl_Port);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UDP_Server";
            Text = "UDP_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Port;
        private TextBox tb_Port;
        private Button btn_Listen;
        private TextBox tb_Status;
        private Label lbl_Title;
        private Button btn_Stop;
    }
}