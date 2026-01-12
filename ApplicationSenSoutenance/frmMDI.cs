using ApplicationSenSoutenance.CustomControls;
using ApplicationSenSoutenance.Views;
using ApplicationSenSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationSenSoutenance
{
    public partial class frmMDI : Form
    {
        private CustomButton activeButton = null;
        private Color defaultButtonColor = ColorTranslator.FromHtml("#7A5CF9");
        private Color activeButtonColor = ColorTranslator.FromHtml("#AD2EC6");

        public frmMDI()
        {
            InitializeComponent();
        }

        private void FermerFormulairesEnfants()
        {
            foreach (Form form in this.MdiChildren)
                form.Close();
        }

        private void OuvrirFormulaire(Form formulaire)
        {
            FermerFormulairesEnfants();
            formulaire.MdiParent = this;
            formulaire.Show();
            formulaire.WindowState = FormWindowState.Maximized;
        }

        private void HighlightActiveButton(CustomButton button)
        {
            if (activeButton != null)
            {
                activeButton.ButtonColor = defaultButtonColor;
                activeButton.BackColor = defaultButtonColor;
            }

            button.ButtonColor = activeButtonColor;
            button.BackColor = activeButtonColor;
            activeButton = button;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            var screen = new Computer().Screen.Bounds;
            this.Width = screen.Width;
            this.Height = screen.Height;
            this.Location = new Point(0, 0);
        }

        private void btnCandidat_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnCandidat);
            OuvrirFormulaire(new frmCandidat());
        }

        private void btnDepartement_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnDepartement);
            OuvrirFormulaire(new frmDepartement());
        }

        private void btnMemoire_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnMemoire);
            OuvrirFormulaire(new frmMemoire());
        }

        private void btnSoutenance_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnSoutenance);
            OuvrirFormulaire(new frmSoutenance());
        }

        private void btnProfesseur_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnProfesseur);
            OuvrirFormulaire(new frmProfesseur());
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnSession);
            OuvrirFormulaire(new frmSession());
        }

        private void btnAnneeAcademique_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnAnneeAcademique);
            OuvrirFormulaire(new frmAnneeAcademique());
        }

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            new frmConnexion().Show();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void candidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            // Code à mettre dans l'événement clic de votre menu par exemple
            frmCandidat f = new frmCandidat();
            f.MdiParent = this; // 'this' désigne le formulaire frmMDI (le parent)
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
