using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserforRegisterDto
    {
        [Required(ErrorMessage="Nome do usuário não pode ser vazio!")]
        public string Username { get; set; }
        
        [Required(ErrorMessage="Nome do usuário não pode ser vazio!")]
        [StringLength(8,MinimumLength=4,ErrorMessage="A senha deve ter entre 4 e 8 caracteres")]
        public string Password { get; set; }
    }
}