﻿using Microsoft.AspNetCore.Identity;
using ProjetoMyTeDev.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMyTeDev.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Nome do Funcionário")]
        [Required]
        [PersonalData]
        public string? Nome { get; set; }
        [Display(Name = "Departamento")]
        [Required]
        public int DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }

        [Display(Name = "Data de Contratação")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateOnly? DataContratacao { get; set; }

        public string? Localidade { get; set; }

        public Cargo? Cargo { get; set; }

        [Display(Name = "Cargo")]
        [Required]
        public int CargoId { get; set; }

        public bool Ativo {  get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Formato de telefone não é válido.")]
        public string? PhoneNumber { get; set; }
    }
}
