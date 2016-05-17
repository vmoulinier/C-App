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
    public partial class addfournisseur : Form
    {
        public addfournisseur()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNom.Text) || string.IsNullOrEmpty(textBoxPrenom.Text) || string.IsNullOrEmpty(textBoxMail.Text) 
                || string.IsNullOrEmpty(textBoxAdr.Text) || string.IsNullOrEmpty(textBoxTel.Text) || string.IsNullOrEmpty(textBoxVille.Text) || string.IsNullOrEmpty(textBoxChateau.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                fournisseurBindingSource.EndEdit();
                fournisseurTableAdapter.Update(this.appData.Fournisseur);
                MessageBox.Show("Fournisseur enregistré !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fournisseurBindingSource.ResetBindings(false);
            }
        }

        private void addfournisseur_Load(object sender, EventArgs e)
        {
            this.fournisseurTableAdapter.Fill(this.appData.Fournisseur);
            fournisseurBindingSource.DataSource = this.appData.Fournisseur;
            this.appData.Fournisseur.Rows.Add(this.appData.Fournisseur.NewFournisseurRow());
            fournisseurBindingSource.MoveLast();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            fournisseurBindingSource.ResetBindings(false);
        }
    }
}
