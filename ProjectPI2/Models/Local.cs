using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("local")]
    public class local
    {

        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Column(TypeName = "varchar(8)")]
        [Display(Name = "CEP")]
        public string cep { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Display(Name = "País")]
        public string pais { get; set; }

        [ForeignKey("Candidatura")]
        public int candidaturaId { get; set; }
        public virtual candidatura Candidatura { get; set; }

        [ForeignKey("Trabalho")]
        public int trabalhoId { get; set; }
        public virtual trabalho Trabalho { get; set; }

    }
}
