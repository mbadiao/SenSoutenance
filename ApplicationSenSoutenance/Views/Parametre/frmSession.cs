using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
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
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filer = new FilerList();

        private void frmSession_Load(object sender, EventArgs e)
        {
            dgSession.DataSource = db.sessions.ToList();
            cbbAnneeAcademique.DataSource = filer.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";

        }

        private void txtSession_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());

            db.sessions.Add(session);
            db.SaveChanges();
            Effacer();
        }

        private void Effacer()
        {
            txtSession.Clear();
            cbbAnneeAcademique.SelectedValue = "";
            dgSession.DataSource = db.sessions.ToList();
            cbbAnneeAcademique.DataSource = filer.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = (int?)cbbAnneeAcademique.SelectedValue;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            db.sessions.Remove(session);
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Récupère toutes les sessions depuis la base de données
            var liste = db.sessions.ToList();

            // Si le champ de recherche de session n'est pas vide
            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                // Filtre la liste pour ne garder que les sessions dont le libellé contient le texte saisi
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();
            }

            // Si le champ de recherche d'année académique n'est pas vide
            if (txtRanneeAcademique.Text != "")
            {
                // Filtre la liste pour ne garder que les sessions dont l'année académique contient le texte saisi
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRanneeAcademique.Text)).ToList();
            }

            // Affiche la liste filtrée dans le DataGridView
            dgSession.DataSource = liste;
        }
    }
}
