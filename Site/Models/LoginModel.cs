using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Por favor, informe seu Login.")]
        [RegularExpression("^[a-z0-9]{4,20}$",
            ErrorMessage = "Erro. Login Inválido.")]
        [Display(Name = "Nome de Usuário")]
        public string UserLogin { get; set; }

        [Required(ErrorMessage = "Por favor, informe sua Senha.")]
        [RegularExpression("^[a-zA-Z0-9]{6,10}$",
            ErrorMessage = "Erro. Senha Inválida.")]
        [Display(Name = "Senha")]
        public string UserPassword { get; set; }
    }
}