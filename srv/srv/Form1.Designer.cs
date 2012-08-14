namespace srv
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.w1 = new AxMSWinsockLib.AxWinsock();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.w2 = new AxMSWinsockLib.AxWinsock();
            this.w3 = new AxMSWinsockLib.AxWinsock();
            this.w4 = new AxMSWinsockLib.AxWinsock();
            this.w5 = new AxMSWinsockLib.AxWinsock();
            this.w6 = new AxMSWinsockLib.AxWinsock();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.w1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w6)).BeginInit();
            this.SuspendLayout();
            // 
            // w1
            // 
            this.w1.Enabled = true;
            this.w1.Location = new System.Drawing.Point(244, 36);
            this.w1.Name = "w1";
            this.w1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("w1.OcxState")));
            this.w1.Size = new System.Drawing.Size(28, 28);
            this.w1.TabIndex = 0;
            this.w1.DataArrival += new AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEventHandler(this.w1_DataArrival);
            this.w1.ConnectEvent += new System.EventHandler(this.w1_ConnectEvent);
            this.w1.ConnectionRequest += new AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEventHandler(this.w1_ConnectionRequest);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Socket 1:Disconnected";
            // 
            // w2
            // 
            this.w2.Enabled = true;
            this.w2.Location = new System.Drawing.Point(244, 70);
            this.w2.Name = "w2";
            this.w2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("w2.OcxState")));
            this.w2.Size = new System.Drawing.Size(28, 28);
            this.w2.TabIndex = 3;
            // 
            // w3
            // 
            this.w3.Enabled = true;
            this.w3.Location = new System.Drawing.Point(244, 105);
            this.w3.Name = "w3";
            this.w3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("w3.OcxState")));
            this.w3.Size = new System.Drawing.Size(28, 28);
            this.w3.TabIndex = 4;
            // 
            // w4
            // 
            this.w4.Enabled = true;
            this.w4.Location = new System.Drawing.Point(244, 139);
            this.w4.Name = "w4";
            this.w4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("w4.OcxState")));
            this.w4.Size = new System.Drawing.Size(28, 28);
            this.w4.TabIndex = 5;
            // 
            // w5
            // 
            this.w5.Enabled = true;
            this.w5.Location = new System.Drawing.Point(244, 173);
            this.w5.Name = "w5";
            this.w5.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("w5.OcxState")));
            this.w5.Size = new System.Drawing.Size(28, 28);
            this.w5.TabIndex = 6;
            // 
            // w6
            // 
            this.w6.Enabled = true;
            this.w6.Location = new System.Drawing.Point(244, 207);
            this.w6.Name = "w6";
            this.w6.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("w6.OcxState")));
            this.w6.Size = new System.Drawing.Size(28, 28);
            this.w6.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Socket 2:Disconnected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Socket 6:Disconnected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Socket 5:Disconnected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Socket 4:Disconnected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Socket 3:Disconnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.w6);
            this.Controls.Add(this.w5);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.w1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.w1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSWinsockLib.AxWinsock w1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private AxMSWinsockLib.AxWinsock w2;
        private AxMSWinsockLib.AxWinsock w3;
        private AxMSWinsockLib.AxWinsock w4;
        private AxMSWinsockLib.AxWinsock w5;
        private AxMSWinsockLib.AxWinsock w6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

