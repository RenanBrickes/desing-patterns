using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder
{
    public class ItemNota
    {
        public ItemNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
