using DesafioPOO.Models;
using System;

namespace CreatingPhoneWithOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia(number: "58993817286", model: "A555", iMEI: "12635175642", memory: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone(number: "82883491829", model: "Iphone 12", iMEI: "1827364", memory: 256);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");

            Console.ReadKey();
        }
    }
}