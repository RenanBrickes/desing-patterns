using DesingPatterns.Builder;

namespace DesingPatterns.Observer
{
    internal class AcaoEmail : IAcao
    {
        public void Execulta(NF notaFiscal)
        {
            Console.WriteLine("Enviou email");
        }
    }
}
