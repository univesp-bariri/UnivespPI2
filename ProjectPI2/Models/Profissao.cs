using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("profissao")]
    public class profissao
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

    }
}