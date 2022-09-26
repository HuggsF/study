namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        
        public Smartphone(string numero, string model, string iMEI, int memoria)
        {
            Numero = numero;
            Model = model;
            IMEI = iMEI;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeDoAplicativo);
    }
}