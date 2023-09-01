using DesingPatterns.Stateg;

namespace DesingPatterns.Template_Method
{
    public class IHIT : TemplateImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Items.Where(c => c.Nome == c.Nome).Any();
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Items.Count() * 0.1;
        }

    }
}
