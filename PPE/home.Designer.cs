namespace PPE
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFournisseurs = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wine-Stock";
            // 
            // btnFournisseurs
            // 
            this.btnFournisseurs.BackColor = System.Drawing.Color.Firebrick;
            this.btnFournisseurs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFournisseurs.Location = new System.Drawing.Point(199, 210);
            this.btnFournisseurs.Name = "btnFournisseurs";
            this.btnFournisseurs.Size = new System.Drawing.Size(140, 60);
            this.btnFournisseurs.TabIndex = 1;
            this.btnFournisseurs.Text = "Fournisseurs";
            this.btnFournisseurs.UseVisualStyleBackColor = false;
            this.btnFournisseurs.Click += new System.EventHandler(this.btnFournisseurs_Click);
            // 
            // btnProduits
            // 
            this.btnProduits.BackColor = System.Drawing.Color.Firebrick;
            this.btnProduits.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProduits.Location = new System.Drawing.Point(377, 210);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(140, 60);
            this.btnProduits.TabIndex = 2;
            this.btnProduits.Text = "Produits";
            this.btnProduits.UseVisualStyleBackColor = false;
            this.btnProduits.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Firebrick;
            this.btnClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClient.Location = new System.Drawing.Point(25, 210);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(140, 60);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 354);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnFournisseurs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFournisseurs;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnClient;
    }
}