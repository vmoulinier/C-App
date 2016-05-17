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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addclient ss = new addclient();
            ss.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            home ss = new home();
            ss.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewclient ss = new viewclient();
            ss.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
