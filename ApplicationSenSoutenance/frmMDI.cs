using ApplicationSenSoutenance.CustomControls;
using ApplicationSenSoutenance.Views;
using ApplicationSenSoutenance.Views.Parametre;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationSenSoutenance
{
    public partial class frmMDI : Form
    {
        private CustomButton activeButton = null;
        private Color defaultButtonColor = ColorTranslator.FromHtml("#7A5CF9");
        private Color activeButtonColor = ColorTranslator.FromHtml("#AD2EC6");

        // Cache des vues (lazy loading)
        private Dictionary<string, UserControl> viewCache = new Dictionary<string, UserControl>();
        private UserControl currentView = null;

        public frmMDI()
        {
            InitializeComponent();
        }

        private void NavigateTo<T>() where T : UserControl, new()
        {
            string viewName = typeof(T).Name;

            // Créer ou récupérer la vue
            if (!viewCache.ContainsKey(viewName))
            {
                var newView = new T();
                newView.Dock = DockStyle.Fill;
                viewCache[viewName] = newView;
                pnlContentArea.Controls.Add(newView);
            }

            var targetView = viewCache[viewName];
            if (currentView == targetView) return;

            // Cacher l'ancienne, afficher la nouvelle
            if (currentView != null)
                currentView.Visible = false;

            targetView.Visible = true;
            targetView.BringToFront();
            currentView = targetView;
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
            var workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Width = workingArea.Width;
            this.Height = workingArea.Height;
            this.Location = new Point(workingArea.X, workingArea.Y);
        }

        private void btnCandidat_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnCandidat);
            NavigateTo<frmCandidat>();
        }

        private void btnDepartement_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnDepartement);
            NavigateTo<frmDepartement>();
        }

        private void btnMemoire_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnMemoire);
            NavigateTo<frmMemoire>();
        }

        private void btnSoutenance_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnSoutenance);
            NavigateTo<frmSoutenance>();
        }

        private void btnProfesseur_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnProfesseur);
            NavigateTo<frmProfesseur>();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnSession);
            NavigateTo<frmSession>();
        }

        private void btnAnneeAcademique_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnAnneeAcademique);
            NavigateTo<frmAnneeAcademique>();
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
    }
}
