using DesingPatterns.Decorator;
using DesingPatterns.Stateg;
using DesingPatterns.Template_Method;

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

        //Decorator
        Orcamento orcamento = new Orcamento(500, new Item("lapis", 100));
        ICCP iCCP = new ICCP(new DesingPatterns.Decorator.ICMS());
        IMA ima = new IMA(new ICCP());
        
        Console.WriteLine(iCCP.Calcula(orcamento));
        Console.WriteLine(ima.Calcula(orcamento));
    }
}