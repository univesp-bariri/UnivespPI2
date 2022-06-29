using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjectPI2.Models
{
    [Table("usuario")]
    public class usuario
    {

        [Display(Name = "id")]
        public int id { get; set; }

        [Required(ErrorMessage ="O username é obrigatório.")]
        [Column(TypeName = "varchar(20)")]
        [MinLength(3, ErrorMessage = "Username muito curto")]
        [MaxLength(20)]
        [Display(Name = "Usuário")]
        public string username { get; set; }

        [Required(ErrorMessage ="A senha é obrigatória.")]
        [Column(TypeName = "varchar(20)")]
        [MinLength(6, ErrorMessage = "Senha muito curta")]
        [MaxLength(20)]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Required(ErrorMessage ="O email é obrigatório.")]
        [Column(TypeName = "varchar(30)")]
        [MaxLength(30)]
        [EmailAddress(ErrorMessage ="Email inválido.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório.")]
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        [MinLength(5, ErrorMessage = "Nome muito curto")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage ="O endereço é obrigatório.")]
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        [MinLength(5, ErrorMessage = "Endereço muito curto")]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Required(ErrorMessage ="O CEP é obrigatório.")]
        [Column(TypeName = "varchar(8)")]
        [MaxLength(8)]
        [MinLength(8, ErrorMessage = "CEP muito curto")]
        [Display(Name = "CEP")]
        public string cep { get; set; }

        [Required(ErrorMessage ="A cidade é obrigatória.")]
        [Column(TypeName = "varchar(30)")]
        [MaxLength(30)]
        [MinLength(3, ErrorMessage = "Cidade inválida, muito curto")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required(ErrorMessage ="O estado é obrigatório.")]
        [Column(TypeName = "varchar(20)")]
        [MaxLength(20)]
        [MinLength(2, ErrorMessage = "Estado inválido, muito curto")]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required()]
        [Column(TypeName = "Boolean  DEFAULT FALSE")]
        [Display(Name = "Pessoa Jurídia")]
        public bool pjuridica { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [MaxLength(14)]
        [MinLength(14, ErrorMessage = "CNPJ muito curto")]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }

        [Column(TypeName = "VARCHAR(11)")]
        [MaxLength(11)]
        [MinLength(11, ErrorMessage = "CPF muito curto")]
        [Display(Name = "CPF")]
        public string cpf { get; set; }
    }
}