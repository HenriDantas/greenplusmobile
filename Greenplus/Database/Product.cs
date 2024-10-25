using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenplus.Database
{
    public class Product
    {
        public int PlantaId {  get; set; }
        public string NomePlanta {  get; set; }
        public string NomeCientifico{  get; set; }
        public string Classificacao {  get; set; }
        public int TempoEstimado {  get; set; }
        public decimal Temperatura {  get; set; }
        public int Irrigacao {  get; set; }
        public float ValorVenda {  get; set; }
    }
}
