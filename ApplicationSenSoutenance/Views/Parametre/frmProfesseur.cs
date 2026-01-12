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
    public partial class frmProfesseur : Form
    {
       
        public frmProfesseur()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        public void Effacer()
        {
           txtNomP.Clear();
            txtPrenomP.Clear();
            txtEmailP.Clear();
            txtTelephoneP.Clear();
            txtSpecialiteP.Clear();

            try
            {
                dgProfesseur.DataSource = bd.professeurs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'actualisation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNomP.Focus();
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            try
            {
                dgProfesseur.DataSource = bd.professeurs.ToList(); // ✅ ToList() au lieu de ToString()
                dgProfesseur.Columns["IdUtilisateur"].Visible = false; // Masquer la colonne IdUtilisateur
                dgProfesseur.Columns["MotDePasse"].Visible = false; // Masquer la colonne MotDePasse

                // Définir l'ordre des colonnes
                dgProfesseur.Columns["NomUtilisateur"].DisplayIndex = 0;
                dgProfesseur.Columns["PrenomUtilisateur"].DisplayIndex = 1;
                dgProfesseur.Columns["EmailUtilisateur"].DisplayIndex = 2;
                dgProfesseur.Columns["TelUtilisateur"].DisplayIndex = 3;
                //dgProfesseur.Columns["SpecialiteProfesseur"].DisplayIndex = 4;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifierP_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProfesseur.CurrentRow.Cells["IdUtilisateur"].Value.ToString());
            Professeur professeur = bd.professeurs.Find(id);
            professeur.NomUtilisateur = txtNomP.Text;
            professeur.PrenomUtilisateur = txtPrenomP.Text;
            professeur.EmailUtilisateur = txtEmailP.Text;
            professeur.TelUtilisateur = txtTelephoneP.Text;
            professeur.SpecialiteProfesseur = txtSpecialiteP.Text;
            bd.SaveChanges();
            Effacer();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouterP_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur()
            {
              NomUtilisateur = txtNomP.Text,
                PrenomUtilisateur = txtPrenomP.Text,
                EmailUtilisateur = txtEmailP.Text,
                TelUtilisateur = txtTelephoneP.Text,
                SpecialiteProfesseur = txtSpecialiteP.Text,
                MotDePasse = "defaultPassword" // Vous pouvez définir un mot de passe par défaut ou générer un mot de passe aléatoire


            };
            bd.professeurs.Add(professeur);
            bd.SaveChanges();
            Effacer();
        }
        

        private void btnSupprimerP_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProfesseur.CurrentRow.Cells["IdUtilisateur"].Value.ToString());
           Professeur professeur = bd.professeurs.Find(id); // ✅ Ajouté id
            bd.professeurs.Remove(professeur);
            bd.SaveChanges();
            Effacer();
        }

        private void btnSelectionnerP_Click(object sender, EventArgs e)
        {
            txtNomP.Text = dgProfesseur.CurrentRow.Cells["NomUtilisateur"].Value.ToString();
            txtPrenomP.Text = dgProfesseur.CurrentRow.Cells["PrenomUtilisateur"].Value.ToString();
            txtEmailP.Text = dgProfesseur.CurrentRow.Cells["EmailUtilisateur"].Value.ToString();
            txtTelephoneP.Text = dgProfesseur.CurrentRow.Cells["TelUtilisateur"].Value.ToString();
            txtSpecialiteP.Text = dgProfesseur.CurrentRow.Cells["SpecialiteProfesseur"].Value.ToString();
           




        }

        private void txtEmailP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
