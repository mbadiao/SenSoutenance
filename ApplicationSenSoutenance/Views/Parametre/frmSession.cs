using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();
        FilerList filer = new FilerList();

        public frmSession()
        {
            InitializeComponent();
        }

        private void frmSession_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyDarkTheme(dgSession);
            ChargerComboBoxes();
            ChargerDonnees();
        }

        private void ChargerComboBoxes()
        {
            cbbAnneeAcademique.DataSource = filer.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
        }

        private void ChargerDonnees()
        {
            try
            {
                dgSession.DataSource = bd.sessions.ToList();
                dgSession.Columns["AnneeAcademique"].Visible = false;
                dgSession.Columns["Memoires"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Effacer()
        {
            txtSession.Texts = "";
            cbbAnneeAcademique.SelectedIndex = 0;
            ChargerDonnees();
            txtSession.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            txtSession.Texts = dgSession.CurrentRow.Cells["LibelleSession"].Value?.ToString() ?? "";

            var idAnnee = dgSession.CurrentRow.Cells["IdAnneeAcademique"].Value?.ToString();
            if (!string.IsNullOrEmpty(idAnnee))
                cbbAnneeAcademique.SelectedValue = idAnnee;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSession.Texts))
            {
                MessageBox.Show("Veuillez saisir le libelle de la session.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbAnneeAcademique.SelectedValue == null)
            {
                MessageBox.Show("Veuillez selectionner une annee academique.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var session = new Session
                {
                    LibelleSession = txtSession.Texts,
                    IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString())
                };
                bd.sessions.Add(session);
                bd.SaveChanges();
                Effacer();
                MessageBox.Show("Session ajoutee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            try
            {
                int id = int.Parse(dgSession.CurrentRow.Cells["IdSession"].Value.ToString());
                var session = bd.sessions.Find(id);
                if (session != null)
                {
                    session.LibelleSession = txtSession.Texts;
                    session.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Session modifiee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            var result = MessageBox.Show("Voulez-vous vraiment supprimer cette session ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(dgSession.CurrentRow.Cells["IdSession"].Value.ToString());
                var session = bd.sessions.Find(id);
                if (session != null)
                {
                    bd.sessions.Remove(session);
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Session supprimee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                var liste = bd.sessions.ToList();

                if (!string.IsNullOrEmpty(txtRSession.Texts))
                    liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Texts)).ToList();

                if (!string.IsNullOrEmpty(txtRanneeAcademique.Texts))
                    liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRanneeAcademique.Texts)).ToList();

                dgSession.DataSource = liste;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
