using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Nome { get; set; }
        [RegularExpression(@"[a-zA-Z0-9._@#$% ]+$", ErrorMessage = "Login Inválido. Confira se Digtou somente lêtras ou números. Por favor!")]
        [Required(ErrorMessage = "O login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Login já cadastrado!")]
        public string Login { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um Email válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não se confirmam. Tente novamente!")]
        public string ConfirmaSenha { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma mensagem válida.")]
        public string Info { get; set; }
    }
}