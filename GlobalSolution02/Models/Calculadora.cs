using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalSolution02.Models
{
    [Table("tblCalculadora")]
    public class Calculadora
    {
        [Required(ErrorMessage = "O campo Id é obrigatório.")]
        [Column("Id")]
        [Display(Name = "Código")]  
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Idade é obrigatório.")]
        [Column("Idade")]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo Sexo é obrigatório.")]
        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string? Sexo { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório.")]
        [Column("Data")]
        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O campo Peso é obrigatório.")]
        [Column("Peso")]
        [Display(Name = "Peso")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "O campo Altura é obrigatório.")]
        [Column("Altura")]
        [Display(Name = "Altura")]
        public decimal Altura { get; set; }

        [Column("Imc")]
        [Display(Name = "Imc")]
        public decimal Imc { get; set; }
    }
}
