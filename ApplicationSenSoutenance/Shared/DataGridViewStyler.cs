using System.Drawing;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Shared
{
    public static class DataGridViewStyler
    {
        public static void ApplyDarkTheme(DataGridView dgv)
        {
            // Couleurs de fond
            dgv.BackgroundColor = ColorTranslator.FromHtml("#1A1A1A");
            dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1A1A1A");
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#7A5CF9");
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);

            // Lignes alternees
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // En-tetes de colonnes
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7A5CF9");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 35;

            // Lignes de grille
            dgv.GridColor = ColorTranslator.FromHtml("#3D3D3D");
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Bordure
            dgv.BorderStyle = BorderStyle.None;

            // En-tetes de lignes
            dgv.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.RowHeadersVisible = false;

            // Autres parametres
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 30;

            // Centrer le contenu des cellules
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Methodes utilitaires pour renommer et masquer les colonnes
        private static void SetColumnHeader(DataGridView dgv, string columnName, string headerText)
        {
            if (dgv.Columns.Contains(columnName))
                dgv.Columns[columnName].HeaderText = headerText;
        }

        private static void HideColumn(DataGridView dgv, string columnName)
        {
            if (dgv.Columns.Contains(columnName))
                dgv.Columns[columnName].Visible = false;
        }

        private static void SetColumnWidth(DataGridView dgv, string columnName, int width)
        {
            if (dgv.Columns.Contains(columnName))
            {
                dgv.Columns[columnName].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns[columnName].Width = width;
            }
        }

        // Configuration pour AnneeAcademique
        public static void ConfigureAnneeAcademique(DataGridView dgv)
        {
            HideColumn(dgv, "IdAnneeAcademique");
            HideColumn(dgv, "Sessions");
            SetColumnHeader(dgv, "LibelleAnneeAcademique", "Libellé");
            SetColumnHeader(dgv, "AnneeAcademiqueVal", "Année");
        }

        // Configuration pour Session
        public static void ConfigureSession(DataGridView dgv)
        {
            HideColumn(dgv, "IdSession");
            HideColumn(dgv, "AnneeAcademique");
            HideColumn(dgv, "Memoires");
            HideColumn(dgv, "IdAnneeAcademique");
            SetColumnHeader(dgv, "LibelleSession", "Session");
        }

        // Configuration pour Professeur
        public static void ConfigureProfesseur(DataGridView dgv)
        {
            HideColumn(dgv, "IdUtilisateur");
            HideColumn(dgv, "MotDePasse");
            HideColumn(dgv, "DateCreation");
            HideColumn(dgv, "DateModification");
            HideColumn(dgv, "EstActif");
            SetColumnHeader(dgv, "NomUtilisateur", "Nom");
            SetColumnHeader(dgv, "PrenomUtilisateur", "Prénom");
            SetColumnHeader(dgv, "EmailUtilisateur", "Email");
            SetColumnHeader(dgv, "TelUtilisateur", "Téléphone");
            SetColumnHeader(dgv, "SpecialiteProfesseur", "Spécialité");
        }

        // Configuration pour Candidat
        public static void ConfigureCandidat(DataGridView dgv)
        {
            HideColumn(dgv, "IdUtilisateur");
            HideColumn(dgv, "MotDePasse");
            HideColumn(dgv, "Memoires");
            HideColumn(dgv, "DateCreation");
            HideColumn(dgv, "DateModification");
            HideColumn(dgv, "EstActif");
            SetColumnHeader(dgv, "MatriculeCandidat", "Matricule");
            SetColumnHeader(dgv, "NomUtilisateur", "Nom");
            SetColumnHeader(dgv, "PrenomUtilisateur", "Prénom");
            SetColumnHeader(dgv, "EmailUtilisateur", "Email");
            SetColumnHeader(dgv, "TelUtilisateur", "Téléphone");
        }

        // Configuration pour Departement
        public static void ConfigureDepartement(DataGridView dgv)
        {
            HideColumn(dgv, "IdDepartement");
            HideColumn(dgv, "ChefsDepartement");
            SetColumnHeader(dgv, "CodeDepartement", "Code");
            SetColumnHeader(dgv, "LibelleDepartement", "Libellé");
        }

        // Configuration pour Memoire
        public static void ConfigureMemoire(DataGridView dgv)
        {
            HideColumn(dgv, "IdMemoire");
            HideColumn(dgv, "Session");
            HideColumn(dgv, "Candidat");
            HideColumn(dgv, "IdSession");
            HideColumn(dgv, "IdCandidat");
            HideColumn(dgv, "DateModification");
            SetColumnHeader(dgv, "SujetMemoire", "Sujet");
            SetColumnHeader(dgv, "DateDepot", "Date Dépôt");
            if (dgv.Columns.Contains("DateDepot"))
                dgv.Columns["DateDepot"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Configuration pour Soutenance
        public static void ConfigureSoutenance(DataGridView dgv)
        {
            // Masquer les colonnes de navigation et IDs
            string[] colonnesAMasquer = { "IdSoutenance", "Memoire", "President", "Rapporteur", "Examinateur1", "Examinateur2",
                                          "IdMemoire", "IdPresident", "IdRapporteur", "IdExaminateur1", "IdExaminateur2",
                                          "DateCreation", "DateModification", "MentionSoutenance", "ObservationsSoutenance" };
            foreach (var col in colonnesAMasquer)
                HideColumn(dgv, col);

            SetColumnHeader(dgv, "DateSoutenance", "Date");
            SetColumnHeader(dgv, "LieuSoutenance", "Lieu");
            SetColumnHeader(dgv, "NoteSoutenance", "Note");
            SetColumnHeader(dgv, "ResultatSoutenance", "Résultat");
            if (dgv.Columns.Contains("DateSoutenance"))
                dgv.Columns["DateSoutenance"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
