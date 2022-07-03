using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPI2.Models
{
    public class anuncio
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string imagepath { get; set; }

        public string categorianome { get; set; }

        public string categnome { get; set; }

        public string descricao { get; set; }

        public string telefone { get; set; }

        public string whatsapp { get; set; }

        public double custo { get; set; }

        public string endereco { get; set; }

        public string cep { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public int usuarioId { get; set; }
        public usuario Usuarios { get; set; }

    }
}
