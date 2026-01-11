using ApplicationSenSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationSenSoutenance
{
    public partial class frmMDI : Form
    {
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

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConnexion().Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmAnneeAcademique());
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmSession());
        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmProfesseur());
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            var screen = new Computer().Screen.Bounds;
            this.Width = screen.Width;
            this.Height = screen.Height;
            this.Location = new Point(0, 0);
        }
    }
}
