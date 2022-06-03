using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("candidatura")]
    public class candidatura
    {

        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "DATE")]
        [Display(Name = "data")]
        public DateTime data { get; set; }

        [Column(TypeName = "DATE")]
        [Display(Name = "expiradata")]
        public DateTime expiradata { get; set; }

        [ForeignKey("contratanteId")]
        [Display(Name = "ID Contratante")]
        public int contratanteId { get; set; }

        [ForeignKey("candidatoId")]
        [Display(Name = "ID Candidato")]
        public int candidatoId { get; set; }

    }
}
