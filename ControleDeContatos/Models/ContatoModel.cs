using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o email do contato!")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular do contato!")]
        [Phone(ErrorMessage = "Celular inválido")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Digite um numero valido com (DDD)")]
        public string Celular { get; set; }
    }
}
