using ApplicationSenSoutenance.Models;
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
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            try
            {
                dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            ChargerDonnees();
            txtLibelleAnneeAcademique.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var anneeAcademique = new AnneeAcademique
            {
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
            };
            bd.anneeAcademiques.Add(anneeAcademique);
            bd.SaveChanges();
            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            var anneeAcademique = bd.anneeAcademiques.Find(id);
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            bd.SaveChanges();
            Effacer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            var anneeAcademique = bd.anneeAcademiques.Find(id);
            bd.anneeAcademiques.Remove(anneeAcademique);
            bd.SaveChanges();
            Effacer();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }
    }
}