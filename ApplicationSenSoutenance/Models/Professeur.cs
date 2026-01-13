using System.ComponentModel.DataAnnotations;

namespace ApplicationSenSoutenance.Models
{
    public class Professeur : Utilisateur
    {
        [MaxLength(80)]
        public string SpecialiteProfesseur { get; set; }
    }
}
