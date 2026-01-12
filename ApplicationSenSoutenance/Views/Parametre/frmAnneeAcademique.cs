using ApplicationSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
        }
        
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();
        
        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id); // ✅ Ajouté id
            bd.anneeAcademiques.Remove(anneeAcademique);
            bd.SaveChanges();
            Effacer();
        }
        
        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            try
            {
                dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList(); // ✅ ToList() au lieu de ToString()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            try
            {
                dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'actualisation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtLibelleAnneeAcademique.Focus();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnneeAcademique anneeAcademique = new AnneeAcademique()
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
            AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id);
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            bd.SaveChanges();
            Effacer();
        }
        
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtLibelleAnneeAcademique_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgAnneeAcademique_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}