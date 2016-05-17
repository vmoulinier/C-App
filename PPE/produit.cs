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
    public partial class produit : Form
    {
        public produit()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addproduit ss = new addproduit();
            ss.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewproduit ss = new viewproduit();
            ss.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            home ss = new home();
            ss.Show();
        }
    }
}
