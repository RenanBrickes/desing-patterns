namespace DesingPatterns.State
{
    public class Finaliza : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél aplicar desconto para um estado finalizado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél aprovar um orçamento com estado finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél reprovar um orçamento com estado finalizado");
        }

        void IEstado.Finaliza(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél finalizar um orçamento com estado finalizado");
        }
    }
}
