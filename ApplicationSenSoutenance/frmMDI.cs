using ApplicationSenSoutenance.Views;
using ApplicationSenSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSenSoutenance
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// methode permettant de fermer tout les forms dans le ParentMDI
        /// </summary>

        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            // Pour chaque formulaire enfant, on le ferme
            foreach (Form chform in charr)
            {
                // chform.WindowState = FormWindowState.Maximized; (optionnel)
                chform.Close();
            }
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            // Code à mettre dans l'événement clic de votre menu par exemple
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this; // 'this' désigne le formulaire frmMDI (le parent)
            f.Show();
            f.WindowState = FormWindowState.Maximized; // ✅ Maximisé au lieu de Minimized
        }
        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            // Code à mettre dans l'événement clic de votre menu par exemple
            frmSession f = new frmSession();
            f.MdiParent = this; // 'this' désigne le formulaire frmMDI (le parent)
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            // Code à mettre dans l'événement clic de votre menu par exemple
            frmProfesseur f = new frmProfesseur();
            f.MdiParent = this; // 'this' désigne le formulaire frmMDI (le parent)
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }
    }
}
