using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filer = new FilerList();

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
            dgSession.DataSource = db.sessions.ToList();
            cbbAnneeAcademique.DataSource = filer.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
        }

        private void txtSession_TextChanged(object sender, EventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Session session = new Session
            {
                LibelleSession = txtSession.Text,
                IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString())
            };
            db.sessions.Add(session);
            db.SaveChanges();
            Effacer();
        }

        private void Effacer()
        {
            txtSession.Clear();
            cbbAnneeAcademique.SelectedIndex = 0;
            ChargerDonnees();
            txtSession.Focus();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            db.sessions.Remove(session);
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.sessions.ToList();

            if (!string.IsNullOrEmpty(txtRSession.Text))
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();

            if (!string.IsNullOrEmpty(txtRanneeAcademique.Text))
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRanneeAcademique.Text)).ToList();

            dgSession.DataSource = liste;
        }
    }
}
