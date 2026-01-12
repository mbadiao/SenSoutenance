using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationSenSoutenance.Models
{
    public class Soutenance
    {
        [Key]
        public int IdSoutenance { get; set; }

        [Required]
        public DateTime DateSoutenance { get; set; } = DateTime.Now;

        [MaxLength(200)]
        public string LieuSoutenance { get; set; }

        [MaxLength(40)]
        public string ResultatSoutenance { get; set; }

        [MaxLength(100)]
        public string MentionSoutenance { get; set; }

        [MaxLength(5000)]
        public string ObservationsSoutenance { get; set; }

        [Required]
        public int IdMemoire { get; set; }

        [ForeignKey("IdMemoire")]
        public virtual Memoire Memoire { get; set; }

        [Required]
        public int IdPresident { get; set; }

        [ForeignKey("IdPresident")]
        public virtual Professeur President { get; set; }

        [Required]
        public int IdRapporteur { get; set; }

        [ForeignKey("IdRapporteur")]
        public virtual Professeur Rapporteur { get; set; }

        [Required]
        public int IdExaminateur1 { get; set; }

        [ForeignKey("IdExaminateur1")]
        public virtual Professeur Examinateur1 { get; set; }

        public int? IdExaminateur2 { get; set; }

        [ForeignKey("IdExaminateur2")]
        public virtual Professeur Examinateur2 { get; set; }

        public decimal? NoteSoutenance { get; set; }

        public DateTime DateCreation { get; set; } = DateTime.Now;
        public DateTime? DateModification { get; set; }
    }
}
