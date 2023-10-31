using System.ComponentModel;

namespace ContasRosen.Models
{
    public class Departamento
    {
        [DisplayName("Código")]
        public long? DepartamentoID { get; set; } 
        public string Nome { get; set; } 
    }
}
