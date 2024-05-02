namespace Blazor;

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
        else if (zapato >= 250)
        {
            int descuento = zapato - 25;
            Console.WriteLine("Precio total con el descuento aplicado: " + zapato);

        }
        else
        {
            Console.WriteLine("No hay na pai");
        }

    }
}
