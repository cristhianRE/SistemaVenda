using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVenda.Models
{
    public class ProdutoViewModel
    {
        public int? Codigo { get; set; }

        [Required(ErrorMessage = "Informe o Descrição do Produto!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a Quantidade em estoque do Produto!")]
        public double Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o Valor unitário do Produto!")]
        [Range(0.1, Double.PositiveInfinity)]
        public decimal? Valor { get; set; }

        [Required(ErrorMessage = "Informe a Categoria do Produto!")]
        public int? CodigoCategoria { get; set; }

        public IEnumerable<SelectListItem> ListaCategorias { get; set; }

        public string DescricaoCategoria { get; set; }
    }
}
