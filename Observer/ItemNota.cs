namespace DesingPatterns.Observer
{
    public class ItemNota
    {
        public ItemNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
