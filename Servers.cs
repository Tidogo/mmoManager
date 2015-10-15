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
    public partial class Servers : Form
    {
        private MMORPGModel db = new MMORPGModel();
        public Servers()
        {
            InitializeComponent();
        }

        private void Servers_Load(object sender, EventArgs e)
        {
            cbo_Servers.DataSource = db.Serves.ToList();
            cbo_Servers.DisplayMember = "ServerName";
            cbo_Servers.ValueMember = "ServerID";

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GetDeets_Click(object sender, EventArgs e)
        {
            txt_Region.Clear();
            Serve selserv = new Serve();
            int servid = Convert.ToInt32(cbo_Servers.SelectedValue);
            IEnumerable<Serve> servquery =
                from servs in db.Serves
                where servs.ServerID == servid
                select servs;
            foreach (Serve srvr in servquery)
            {
                selserv = srvr;
            }
            txt_Region.Text = Convert.ToString(selserv.ServerRegion);
            if (Convert.ToInt32(selserv.ServerStatus) == 1)
            {
                lbl_Status.Text = "Online";
            }
            else
            {
                lbl_Status.Text = "Offline";
            }


        }
    }
}
