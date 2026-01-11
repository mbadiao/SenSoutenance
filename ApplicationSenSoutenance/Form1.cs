using ApplicationSenSoutenance.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSenSoutenance
{
    public partial class frmConnexion : Form
    {
        private BdSenSoutenanceContext bd = new BdSenSoutenanceContext();
        private const string EMAIL_PLACEHOLDER = "Email ou Matricule";
        private const string PASSWORD_PLACEHOLDER = "Mot de passe";

        public frmConnexion()
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializePlaceholders();
        }

        private void InitializePlaceholders()
        {
            SetPlaceholder(txtEmail, EMAIL_PLACEHOLDER);
            SetPlaceholder(txtMotDePasse, PASSWORD_PLACEHOLDER);

            txtEmail.Enter += RemovePlaceholder;
            txtEmail.Leave += AddPlaceholder;
            txtMotDePasse.Enter += RemovePlaceholder;
            txtMotDePasse.Leave += AddPlaceholder;
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.DarkGray;
            if (textBox == txtMotDePasse)
                textBox.PasswordChar = '\0';
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == EMAIL_PLACEHOLDER || textBox.Text == PASSWORD_PLACEHOLDER)
            {
                textBox.Text = "";
                textBox.ForeColor = ColorTranslator.FromHtml("#E0E0E0");
                if (textBox == txtMotDePasse)
                    textBox.PasswordChar = '*';
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txtEmail)
                    SetPlaceholder(textBox, EMAIL_PLACEHOLDER);
                else if (textBox == txtMotDePasse)
                    SetPlaceholder(textBox, PASSWORD_PLACEHOLDER);
            }
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void btnSeConnecter_MouseEnter(object sender, EventArgs e)
        {
            btnSeConnecter.BackColor = ColorTranslator.FromHtml("#AD2EC6");
        }

        private void btnSeConnecter_MouseLeave(object sender, EventArgs e)
        {
            btnSeConnecter.BackColor = ColorTranslator.FromHtml("#7A5CF9");
        }

        private void btnQuitter_MouseEnter(object sender, EventArgs e)
        {
            btnQuitter.ForeColor = ColorTranslator.FromHtml("#FF6B6B");
        }

        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.ForeColor = ColorTranslator.FromHtml("#B0B0B0");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            Authentifier();
        }

        private void frmConnexion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Authentifier();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void Authentifier()
        {
            lblErreur.Visible = false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == EMAIL_PLACEHOLDER)
            {
                AfficherErreur("Veuillez saisir votre email ou matricule");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotDePasse.Text) || txtMotDePasse.Text == PASSWORD_PLACEHOLDER)
            {
                AfficherErreur("Veuillez saisir votre mot de passe");
                txtMotDePasse.Focus();
                return;
            }

            try
            {
                string identifiant = txtEmail.Text.Trim();
                string motDePasse = txtMotDePasse.Text;

                var utilisateur = bd.utilisateurs.ToList()
                    .FirstOrDefault(u => u.EmailUtilisateur.Equals(identifiant, StringComparison.OrdinalIgnoreCase));

                if (utilisateur == null || utilisateur.MotDePasse != motDePasse)
                {
                    AfficherErreur("Email/Matricule ou mot de passe incorrect");
                    txtMotDePasse.Clear();
                    SetPlaceholder(txtMotDePasse, PASSWORD_PLACEHOLDER);
                    txtMotDePasse.Focus();
                    return;
                }

                if (!utilisateur.EstActif)
                {
                    AfficherErreur("Compte désactivé. Contactez l'administrateur.");
                    return;
                }

                SessionUtilisateur.Utilisateur = utilisateur;
                frmMDI f = new frmMDI();
                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                string erreur = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                AfficherErreur(erreur);
            }
        }

        private void AfficherErreur(string message)
        {
            lblErreur.Text = message;
            lblErreur.Visible = true;
        }
    }

    public static class SessionUtilisateur
    {
        public static Utilisateur Utilisateur { get; set; }

        public static bool EstAdmin() => Utilisateur is Admin;
        public static bool EstProfesseur() => Utilisateur is Professeur;
        public static bool EstCandidat() => Utilisateur is Candidat;
        public static bool EstChefDepartement() => Utilisateur is ChefDepartement;

        public static string ObtenirNomComplet()
        {
            return Utilisateur != null ? $"{Utilisateur.PrenomUtilisateur} {Utilisateur.NomUtilisateur}" : "";
        }
    }
}
