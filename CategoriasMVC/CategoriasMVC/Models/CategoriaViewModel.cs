﻿using System.ComponentModel.DataAnnotations;

namespace CategoriasMVC.Models
{
    public class CategoriaViewModel
    {
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "O nome da categoria é obrigatório")]
        public string? Nome { get; set; }
        [Required]
        [Display(Name ="Imagem")]
        public string?  ImagemUrl { get; set; }
    }
}
