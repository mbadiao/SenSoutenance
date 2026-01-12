using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationSenSoutenance.Models
{
    public class Session
    {
        [Key]
        public int IdSession { get; set; }

        [Required, MaxLength(100)]
        public string LibelleSession { get; set; }

        [Required]
        public int IdAnneeAcademique { get; set; }

        [ForeignKey("IdAnneeAcademique")]
        public virtual AnneeAcademique AnneeAcademique { get; set; }

        public virtual ICollection<Memoire> Memoires { get; set; }
    }
}
