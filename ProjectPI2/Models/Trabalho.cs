using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("trabalho")]
    public class trabalho
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Display(Name = "Título")]
        public string titulo { get; set; }
        
        [Column(TypeName = "DOUBLE PRECISION")]
        [Display(Name = "salario")]
        public double salario { get; set; }
        
        [Column(TypeName = "DATE")]
        [Display(Name = "dataContratacao")]
        public DateTime dataContratacao { get; set; }

        [ForeignKey("Categoria")]
        public int categoriaId { get; set; }
        public virtual categoria Categoria { get; set; }

        [ForeignKey("LocalId")]
        public int localId { get; set; }
        public virtual local Local { get; set; }

        [ForeignKey("Candidatura")]
        public int candidaturaId { get; set; }
        public virtual candidatura Candidatura { get; set; }

    }
}