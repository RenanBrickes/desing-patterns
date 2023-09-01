using DesingPatterns.Stateg;

namespace DesingPatterns
{
    public class CalculadoraDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            IDescontoProximo d1 = new DescontoPorItem();
            IDescontoProximo d2 = new DescontoPorValor();
            IDescontoProximo d3 = new DescontoVendaCasada();
            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconto(orcamento);
        }

    }
}
