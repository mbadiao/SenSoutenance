namespace ApplicationSenSoutenance.Views
{
    partial class frmDepartement
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtCode = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.txtLibelle = new ApplicationSenSoutenance.CustomControls.CustomTextBox();
            this.btnSelectionner = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnAjouter = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnModifier = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSupprimer = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.dgDepartement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitre
            //
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.lblTitre.Location = new System.Drawing.Point(30, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(250, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des Departements";
            //
            // lblCode
            //
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(30, 80);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(130, 19);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code Departement";
            //
            // txtCode
            //
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtCode.BorderRadius = 5;
            this.txtCode.BorderSize = 2;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(30, 105);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(7);
            this.txtCode.PasswordChar = false;
            this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCode.PlaceholderText = "Entrez le code";
            this.txtCode.Size = new System.Drawing.Size(280, 38);
            this.txtCode.TabIndex = 2;
            this.txtCode.Texts = "";
            this.txtCode.UnderlinedStyle = false;
            //
            // lblLibelle
            //
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLibelle.ForeColor = System.Drawing.Color.White;
            this.lblLibelle.Location = new System.Drawing.Point(30, 160);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(137, 19);
            this.lblLibelle.TabIndex = 3;
            this.lblLibelle.Text = "Libelle Departement";
            //
            // txtLibelle
            //
            this.txtLibelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtLibelle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtLibelle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.txtLibelle.BorderRadius = 5;
            this.txtLibelle.BorderSize = 2;
            this.txtLibelle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLibelle.ForeColor = System.Drawing.Color.White;
            this.txtLibelle.Location = new System.Drawing.Point(30, 185);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(4);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Padding = new System.Windows.Forms.Padding(7);
            this.txtLibelle.PasswordChar = false;
            this.txtLibelle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLibelle.PlaceholderText = "Entrez le libelle";
            this.txtLibelle.Size = new System.Drawing.Size(280, 38);
            this.txtLibelle.TabIndex = 4;
            this.txtLibelle.Texts = "";
            this.txtLibelle.UnderlinedStyle = false;
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
            this.btnSelectionner.Location = new System.Drawing.Point(30, 260);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(130, 40);
            this.btnSelectionner.TabIndex = 5;
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
            this.btnAjouter.Location = new System.Drawing.Point(180, 260);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 40);
            this.btnAjouter.TabIndex = 6;
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
            this.btnModifier.Location = new System.Drawing.Point(30, 320);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 40);
            this.btnModifier.TabIndex = 7;
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
            this.btnSupprimer.Location = new System.Drawing.Point(180, 320);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 40);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.TextColor = System.Drawing.Color.White;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            //
            // dgDepartement
            //
            this.dgDepartement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartement.Location = new System.Drawing.Point(350, 80);
            this.dgDepartement.Name = "dgDepartement";
            this.dgDepartement.Size = new System.Drawing.Size(500, 400);
            this.dgDepartement.TabIndex = 9;
            //
            // frmDepartement
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dgDepartement);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmDepartement";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.frmDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblLibelle;
        private CustomControls.CustomTextBox txtCode;
        private CustomControls.CustomTextBox txtLibelle;
        private CustomControls.CustomButton btnSelectionner;
        private CustomControls.CustomButton btnAjouter;
        private CustomControls.CustomButton btnModifier;
        private CustomControls.CustomButton btnSupprimer;
        private System.Windows.Forms.DataGridView dgDepartement;
    }
}
