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
        }
    }
}
