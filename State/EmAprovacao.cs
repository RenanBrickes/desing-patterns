namespace DesingPatterns.State
{
    public class EmAprovacao : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprova();
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finaliza();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprova();
        }
    }
}
