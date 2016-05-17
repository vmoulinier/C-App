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
    public partial class viewfournisseur : Form
    {
        public viewfournisseur()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void viewfournisseur_Load(object sender, EventArgs e)
        {
            this.fournisseurTableAdapter.Fill(this.appData.Fournisseur);
            fournisseurBindingSource.DataSource = this.appData.Fournisseur;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer cela ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                fournisseurBindingSource.RemoveCurrent();
                fournisseurTableAdapter.Update(this.appData.Fournisseur);
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                fournisseurBindingSource.EndEdit();
                fournisseurTableAdapter.Update(this.appData.Fournisseur);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addfournisseur ss = new addfournisseur();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewfournisseur ss = new viewfournisseur();
            ss.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from o in this.appData.Fournisseur
                        where o.Nom.Contains(textBox1.Text) || o.Prenom.Contains(textBox1.Text) || o.Mail.Contains(textBox1.Text) 
                        || o.Adresse.Contains(textBox1.Text) || o.Telephone.Contains(textBox1.Text) || o.Chateau.Contains(textBox1.Text)
                        select o;
            dataGridView1.DataSource = query.ToList();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            fournisseur ss = new fournisseur();
            ss.Show();
        }
    }
}
