using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace TesteProjetoEixo2.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int CPF { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int DDD { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Senha { get; set; }

    }
}
