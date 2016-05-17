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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtUtilisateur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtMotdepasse.Focus();
        }

        private void txtMotdepasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnConnexion.PerformClick();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUtilisateur.Text))
            {
                MessageBox.Show("Veuillez entrer un utilisateur et un mot de passe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUtilisateur.Focus();
                return;
            }
            try
            {
                AppDataTableAdapters.utilisateursTableAdapter utilisateurs = new AppDataTableAdapters.utilisateursTableAdapter();
                AppData.utilisateursDataTable dt = utilisateurs.GetDataByUtilisateurMdp(txtUtilisateur.Text, txtMotdepasse.Text);
                if (dt.Rows.Count > 0 )
                {
                    MessageBox.Show("Vous avez bien été connecté", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    home ss = new home();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Mauvais utilisateur ou mot de passe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
