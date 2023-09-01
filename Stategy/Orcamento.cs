namespace DesingPatterns.Stateg
{
    public class Orcamento
    {
        public Orcamento(double valor, Item item)
        {
            Valor = valor;
            Items = new List<Item>();
            Adiciona(item);
        }

        public double Valor { get; set; }
        public IList<Item> Items { get; private set; }

        public void Adiciona(Item item)
        {
            Items.Add(item);
        }
    }
}
