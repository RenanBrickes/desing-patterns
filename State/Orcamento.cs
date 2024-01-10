using DesingPatterns.Stateg;

namespace DesingPatterns.State
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
            Estado = new EmAprovacao();

        }

        public double Valor { get; set; }
        public IEstado Estado { get; set; }

        public void AplicaDescontoDiferencial()
        {
            Estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            Estado.Aprova(this);
        }

        public void Reprova()
        {
            Estado.Reprova(this);
        }

        public void Finaliza()
        {
            Estado.Finaliza(this);
        }
    }
}
