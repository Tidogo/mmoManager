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
    public partial class Guilds : Form
    {
        private MMORPGModel db = new MMORPGModel();
        public Guilds()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guilds_Load(object sender, EventArgs e)
        {
            lbo_Guilds.DataSource = db.Guilds.ToList();
            lbo_Guilds.DisplayMember = "GuildName";
            lbo_Guilds.ValueMember = "GuildID";
        }
    }
}
