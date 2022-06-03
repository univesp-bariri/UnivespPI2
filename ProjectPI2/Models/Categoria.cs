using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("categoria")]
    public class categoria
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [ForeignKey("Candidatura")]
        public int candidaturaId { get; set; }
        public virtual candidatura Candidatura { get; set; }

        [ForeignKey("Trabalho")]
        public int trabalhoId { get; set; }
        public virtual trabalho Trabalho { get; set; }
    }
}