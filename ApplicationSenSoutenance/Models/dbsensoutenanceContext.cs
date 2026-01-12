using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSenSoutenance.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class dbsensoutenanceContext:DbContext
    {
        public dbsensoutenanceContext() : base("connBdSenSoutenance") { }
        public DbSet<AnneeAcademique> AnneeAcademiques { get; set; }
        public DbSet<Session> Sessions { get; set; }    
        public DbSet<Memoire> Memoires { get; set; }
        public DbSet<Soutenance> Soutenances { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ChefDepartement> ChefDepartements { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Departement> Departements { get; set; }
      


    }
}
