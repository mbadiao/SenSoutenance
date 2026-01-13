namespace ApplicationSenSoutenance.Views
{
    partial class frmMemoire
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
            this.lblSujet = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblCandidat = new System.Windows.Forms.Label();
            this.txtSujet = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.cbbSession = new System.Windows.Forms.ComboBox();
            this.cbbCandidat = new System.Windows.Forms.ComboBox();
            this.btnSelectionner = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnAjouter = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnModifier = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSupprimer = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.dgMemoire = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitre
            //
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.lblTitre.Location = new System.Drawing.Point(30, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(220, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des Memoires";
            //
            // lblSujet
            //
            this.lblSujet.AutoSize = true;
            this.lblSujet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSujet.ForeColor = System.Drawing.Color.White;
            this.lblSujet.Location = new System.Drawing.Point(30, 70);
            this.lblSujet.Name = "lblSujet";
            this.lblSujet.Size = new System.Drawing.Size(116, 19);
            this.lblSujet.TabIndex = 1;
            this.lblSujet.Text = "Sujet du Memoire";
            //
            // txtSujet
            //
            this.txtSujet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtSujet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtSujet.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtSujet.BorderRadius = 5;
            this.txtSujet.BorderSize = 2;
            this.txtSujet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSujet.ForeColor = System.Drawing.Color.White;
            this.txtSujet.Location = new System.Drawing.Point(30, 92);
            this.txtSujet.Multiline = true;
            this.txtSujet.Name = "txtSujet";
            this.txtSujet.Padding = new System.Windows.Forms.Padding(7);
            this.txtSujet.PasswordChar = false;
            this.txtSujet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSujet.PlaceholderText = "Entrez le sujet du memoire";
            this.txtSujet.Size = new System.Drawing.Size(300, 70);
            this.txtSujet.TabIndex = 2;
            this.txtSujet.Texts = "";
            this.txtSujet.UnderlinedStyle = false;
            //
            // lblSession
            //
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSession.ForeColor = System.Drawing.Color.White;
            this.lblSession.Location = new System.Drawing.Point(30, 175);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(58, 19);
            this.lblSession.TabIndex = 3;
            this.lblSession.Text = "Session";
            //
            // cbbSession
            //
            this.cbbSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSession.ForeColor = System.Drawing.Color.White;
            this.cbbSession.Location = new System.Drawing.Point(30, 197);
            this.cbbSession.Name = "cbbSession";
            this.cbbSession.Size = new System.Drawing.Size(300, 25);
            this.cbbSession.TabIndex = 4;
            //
            // lblCandidat
            //
            this.lblCandidat.AutoSize = true;
            this.lblCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCandidat.ForeColor = System.Drawing.Color.White;
            this.lblCandidat.Location = new System.Drawing.Point(30, 235);
            this.lblCandidat.Name = "lblCandidat";
            this.lblCandidat.Size = new System.Drawing.Size(69, 19);
            this.lblCandidat.TabIndex = 5;
            this.lblCandidat.Text = "Candidat";
            //
            // cbbCandidat
            //
            this.cbbCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbCandidat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCandidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCandidat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCandidat.ForeColor = System.Drawing.Color.White;
            this.cbbCandidat.Location = new System.Drawing.Point(30, 257);
            this.cbbCandidat.Name = "cbbCandidat";
            this.cbbCandidat.Size = new System.Drawing.Size(300, 25);
            this.cbbCandidat.TabIndex = 6;
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
            this.btnSelectionner.Location = new System.Drawing.Point(30, 310);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(130, 40);
            this.btnSelectionner.TabIndex = 7;
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
            this.btnAjouter.Location = new System.Drawing.Point(180, 310);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 40);
            this.btnAjouter.TabIndex = 8;
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
            this.btnModifier.Location = new System.Drawing.Point(30, 370);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 40);
            this.btnModifier.TabIndex = 9;
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
            this.btnSupprimer.Location = new System.Drawing.Point(180, 370);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 40);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.TextColor = System.Drawing.Color.White;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            //
            // dgMemoire
            //
            this.dgMemoire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMemoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemoire.Location = new System.Drawing.Point(350, 70);
            this.dgMemoire.Name = "dgMemoire";
            this.dgMemoire.Size = new System.Drawing.Size(550, 450);
            this.dgMemoire.TabIndex = 11;
            //
            // frmMemoire
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.ControlBox = false;
            this.Controls.Add(this.dgMemoire);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.cbbCandidat);
            this.Controls.Add(this.lblCandidat);
            this.Controls.Add(this.cbbSession);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.txtSujet);
            this.Controls.Add(this.lblSujet);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmMemoire";
            this.Text = "Gestion des Memoires";
            this.Load += new System.EventHandler(this.frmMemoire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSujet;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblCandidat;
        private CustomControls.CustomTextBox txtSujet;
        private System.Windows.Forms.ComboBox cbbSession;
        private System.Windows.Forms.ComboBox cbbCandidat;
        private CustomControls.CustomButton btnSelectionner;
        private CustomControls.CustomButton btnAjouter;
        private CustomControls.CustomButton btnModifier;
        private CustomControls.CustomButton btnSupprimer;
        private System.Windows.Forms.DataGridView dgMemoire;
    }
}
