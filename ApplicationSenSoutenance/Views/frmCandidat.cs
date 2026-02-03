using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views
{
    public partial class frmCandidat : UserControl
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        public frmCandidat()
        {
            InitializeComponent();
        }

        private void frmCandidat_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyDarkTheme(dgCandidat);
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            try
            {
                dgCandidat.DataSource = bd.candidats.ToList();
                dgCandidat.Columns["IdUtilisateur"].Visible = false;
                dgCandidat.Columns["MotDePasse"].Visible = false;
                dgCandidat.Columns["Memoires"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Effacer()
        {
            txtMatricule.Texts = "";
            txtNom.Texts = "";
            txtPrenom.Texts = "";
            txtEmail.Texts = "";
            txtTelephone.Texts = "";
            ChargerDonnees();
            txtMatricule.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgCandidat.CurrentRow == null) return;

            txtMatricule.Texts = dgCandidat.CurrentRow.Cells["MatriculeCandidat"].Value?.ToString() ?? "";
            txtNom.Texts = dgCandidat.CurrentRow.Cells["NomUtilisateur"].Value?.ToString() ?? "";
            txtPrenom.Texts = dgCandidat.CurrentRow.Cells["PrenomUtilisateur"].Value?.ToString() ?? "";
            txtEmail.Texts = dgCandidat.CurrentRow.Cells["EmailUtilisateur"].Value?.ToString() ?? "";
            txtTelephone.Texts = dgCandidat.CurrentRow.Cells["TelUtilisateur"].Value?.ToString() ?? "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricule.Texts) || string.IsNullOrWhiteSpace(txtNom.Texts))
            {
                MessageBox.Show("Veuillez saisir au moins le matricule et le nom.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var candidat = new Candidat
                {
                    MatriculeCandidat = txtMatricule.Texts,
                    NomUtilisateur = txtNom.Texts,
                    PrenomUtilisateur = txtPrenom.Texts,
                    EmailUtilisateur = txtEmail.Texts,
                    TelUtilisateur = txtTelephone.Texts,
                    MotDePasse = "defaultPassword",
                    EstActif = true,
                    DateCreation = DateTime.Now
                };
                bd.candidats.Add(candidat);
                bd.SaveChanges();
                Effacer();
                MessageBox.Show("Candidat ajoute avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgCandidat.CurrentRow == null) return;

            var cellValue = dgCandidat.CurrentRow.Cells["IdUtilisateur"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Veuillez selectionner une ligne valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var candidat = bd.candidats.Find(id);
                if (candidat != null)
                {
                    candidat.MatriculeCandidat = txtMatricule.Texts;
                    candidat.NomUtilisateur = txtNom.Texts;
                    candidat.PrenomUtilisateur = txtPrenom.Texts;
                    candidat.EmailUtilisateur = txtEmail.Texts;
                    candidat.TelUtilisateur = txtTelephone.Texts;
                    candidat.DateModification = DateTime.Now;
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Candidat modifie avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgCandidat.CurrentRow == null) return;

            var cellValue = dgCandidat.CurrentRow.Cells["IdUtilisateur"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Veuillez selectionner une ligne valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Voulez-vous vraiment supprimer ce candidat ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                var candidat = bd.candidats.Find(id);
                if (candidat != null)
                {
                    bd.candidats.Remove(candidat);
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Candidat supprime avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
