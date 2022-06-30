using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    public class categoria
    {
        public int id { get; set; }

        public string nome { get; set; }

        public ICollection<anuncio> Anuncios { get; set; }

    }
}