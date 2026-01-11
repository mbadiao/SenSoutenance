using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationSenSoutenance.Models
{
    public class AnneeAcademique
    {
        [Key]
        public int IdAnneeAcademique { get; set; }

        [Required, MaxLength(10)]
        public string LibelleAnneeAcademique { get; set; }

        [Required]
        public int AnneeAcademiqueVal { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
