using ApplicationSenSoutenance.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity; // pour Include

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public frmSession()
        {
            InitializeComponent();
        }

        private void frmSession_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            // Charger le DataGridView avec le Libelle de l'année mappé
            var sessions = db.sessions
                             .Include(s => s.AnneeAcademique)
                             .Select(s => new
                             {
                                 s.IdSession,
                                 s.LibelleSession,
                                 Annee = s.AnneeAcademique.LibelleAnneeAcademique
                             })
                             .ToList();

            dgSession.DataSource = sessions;

            // Masquer l'ID et mettre l'ordre
            dgSession.Columns["IdSession"].Visible = false;
            dgSession.Columns["LibelleSession"].DisplayIndex = 0;
            dgSession.Columns["Annee"].DisplayIndex = 1;

            // Charger le ComboBox directement depuis la table
            cbxAnneeAcademique.DataSource = db.anneeAcademiques.ToList();
            cbxAnneeAcademique.DisplayMember = "LibelleAnnee";
            cbxAnneeAcademique.ValueMember = "IdAnneeAcademique";
        }

        private void Effacer()
        {
            txtSession.Clear();
            cbxAnneeAcademique.SelectedIndex = 0;
            ChargerDonnees();
            txtSession.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé de la session.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Session session = new Session
            {
                LibelleSession = txtSession.Text,
                IdAnneeAcademique = (int)cbxAnneeAcademique.SelectedValue
            };

            db.sessions.Add(session);
            db.SaveChanges();
            Effacer();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            int id = (int)dgSession.CurrentRow.Cells["IdSession"].Value;
            Session session = db.sessions.Find(id);

            txtSession.Text = session.LibelleSession;
            cbxAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            int id = (int)dgSession.CurrentRow.Cells["IdSession"].Value;
            Session session = db.sessions.Find(id);

            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = (int)cbxAnneeAcademique.SelectedValue;

            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            int id = (int)dgSession.CurrentRow.Cells["IdSession"].Value;
            Session session = db.sessions.Find(id);

            db.sessions.Remove(session);
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.sessions.Include(s => s.AnneeAcademique).ToList();

            if (!string.IsNullOrWhiteSpace(txtSession.Text))
                liste = liste.Where(s => s.LibelleSession.Contains(txtSession.Text)).ToList();

            if (cbxAnneeAcademique.SelectedIndex > 0)
                liste = liste.Where(s => s.AnneeAcademique.IdAnneeAcademique == (int)cbxAnneeAcademique.SelectedValue).ToList();

            dgSession.DataSource = liste.Select(s => new
            {
                s.IdSession,
                s.LibelleSession,
                Annee = s.AnneeAcademique.LibelleAnneeAcademique
            }).ToList();
        }

        private void txtSession_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
