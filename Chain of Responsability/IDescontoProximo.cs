using DesingPatterns.Stateg;

namespace DesingPatterns
{
    public interface IDescontoProximo
    {
        public IDescontoProximo Proximo { get; set; }
        public double Desconto(Orcamento orcamento);
    }
}
