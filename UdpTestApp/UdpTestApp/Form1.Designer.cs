namespace UdpTestApp
{
    partial class Form1
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
            this.btn_SendUdpPacket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SendUdpPacket
            // 
            this.btn_SendUdpPacket.Location = new System.Drawing.Point(68, 78);
            this.btn_SendUdpPacket.Name = "btn_SendUdpPacket";
            this.btn_SendUdpPacket.Size = new System.Drawing.Size(126, 48);
            this.btn_SendUdpPacket.TabIndex = 0;
            this.btn_SendUdpPacket.Text = "Send UDP Packet";
            this.btn_SendUdpPacket.UseVisualStyleBackColor = true;
            this.btn_SendUdpPacket.Click += new System.EventHandler(this.btn_SendUdpPacket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btn_SendUdpPacket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SendUdpPacket;
    }
}

