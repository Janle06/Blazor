namespace Proyecto3;

class Program
{
    static void Main(string[] args)
    {
        int zapato = 300;

        if (zapato < 200)
        {
            int descuento = zapato - 50;
            Console.WriteLine("Precio total con el descuento aplicado: " + zapato);
        }
    }
}
