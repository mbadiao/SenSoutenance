using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ApplicationSenSoutenance.Models;

namespace ApplicationSenSoutenance
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += GlobalExceptionHandler;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += GlobalUnhandledExceptionHandler;

            if (!VerifierConnexionDB())
                return;

            Application.Run(new frmConnexion());
        }

        static bool VerifierConnexionDB()
        {
            try
            {
                using (var context = new BdSenSoutenanceContext())
                {
                    if (!context.Database.Exists())
                    {
                        MessageBox.Show(
                            "La base de données 'dbsensoutenance' n'existe pas.\n\n" +
                            "Créez-la dans MySQL Workbench.",
                            "Base de données introuvable",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                    context.utilisateurs.Any();
                }
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Erreur de connexion :\n\n" + message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static void GlobalExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(((Exception)e.ExceptionObject).Message, "Erreur Critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
