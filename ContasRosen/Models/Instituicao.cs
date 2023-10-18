using System.ComponentModel;

namespace ContasRosen.Models
{
    public class Instituicao
    {
        [DisplayName("Código")]
        public long? InstituicaoID { get; set; } // o ? significa que o long pode ser nulo e vamos colocar para ser autoincrement
        public string Nome { get; set; } // Tem que ser preenchido pois não tem o ?
        public string Endereco { get; set; } // Tem que ser preenchido pois não tem o ?
    }
}
