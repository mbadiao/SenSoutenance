namespace ApplicationSenSoutenance.Views
{
    partial class frmSoutenance
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
            this.lblMemoire = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblPresident = new System.Windows.Forms.Label();
            this.lblRapporteur = new System.Windows.Forms.Label();
            this.lblExaminateur1 = new System.Windows.Forms.Label();
            this.lblExaminateur2 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.cbbMemoire = new System.Windows.Forms.ComboBox();
            this.dtpDateSoutenance = new System.Windows.Forms.DateTimePicker();
            this.txtLieu = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.cbbPresident = new System.Windows.Forms.ComboBox();
            this.cbbRapporteur = new System.Windows.Forms.ComboBox();
            this.cbbExaminateur1 = new System.Windows.Forms.ComboBox();
            this.cbbExaminateur2 = new System.Windows.Forms.ComboBox();
            this.txtNote = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.cbbResultat = new System.Windows.Forms.ComboBox();
            this.btnSelectionner = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnAjouter = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnModifier = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSupprimer = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.dgSoutenance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.lblTitre.Location = new System.Drawing.Point(30, 15);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(270, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des Soutenances";
            // 
            // lblMemoire
            // 
            this.lblMemoire.AutoSize = true;
            this.lblMemoire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMemoire.ForeColor = System.Drawing.Color.White;
            this.lblMemoire.Location = new System.Drawing.Point(30, 55);
            this.lblMemoire.Name = "lblMemoire";
            this.lblMemoire.Size = new System.Drawing.Size(58, 15);
            this.lblMemoire.TabIndex = 1;
            this.lblMemoire.Text = "Memoire";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(30, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date Soutenance";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLieu.ForeColor = System.Drawing.Color.White;
            this.lblLieu.Location = new System.Drawing.Point(175, 105);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(30, 15);
            this.lblLieu.TabIndex = 5;
            this.lblLieu.Text = "Lieu";
            // 
            // lblPresident
            // 
            this.lblPresident.AutoSize = true;
            this.lblPresident.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPresident.ForeColor = System.Drawing.Color.White;
            this.lblPresident.Location = new System.Drawing.Point(30, 160);
            this.lblPresident.Name = "lblPresident";
            this.lblPresident.Size = new System.Drawing.Size(60, 15);
            this.lblPresident.TabIndex = 7;
            this.lblPresident.Text = "President";
            // 
            // lblRapporteur
            // 
            this.lblRapporteur.AutoSize = true;
            this.lblRapporteur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRapporteur.ForeColor = System.Drawing.Color.White;
            this.lblRapporteur.Location = new System.Drawing.Point(30, 210);
            this.lblRapporteur.Name = "lblRapporteur";
            this.lblRapporteur.Size = new System.Drawing.Size(71, 15);
            this.lblRapporteur.TabIndex = 9;
            this.lblRapporteur.Text = "Rapporteur";
            // 
            // lblExaminateur1
            // 
            this.lblExaminateur1.AutoSize = true;
            this.lblExaminateur1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExaminateur1.ForeColor = System.Drawing.Color.White;
            this.lblExaminateur1.Location = new System.Drawing.Point(30, 260);
            this.lblExaminateur1.Name = "lblExaminateur1";
            this.lblExaminateur1.Size = new System.Drawing.Size(87, 15);
            this.lblExaminateur1.TabIndex = 11;
            this.lblExaminateur1.Text = "Examinateur 1";
            // 
            // lblExaminateur2
            // 
            this.lblExaminateur2.AutoSize = true;
            this.lblExaminateur2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExaminateur2.ForeColor = System.Drawing.Color.White;
            this.lblExaminateur2.Location = new System.Drawing.Point(30, 310);
            this.lblExaminateur2.Name = "lblExaminateur2";
            this.lblExaminateur2.Size = new System.Drawing.Size(120, 15);
            this.lblExaminateur2.TabIndex = 13;
            this.lblExaminateur2.Text = "Examinateur 2 (opt.)";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(30, 360);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(57, 15);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "Note /20";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultat.ForeColor = System.Drawing.Color.White;
            this.lblResultat.Location = new System.Drawing.Point(145, 360);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(53, 15);
            this.lblResultat.TabIndex = 17;
            this.lblResultat.Text = "Resultat";
            // 
            // cbbMemoire
            // 
            this.cbbMemoire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbMemoire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMemoire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbMemoire.ForeColor = System.Drawing.Color.White;
            this.cbbMemoire.Location = new System.Drawing.Point(30, 73);
            this.cbbMemoire.Name = "cbbMemoire";
            this.cbbMemoire.Size = new System.Drawing.Size(280, 23);
            this.cbbMemoire.TabIndex = 2;
            // 
            // dtpDateSoutenance
            // 
            this.dtpDateSoutenance.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDateSoutenance.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dtpDateSoutenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateSoutenance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSoutenance.Location = new System.Drawing.Point(30, 123);
            this.dtpDateSoutenance.Name = "dtpDateSoutenance";
            this.dtpDateSoutenance.Size = new System.Drawing.Size(130, 23);
            this.dtpDateSoutenance.TabIndex = 4;
            // 
            // txtLieu
            // 
            this.txtLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtLieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtLieu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtLieu.BorderRadius = 5;
            this.txtLieu.BorderSize = 2;
            this.txtLieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLieu.ForeColor = System.Drawing.Color.White;
            this.txtLieu.Location = new System.Drawing.Point(175, 120);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtLieu.Multiline = false;
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Padding = new System.Windows.Forms.Padding(5);
            this.txtLieu.PasswordChar = false;
            this.txtLieu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLieu.PlaceholderText = "Salle";
            this.txtLieu.Size = new System.Drawing.Size(135, 26);
            this.txtLieu.TabIndex = 6;
            this.txtLieu.Texts = "";
            this.txtLieu.UnderlinedStyle = false;
            // 
            // cbbPresident
            // 
            this.cbbPresident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbPresident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPresident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPresident.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbPresident.ForeColor = System.Drawing.Color.White;
            this.cbbPresident.Location = new System.Drawing.Point(30, 178);
            this.cbbPresident.Name = "cbbPresident";
            this.cbbPresident.Size = new System.Drawing.Size(280, 23);
            this.cbbPresident.TabIndex = 8;
            // 
            // cbbRapporteur
            // 
            this.cbbRapporteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbRapporteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRapporteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbRapporteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbRapporteur.ForeColor = System.Drawing.Color.White;
            this.cbbRapporteur.Location = new System.Drawing.Point(30, 228);
            this.cbbRapporteur.Name = "cbbRapporteur";
            this.cbbRapporteur.Size = new System.Drawing.Size(280, 23);
            this.cbbRapporteur.TabIndex = 10;
            // 
            // cbbExaminateur1
            // 
            this.cbbExaminateur1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbExaminateur1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExaminateur1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbExaminateur1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbExaminateur1.ForeColor = System.Drawing.Color.White;
            this.cbbExaminateur1.Location = new System.Drawing.Point(30, 278);
            this.cbbExaminateur1.Name = "cbbExaminateur1";
            this.cbbExaminateur1.Size = new System.Drawing.Size(280, 23);
            this.cbbExaminateur1.TabIndex = 12;
            // 
            // cbbExaminateur2
            // 
            this.cbbExaminateur2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbExaminateur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExaminateur2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbExaminateur2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbExaminateur2.ForeColor = System.Drawing.Color.White;
            this.cbbExaminateur2.Location = new System.Drawing.Point(30, 328);
            this.cbbExaminateur2.Name = "cbbExaminateur2";
            this.cbbExaminateur2.Size = new System.Drawing.Size(280, 23);
            this.cbbExaminateur2.TabIndex = 14;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtNote.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtNote.BorderRadius = 5;
            this.txtNote.BorderSize = 2;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.ForeColor = System.Drawing.Color.White;
            this.txtNote.Location = new System.Drawing.Point(30, 378);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = false;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new System.Windows.Forms.Padding(5);
            this.txtNote.PasswordChar = false;
            this.txtNote.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNote.PlaceholderText = "Ex: 15.5";
            this.txtNote.Size = new System.Drawing.Size(100, 26);
            this.txtNote.TabIndex = 16;
            this.txtNote.Texts = "";
            this.txtNote.UnderlinedStyle = false;
            // 
            // cbbResultat
            // 
            this.cbbResultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbbResultat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbResultat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbResultat.ForeColor = System.Drawing.Color.White;
            this.cbbResultat.Items.AddRange(new object[] {
            "",
            "Admis",
            "Ajourne"});
            this.cbbResultat.Location = new System.Drawing.Point(145, 381);
            this.cbbResultat.Name = "cbbResultat";
            this.cbbResultat.Size = new System.Drawing.Size(165, 23);
            this.cbbResultat.TabIndex = 18;
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
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSelectionner.Location = new System.Drawing.Point(30, 430);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(115, 35);
            this.btnSelectionner.TabIndex = 19;
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
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnAjouter.Location = new System.Drawing.Point(160, 430);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 35);
            this.btnAjouter.TabIndex = 20;
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
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnModifier.Location = new System.Drawing.Point(30, 480);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 35);
            this.btnModifier.TabIndex = 21;
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
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnSupprimer.Location = new System.Drawing.Point(160, 480);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(115, 35);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.TextColor = System.Drawing.Color.White;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dgSoutenance
            // 
            this.dgSoutenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSoutenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoutenance.Location = new System.Drawing.Point(340, 55);
            this.dgSoutenance.Name = "dgSoutenance";
            this.dgSoutenance.Size = new System.Drawing.Size(620, 470);
            this.dgSoutenance.TabIndex = 23;
            this.dgSoutenance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSoutenance_CellContentClick);
            //
            // frmSoutenance
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dgSoutenance);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.cbbResultat);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.cbbExaminateur2);
            this.Controls.Add(this.lblExaminateur2);
            this.Controls.Add(this.cbbExaminateur1);
            this.Controls.Add(this.lblExaminateur1);
            this.Controls.Add(this.cbbRapporteur);
            this.Controls.Add(this.lblRapporteur);
            this.Controls.Add(this.cbbPresident);
            this.Controls.Add(this.lblPresident);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.dtpDateSoutenance);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbbMemoire);
            this.Controls.Add(this.lblMemoire);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmSoutenance";
            this.Size = new System.Drawing.Size(1000, 560);
            this.Load += new System.EventHandler(this.frmSoutenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMemoire;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblPresident;
        private System.Windows.Forms.Label lblRapporteur;
        private System.Windows.Forms.Label lblExaminateur1;
        private System.Windows.Forms.Label lblExaminateur2;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.ComboBox cbbMemoire;
        private System.Windows.Forms.DateTimePicker dtpDateSoutenance;
        private CustomControls.CustomTextBox txtLieu;
        private System.Windows.Forms.ComboBox cbbPresident;
        private System.Windows.Forms.ComboBox cbbRapporteur;
        private System.Windows.Forms.ComboBox cbbExaminateur1;
        private System.Windows.Forms.ComboBox cbbExaminateur2;
        private CustomControls.CustomTextBox txtNote;
        private System.Windows.Forms.ComboBox cbbResultat;
        private CustomControls.CustomButton btnSelectionner;
        private CustomControls.CustomButton btnAjouter;
        private CustomControls.CustomButton btnModifier;
        private CustomControls.CustomButton btnSupprimer;
        private System.Windows.Forms.DataGridView dgSoutenance;
    }
}
