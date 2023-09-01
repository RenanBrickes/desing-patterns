using DesingPatterns.Stateg;

namespace DesingPatterns
{
    public class DescontoPorValor : DescontoBase
    {
        public DescontoPorValor() : base()
        {
        }

        public override double Desconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                double desconto = orcamento.Valor - (100 * 0.7);
                Console.WriteLine(desconto);
                return desconto;
            }

            return Proximo.Desconto(orcamento);
        }
    }
}
