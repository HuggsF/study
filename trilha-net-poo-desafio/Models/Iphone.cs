namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string iMEI, int memory) : base(number, model, iMEI, memory)
        {
        }

        public override void InstalarAplicativo(string nomeDoAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeDoAplicativo} no Iphone.");
        }
    }
}