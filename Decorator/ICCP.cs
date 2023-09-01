using DesingPatterns.Stateg;

namespace DesingPatterns.Decorator
{
    public class ICCP : Imposto
    {
        public ICCP()
        {
        }

        public ICCP(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculaOutroImposto(orcamento);
        }

    }
}
