namespace PPE
{
    partial class addfournisseur
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new PPE.AppData();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.textBoxChateau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fournisseurTableAdapter = new PPE.AppDataTableAdapters.FournisseurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNom.Location = new System.Drawing.Point(102, -26);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(154, 22);
            this.textBoxNom.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Telephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Prenom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nom";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Firebrick;
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.Location = new System.Drawing.Point(99, 344);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(70, 30);
            this.btnValider.TabIndex = 38;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Adresse", true));
            this.textBoxAdr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAdr.Location = new System.Drawing.Point(99, 291);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(154, 22);
            this.textBoxAdr.TabIndex = 37;
            // 
            // fournisseurBindingSource
            // 
            this.fournisseurBindingSource.DataMember = "Fournisseur";
            this.fournisseurBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxVille
            // 
            this.textBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Ville", true));
            this.textBoxVille.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxVille.Location = new System.Drawing.Point(99, 246);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(154, 22);
            this.textBoxVille.TabIndex = 36;
            // 
            // textBoxTel
            // 
            this.textBoxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Telephone", true));
            this.textBoxTel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTel.Location = new System.Drawing.Point(99, 203);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(154, 22);
            this.textBoxTel.TabIndex = 35;
            // 
            // textBoxMail
            // 
            this.textBoxMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Mail", true));
            this.textBoxMail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxMail.Location = new System.Drawing.Point(99, 161);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(154, 22);
            this.textBoxMail.TabIndex = 34;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Prenom", true));
            this.textBoxPrenom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPrenom.Location = new System.Drawing.Point(99, 73);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(154, 22);
            this.textBoxPrenom.TabIndex = 33;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Nom", true));
            this.txtBoxNom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxNom.Location = new System.Drawing.Point(99, 27);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(154, 22);
            this.txtBoxNom.TabIndex = 32;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.Location = new System.Drawing.Point(183, 344);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(70, 30);
            this.btnAnnuler.TabIndex = 31;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // textBoxChateau
            // 
            this.textBoxChateau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Chateau", true));
            this.textBoxChateau.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxChateau.Location = new System.Drawing.Point(99, 117);
            this.textBoxChateau.Name = "textBoxChateau";
            this.textBoxChateau.Size = new System.Drawing.Size(154, 22);
            this.textBoxChateau.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Chateau";
            // 
            // fournisseurTableAdapter
            // 
            this.fournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // addfournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 410);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxChateau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addfournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un fournisseur";
            this.Load += new System.EventHandler(this.addfournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox textBoxChateau;
        private System.Windows.Forms.Label label8;
        private AppData appData;
        private System.Windows.Forms.BindingSource fournisseurBindingSource;
        private AppDataTableAdapters.FournisseurTableAdapter fournisseurTableAdapter;
    }
}