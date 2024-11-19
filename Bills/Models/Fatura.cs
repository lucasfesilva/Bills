using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills.Models
{
    public class Fatura
    {
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime? DataEmissao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Item> Itens { get; set; }

        public void CalcularValorTotal()
        {
            ValorTotal = Itens.Sum(item => item.PrecoUnitario * item.Quantidade);
        }
    }
}
