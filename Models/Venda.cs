using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Poo.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("nome_produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

    }
}