namespace DesingPatterns.State
{
    public class Aprova : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finaliza();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprova();
        }

        void IEstado.Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél aprovar um orçamento com estado aprovado");
        }
    }
}
