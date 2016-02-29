using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DAL.Entity;
using DAL.Persistence;

namespace Site.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Por favor, informe seu Nome de Usuário.")]
        [RegularExpression("^[a-zA-ZÀ-Üà-ü\\s]{4,50}$",
            ErrorMessage = "Erro. Nome Inválido.")]
        [Display(Name = "Nome de Usuário:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu Nome de CPF.")]
        [RegularExpression("^[a-zA-Z0-9_.-]*$",
            ErrorMessage = "CPF. Nome Inválido.")]
        [Display(Name = "CPF:")]
        public string UserCpf { get; set; }

        
        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento.")]
        [Display(Name = "Data de Nascimento:")]
        public string UserBirth { get; set; }

        
        [Required(ErrorMessage = "Por favor, informe seu Sexo.")]
        [RegularExpression("^[a-zA-ZÀ-Üà-ü\\s]{4,50}$",
            ErrorMessage = "Erro. Nome Inválido.")]
        [Display(Name = "Sexo:")]
        public string UserGender { get; set; }
        
        [Required(ErrorMessage = "Por favor, informe seu CEP.")]
        [RegularExpression("^[a-zA-Z0-9_.-]*$",
            ErrorMessage = "Erro. CEP inválido.")]
        [Display(Name = "CEP:")]
        public string AddressCep { get; set; }

        [Required(ErrorMessage = "Por favor, informe sua Rua.")]
        [RegularExpression("^[a-zA-ZÀ-Üà-ü0-9\\s]{4,50}$",
            ErrorMessage = "Erro. Rua Inválida.")]
        [Display(Name = "Rua:")]
        public string AddressStreet { get; set; }

        [Required(ErrorMessage = "Por favor, informe o número de sua casa.")]
        [RegularExpression("^[a-zA-Z0-9\\s]{1,10}$",
            ErrorMessage = "Erro. Número de casa Inválido.")]
        [Display(Name = "Número:")]
        public string AddressNumber { get; set; }

        [RegularExpression("^[a-zA-ZÀ-Üà-ü0-9\\s]{4,50}$",
            ErrorMessage = "Erro. Complemento de endereço Inválido.")]
        [Display(Name = "Complemento:")]
        public string AddressComplement { get; set; }
        
        [Required(ErrorMessage = "Por favor, informe sua cidade.")]
        [RegularExpression("^[a-zA-ZÀ-Üà-ü0-9\\s]{4,50}$",
            ErrorMessage = "Erro. Cidade Inválido.")]
        [Display(Name = "Cidade:")]
        public string AddressCity { get; set; }

        [Required(ErrorMessage = "Por favor, informe o seu estado.")]
        [RegularExpression("^[a-zA-ZÀ-Üà-ü0-9\\s]{4,50}$",
            ErrorMessage = "Erro. Estado Inválido.")]
        [Display(Name = "Estado:")]
        public string AddressState { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu bairro.")]
        [RegularExpression("^[a-zA-ZÀ-Üà-ü0-9\\s]{4,50}$",
            ErrorMessage = "Erro. Bairro Inválido.")]
        [Display(Name = "Bairro:")]
        public string AddressDistrict { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu Login.")]
        [RegularExpression("^[a-z0-9]{4,20}$",
            ErrorMessage = "Erro. Login Inválido.")]
        [Display(Name = "Login:")]
        public string UserLogin { get; set; }

        [Required(ErrorMessage = "Por favor, informe sua senha.")]
        [RegularExpression("^[a-zA-Z0-9]{6,10}$",
            ErrorMessage = "Erro. Senha Inválido.")]
        [Display(Name = "Senha:")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "Por favor, informe o sua senha novamente.")]
        [RegularExpression("^[a-zA-Z0-9]{6,10}$",
            ErrorMessage = "Erro. As senhas devem coincidir.")]
        [Display(Name = "Confirmação de Senha:")]
        public string UserPasswordConfirm { get; set; }


        
    }
}