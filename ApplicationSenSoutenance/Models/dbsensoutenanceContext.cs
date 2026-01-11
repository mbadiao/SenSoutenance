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


    }
}
