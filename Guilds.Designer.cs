﻿namespace mmoManager
{
    partial class Guilds
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbo_Guilds = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(145, 266);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbo_Guilds
            // 
            this.lbo_Guilds.FormattingEnabled = true;
            this.lbo_Guilds.Location = new System.Drawing.Point(8, 12);
            this.lbo_Guilds.Name = "lbo_Guilds";
            this.lbo_Guilds.Size = new System.Drawing.Size(120, 277);
            this.lbo_Guilds.TabIndex = 4;
            // 
            // Guilds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 298);
            this.Controls.Add(this.lbo_Guilds);
            this.Controls.Add(this.btn_Close);
            this.Name = "Guilds";
            this.Text = "Guilds";
            this.Load += new System.EventHandler(this.Guilds_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ListBox lbo_Guilds;
    }
}