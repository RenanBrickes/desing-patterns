using DesingPatterns.Builder;

namespace DesingPatterns.Observer
{
    public class AcaoSms : IAcao
    {
        public void Execulta(NF notaFiscal)
        {
            Console.WriteLine("Enviou SMS");
        }
    }
}
