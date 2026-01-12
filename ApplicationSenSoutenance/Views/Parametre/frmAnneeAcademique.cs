using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        public frmAnneeAcademique()
        {
            InitializeComponent();
        }

        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyDarkTheme(dgAnneeAcademique);
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            try
            {
                dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();
                dgAnneeAcademique.Columns["Sessions"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Effacer()
        {
            txtLibelleAnneeAcademique.Texts = "";
            txtAnneeAcademiqueVal.Texts = "";
            ChargerDonnees();
            txtLibelleAnneeAcademique.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;

            txtLibelleAnneeAcademique.Texts = dgAnneeAcademique.CurrentRow.Cells["LibelleAnneeAcademique"].Value?.ToString() ?? "";
            txtAnneeAcademiqueVal.Texts = dgAnneeAcademique.CurrentRow.Cells["AnneeAcademiqueVal"].Value?.ToString() ?? "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelleAnneeAcademique.Texts))
            {
                MessageBox.Show("Veuillez saisir le libelle de l'annee academique.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAnneeAcademiqueVal.Texts) || !int.TryParse(txtAnneeAcademiqueVal.Texts, out int anneeVal))
            {
                MessageBox.Show("Veuillez saisir une valeur numerique valide pour l'annee.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var anneeAcademique = new AnneeAcademique
                {
                    LibelleAnneeAcademique = txtLibelleAnneeAcademique.Texts,
                    AnneeAcademiqueVal = anneeVal
                };
                bd.anneeAcademiques.Add(anneeAcademique);
                bd.SaveChanges();
                Effacer();
                MessageBox.Show("Annee academique ajoutee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;

            if (!int.TryParse(txtAnneeAcademiqueVal.Texts, out int anneeVal))
            {
                MessageBox.Show("Veuillez saisir une valeur numerique valide pour l'annee.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells["IdAnneeAcademique"].Value.ToString());
                var anneeAcademique = bd.anneeAcademiques.Find(id);
                if (anneeAcademique != null)
                {
                    anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Texts;
                    anneeAcademique.AnneeAcademiqueVal = anneeVal;
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Annee academique modifiee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;

            var result = MessageBox.Show("Voulez-vous vraiment supprimer cette annee academique ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells["IdAnneeAcademique"].Value.ToString());
                var anneeAcademique = bd.anneeAcademiques.Find(id);
                if (anneeAcademique != null)
                {
                    bd.anneeAcademiques.Remove(anneeAcademique);
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Annee academique supprimee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
