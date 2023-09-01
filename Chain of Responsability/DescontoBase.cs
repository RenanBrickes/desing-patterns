using DesingPatterns.Stateg;

namespace DesingPatterns
{
    public abstract class DescontoBase : IDescontoProximo
    {
        public IDescontoProximo Proximo { get; set; }

        public abstract double Desconto(Orcamento orcamento);
    }
}
