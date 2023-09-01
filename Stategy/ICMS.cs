namespace DesingPatterns.Stateg
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;

        }
    }
}
