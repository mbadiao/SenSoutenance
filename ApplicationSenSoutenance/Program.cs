using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSenSoutenance
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Gestion globale des exceptions
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalUnhandledExceptionHandler);

            Application.Run(new frmConnexion());
        }

        static void GlobalExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Une erreur inattendue s'est produite : " + e.Exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Une erreur critique s'est produite : " + ((Exception)e.ExceptionObject).Message, "Erreur Critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
