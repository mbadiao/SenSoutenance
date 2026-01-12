using ApplicationSenSoutenance.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmCandidat : Form
    {
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        public frmCandidat()
        {
            InitializeComponent();
        }

        // ===================== Effacer =====================
        public void Effacer()
        {
            txtNomC.Clear();
            txtPrenomC.Clear();
            txtEmailC.Clear();
            txtTelephoneC.Clear();
            txtMatriculeC.Clear();

            try
            {
                dgCandidat.DataSource = bd.candidats.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'actualisation : " + ex.Message);
            }

            txtNomC.Focus();
        }

        private void frmCandidat_Load(object sender, EventArgs e)
        {
            try
            {
                dgCandidat.DataSource = bd.candidats.ToList();

                dgCandidat.Columns["IdUtilisateur"].Visible = false;
                dgCandidat.Columns["MotDePasse"].Visible = false;

                dgCandidat.Columns["NomUtilisateur"].DisplayIndex = 0;
                dgCandidat.Columns["PrenomUtilisateur"].DisplayIndex = 1;
                dgCandidat.Columns["EmailUtilisateur"].DisplayIndex = 2;
                dgCandidat.Columns["TelUtilisateur"].DisplayIndex = 3;
                dgCandidat.Columns["MatriculeCandidat"].DisplayIndex = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement : " + ex.Message);
            }

        }

        private void btnAjouterC_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat()
            {
                NomUtilisateur = txtNomC.Text,
                PrenomUtilisateur = txtPrenomC.Text,
                EmailUtilisateur = txtEmailC.Text,
                TelUtilisateur = txtTelephoneC.Text,
                MatriculeCandidat = txtMatriculeC.Text,
                MotDePasse = "defaultPassword"
            };

            bd.candidats.Add(candidat);
            bd.SaveChanges();
            Effacer();

        }

        private void btnModifierC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCandidat.CurrentRow.Cells["IdUtilisateur"].Value.ToString());
            Candidat candidat = bd.candidats.Find(id);

            candidat.NomUtilisateur = txtNomC.Text;
            candidat.PrenomUtilisateur = txtPrenomC.Text;
            candidat.EmailUtilisateur = txtEmailC.Text;
            candidat.TelUtilisateur = txtTelephoneC.Text;
            candidat.MatriculeCandidat = txtMatriculeC.Text;

            bd.SaveChanges();
            Effacer();

        }

        private void btnSupprimerC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCandidat.CurrentRow.Cells["IdUtilisateur"].Value.ToString());
            Candidat candidat = bd.candidats.Find(id);

            bd.candidats.Remove(candidat);
            bd.SaveChanges();
            Effacer();

        }

        private void btnSelectionnerC_Click(object sender, EventArgs e)
        {
            txtNomC.Text = dgCandidat.CurrentRow.Cells["NomUtilisateur"].Value.ToString();
            txtPrenomC.Text = dgCandidat.CurrentRow.Cells["PrenomUtilisateur"].Value.ToString();
            txtEmailC.Text = dgCandidat.CurrentRow.Cells["EmailUtilisateur"].Value.ToString();
            txtTelephoneC.Text = dgCandidat.CurrentRow.Cells["TelUtilisateur"].Value.ToString();
            txtMatriculeC.Text = dgCandidat.CurrentRow.Cells["MatriculeCandidat"].Value.ToString();

        }
    }
}