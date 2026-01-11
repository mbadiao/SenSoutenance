using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationSenSoutenance.Models
{
    public class Memoire
    {
        [Key]
        public int IdMemoire { get; set; }

        [MaxLength(500), Required]
        public string SujetMemoire { get; set; }

        public byte[] DocumentMemoire { get; set; }

        [Required]
        public int IdSession { get; set; }

        [ForeignKey("IdSession")]
        public virtual Session Session { get; set; }

        [Required]
        public int IdCandidat { get; set; }

        [ForeignKey("IdCandidat")]
        public virtual Candidat Candidat { get; set; }

        [Required]
        public int IdDirecteurMemoire { get; set; }

        [ForeignKey("IdDirecteurMemoire")]
        public virtual Professeur DirecteurMemoire { get; set; }

        public int? IdCoDirecteurMemoire { get; set; }

        [ForeignKey("IdCoDirecteurMemoire")]
        public virtual Professeur CoDirecteurMemoire { get; set; }

        public DateTime DateDepot { get; set; } = DateTime.Now;
        public DateTime? DateModification { get; set; }
    }
}
