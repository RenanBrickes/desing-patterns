using DesingPatterns.Stateg;

namespace DesingPatterns.Decorator
{
    public class IMA : Imposto
    {
        public IMA()
        {
        }

        public IMA(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + OutroImposto.Calcula(orcamento);
        }
    }
}
