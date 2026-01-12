using System.ComponentModel.DataAnnotations;

namespace ApplicationSenSoutenance.Models
{
    public class Candidat : Utilisateur
    {
        [Required, MaxLength(20)]
        public string MatriculeCandidat { get; set; }

        public virtual System.Collections.Generic.ICollection<Memoire> Memoires { get; set; }
    }
}
