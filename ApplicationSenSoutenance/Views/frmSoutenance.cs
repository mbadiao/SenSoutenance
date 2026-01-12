using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views
{
    public partial class frmSoutenance : Form
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();
        FilerList filer = new FilerList();

        public frmSoutenance()
        {
            InitializeComponent();
        }

        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            DataGridViewStyler.ApplyDarkTheme(dgSoutenance);
            ChargerComboBoxes();
            ChargerDonnees();
        }

        private void ChargerComboBoxes()
        {
            // Memoires
            cbbMemoire.DataSource = filer.FillMemoires();
            cbbMemoire.DisplayMember = "Text";
            cbbMemoire.ValueMember = "Value";

            // Professeurs pour President
            cbbPresident.DataSource = filer.FillProfesseurs();
            cbbPresident.DisplayMember = "Text";
            cbbPresident.ValueMember = "Value";

            // Professeurs pour Rapporteur
            cbbRapporteur.DataSource = new FilerList().FillProfesseurs();
            cbbRapporteur.DisplayMember = "Text";
            cbbRapporteur.ValueMember = "Value";

            // Professeurs pour Examinateur1
            cbbExaminateur1.DataSource = new FilerList().FillProfesseurs();
            cbbExaminateur1.DisplayMember = "Text";
            cbbExaminateur1.ValueMember = "Value";

            // Professeurs pour Examinateur2 (optionnel)
            cbbExaminateur2.DataSource = new FilerList().FillProfesseurs();
            cbbExaminateur2.DisplayMember = "Text";
            cbbExaminateur2.ValueMember = "Value";
        }

        private void ChargerDonnees()
        {
            try
            {
                dgSoutenance.DataSource = bd.soutenances.ToList();
                dgSoutenance.Columns["Memoire"].Visible = false;
                dgSoutenance.Columns["President"].Visible = false;
                dgSoutenance.Columns["Rapporteur"].Visible = false;
                dgSoutenance.Columns["Examinateur1"].Visible = false;
                dgSoutenance.Columns["Examinateur2"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Effacer()
        {
            cbbMemoire.SelectedIndex = 0;
            dtpDateSoutenance.Value = DateTime.Now;
            txtLieu.Texts = "";
            cbbPresident.SelectedIndex = 0;
            cbbRapporteur.SelectedIndex = 0;
            cbbExaminateur1.SelectedIndex = 0;
            cbbExaminateur2.SelectedIndex = 0;
            txtNote.Texts = "";
            cbbResultat.SelectedIndex = 0;
            ChargerDonnees();
            cbbMemoire.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            var row = dgSoutenance.CurrentRow;

            var idMemoire = row.Cells["IdMemoire"].Value?.ToString();
            if (!string.IsNullOrEmpty(idMemoire))
                cbbMemoire.SelectedValue = idMemoire;

            if (row.Cells["DateSoutenance"].Value != null)
                dtpDateSoutenance.Value = (DateTime)row.Cells["DateSoutenance"].Value;

            txtLieu.Texts = row.Cells["LieuSoutenance"].Value?.ToString() ?? "";

            var idPresident = row.Cells["IdPresident"].Value?.ToString();
            if (!string.IsNullOrEmpty(idPresident))
                cbbPresident.SelectedValue = idPresident;

            var idRapporteur = row.Cells["IdRapporteur"].Value?.ToString();
            if (!string.IsNullOrEmpty(idRapporteur))
                cbbRapporteur.SelectedValue = idRapporteur;

            var idExam1 = row.Cells["IdExaminateur1"].Value?.ToString();
            if (!string.IsNullOrEmpty(idExam1))
                cbbExaminateur1.SelectedValue = idExam1;

            var idExam2 = row.Cells["IdExaminateur2"].Value?.ToString();
            if (!string.IsNullOrEmpty(idExam2))
                cbbExaminateur2.SelectedValue = idExam2;
            else
                cbbExaminateur2.SelectedIndex = 0;

            txtNote.Texts = row.Cells["NoteSoutenance"].Value?.ToString() ?? "";
            cbbResultat.Text = row.Cells["ResultatSoutenance"].Value?.ToString() ?? "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (cbbMemoire.SelectedValue == null || cbbPresident.SelectedValue == null ||
                cbbRapporteur.SelectedValue == null || cbbExaminateur1.SelectedValue == null)
            {
                MessageBox.Show("Veuillez selectionner le memoire et les membres du jury.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var soutenance = new Soutenance
                {
                    IdMemoire = int.Parse(cbbMemoire.SelectedValue.ToString()),
                    DateSoutenance = dtpDateSoutenance.Value,
                    LieuSoutenance = txtLieu.Texts,
                    IdPresident = int.Parse(cbbPresident.SelectedValue.ToString()),
                    IdRapporteur = int.Parse(cbbRapporteur.SelectedValue.ToString()),
                    IdExaminateur1 = int.Parse(cbbExaminateur1.SelectedValue.ToString()),
                    IdExaminateur2 = cbbExaminateur2.SelectedValue != null && !string.IsNullOrEmpty(cbbExaminateur2.SelectedValue.ToString())
                        ? (int?)int.Parse(cbbExaminateur2.SelectedValue.ToString())
                        : null,
                    NoteSoutenance = !string.IsNullOrWhiteSpace(txtNote.Texts)
                        ? (decimal?)decimal.Parse(txtNote.Texts)
                        : null,
                    ResultatSoutenance = cbbResultat.Text,
                    DateCreation = DateTime.Now
                };
                bd.soutenances.Add(soutenance);
                bd.SaveChanges();
                Effacer();
                MessageBox.Show("Soutenance ajoutee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            try
            {
                int id = int.Parse(dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value.ToString());
                var soutenance = bd.soutenances.Find(id);
                if (soutenance != null)
                {
                    soutenance.IdMemoire = int.Parse(cbbMemoire.SelectedValue.ToString());
                    soutenance.DateSoutenance = dtpDateSoutenance.Value;
                    soutenance.LieuSoutenance = txtLieu.Texts;
                    soutenance.IdPresident = int.Parse(cbbPresident.SelectedValue.ToString());
                    soutenance.IdRapporteur = int.Parse(cbbRapporteur.SelectedValue.ToString());
                    soutenance.IdExaminateur1 = int.Parse(cbbExaminateur1.SelectedValue.ToString());
                    soutenance.IdExaminateur2 = cbbExaminateur2.SelectedValue != null && !string.IsNullOrEmpty(cbbExaminateur2.SelectedValue.ToString())
                        ? (int?)int.Parse(cbbExaminateur2.SelectedValue.ToString())
                        : null;
                    soutenance.NoteSoutenance = !string.IsNullOrWhiteSpace(txtNote.Texts)
                        ? (decimal?)decimal.Parse(txtNote.Texts)
                        : null;
                    soutenance.ResultatSoutenance = cbbResultat.Text;
                    soutenance.DateModification = DateTime.Now;
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Soutenance modifiee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            var result = MessageBox.Show("Voulez-vous vraiment supprimer cette soutenance ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value.ToString());
                var soutenance = bd.soutenances.Find(id);
                if (soutenance != null)
                {
                    bd.soutenances.Remove(soutenance);
                    bd.SaveChanges();
                    Effacer();
                    MessageBox.Show("Soutenance supprimee avec succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
