using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmProfesseur : UserControl
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        public frmProfesseur()
        {
            InitializeComponent();
        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyDarkTheme(dgProfesseur);
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            try
            {
                dgProfesseur.DataSource = bd.professeurs.ToList();
                dgProfesseur.Columns["IdUtilisateur"].Visible = false;
                dgProfesseur.Columns["MotDePasse"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Effacer()
        {
            txtNomP.Texts = "";
            txtPrenomP.Texts = "";
            txtEmailP.Texts = "";
            txtTelephoneP.Texts = "";
            txtSpecialiteP.Texts = "";
            ChargerDonnees();
            txtNomP.Focus();
        }

        private void btnSelectionnerP_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;

            txtNomP.Texts = dgProfesseur.CurrentRow.Cells["NomUtilisateur"].Value?.ToString() ?? "";
            txtPrenomP.Texts = dgProfesseur.CurrentRow.Cells["PrenomUtilisateur"].Value?.ToString() ?? "";
            txtEmailP.Texts = dgProfesseur.CurrentRow.Cells["EmailUtilisateur"].Value?.ToString() ?? "";
            txtTelephoneP.Texts = dgProfesseur.CurrentRow.Cells["TelUtilisateur"].Value?.ToString() ?? "";
            txtSpecialiteP.Texts = dgProfesseur.CurrentRow.Cells["SpecialiteProfesseur"].Value?.ToString() ?? "";
        }

        private void btnAjouterP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomP.Texts))
            {
                MessageBox.Show("Veuillez saisir le nom du professeur.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var professeur = new Professeur
                {
                    NomUtilisateur = txtNomP.Texts,
                    PrenomUtilisateur = txtPrenomP.Texts,
                    EmailUtilisateur = txtEmailP.Texts,
                    TelUtilisateur = txtTelephoneP.Texts,
                    SpecialiteProfesseur = txtSpecialiteP.Texts,
                    MotDePasse = "defaultPassword",
                    EstActif = true,
                    DateCreation = DateTime.Now
                };
                bd.professeurs.Add(professeur);
                bd.SaveChanges();
                Effacer();
                MessageBox.Show("Professeur ajoute avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifierP_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;

            var cellValue = dgProfesseur.CurrentRow.Cells["IdUtilisateur"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Veuillez selectionner une ligne valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var professeur = bd.professeurs.Find(id);
                if (professeur != null)
                {
                    professeur.NomUtilisateur = txtNomP.Texts;
                    professeur.PrenomUtilisateur = txtPrenomP.Texts;
                    professeur.EmailUtilisateur = txtEmailP.Texts;
                    professeur.TelUtilisateur = txtTelephoneP.Texts;
                    professeur.SpecialiteProfesseur = txtSpecialiteP.Texts;
                    professeur.DateModification = DateTime.Now;
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Professeur modifie avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerP_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;

            var cellValue = dgProfesseur.CurrentRow.Cells["IdUtilisateur"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Veuillez selectionner une ligne valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Voulez-vous vraiment supprimer ce professeur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                var professeur = bd.professeurs.Find(id);
                if (professeur != null)
                {
                    bd.professeurs.Remove(professeur);
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Professeur supprime avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
