using System.ComponentModel.DataAnnotations;

namespace GlobalSolution02.Models
{
    public class CalculadoraIMC
    {
        [Required(ErrorMessage = "O campo Peso é obrigatório.")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "O campo Altura é obrigatório.")]
        public decimal Altura { get; set; }

        public decimal Resultado { get; set; }
    }
}
