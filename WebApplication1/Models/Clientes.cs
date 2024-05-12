using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace TesteProjetoEixo2.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        //[Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o CPF.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o nome.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o email.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o DDD.")]
        public int DDD { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha o telefone.")]
        public int Numero { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório. Por favor, preencha a data de nascimento.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório. Por favor, informe uma senha.")]
        public string Senha { get; set; }
    }
}
