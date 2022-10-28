namespace Calculadora.Models
{
    public class Calculadora
    {
    
    public int num1 { get; set; }
    public int num2 { get; set; }


    public int Soma(int num1, int num2)
    {
    return num1 + num2;
    }
    public int Subtracao(int num1, int num2)
    {
    return num1 - num2;
    }
    public int Multiplicacao(int num1, int num2)
    {
     return num1 * num2;
    }
    public int Divisao(int num1, int num2)
    {
     return num1 / num2;
    }
    }
 }
