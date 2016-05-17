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
    public partial class addproduit : Form
    {
        public addproduit()
        {
            InitializeComponent();
        }

        private void addproduit_Load(object sender, EventArgs e)
        {
            this.anneeTableAdapter.Fill(this.appData.Annee);
            this.typeTableAdapter.Fill(this.appData.type);
            this.fournisseurTableAdapter.Fill(this.appData.Fournisseur);
            this.produitTableAdapter.Fill(this.appData.Produit);
            produitBindingSource.DataSource = this.appData.Produit;
            this.appData.Produit.Rows.Add(this.appData.Produit.NewProduitRow());
            produitBindingSource.MoveLast();

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) 
                || string.IsNullOrEmpty(comboBox3.Text) || string.IsNullOrEmpty(textBoxPrix.Text) || string.IsNullOrEmpty(textBoxStock.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                produitBindingSource.EndEdit();
                produitTableAdapter.Update(this.appData.Produit);
                MessageBox.Show("Produit enregistré !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                produitBindingSource.ResetBindings(false);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            produitBindingSource.ResetBindings(false);
        }
    }
}
