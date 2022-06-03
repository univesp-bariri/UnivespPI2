using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("contratante")]
    public class contratante
    {

        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Setor")]
        public string setor { get; set; }

        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }
        public virtual usuario Usuario { get; set; }
    }
}
