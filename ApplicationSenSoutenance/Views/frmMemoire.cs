using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views
{
    public partial class frmMemoire : Form
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();
        FilerList filer = new FilerList();

        public frmMemoire()
        {
            InitializeComponent();
        }

        private void frmMemoire_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyDarkTheme(dgMemoire);
            ChargerComboBoxes();
            ChargerDonnees();
        }

        private void ChargerComboBoxes()
        {
            // Sessions
            cbbSession.DataSource = filer.FillSessions();
            cbbSession.DisplayMember = "Text";
            cbbSession.ValueMember = "Value";

            // Candidats
            cbbCandidat.DataSource = filer.FillCandidats();
            cbbCandidat.DisplayMember = "Text";
            cbbCandidat.ValueMember = "Value";
        }

        private void ChargerDonnees()
        {
            try
            {
                dgMemoire.DataSource = bd.memoires.ToList();
                dgMemoire.Columns["Session"].Visible = false;
                dgMemoire.Columns["Candidat"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Effacer()
        {
            txtSujet.Texts = "";
            cbbSession.SelectedIndex = 0;
            cbbCandidat.SelectedIndex = 0;
            ChargerDonnees();
            txtSujet.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;

            txtSujet.Texts = dgMemoire.CurrentRow.Cells["SujetMemoire"].Value?.ToString() ?? "";

            var idSession = dgMemoire.CurrentRow.Cells["IdSession"].Value?.ToString();
            if (!string.IsNullOrEmpty(idSession))
                cbbSession.SelectedValue = idSession;

            var idCandidat = dgMemoire.CurrentRow.Cells["IdCandidat"].Value?.ToString();
            if (!string.IsNullOrEmpty(idCandidat))
                cbbCandidat.SelectedValue = idCandidat;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSujet.Texts))
            {
                MessageBox.Show("Veuillez saisir le sujet du memoire.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbSession.SelectedValue == null || cbbCandidat.SelectedValue == null)
            {
                MessageBox.Show("Veuillez selectionner la session et le candidat.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var memoire = new Memoire
                {
                    SujetMemoire = txtSujet.Texts,
                    IdSession = int.Parse(cbbSession.SelectedValue.ToString()),
                    IdCandidat = int.Parse(cbbCandidat.SelectedValue.ToString()),
                    DateDepot = DateTime.Now
                };
                bd.memoires.Add(memoire);
                bd.SaveChanges();
                Effacer();
                MessageBox.Show("Memoire ajoute avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;

            try
            {
                int id = int.Parse(dgMemoire.CurrentRow.Cells["IdMemoire"].Value.ToString());
                var memoire = bd.memoires.Find(id);
                if (memoire != null)
                {
                    memoire.SujetMemoire = txtSujet.Texts;
                    memoire.IdSession = int.Parse(cbbSession.SelectedValue.ToString());
                    memoire.IdCandidat = int.Parse(cbbCandidat.SelectedValue.ToString());
                    memoire.DateModification = DateTime.Now;
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Memoire modifie avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;

            var result = MessageBox.Show("Voulez-vous vraiment supprimer ce memoire ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(dgMemoire.CurrentRow.Cells["IdMemoire"].Value.ToString());
                var memoire = bd.memoires.Find(id);
                if (memoire != null)
                {
                    bd.memoires.Remove(memoire);
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Memoire supprime avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
