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
    public partial class addclient : Form
    {
        public addclient()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'appData.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.appData.Client);
            clientBindingSource.DataSource = this.appData.Client;
            this.appData.Client.Rows.Add(this.appData.Client.NewClientRow());
            clientBindingSource.MoveLast();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom.Text) || string.IsNullOrEmpty(textBoxPrenom.Text) || string.IsNullOrEmpty(textBoxMail.Text) || string.IsNullOrEmpty(textBoxAdr.Text)
                || string.IsNullOrEmpty(textBoxTel.Text) || string.IsNullOrEmpty(textBoxVille.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                clientBindingSource.EndEdit();
                clientTableAdapter.Update(this.appData.Client);
                MessageBox.Show("Client enregistré !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientBindingSource.ResetBindings(false);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientBindingSource.ResetBindings(false);
        }
    }
}
