﻿namespace DesingPatterns.Builder
{
    public class NFBuilder
    {
        public string RazaoSocial;
        public string Cnpj;
        public DateTime DataEmissao;
        public double ValorBruto;
        public double Imposto;
        public IList<ItemNota> Item = new List<ItemNota>();
        public string Observacoes;

        public NF BuilderNF()
        {
            return new NF(RazaoSocial, Cnpj, DataEmissao, ValorBruto, Imposto, Item, Observacoes);
        }


        public NFBuilder ComRazaoSocial(string razao)
        {
            RazaoSocial = razao;
            return this;
        }

        public NFBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NFBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NFBuilder ComData()
        {
            DataEmissao = DateTime.Now;
            return this;
        }

        public NFBuilder ComValorBruto(double valorBruto)
        {
            ValorBruto = valorBruto;
            return this;
        }

        public NFBuilder ComImposto(double imposto)
        {
            Imposto = imposto;
            return this;
        }

        public NFBuilder ComItem(ItemNota item)
        {
            Item.Add(item);
            ValorBruto += item.Valor;
            Imposto += item.Valor * 0.05;
            return this;
        }

        public NFBuilder ComObeservacao(string observacao)
        {
            Observacoes = observacao;
            return this;
        }

    }
}
