using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationSenSoutenance.Models
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }

        [Required, MaxLength(80)]
        public string NomUtilisateur { get; set; }

        [MaxLength(80)]
        public string PrenomUtilisateur { get; set; }

        [MaxLength(15)]
        public string TelUtilisateur { get; set; }

        [MaxLength(80), DataType(DataType.EmailAddress)]
        public string EmailUtilisateur { get; set; }

        [Required, MaxLength(300)]
        public string MotDePasse { get; set; }

        public DateTime DateCreation { get; set; } = DateTime.Now;
        public DateTime? DateModification { get; set; }
        public bool EstActif { get; set; } = true;
    }
}
