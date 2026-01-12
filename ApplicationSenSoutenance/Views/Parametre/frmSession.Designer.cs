namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmSession
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
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblAnneeAcademique = new System.Windows.Forms.Label();
            this.lblRechercheSession = new System.Windows.Forms.Label();
            this.lblRechercheAnnee = new System.Windows.Forms.Label();
            this.txtSession = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtRSession = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtRanneeAcademique = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.btnSelectionner = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnAjouter = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnModifier = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSupprimer = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnRechercher = new ApplicationSenSoutenance.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.SuspendLayout();
            //
            // dgSession
            //
            this.dgSession.AllowUserToAddRows = false;
            this.dgSession.AllowUserToDeleteRows = false;
            this.dgSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSession.Location = new System.Drawing.Point(300, 120);
            this.dgSession.Name = "dgSession";
            this.dgSession.ReadOnly = true;
            this.dgSession.RowHeadersVisible = false;
            this.dgSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSession.Size = new System.Drawing.Size(550, 380);
            this.dgSession.TabIndex = 0;
            //
            // lblSession
            //
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.ForeColor = System.Drawing.Color.White;
            this.lblSession.Location = new System.Drawing.Point(30, 80);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(56, 19);
            this.lblSession.TabIndex = 1;
            this.lblSession.Text = "Session";
            //
            // txtSession
            //
            this.txtSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtSession.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtSession.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.txtSession.BorderRadius = 5;
            this.txtSession.BorderSize = 2;
            this.txtSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSession.ForeColor = System.Drawing.Color.White;
            this.txtSession.Location = new System.Drawing.Point(30, 105);
            this.txtSession.Multiline = false;
            this.txtSession.Name = "txtSession";
            this.txtSession.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSession.PasswordChar = false;
            this.txtSession.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtSession.PlaceholderText = "Libellé de la session";
            this.txtSession.Size = new System.Drawing.Size(230, 35);
            this.txtSession.TabIndex = 2;
            this.txtSession.Texts = "";
            this.txtSession.UnderlinedStyle = false;
            //
            // lblAnneeAcademique
            //
            this.lblAnneeAcademique.AutoSize = true;
            this.lblAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnneeAcademique.ForeColor = System.Drawing.Color.White;
            this.lblAnneeAcademique.Location = new System.Drawing.Point(30, 160);
            this.lblAnneeAcademique.Name = "lblAnneeAcademique";
            this.lblAnneeAcademique.Size = new System.Drawing.Size(127, 19);
            this.lblAnneeAcademique.TabIndex = 3;
            this.lblAnneeAcademique.Text = "Année Académique";
            //
            // cbbAnneeAcademique
            //
            this.cbbAnneeAcademique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbAnneeAcademique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAnneeAcademique.ForeColor = System.Drawing.Color.White;
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(30, 185);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(230, 27);
            this.cbbAnneeAcademique.TabIndex = 4;
            //
            // btnSelectionner
            //
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionner.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelectionner.BorderRadius = 5;
            this.btnSelectionner.BorderSize = 0;
            this.btnSelectionner.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSelectionner.FlatAppearance.BorderSize = 0;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(30, 250);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(230, 40);
            this.btnSelectionner.TabIndex = 5;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.TextColor = System.Drawing.Color.White;
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            //
            // btnAjouter
            //
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouter.BorderColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BorderRadius = 5;
            this.btnAjouter.BorderSize = 0;
            this.btnAjouter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(30, 300);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(230, 40);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextColor = System.Drawing.Color.White;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            //
            // btnModifier
            //
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnModifier.BorderColor = System.Drawing.Color.Transparent;
            this.btnModifier.BorderRadius = 5;
            this.btnModifier.BorderSize = 0;
            this.btnModifier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(30, 350);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(230, 40);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextColor = System.Drawing.Color.White;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            //
            // btnSupprimer
            //
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimer.BorderColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BorderRadius = 5;
            this.btnSupprimer.BorderSize = 0;
            this.btnSupprimer.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(30, 400);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(230, 40);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextColor = System.Drawing.Color.White;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            //
            // lblRechercheSession
            //
            this.lblRechercheSession.AutoSize = true;
            this.lblRechercheSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercheSession.ForeColor = System.Drawing.Color.White;
            this.lblRechercheSession.Location = new System.Drawing.Point(300, 25);
            this.lblRechercheSession.Name = "lblRechercheSession";
            this.lblRechercheSession.Size = new System.Drawing.Size(46, 15);
            this.lblRechercheSession.TabIndex = 9;
            this.lblRechercheSession.Text = "Session";
            //
            // txtRSession
            //
            this.txtRSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtRSession.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtRSession.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.txtRSession.BorderRadius = 5;
            this.txtRSession.BorderSize = 2;
            this.txtRSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSession.ForeColor = System.Drawing.Color.White;
            this.txtRSession.Location = new System.Drawing.Point(300, 45);
            this.txtRSession.Multiline = false;
            this.txtRSession.Name = "txtRSession";
            this.txtRSession.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtRSession.PasswordChar = false;
            this.txtRSession.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRSession.PlaceholderText = "";
            this.txtRSession.Size = new System.Drawing.Size(180, 30);
            this.txtRSession.TabIndex = 10;
            this.txtRSession.Texts = "";
            this.txtRSession.UnderlinedStyle = false;
            //
            // lblRechercheAnnee
            //
            this.lblRechercheAnnee.AutoSize = true;
            this.lblRechercheAnnee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercheAnnee.ForeColor = System.Drawing.Color.White;
            this.lblRechercheAnnee.Location = new System.Drawing.Point(495, 25);
            this.lblRechercheAnnee.Name = "lblRechercheAnnee";
            this.lblRechercheAnnee.Size = new System.Drawing.Size(108, 15);
            this.lblRechercheAnnee.TabIndex = 11;
            this.lblRechercheAnnee.Text = "Année Académique";
            //
            // txtRanneeAcademique
            //
            this.txtRanneeAcademique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtRanneeAcademique.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtRanneeAcademique.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.txtRanneeAcademique.BorderRadius = 5;
            this.txtRanneeAcademique.BorderSize = 2;
            this.txtRanneeAcademique.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanneeAcademique.ForeColor = System.Drawing.Color.White;
            this.txtRanneeAcademique.Location = new System.Drawing.Point(495, 45);
            this.txtRanneeAcademique.Multiline = false;
            this.txtRanneeAcademique.Name = "txtRanneeAcademique";
            this.txtRanneeAcademique.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtRanneeAcademique.PasswordChar = false;
            this.txtRanneeAcademique.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRanneeAcademique.PlaceholderText = "";
            this.txtRanneeAcademique.Size = new System.Drawing.Size(180, 30);
            this.txtRanneeAcademique.TabIndex = 12;
            this.txtRanneeAcademique.Texts = "";
            this.txtRanneeAcademique.UnderlinedStyle = false;
            //
            // btnRechercher
            //
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnRechercher.BorderColor = System.Drawing.Color.Transparent;
            this.btnRechercher.BorderRadius = 5;
            this.btnRechercher.BorderSize = 0;
            this.btnRechercher.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(695, 45);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(120, 30);
            this.btnRechercher.TabIndex = 13;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.TextColor = System.Drawing.Color.White;
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            //
            // frmSession
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRanneeAcademique);
            this.Controls.Add(this.lblRechercheAnnee);
            this.Controls.Add(this.txtRSession);
            this.Controls.Add(this.lblRechercheSession);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.lblAnneeAcademique);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.dgSession);
            this.Name = "frmSession";
            this.Text = "Gestion des Sessions";
            this.Load += new System.EventHandler(this.frmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.Label lblSession;
        private CustomControls.CustomTextBox txtSession;
        private System.Windows.Forms.Label lblAnneeAcademique;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private CustomControls.CustomButton btnSelectionner;
        private CustomControls.CustomButton btnAjouter;
        private CustomControls.CustomButton btnModifier;
        private CustomControls.CustomButton btnSupprimer;
        private System.Windows.Forms.Label lblRechercheSession;
        private CustomControls.CustomTextBox txtRSession;
        private System.Windows.Forms.Label lblRechercheAnnee;
        private CustomControls.CustomTextBox txtRanneeAcademique;
        private CustomControls.CustomButton btnRechercher;
    }
}
