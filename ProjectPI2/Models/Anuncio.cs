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

        [Column(TypeName = "varchar(30)")]
        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Display(Name = "Categoria")]
        public string categorianome { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Data")]
        public DateTime data { get; set; }
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Column(TypeName = "varchar(15)")]
        [Display(Name = "WhatsApp")]
        public string whatsapp { get; set; }

        [Column(TypeName = "DOUBLE PRECISION")]
        [Display(Name = "Custo")]
        public double custo { get; set; }

        [Required()]
        [Column(TypeName = "Boolean  DEFAULT FALSE")]
        [Display(Name = "disponibilidade")]
        public bool disponibilidade { get; set; }

        [ForeignKey("usuarioId")]
        [Display(Name = "ID usuario")]
        public int usuarioId { get; set; }

    }
}
