using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSenSoutenance.Models
{
    public class Soutenance
    {
        [Key]
        public int IdSoutenance { get; set; }

        public DateTime DateSoutenance { get; set; } = DateTime.Now;

        [MaxLength(2000)]
        public string LieuSoutenance { get; set; }

        [MaxLength(40)]
        public string ResultatSoutenance { get; set; }

        [MaxLength(100)]
        public string MentionSoutenance { get; set; }

        [MaxLength(5000)]

        public string ObservationsSoutenance { get; set; }

        public int? IdMemoire { get; set; }

        [ForeignKey("IdMemoire")]

        public virtual Memoire Memoire { get; set; }
    }
}
