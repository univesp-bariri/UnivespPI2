using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    [Table("usuario")]
    public class usuario
    {

        [Display(Name = "id")]
        public int id { get; set; }

        [Required()]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Usuário")]
        public string username { get; set; }

        [Required()]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Required()]
        [Column(TypeName = "varchar(30)")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Required()]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required()]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Required()]
        [Column(TypeName = "varchar(8)")]
        [Display(Name = "CEP")]
        public string cep { get; set; }

        [Required()]
        [Column(TypeName = "varchar(30)")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required()]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required()]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "País")]
        public string pais { get; set; }

        [Required()]
        [Column(TypeName = "Boolean  DEFAULT FALSE")]
        [Display(Name = "Pessoa Jurídia")]
        public Boolean pjuridica { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }

        [Column(TypeName = "VARCHAR(11)")]
        [Display(Name = "CPF")]
        public string cpf { get; set; }

/*
        [ForeignKey("Contratante")]
        public int contratanteId { get; set; }
        public virtual contratante Contratante { get; set; }
        
        [ForeignKey("Candidato")]
        public int candidatoId { get; set; }
        public virtual candidato Candidato { get; set; }
        */
    }
}
