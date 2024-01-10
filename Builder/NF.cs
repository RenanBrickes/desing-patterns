using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder
{
    public class NF
    {
        public NF(string razaoSocial, string cNPJ, DateTime dataEmissao, double valorBruto, double imposto, IList<ItemNota> items, string observacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            DataEmissao = dataEmissao;
            ValorBruto = valorBruto;
            Item = items;
            Imposto = imposto;
            Observacoes = observacoes;
        }

        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Imposto { get; set; }
        public IList<ItemNota> Item { get; set; }
        public string Observacoes { get; set; }
    }
}
