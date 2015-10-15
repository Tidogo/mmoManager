namespace mmoManager
{
    partial class Servers
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
            this.cbo_Servers = new System.Windows.Forms.ComboBox();
            this.txt_Region = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_GetDeets = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_Servers
            // 
            this.cbo_Servers.FormattingEnabled = true;
            this.cbo_Servers.Location = new System.Drawing.Point(12, 12);
            this.cbo_Servers.Name = "cbo_Servers";
            this.cbo_Servers.Size = new System.Drawing.Size(121, 21);
            this.cbo_Servers.TabIndex = 0;
            // 
            // txt_Region
            // 
            this.txt_Region.Location = new System.Drawing.Point(172, 59);
            this.txt_Region.Name = "txt_Region";
            this.txt_Region.Size = new System.Drawing.Size(100, 20);
            this.txt_Region.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Region:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Status:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(172, 89);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(25, 13);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "???";
            // 
            // btn_GetDeets
            // 
            this.btn_GetDeets.Location = new System.Drawing.Point(172, 10);
            this.btn_GetDeets.Name = "btn_GetDeets";
            this.btn_GetDeets.Size = new System.Drawing.Size(75, 23);
            this.btn_GetDeets.TabIndex = 6;
            this.btn_GetDeets.Text = "Get Details";
            this.btn_GetDeets.UseVisualStyleBackColor = true;
            this.btn_GetDeets.Click += new System.EventHandler(this.btn_GetDeets_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(95, 120);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Servers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_GetDeets);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Region);
            this.Controls.Add(this.cbo_Servers);
            this.Name = "Servers";
            this.Text = "Servers";
            this.Load += new System.EventHandler(this.Servers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Servers;
        private System.Windows.Forms.TextBox txt_Region;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_GetDeets;
        private System.Windows.Forms.Button btn_Close;
    }
}