using System.ComponentModel.DataAnnotations;

namespace AplicacaoBlazor.DTO
{
    public class UsuarioDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        [MinLength(10, ErrorMessage = "O nome deve ter no mínimo 10 caracteres.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [MaxLength(100, ErrorMessage = "O email deve ter no máximo 100 caracteres.")]
        [MinLength(10, ErrorMessage = "O email deve ter no mínimo 10 caracteres.")]
        public string email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O senha deve ter no máximo 50 caracteres.")]
        [MinLength(10, ErrorMessage = "O senha deve ter no mínimo 10 caracteres.")]
        public string senha { get; set; }
    }
}