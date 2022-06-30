using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjectPI2.Models
{
    public class usuario
    {

        [Display(Name = "id")]
        public int id { get; set; }

        public string username { get; set; }

        public string senha { get; set; }

        public string email { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public string cep { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public bool pjuridica { get; set; }

        public string cnpj { get; set; }

        public string cpf { get; set; }

        public ICollection<anuncio> Anuncios { get; set; }

    }
}