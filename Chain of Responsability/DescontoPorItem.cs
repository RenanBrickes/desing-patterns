using DesingPatterns.Stateg;

namespace DesingPatterns
{
    public class DescontoPorItem : DescontoBase
    {
        public DescontoPorItem() : base()
        {
        }

        public override double Desconto(Orcamento orcamento)
        {
            if (orcamento.Items.Count > 5)
            {
                double desconto = orcamento.Valor - (100 * 0.1);
                Console.WriteLine(desconto);
                return desconto;
            }
            return Proximo.Desconto(orcamento);
        }
    }
}
