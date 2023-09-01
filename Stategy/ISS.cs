namespace DesingPatterns.Stateg
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6;
        }
    }
}
