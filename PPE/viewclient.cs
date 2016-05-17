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
    public partial class viewclient : Form
    {
        public viewclient()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void viewclient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'appData.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.appData.Client);
            // TODO: cette ligne de code charge les données dans la table 'appData.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            clientBindingSource.DataSource = this.appData.Client;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer cela ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                clientBindingSource.RemoveCurrent();
                clientTableAdapter.Update(this.appData.Client);
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                clientBindingSource.EndEdit();
                clientTableAdapter.Update(this.appData.Client);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            client ss = new client();
            ss.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from o in this.appData.Client
                        where o.nom.Contains(textBox1.Text) || o.prenom.Contains(textBox1.Text) || o.mail.Contains(textBox1.Text) || o.adresse.Contains(textBox1.Text) || o.telephone.Contains(textBox1.Text)
                        select o;
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addclient ss = new addclient();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewclient ss = new viewclient();
            ss.Show();
        }
    }
}
