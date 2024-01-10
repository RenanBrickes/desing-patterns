namespace DesingPatterns.State
{
    public class Reprova : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél aplicar desconto para o estado reprovado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél aprovar um orçamento com estado reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Reprova();
        }

        void IEstado.Reprova(Orcamento orcamento)
        {
            throw new NotImplementedException("Não é possivél reprovar um orçamento com estado reprovado");
        }
    }
}
