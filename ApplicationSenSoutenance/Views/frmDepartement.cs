using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views
{
    public partial class frmDepartement : UserControl
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        public frmDepartement()
        {
            InitializeComponent();
        }

        private void frmDepartement_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyDarkTheme(dgDepartement);
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            try
            {
                dgDepartement.DataSource = bd.departements.ToList();
                dgDepartement.Columns["ChefsDepartement"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Effacer()
        {
            txtCode.Texts = "";
            txtLibelle.Texts = "";
            ChargerDonnees();
            txtCode.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;

            txtCode.Texts = dgDepartement.CurrentRow.Cells["CodeDepartement"].Value?.ToString() ?? "";
            txtLibelle.Texts = dgDepartement.CurrentRow.Cells["LibelleDepartement"].Value?.ToString() ?? "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Texts))
            {
                MessageBox.Show("Veuillez saisir le libelle du departement.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var departement = new Departement
                {
                    CodeDepartement = txtCode.Texts,
                    LibelleDepartement = txtLibelle.Texts
                };
                bd.departements.Add(departement);
                bd.SaveChanges();
                Effacer();
                MessageBox.Show("Departement ajoute avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;

            var cellValue = dgDepartement.CurrentRow.Cells["IdDepartement"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Veuillez selectionner une ligne valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var departement = bd.departements.Find(id);
                if (departement != null)
                {
                    departement.CodeDepartement = txtCode.Texts;
                    departement.LibelleDepartement = txtLibelle.Texts;
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Departement modifie avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;

            var cellValue = dgDepartement.CurrentRow.Cells["IdDepartement"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Veuillez selectionner une ligne valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Voulez-vous vraiment supprimer ce departement ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                var departement = bd.departements.Find(id);
                if (departement != null)
                {
                    bd.departements.Remove(departement);
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Departement supprime avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
