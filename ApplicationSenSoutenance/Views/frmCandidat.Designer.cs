namespace ApplicationSenSoutenance.Views
{
    partial class frmCandidat
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
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtMatricule = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtNom = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtPrenom = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtEmail = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtTelephone = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.btnSelectionner = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnAjouter = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnModifier = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSupprimer = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.dgCandidat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.lblTitre.Location = new System.Drawing.Point(30, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(244, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des Candidats";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatricule.ForeColor = System.Drawing.Color.White;
            this.lblMatricule.Location = new System.Drawing.Point(30, 70);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(72, 19);
            this.lblMatricule.TabIndex = 1;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(30, 135);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 19);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.ForeColor = System.Drawing.Color.White;
            this.lblPrenom.Location = new System.Drawing.Point(30, 200);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(62, 19);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 265);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelephone.ForeColor = System.Drawing.Color.White;
            this.lblTelephone.Location = new System.Drawing.Point(30, 330);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(78, 19);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtMatricule
            // 
            this.txtMatricule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtMatricule.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtMatricule.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtMatricule.BorderRadius = 5;
            this.txtMatricule.BorderSize = 2;
            this.txtMatricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricule.ForeColor = System.Drawing.Color.White;
            this.txtMatricule.Location = new System.Drawing.Point(30, 92);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricule.Multiline = false;
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Padding = new System.Windows.Forms.Padding(7);
            this.txtMatricule.PasswordChar = false;
            this.txtMatricule.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatricule.PlaceholderText = "Entrez le matricule";
            this.txtMatricule.Size = new System.Drawing.Size(280, 34);
            this.txtMatricule.TabIndex = 2;
            this.txtMatricule.Texts = "";
            this.txtMatricule.UnderlinedStyle = false;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtNom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtNom.BorderRadius = 5;
            this.txtNom.BorderSize = 2;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.ForeColor = System.Drawing.Color.White;
            this.txtNom.Location = new System.Drawing.Point(30, 157);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Multiline = false;
            this.txtNom.Name = "txtNom";
            this.txtNom.Padding = new System.Windows.Forms.Padding(7);
            this.txtNom.PasswordChar = false;
            this.txtNom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNom.PlaceholderText = "Entrez le nom";
            this.txtNom.Size = new System.Drawing.Size(280, 34);
            this.txtNom.TabIndex = 4;
            this.txtNom.Texts = "";
            this.txtNom.UnderlinedStyle = false;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtPrenom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtPrenom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtPrenom.BorderRadius = 5;
            this.txtPrenom.BorderSize = 2;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenom.ForeColor = System.Drawing.Color.White;
            this.txtPrenom.Location = new System.Drawing.Point(30, 222);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Multiline = false;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrenom.PasswordChar = false;
            this.txtPrenom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrenom.PlaceholderText = "Entrez le prenom";
            this.txtPrenom.Size = new System.Drawing.Size(280, 34);
            this.txtPrenom.TabIndex = 6;
            this.txtPrenom.Texts = "";
            this.txtPrenom.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(30, 287);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Entrez l\'email";
            this.txtEmail.Size = new System.Drawing.Size(280, 34);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtTelephone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtTelephone.BorderRadius = 5;
            this.txtTelephone.BorderSize = 2;
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelephone.ForeColor = System.Drawing.Color.White;
            this.txtTelephone.Location = new System.Drawing.Point(30, 352);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelephone.Multiline = false;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelephone.PasswordChar = false;
            this.txtTelephone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelephone.PlaceholderText = "Entrez le telephone";
            this.txtTelephone.Size = new System.Drawing.Size(280, 34);
            this.txtTelephone.TabIndex = 10;
            this.txtTelephone.Texts = "";
            this.txtTelephone.UnderlinedStyle = false;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionner.BorderRadius = 10;
            this.btnSelectionner.BorderSize = 0;
            this.btnSelectionner.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectionner.FlatAppearance.BorderSize = 0;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSelectionner.Location = new System.Drawing.Point(30, 410);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(130, 40);
            this.btnSelectionner.TabIndex = 11;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.TextColor = System.Drawing.Color.White;
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouter.BorderRadius = 10;
            this.btnAjouter.BorderSize = 0;
            this.btnAjouter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnAjouter.Location = new System.Drawing.Point(180, 410);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 40);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.TextColor = System.Drawing.Color.White;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnModifier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnModifier.BorderRadius = 10;
            this.btnModifier.BorderSize = 0;
            this.btnModifier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnModifier.Location = new System.Drawing.Point(30, 470);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 40);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.TextColor = System.Drawing.Color.White;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimer.BorderRadius = 10;
            this.btnSupprimer.BorderSize = 0;
            this.btnSupprimer.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnSupprimer.Location = new System.Drawing.Point(180, 470);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 40);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.TextColor = System.Drawing.Color.White;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dgCandidat
            // 
            this.dgCandidat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCandidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCandidat.Location = new System.Drawing.Point(350, 70);
            this.dgCandidat.Name = "dgCandidat";
            this.dgCandidat.Size = new System.Drawing.Size(550, 450);
            this.dgCandidat.TabIndex = 15;
            //
            // frmCandidat
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dgCandidat);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmCandidat";
            this.Size = new System.Drawing.Size(950, 550);
            this.Load += new System.EventHandler(this.frmCandidat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private CustomControls.CustomTextBox txtMatricule;
        private CustomControls.CustomTextBox txtNom;
        private CustomControls.CustomTextBox txtPrenom;
        private CustomControls.CustomTextBox txtEmail;
        private CustomControls.CustomTextBox txtTelephone;
        private CustomControls.CustomButton btnSelectionner;
        private CustomControls.CustomButton btnAjouter;
        private CustomControls.CustomButton btnModifier;
        private CustomControls.CustomButton btnSupprimer;
        private System.Windows.Forms.DataGridView dgCandidat;
    }
}
