namespace Server.Views
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.IpTB = new System.Windows.Forms.TextBox();
            this.LocalhostCB = new System.Windows.Forms.CheckBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClientPortLabel = new System.Windows.Forms.Label();
            this.ClientIpLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openXmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.XmlTB = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.PortTB);
            this.panel1.Controls.Add(this.IpTB);
            this.panel1.Controls.Add(this.LocalhostCB);
            this.panel1.Controls.Add(this.DisconnectBtn);
            this.panel1.Controls.Add(this.ConnectBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 167);
            this.panel1.TabIndex = 0;
            // 
            // PortTB
            // 
            this.PortTB.Location = new System.Drawing.Point(51, 46);
            this.PortTB.MaxLength = 5;
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(100, 20);
            this.PortTB.TabIndex = 10;
            this.PortTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortTB_KeyPress);
            // 
            // IpTB
            // 
            this.IpTB.Location = new System.Drawing.Point(51, 23);
            this.IpTB.Name = "IpTB";
            this.IpTB.Size = new System.Drawing.Size(100, 20);
            this.IpTB.TabIndex = 9;
            this.IpTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpTB_KeyPress);
            // 
            // LocalhostCB
            // 
            this.LocalhostCB.AutoSize = true;
            this.LocalhostCB.Location = new System.Drawing.Point(52, 73);
            this.LocalhostCB.Name = "LocalhostCB";
            this.LocalhostCB.Size = new System.Drawing.Size(68, 17);
            this.LocalhostCB.TabIndex = 9;
            this.LocalhostCB.Text = "localhost";
            this.LocalhostCB.UseVisualStyleBackColor = true;
            this.LocalhostCB.CheckedChanged += new System.EventHandler(this.LocalhostCB_CheckedChanged);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(84, 95);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(67, 28);
            this.DisconnectBtn.TabIndex = 4;
            this.DisconnectBtn.Text = "disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(17, 95);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(56, 28);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ClientPortLabel);
            this.panel2.Controls.Add(this.ClientIpLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 93);
            this.panel2.TabIndex = 1;
            // 
            // ClientPortLabel
            // 
            this.ClientPortLabel.AutoSize = true;
            this.ClientPortLabel.Location = new System.Drawing.Point(62, 56);
            this.ClientPortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientPortLabel.Name = "ClientPortLabel";
            this.ClientPortLabel.Size = new System.Drawing.Size(16, 13);
            this.ClientPortLabel.TabIndex = 6;
            this.ClientPortLabel.Text = "...";
            // 
            // ClientIpLabel
            // 
            this.ClientIpLabel.AutoSize = true;
            this.ClientIpLabel.Location = new System.Drawing.Point(62, 33);
            this.ClientIpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientIpLabel.Name = "ClientIpLabel";
            this.ClientIpLabel.Size = new System.Drawing.Size(16, 13);
            this.ClientIpLabel.TabIndex = 5;
            this.ClientIpLabel.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client";
            // 
            // openXmlFileDialog
            // 
            this.openXmlFileDialog.FileName = "openXmlFileDialog";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.XmlTB);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.OpenFileBtn);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(184, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 366);
            this.panel3.TabIndex = 2;
            // 
            // XmlTB
            // 
            this.XmlTB.Location = new System.Drawing.Point(4, 171);
            this.XmlTB.Margin = new System.Windows.Forms.Padding(2);
            this.XmlTB.Name = "XmlTB";
            this.XmlTB.ReadOnly = true;
            this.XmlTB.Size = new System.Drawing.Size(301, 162);
            this.XmlTB.TabIndex = 8;
            this.XmlTB.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "image";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "text";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 26);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(123, 127);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(126, 336);
            this.OpenFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(56, 28);
            this.OpenFileBtn.TabIndex = 4;
            this.OpenFileBtn.Text = "Open file";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "XML";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "STATUS:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(66, 140);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(27, 13);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "N/A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 386);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Server";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ClientPortLabel;
        private System.Windows.Forms.Label ClientIpLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openXmlFileDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox XmlTB;
        private System.Windows.Forms.CheckBox LocalhostCB;
        private System.Windows.Forms.TextBox PortTB;
        private System.Windows.Forms.TextBox IpTB;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label11;
    }
}