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
    public partial class viewproduit : Form
    {
        public viewproduit()
        {
            InitializeComponent();
        }

        private void viewproduit_Load(object sender, EventArgs e)
        {        
            this.produitTableAdapter.Fill(this.appData.Produit);
            produitBindingSource.DataSource = this.appData.Produit;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            produit ss = new produit();
            ss.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer cela ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    produitBindingSource.RemoveCurrent();
                produitTableAdapter.Update(this.appData.Produit);
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                produitBindingSource.EndEdit();
                produitTableAdapter.Update(this.appData.Produit);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addproduit ss = new addproduit();
            ss.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from o in this.appData.Produit
                        where o.libelle.Contains(textBox1.Text) || o.annee.Contains(textBox1.Text) || o.type.Contains(textBox1.Text) 
                        || o.prix.Contains(textBox1.Text)
                        select o;
            dataGridView1.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewproduit ss = new viewproduit();
            ss.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
