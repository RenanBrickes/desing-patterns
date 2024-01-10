//using DesingPatterns.Builder;
//using DesingPatterns.Decorator;
//using DesingPatterns.State;
////using DesingPatterns.Stateg;
//using DesingPatterns.Template_Method;

using DesingPatterns.Observer;

public class TesteDeImpostos
{
    static void Main(String[] args)
    {
        ////Stategy Parttern
        //IImposto iss = new ISS();
        //IImposto icms = new ICMS();
        //Orcamento orcamento = new Orcamento(500.0, new Item("Lapis", 200));
        //CalculoDeImposto calculador = new CalculoDeImposto();

        //// Calculando o ISS
        //calculador.RealizaCalculo(orcamento, iss);

        //// Calculando o ICMS        
        //calculador.RealizaCalculo(orcamento, icms);

        ////Chain of Responsability
        //Orcamento orcamento = new Orcamento(500, new Item("Lapis 1", 200));
        //orcamento.Adiciona(new Item("Lapis1", 300));
        //orcamento.Adiciona(new Item("Caneta1s", 200));
        //orcamento.Adiciona(new Item("Lapis2", 140));
        //double valorDesconto = new CalculadoraDesconto().Calcula(orcamento);
        //Console.WriteLine(valorDesconto.ToString());

        //Template Method
        //Orcamento orcamento = new Orcamento(500, new Item("Lapis 1", 200));
        //orcamento.Adiciona(new Item("Lapis1", 300));
        //orcamento.Adiciona(new Item("Caneta1s", 200));
        //ICMM iCMM = new ICMM();
        //ISVL iSVL = new ISVL();
        //double valor = iCMM.Calcula(orcamento);
        //double valor2 = iSVL.Calcula(orcamento);
        //Console.WriteLine(valor);
        //Console.WriteLine(valor2);

        ////Decorator
        //Orcamento orcamento = new Orcamento(500, new Item("lapis", 100));
        //ICCP iCCP = new ICCP(new DesingPatterns.Decorator.ICMS());
        //IMA ima = new IMA(new ICCP());

        //Console.WriteLine(iCCP.Calcula(orcamento));
        //Console.WriteLine(ima.Calcula(orcamento));

        //State
        //Orcamento orcamento = new Orcamento(500);
        //orcamento.AplicaDescontoDiferencial();
        //orcamento.Aprova();
        //orcamento.Aprova();

        ////Builder
        //NFBuilder criadorNF = new NFBuilder();
        //ItemNotaBuilder itemNotaBuilder = new ItemNotaBuilder();
        //ItemNota itemNota = itemNotaBuilder.ComNome("Item 1").ComValor(200).Builder();
        //criadorNF.ComCnpj("10.203.203/0001-10")
        //          .ComRazaoSocial("Renan Brickes LTDA")
        //           .ComData()
        //            .ComImposto(100)
        //             .ComValorBruto(200)
        //              .ComItem(itemNota)
        //               .ComObeservacao("Teste");

        //NF nf = criadorNF.BuilderNF();
        //Console.WriteLine(nf.ValorBruto);
        //Console.WriteLine(nf.Imposto);

        //Observer
        NFBuilder criadorNF = new NFBuilder();
        criadorNF.ComCnpj("10.203.203/0001-10")
                  .ComRazaoSocial("Renan Brickes LTDA")
                   .ComData()
                    .ComImposto(100)
                     .ComValorBruto(200)
                      .ComItem(new ItemNota("item 1", 200))
                       .ComObeservacao("Teste");

        criadorNF.NovaAcao(new AcaoBanco());
        criadorNF.NovaAcao(new AcaoSms());
        criadorNF.NovaAcao(new AcaoEmail());
        NF nf = criadorNF.BuilderNF();
        Console.WriteLine(nf.ValorBruto);
        Console.WriteLine(nf.Imposto);

    }
}