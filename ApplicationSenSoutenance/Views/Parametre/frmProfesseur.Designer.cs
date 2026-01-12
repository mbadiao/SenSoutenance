namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmProfesseur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.txtNomP = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtPrenomP = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtEmailP = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtTelephoneP = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtSpecialiteP = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.btnSelectionnerP = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnAjouterP = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnModifierP = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSupprimerP = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.dgProfesseur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomP
            //
            this.txtNomP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtNomP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtNomP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtNomP.BorderRadius = 5;
            this.txtNomP.BorderSize = 2;
            this.txtNomP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNomP.ForeColor = System.Drawing.Color.White;
            this.txtNomP.Location = new System.Drawing.Point(30, 92);
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Padding = new System.Windows.Forms.Padding(7);
            this.txtNomP.PasswordChar = false;
            this.txtNomP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNomP.PlaceholderText = "Entrez le nom";
            this.txtNomP.Size = new System.Drawing.Size(280, 36);
            this.txtNomP.TabIndex = 2;
            this.txtNomP.Texts = "";
            this.txtNomP.UnderlinedStyle = false;
            //
            // lblPrenom
            //
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.ForeColor = System.Drawing.Color.White;
            this.lblPrenom.Location = new System.Drawing.Point(30, 135);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(61, 19);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom";
            //
            // txtPrenomP
            //
            this.txtPrenomP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtPrenomP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtPrenomP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtPrenomP.BorderRadius = 5;
            this.txtPrenomP.BorderSize = 2;
            this.txtPrenomP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenomP.ForeColor = System.Drawing.Color.White;
            this.txtPrenomP.Location = new System.Drawing.Point(30, 157);
            this.txtPrenomP.Name = "txtPrenomP";
            this.txtPrenomP.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrenomP.PasswordChar = false;
            this.txtPrenomP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrenomP.PlaceholderText = "Entrez le prenom";
            this.txtPrenomP.Size = new System.Drawing.Size(280, 36);
            this.txtPrenomP.TabIndex = 4;
            this.txtPrenomP.Texts = "";
            this.txtPrenomP.UnderlinedStyle = false;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            //
            // txtEmailP
            //
            this.txtEmailP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtEmailP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtEmailP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtEmailP.BorderRadius = 5;
            this.txtEmailP.BorderSize = 2;
            this.txtEmailP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailP.ForeColor = System.Drawing.Color.White;
            this.txtEmailP.Location = new System.Drawing.Point(30, 222);
            this.txtEmailP.Name = "txtEmailP";
            this.txtEmailP.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmailP.PasswordChar = false;
            this.txtEmailP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmailP.PlaceholderText = "Entrez l'email";
            this.txtEmailP.Size = new System.Drawing.Size(280, 36);
            this.txtEmailP.TabIndex = 6;
            this.txtEmailP.Texts = "";
            this.txtEmailP.UnderlinedStyle = false;
            //
            // lblTelephone
            //
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelephone.ForeColor = System.Drawing.Color.White;
            this.lblTelephone.Location = new System.Drawing.Point(30, 265);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(78, 19);
            this.lblTelephone.TabIndex = 7;
            this.lblTelephone.Text = "Telephone";
            //
            // txtTelephoneP
            //
            this.txtTelephoneP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtTelephoneP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtTelephoneP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtTelephoneP.BorderRadius = 5;
            this.txtTelephoneP.BorderSize = 2;
            this.txtTelephoneP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelephoneP.ForeColor = System.Drawing.Color.White;
            this.txtTelephoneP.Location = new System.Drawing.Point(30, 287);
            this.txtTelephoneP.Name = "txtTelephoneP";
            this.txtTelephoneP.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelephoneP.PasswordChar = false;
            this.txtTelephoneP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelephoneP.PlaceholderText = "Entrez le telephone";
            this.txtTelephoneP.Size = new System.Drawing.Size(280, 36);
            this.txtTelephoneP.TabIndex = 8;
            this.txtTelephoneP.Texts = "";
            this.txtTelephoneP.UnderlinedStyle = false;
            //
            // lblSpecialite
            //
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpecialite.ForeColor = System.Drawing.Color.White;
            this.lblSpecialite.Location = new System.Drawing.Point(30, 330);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(75, 19);
            this.lblSpecialite.TabIndex = 9;
            this.lblSpecialite.Text = "Specialite";
            //
            // txtSpecialiteP
            //
            this.txtSpecialiteP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtSpecialiteP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtSpecialiteP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtSpecialiteP.BorderRadius = 5;
            this.txtSpecialiteP.BorderSize = 2;
            this.txtSpecialiteP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSpecialiteP.ForeColor = System.Drawing.Color.White;
            this.txtSpecialiteP.Location = new System.Drawing.Point(30, 352);
            this.txtSpecialiteP.Name = "txtSpecialiteP";
            this.txtSpecialiteP.Padding = new System.Windows.Forms.Padding(7);
            this.txtSpecialiteP.PasswordChar = false;
            this.txtSpecialiteP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSpecialiteP.PlaceholderText = "Entrez la specialite";
            this.txtSpecialiteP.Size = new System.Drawing.Size(280, 36);
            this.txtSpecialiteP.TabIndex = 10;
            this.txtSpecialiteP.Texts = "";
            this.txtSpecialiteP.UnderlinedStyle = false;
            //
            // btnSelectionnerP
            //
            this.btnSelectionnerP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionnerP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionnerP.BorderRadius = 10;
            this.btnSelectionnerP.BorderSize = 0;
            this.btnSelectionnerP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionnerP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectionnerP.FlatAppearance.BorderSize = 0;
            this.btnSelectionnerP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionnerP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectionnerP.ForeColor = System.Drawing.Color.White;
            this.btnSelectionnerP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSelectionnerP.Location = new System.Drawing.Point(30, 410);
            this.btnSelectionnerP.Name = "btnSelectionnerP";
            this.btnSelectionnerP.Size = new System.Drawing.Size(130, 40);
            this.btnSelectionnerP.TabIndex = 11;
            this.btnSelectionnerP.Text = "&Selectionner";
            this.btnSelectionnerP.TextColor = System.Drawing.Color.White;
            this.btnSelectionnerP.UseVisualStyleBackColor = false;
            this.btnSelectionnerP.Click += new System.EventHandler(this.btnSelectionnerP_Click);
            //
            // btnAjouterP
            //
            this.btnAjouterP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouterP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouterP.BorderRadius = 10;
            this.btnAjouterP.BorderSize = 0;
            this.btnAjouterP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouterP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterP.FlatAppearance.BorderSize = 0;
            this.btnAjouterP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouterP.ForeColor = System.Drawing.Color.White;
            this.btnAjouterP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnAjouterP.Location = new System.Drawing.Point(180, 410);
            this.btnAjouterP.Name = "btnAjouterP";
            this.btnAjouterP.Size = new System.Drawing.Size(130, 40);
            this.btnAjouterP.TabIndex = 12;
            this.btnAjouterP.Text = "&Ajouter";
            this.btnAjouterP.TextColor = System.Drawing.Color.White;
            this.btnAjouterP.UseVisualStyleBackColor = false;
            this.btnAjouterP.Click += new System.EventHandler(this.btnAjouterP_Click);
            //
            // btnModifierP
            //
            this.btnModifierP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnModifierP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnModifierP.BorderRadius = 10;
            this.btnModifierP.BorderSize = 0;
            this.btnModifierP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnModifierP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierP.FlatAppearance.BorderSize = 0;
            this.btnModifierP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifierP.ForeColor = System.Drawing.Color.White;
            this.btnModifierP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnModifierP.Location = new System.Drawing.Point(30, 470);
            this.btnModifierP.Name = "btnModifierP";
            this.btnModifierP.Size = new System.Drawing.Size(130, 40);
            this.btnModifierP.TabIndex = 13;
            this.btnModifierP.Text = "&Modifier";
            this.btnModifierP.TextColor = System.Drawing.Color.White;
            this.btnModifierP.UseVisualStyleBackColor = false;
            this.btnModifierP.Click += new System.EventHandler(this.btnModifierP_Click);
            //
            // btnSupprimerP
            //
            this.btnSupprimerP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimerP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimerP.BorderRadius = 10;
            this.btnSupprimerP.BorderSize = 0;
            this.btnSupprimerP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimerP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerP.FlatAppearance.BorderSize = 0;
            this.btnSupprimerP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerP.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnSupprimerP.Location = new System.Drawing.Point(180, 470);
            this.btnSupprimerP.Name = "btnSupprimerP";
            this.btnSupprimerP.Size = new System.Drawing.Size(130, 40);
            this.btnSupprimerP.TabIndex = 14;
            this.btnSupprimerP.Text = "&Supprimer";
            this.btnSupprimerP.TextColor = System.Drawing.Color.White;
            this.btnSupprimerP.UseVisualStyleBackColor = false;
            this.btnSupprimerP.Click += new System.EventHandler(this.btnSupprimerP_Click);
            //
            // dgProfesseur
            //
            this.dgProfesseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesseur.Location = new System.Drawing.Point(350, 70);
            this.dgProfesseur.Name = "dgProfesseur";
            this.dgProfesseur.Size = new System.Drawing.Size(550, 450);
            this.dgProfesseur.TabIndex = 15;
            //
            // frmProfesseur
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.ControlBox = false;
            this.Controls.Add(this.dgProfesseur);
            this.Controls.Add(this.btnSupprimerP);
            this.Controls.Add(this.btnModifierP);
            this.Controls.Add(this.btnAjouterP);
            this.Controls.Add(this.btnSelectionnerP);
            this.Controls.Add(this.txtSpecialiteP);
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.txtTelephoneP);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmailP);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPrenomP);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNomP);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmProfesseur";
            this.Text = "Gestion des Professeurs";
            this.Load += new System.EventHandler(this.frmProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblSpecialite;
        private CustomControls.CustomTextBox txtNomP;
        private CustomControls.CustomTextBox txtPrenomP;
        private CustomControls.CustomTextBox txtEmailP;
        private CustomControls.CustomTextBox txtTelephoneP;
        private CustomControls.CustomTextBox txtSpecialiteP;
        private CustomControls.CustomButton btnSelectionnerP;
        private CustomControls.CustomButton btnAjouterP;
        private CustomControls.CustomButton btnModifierP;
        private CustomControls.CustomButton btnSupprimerP;
        private System.Windows.Forms.DataGridView dgProfesseur;
    }
}
