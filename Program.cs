using DesafioPOO.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia: ");
        Nokia nokia = new Nokia("987455200", "Modelo 1", "123456", 128);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone: ");
        Iphone iphone = new Iphone("123456", "Iphone 11", "654321", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

    }
}
