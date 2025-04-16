using System.ComponentModel.DataAnnotations;

namespace AplicacaoBlazor.DTO.Tarefa
{
    public class TarefaDTO
    {
        [Required(ErrorMessage = "A titulo é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O titulo deve ter no máximo 50 caracteres.")]
        [MinLength(5, ErrorMessage = "O titulo deve ter no mínimo 5 caracteres.")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatório!")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres.")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no mínimo 10 caracteres.")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "O status é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O status deve ter no máximo 50 caracteres.")]
        [MinLength(5, ErrorMessage = "O status deve ter no mínimo 5 caracteres.")]
        public string status { get; set; }

        [Required(ErrorMessage = "O email do usuário é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O email do usuário deve ter no máximo 50 caracteres.")]
        [MinLength(5, ErrorMessage = "O email do usuário deve ter no mínimo 5 caracteres.")]
        public string emailUsuario { get; set; }
    }
}