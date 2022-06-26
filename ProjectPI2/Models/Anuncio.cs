using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("anuncio")]
    public class anuncio
    {

        [Display(Name = "id")]
        public int id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data")]
        public DateTime data { get; set; }

        [Column(TypeName = "DOUBLE PRECISION")]
        [Display(Name = "Custo por hora")]
        public double custo { get; set; }

        [Required()]
        [Column(TypeName = "Boolean  DEFAULT FALSE")]
        [Display(Name = "disponibilidade")]
        public bool disponibilidade { get; set; }

        [ForeignKey("usuarioId")]
        [Display(Name = "ID usuario")]
        public int usuarioId { get; set; }

        [ForeignKey("categoriaId")]
        [Display(Name = "ID categoria")]
        public int categoriaId { get; set; }

        [ForeignKey("profissaoId")]
        [Display(Name = "ID profissao")]
        public int profissaoId { get; set; }

    }
}
