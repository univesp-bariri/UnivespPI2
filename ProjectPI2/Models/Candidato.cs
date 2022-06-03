using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("candidato")]
    public class candidato
    {

        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Qualificação")]
        public string qualificacao { get; set; }

        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }
        public virtual usuario Usuario { get; set; }
    }
}
