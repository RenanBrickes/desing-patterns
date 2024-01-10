using DesingPatterns.Builder;

namespace DesingPatterns.Observer
{
    public class AcaoBanco : IAcao
    {
        public void Execulta(NF notaFiscal)
        {
            Console.WriteLine("Enviou ao banco");
        }
    }
}
