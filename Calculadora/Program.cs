namespace Calculadora.Models;

public class Program
{
public static void Main (string[] args)
{
    string escolha = "";

    do{
        Console.WriteLine("===CALCULADORA===");
        Console.WriteLine("1 - Adição ");
        Console.WriteLine("2 - Subtração ");
        Console.WriteLine("3 - Multiplicação ");
        Console.WriteLine("4 - Divisão ");
        Console.WriteLine("5 - Sair ");
        Console.WriteLine("=================");

        escolha = Console.ReadLine();

        Calculadora _calculadora = new Calculadora();


        int num1 = _calculadora.num1;
        int num2 = _calculadora.num2;


            switch(escolha){

                case "1":
                    Console.WriteLine("Digite o primeiro número.");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo núemro.");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O resultado da sua soma é: {num1} + {num2} = " + _calculadora.Soma(num1, num2));
                break;
            
                case "2":
                    Console.WriteLine("Digite o primeiro número.");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo núemro.");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O resultado da sua subtração é: {num1} - {num2} = " + _calculadora.Subtracao(num1, num2));
                break;
            
                case "3":
                    Console.WriteLine("Digite o primeiro número.");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo núemro.");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O resultado da sua multiplicação é: {num1} * {num2} = " + _calculadora.Multiplicacao(num1, num2));
                break;
            
                case "4":
                    Console.WriteLine("Digite o primeiro número.");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo núemro.");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O resultado da sua divisão é: {num1} / {num2} = " + _calculadora.Divisao(num1, num2));
                break;
                            
                case "5":                   
                    Console.WriteLine("Até logo!");
                break;
                default:
			        Console.WriteLine($"{escolha} não é uma escolha válida.");
			    break;
                            };

            Console.Write("Aperte uma tecla para continuar...");
	        Console.ReadLine();

        
        }while (escolha != "5");
}
}

// Exercício feito do "zero" por Hugo Fernandes no dia 28/10/2022