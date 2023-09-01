using DesingPatterns.Stateg;

namespace DesingPatterns.Decorator
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ICMS()
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6 + CalculaOutroImposto(orcamento);
        }

    }
}
