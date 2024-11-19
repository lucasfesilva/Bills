using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bills.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public ICollection<Fatura> Faturas { get; set; }


        public override string ToString()
        {
            return $"{Id} - {Nome} - {Sobrenome} - {Cpf}";
        }
    }
}
