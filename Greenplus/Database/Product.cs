using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenplus.Database
{
    public class Product
    {
        public int? ProdutoId {  get; set; }
        public bool Categoria {  get; set; }
        public string? Nome {  get; set; }
        public string? NomeCientifico {  get; set; }
        public string? Descricao { get; set; }
        public string? EstadoDeConservacao { get; set; }
        public string? Classificacao {  get; set; }
        public int? TempoEstimado {  get; set; }
        public int? Temperatura {  get; set; }
        public int? Irrigacao {  get; set; }
        public float? ValorVenda {  get; set; }
    }
}
