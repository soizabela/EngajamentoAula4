using System;

class MainClass{
    public static void Main(){
    Console.WriteLine("------------------------------");Console.WriteLine("100   Cachorro Quente   R$1,70");
    Console.WriteLine("101    Bauru Simples    R$2,30");
    Console.WriteLine("102    Bauru com ovo    R$2,60");
    Console.WriteLine("103      Hamburguer     R$1,40");
    Console.WriteLine("104      X-Burguer      R$2,50");
    Console.WriteLine("105    Refrigerante     R$1,00");
    Console.WriteLine("------------------------------");

    Console.WriteLine("Digite o Código do Produto:");
    int codigo= int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Quantidade::");
    int qt= int.Parse(Console.ReadLine());

    if (codigo == 100){
      Console.WriteLine ("Valor Total {0}", 1.7*qt);    
    }else if (codigo == 101){
      Console.WriteLine ("Valor Total {0}", 2.3*qt);        
    }else if (codigo == 102){
      Console.WriteLine ("Valor Total {0}", 2.6*qt);        
    }else if (codigo == 103){
      Console.WriteLine ("Valor Total {0}", 2.4*qt);        
    }else if (codigo == 104){
      Console.WriteLine ("Valor Total {0}", 2.5*qt);        
    }else if (codigo == 105){
      Console.WriteLine ("Valor Total {0}", 1*qt);        
    }else{
      Console.WriteLine ("Código Inválido");        
    }
  }
}