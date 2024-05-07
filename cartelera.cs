namespace Cartelera;

using System.Collections.Generic;
using System;
using System.IO;


class Tarea1
{
    static void Main(string[] args)
    {
        /*Crear un sistema de cartelera de cine donde
        el balance del usuario se vaya reduciendo */

        //Balance disponible
        double Balance = 1000;

        //Tipos y precios de boletas
        double BoletaRegular = 125; //Precio de boleto
        double Boleta3D = 350; //Precio de boleto
        double BoletaVIP = 525; //Precio de boleto
        double BoletaCombo = 650; //Precio de boleto
        double PrecioTotal = 0; //El Precio total de todas las boletas

        //Interfaz de la cartelera 
        Console.WriteLine("---Cartelera---");
        Console.WriteLine("Por favor seleccione una opcion:");
        Console.WriteLine("1. Boleto Regular");
        Console.WriteLine("2. Boleto 3D");
        Console.WriteLine("3. Boleto VIP");
        Console.WriteLine("4. Boleto con Combo");
        Console.WriteLine("5. Salir");

        //Cantidad de tickets
        List<int> Tickets = new List<int>();

        bool salir = true;

        //Generador de escritura
        const string path = "TextFiles//cartelera.txt";
        //Generador de escritura

        using (StreamReader generaEscritura = new StreamReader(path))
        {

            while (salir)
            {

                int SeleccionBoleto = int.Parse(Console.ReadLine()!);

                switch (SeleccionBoleto)
                {
                    case 1:
                        if (Balance >= BoletaRegular)
                        {
                            Balance = Balance -= BoletaRegular;
                            PrecioTotal = PrecioTotal += BoletaRegular;
                            Console.WriteLine("Boleta regular agregada");
                            generaEscritura.WriteLine("Boleta regular agregada");
                            Tickets.Add(1);
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente balance");
                        }
                        break;
                    case 2:
                        if (Balance >= Boleta3D)
                        {
                            Balance = Balance -= Boleta3D;
                            PrecioTotal = PrecioTotal += Boleta3D;
                            Console.WriteLine("Boleta 3D agregada");
                            generaEscritura.WriteLine("Boleta 3D agregada");
                            Tickets.Add(1);

                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente balance");
                        }
                        break;
                    case 3:
                        if (Balance >= BoletaVIP)
                        {
                            Balance = Balance -= BoletaVIP;
                            PrecioTotal = PrecioTotal += BoletaVIP;
                            Console.WriteLine("Boleta VIP agregada");
                            generaEscritura.WriteLine("Boleta VIP agregada");
                            Tickets.Add(1);
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente balance");
                        }
                        break;
                    case 4:
                        if (Balance >= BoletaCombo)
                        {
                            Balance = Balance -= BoletaCombo;
                            PrecioTotal = PrecioTotal += BoletaCombo;
                            Console.WriteLine("Boleta con Combo agregada");
                            generaEscritura.WriteLine("Boleta con Combo agregada");
                            Tickets.Add(1);
                        }
                        else
                        {
                            Console.WriteLine("No tienes suficiente balance");
                        }
                        break;
                    case 5:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Introduzca una opcion valida..");
                        break;
                }
            }
            Console.WriteLine("Su balance es: " + Balance + " pesos" + " y ha compado " + Tickets.Count + " tickets");
        }
    }
}