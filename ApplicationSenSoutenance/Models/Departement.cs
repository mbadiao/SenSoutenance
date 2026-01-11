using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationSenSoutenance.Models
{
    public class Departement
    {
        [Key]
        public int IdDepartement { get; set; }

        [Required, MaxLength(80)]
        public string LibelleDepartement { get; set; }

        [MaxLength(20)]
        public string CodeDepartement { get; set; }

        public virtual ICollection<ChefDepartement> ChefsDepartement { get; set; }
    }
}
