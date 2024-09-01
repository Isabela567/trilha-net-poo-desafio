using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("12345", "Nokia 3310", "1122334455", 64);
        Smartphone iphone = new Iphone("98765", "Iphone 12", "88776655", 128);

        Console.WriteLine("Smartphone Nokia:");
        nokia.Ligar();
        nokia.InstalarAplicativo("Angry Birds");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

    }
}