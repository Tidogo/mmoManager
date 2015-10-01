using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmoManager
{
    public partial class Main : Form
    {
        private MMORPGModel db = new MMORPGModel();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cbo_Accounts.DataSource = db.Accounts.ToList();
            cbo_Accounts.DisplayMember = "AccountName";
            cbo_Accounts.ValueMember = "AccountID";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GetChars_Click(object sender, EventArgs e)
        {
            lbo_Chars.DataSource = null;
            //For some reason this doesn't capture the display member of the selected index. Not sure why.
            //String accname = cbo_Accounts.SelectedText;
            List<Character> chrs = new List<Character>();
            int accid = Convert.ToInt32(cbo_Accounts.SelectedValue);
            IEnumerable<Character> charquery =
                from chars in db.Characters
                where chars.AccountID == accid
                select chars;
            foreach (Character chars in charquery)
            {
                chrs.Add(chars);
            }
            if (chrs.Count == 0)
            {
                MessageBox.Show("This account does not have any characters created.");
            }
            else {
                lbo_Chars.DataSource = chrs;
                lbo_Chars.DisplayMember = "CharName";
                lbo_Chars.ValueMember = "CharacterID";
            }
        }

        private void lbo_Chars_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_GetInfo_Click(object sender, EventArgs e)
        {
            Character character = new Character();
            int charid = Convert.ToInt32(lbo_Chars.SelectedValue);
            IEnumerable<Character> charquery =
                from chars in db.Characters
                where chars.CharacterID == charid
                select chars;
            foreach (Character chars in charquery)
            {
                character = chars;
            }
            txt_CharClass.Text = character.CharClass.ToString();
            txt_CharID.Text = character.CharacterID.ToString();
            txt_CharLvl.Text = character.CharLevel.ToString();
            txt_CharGuild.Text = character.CharGuild.ToString();
        }

        private void btn_ViewServers_Click(object sender, EventArgs e)
        {
            Servers sv = new Servers();
            sv.ShowDialog();
        }
    }
}
