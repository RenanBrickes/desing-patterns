using DesingPatterns.Stateg;

namespace DesingPatterns.Template_Method
{
    public class ICMM : TemplateImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Items.Count() > 2;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
