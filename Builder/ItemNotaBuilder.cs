namespace DesingPatterns.Builder
{
    public class ItemNotaBuilder
    {
        private string Nome;
        private double Valor;


        public ItemNota Builder()
        {
            return new ItemNota(Nome, Valor);
        }

        public ItemNotaBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemNotaBuilder ComValor(double valor)
        {
            Valor = valor; return this;
        }
    }
}
