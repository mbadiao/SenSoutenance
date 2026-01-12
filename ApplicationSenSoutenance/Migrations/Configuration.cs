using System;
using System.Data.Entity.Migrations;

namespace ApplicationSenSoutenance.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Models.BdSenSoutenanceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Models.BdSenSoutenanceContext context)
        {
            context.admins.AddOrUpdate(
                a => a.EmailUtilisateur,
                new Models.Admin
                {
                    NomUtilisateur = "Admin",
                    PrenomUtilisateur = "Système",
                    EmailUtilisateur = "admin@sensoutenance.sn",
                    TelUtilisateur = "770000000",
                    MotDePasse = "admin123",
                    EstActif = true,
                    DateCreation = DateTime.Now
                }
            );
            context.SaveChanges();
        }
    }
}
