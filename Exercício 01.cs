 using System;

class MainClass {
    public static double Calculadora (double num1, double num2, char op){
      switch (op){
    case '+': 
     return (num1+num2);
    case '-':
     return (num1-num2);
    case '*':
     return (num1*num2);
    case '/':
     return (num1/num2);
    default:
     return -1;
   
   }

  }
  public static void Main () {
    double num1;
    double num2;
    char op;

    Console.WriteLine("Digite o primeiro número: ");
    num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Escolha a Operação(+,-,*,/): ");
    op = char.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Resultado: {0} ", Calculadora(num1,num2,op));

   }
  }