using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnFournisseurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            fournisseur ss = new fournisseur();
            ss.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            produit ss = new produit();
            ss.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            client ss = new client();
            ss.Show();
        }
    }
}
