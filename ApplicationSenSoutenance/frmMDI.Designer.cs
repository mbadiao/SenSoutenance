namespace ApplicationSenSoutenance
{
    partial class frmMDI
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnCandidat = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnDepartement = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnMemoire = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSoutenance = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnProfesseur = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnSession = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnAnneeAcademique = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSeDeconnecter = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.btnQuitter = new ApplicationSenSoutenance.CustomControls.CustomButton();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlContentArea
            //
            this.pnlContentArea.BackColor = System.Drawing.Color.Black;
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentArea.Location = new System.Drawing.Point(220, 0);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Size = new System.Drawing.Size(980, 600);
            this.pnlContentArea.TabIndex = 1;
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlSidebar.Controls.Add(this.pnlNavigation);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.pnlBottom);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 600);
            this.pnlSidebar.TabIndex = 0;
            //
            // pnlLogo
            //
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLogo.Controls.Add(this.lblTitre);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 80);
            this.pnlLogo.TabIndex = 0;
            //
            // lblTitre
            //
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(220, 80);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "SEN SOUTENANCE";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlNavigation
            //
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlNavigation.Controls.Add(this.btnCandidat);
            this.pnlNavigation.Controls.Add(this.btnDepartement);
            this.pnlNavigation.Controls.Add(this.btnMemoire);
            this.pnlNavigation.Controls.Add(this.btnSoutenance);
            this.pnlNavigation.Controls.Add(this.btnProfesseur);
            this.pnlNavigation.Controls.Add(this.btnSession);
            this.pnlNavigation.Controls.Add(this.btnAnneeAcademique);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 80);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.pnlNavigation.Size = new System.Drawing.Size(220, 400);
            this.pnlNavigation.TabIndex = 1;
            //
            // btnCandidat
            //
            this.btnCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnCandidat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnCandidat.BorderRadius = 10;
            this.btnCandidat.BorderSize = 0;
            this.btnCandidat.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnCandidat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCandidat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCandidat.FlatAppearance.BorderSize = 0;
            this.btnCandidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCandidat.ForeColor = System.Drawing.Color.White;
            this.btnCandidat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnCandidat.Location = new System.Drawing.Point(10, 20);
            this.btnCandidat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnCandidat.Name = "btnCandidat";
            this.btnCandidat.Size = new System.Drawing.Size(200, 40);
            this.btnCandidat.TabIndex = 0;
            this.btnCandidat.Text = "Candidat";
            this.btnCandidat.TextColor = System.Drawing.Color.White;
            this.btnCandidat.UseVisualStyleBackColor = false;
            this.btnCandidat.Click += new System.EventHandler(this.btnCandidat_Click);
            //
            // btnDepartement
            //
            this.btnDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnDepartement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnDepartement.BorderRadius = 10;
            this.btnDepartement.BorderSize = 0;
            this.btnDepartement.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnDepartement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartement.FlatAppearance.BorderSize = 0;
            this.btnDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDepartement.ForeColor = System.Drawing.Color.White;
            this.btnDepartement.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnDepartement.Location = new System.Drawing.Point(10, 60);
            this.btnDepartement.Name = "btnDepartement";
            this.btnDepartement.Size = new System.Drawing.Size(200, 40);
            this.btnDepartement.TabIndex = 1;
            this.btnDepartement.Text = "Departement";
            this.btnDepartement.TextColor = System.Drawing.Color.White;
            this.btnDepartement.UseVisualStyleBackColor = false;
            this.btnDepartement.Click += new System.EventHandler(this.btnDepartement_Click);
            //
            // btnMemoire
            //
            this.btnMemoire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnMemoire.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnMemoire.BorderRadius = 10;
            this.btnMemoire.BorderSize = 0;
            this.btnMemoire.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnMemoire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemoire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoire.FlatAppearance.BorderSize = 0;
            this.btnMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMemoire.ForeColor = System.Drawing.Color.White;
            this.btnMemoire.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnMemoire.Location = new System.Drawing.Point(10, 100);
            this.btnMemoire.Name = "btnMemoire";
            this.btnMemoire.Size = new System.Drawing.Size(200, 40);
            this.btnMemoire.TabIndex = 2;
            this.btnMemoire.Text = "Memoire";
            this.btnMemoire.TextColor = System.Drawing.Color.White;
            this.btnMemoire.UseVisualStyleBackColor = false;
            this.btnMemoire.Click += new System.EventHandler(this.btnMemoire_Click);
            //
            // btnSoutenance
            //
            this.btnSoutenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSoutenance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSoutenance.BorderRadius = 10;
            this.btnSoutenance.BorderSize = 0;
            this.btnSoutenance.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSoutenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoutenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoutenance.FlatAppearance.BorderSize = 0;
            this.btnSoutenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSoutenance.ForeColor = System.Drawing.Color.White;
            this.btnSoutenance.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSoutenance.Location = new System.Drawing.Point(10, 140);
            this.btnSoutenance.Name = "btnSoutenance";
            this.btnSoutenance.Size = new System.Drawing.Size(200, 40);
            this.btnSoutenance.TabIndex = 3;
            this.btnSoutenance.Text = "Soutenance";
            this.btnSoutenance.TextColor = System.Drawing.Color.White;
            this.btnSoutenance.UseVisualStyleBackColor = false;
            this.btnSoutenance.Click += new System.EventHandler(this.btnSoutenance_Click);
            //
            // btnProfesseur
            //
            this.btnProfesseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnProfesseur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnProfesseur.BorderRadius = 10;
            this.btnProfesseur.BorderSize = 0;
            this.btnProfesseur.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnProfesseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesseur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesseur.FlatAppearance.BorderSize = 0;
            this.btnProfesseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesseur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfesseur.ForeColor = System.Drawing.Color.White;
            this.btnProfesseur.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnProfesseur.Location = new System.Drawing.Point(10, 180);
            this.btnProfesseur.Name = "btnProfesseur";
            this.btnProfesseur.Size = new System.Drawing.Size(200, 40);
            this.btnProfesseur.TabIndex = 4;
            this.btnProfesseur.Text = "Professeur";
            this.btnProfesseur.TextColor = System.Drawing.Color.White;
            this.btnProfesseur.UseVisualStyleBackColor = false;
            this.btnProfesseur.Click += new System.EventHandler(this.btnProfesseur_Click);
            //
            // btnSession
            //
            this.btnSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSession.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSession.BorderRadius = 10;
            this.btnSession.BorderSize = 0;
            this.btnSession.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSession.ForeColor = System.Drawing.Color.White;
            this.btnSession.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnSession.Location = new System.Drawing.Point(10, 220);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(200, 40);
            this.btnSession.TabIndex = 5;
            this.btnSession.Text = "Session";
            this.btnSession.TextColor = System.Drawing.Color.White;
            this.btnSession.UseVisualStyleBackColor = false;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            //
            // btnAnneeAcademique
            //
            this.btnAnneeAcademique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAnneeAcademique.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAnneeAcademique.BorderRadius = 10;
            this.btnAnneeAcademique.BorderSize = 0;
            this.btnAnneeAcademique.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAnneeAcademique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnneeAcademique.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnneeAcademique.FlatAppearance.BorderSize = 0;
            this.btnAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnneeAcademique.ForeColor = System.Drawing.Color.White;
            this.btnAnneeAcademique.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnAnneeAcademique.Location = new System.Drawing.Point(10, 260);
            this.btnAnneeAcademique.Name = "btnAnneeAcademique";
            this.btnAnneeAcademique.Size = new System.Drawing.Size(200, 40);
            this.btnAnneeAcademique.TabIndex = 6;
            this.btnAnneeAcademique.Text = "Annee Academique";
            this.btnAnneeAcademique.TextColor = System.Drawing.Color.White;
            this.btnAnneeAcademique.UseVisualStyleBackColor = false;
            this.btnAnneeAcademique.Click += new System.EventHandler(this.btnAnneeAcademique_Click);
            //
            // pnlBottom
            //
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlBottom.Controls.Add(this.btnQuitter);
            this.pnlBottom.Controls.Add(this.btnSeDeconnecter);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 480);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(220, 120);
            this.pnlBottom.TabIndex = 2;
            //
            // btnSeDeconnecter
            //
            this.btnSeDeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnSeDeconnecter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnSeDeconnecter.BorderRadius = 10;
            this.btnSeDeconnecter.BorderSize = 0;
            this.btnSeDeconnecter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(205)))));
            this.btnSeDeconnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeDeconnecter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnSeDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeDeconnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeDeconnecter.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnSeDeconnecter.Location = new System.Drawing.Point(10, 10);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(200, 40);
            this.btnSeDeconnecter.TabIndex = 0;
            this.btnSeDeconnecter.Text = "Se Deconnecter";
            this.btnSeDeconnecter.TextColor = System.Drawing.Color.White;
            this.btnSeDeconnecter.UseVisualStyleBackColor = false;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            //
            // btnQuitter
            //
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnQuitter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnQuitter.BorderRadius = 10;
            this.btnQuitter.BorderSize = 0;
            this.btnQuitter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(198)))));
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnQuitter.Location = new System.Drawing.Point(10, 70);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(200, 40);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextColor = System.Drawing.Color.White;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            //
            // frmMDI
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlContentArea);
            this.Controls.Add(this.pnlSidebar);
            this.ControlBox = false;
            this.Name = "frmMDI";
            this.Text = "Sen Soutenance";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlNavigation;
        private CustomControls.CustomButton btnCandidat;
        private CustomControls.CustomButton btnDepartement;
        private CustomControls.CustomButton btnMemoire;
        private CustomControls.CustomButton btnSoutenance;
        private CustomControls.CustomButton btnProfesseur;
        private CustomControls.CustomButton btnSession;
        private CustomControls.CustomButton btnAnneeAcademique;
        private System.Windows.Forms.Panel pnlBottom;
        private CustomControls.CustomButton btnSeDeconnecter;
        private CustomControls.CustomButton btnQuitter;
        private System.Windows.Forms.Panel pnlContentArea;
    }
}
