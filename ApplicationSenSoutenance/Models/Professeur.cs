using System.ComponentModel.DataAnnotations;

namespace ApplicationSenSoutenance.Models
{
    public class Professeur : Utilisateur
    {
        [Required, MaxLength(80)]
        public string SpecialiteProfesseur { get; set; }

        [MaxLength(100)]
        public string GradeProfesseur { get; set; }
    }
}
