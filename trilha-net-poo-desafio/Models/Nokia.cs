namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string iMEI, int memory) : base(number, model, iMEI, memory)
        {
        }

        public override void InstalarAplicativo(string nomeDoAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeDoAplicativo} no Android.");
        }
    }
}