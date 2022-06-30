using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    public class anuncio
    {

        public int id { get; set; }

        public string titulo { get; set; }

        public string categorianome { get; set; }

        public string descricao { get; set; }


        public string telefone { get; set; }

        public string whatsapp { get; set; }

        public double custo { get; set; }

        public int usuarioId { get; set; }
        public usuario Usuarios { get; set; }

        public int categoriaId { get; set; }
        public categoria categoria { get; set; }




    }
}
