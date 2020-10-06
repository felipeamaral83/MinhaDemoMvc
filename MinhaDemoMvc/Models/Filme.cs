﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 ou 60 caracteres.")]
        public string Titulo { get; set; }
        
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto.")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório.")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido.")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres."), Required(ErrorMessage = "O campo Gênero é obrigatório.")]
        public string Genero { get; set; }
        
        [Range(1,1000, ErrorMessage = "Valor de R$ 1,00 a R$ 1.000,00.")]
        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números.")]
        [Required(ErrorMessage = "O campo Avaliação é obrigatório.")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
