using DesingPatterns.Stateg;

namespace DesingPatterns
{
    public class DescontoVendaCasada : DescontoBase
    {
        public DescontoVendaCasada() : base()
        {
        }

        public override double Desconto(Orcamento orcamento)
        {
            var hasLapis = orcamento.Items.Where(c => c.Nome.ToUpper() == "lapis".ToUpper()).Any();
            var hasCaneta = orcamento.Items.Where(c => c.Nome.ToUpper() == "caneta".ToUpper()).Any();
            if (hasLapis && hasCaneta)
            {
                double desconto = orcamento.Valor * 0.5;
                return desconto;
            }

            return 0;
        }
    }
}
