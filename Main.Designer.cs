namespace mmoManager
{
    partial class Main
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
            this.cbo_Accounts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbo_Chars = new System.Windows.Forms.ListBox();
            this.btn_GetChars = new System.Windows.Forms.Button();
            this.txt_CharID = new System.Windows.Forms.TextBox();
            this.txt_CharClass = new System.Windows.Forms.TextBox();
            this.txt_CharLvl = new System.Windows.Forms.TextBox();
            this.txt_CharGuild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ViewServers = new System.Windows.Forms.Button();
            this.btn_ViewGuilds = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_GetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_Accounts
            // 
            this.cbo_Accounts.FormattingEnabled = true;
            this.cbo_Accounts.Location = new System.Drawing.Point(12, 34);
            this.cbo_Accounts.Name = "cbo_Accounts";
            this.cbo_Accounts.Size = new System.Drawing.Size(121, 21);
            this.cbo_Accounts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accounts:";
            // 
            // lbo_Chars
            // 
            this.lbo_Chars.FormattingEnabled = true;
            this.lbo_Chars.Location = new System.Drawing.Point(12, 95);
            this.lbo_Chars.Name = "lbo_Chars";
            this.lbo_Chars.Size = new System.Drawing.Size(120, 121);
            this.lbo_Chars.TabIndex = 2;
            this.lbo_Chars.SelectedIndexChanged += new System.EventHandler(this.lbo_Chars_SelectedIndexChanged);
            // 
            // btn_GetChars
            // 
            this.btn_GetChars.Location = new System.Drawing.Point(160, 32);
            this.btn_GetChars.Name = "btn_GetChars";
            this.btn_GetChars.Size = new System.Drawing.Size(75, 23);
            this.btn_GetChars.TabIndex = 3;
            this.btn_GetChars.Text = "Get Chars";
            this.btn_GetChars.UseVisualStyleBackColor = true;
            this.btn_GetChars.Click += new System.EventHandler(this.btn_GetChars_Click);
            // 
            // txt_CharID
            // 
            this.txt_CharID.Location = new System.Drawing.Point(351, 118);
            this.txt_CharID.Name = "txt_CharID";
            this.txt_CharID.Size = new System.Drawing.Size(30, 20);
            this.txt_CharID.TabIndex = 4;
            // 
            // txt_CharClass
            // 
            this.txt_CharClass.Location = new System.Drawing.Point(259, 196);
            this.txt_CharClass.Name = "txt_CharClass";
            this.txt_CharClass.Size = new System.Drawing.Size(122, 20);
            this.txt_CharClass.TabIndex = 6;
            // 
            // txt_CharLvl
            // 
            this.txt_CharLvl.Location = new System.Drawing.Point(351, 144);
            this.txt_CharLvl.Name = "txt_CharLvl";
            this.txt_CharLvl.Size = new System.Drawing.Size(30, 20);
            this.txt_CharLvl.TabIndex = 7;
            // 
            // txt_CharGuild
            // 
            this.txt_CharGuild.Location = new System.Drawing.Point(281, 170);
            this.txt_CharGuild.Name = "txt_CharGuild";
            this.txt_CharGuild.Size = new System.Drawing.Size(100, 20);
            this.txt_CharGuild.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Character ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Character Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Character Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Character Guild:";
            // 
            // btn_ViewServers
            // 
            this.btn_ViewServers.Location = new System.Drawing.Point(12, 237);
            this.btn_ViewServers.Name = "btn_ViewServers";
            this.btn_ViewServers.Size = new System.Drawing.Size(84, 37);
            this.btn_ViewServers.TabIndex = 14;
            this.btn_ViewServers.Text = "View Servers";
            this.btn_ViewServers.UseVisualStyleBackColor = true;
            this.btn_ViewServers.Click += new System.EventHandler(this.btn_ViewServers_Click);
            // 
            // btn_ViewGuilds
            // 
            this.btn_ViewGuilds.Location = new System.Drawing.Point(156, 237);
            this.btn_ViewGuilds.Name = "btn_ViewGuilds";
            this.btn_ViewGuilds.Size = new System.Drawing.Size(79, 37);
            this.btn_ViewGuilds.TabIndex = 15;
            this.btn_ViewGuilds.Text = "View Guilds";
            this.btn_ViewGuilds.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(303, 237);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 37);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_GetInfo
            // 
            this.btn_GetInfo.Location = new System.Drawing.Point(156, 95);
            this.btn_GetInfo.Name = "btn_GetInfo";
            this.btn_GetInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_GetInfo.TabIndex = 17;
            this.btn_GetInfo.Text = "Get Info";
            this.btn_GetInfo.UseVisualStyleBackColor = true;
            this.btn_GetInfo.Click += new System.EventHandler(this.btn_GetInfo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 280);
            this.Controls.Add(this.btn_GetInfo);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ViewGuilds);
            this.Controls.Add(this.btn_ViewServers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CharGuild);
            this.Controls.Add(this.txt_CharLvl);
            this.Controls.Add(this.txt_CharClass);
            this.Controls.Add(this.txt_CharID);
            this.Controls.Add(this.btn_GetChars);
            this.Controls.Add(this.lbo_Chars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Accounts);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Accounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbo_Chars;
        private System.Windows.Forms.Button btn_GetChars;
        private System.Windows.Forms.TextBox txt_CharID;
        private System.Windows.Forms.TextBox txt_CharClass;
        private System.Windows.Forms.TextBox txt_CharLvl;
        private System.Windows.Forms.TextBox txt_CharGuild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ViewServers;
        private System.Windows.Forms.Button btn_ViewGuilds;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_GetInfo;
    }
}