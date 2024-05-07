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

        //Cantidad de tickets
        List<int> Tickets = new List<int>();

        bool salir = true;
        //Generador de escritura
        string filepath = "Cartelera.txt";
        using (StreamWriter generadorEscritura = new StreamWriter(filepath))
        {

            while (salir)
            {

                //Interfaz de la cartelera 
                Console.WriteLine("---Cartelera---");
                Console.WriteLine("Por favor seleccione una opcion:");
                Console.WriteLine("1. Boleto Regular");
                Console.WriteLine("2. Boleto 3D");
                Console.WriteLine("3. Boleto VIP");
                Console.WriteLine("4. Boleto con Combo");
                Console.WriteLine("5. Salir");
                int SeleccionBoleto = int.Parse(Console.ReadLine()!);

                switch (SeleccionBoleto)
                {
                    case 1:
                        if (Balance >= BoletaRegular)
                        {
                            Balance -= BoletaRegular;
                            PrecioTotal += BoletaRegular;
                            Console.WriteLine("Boleta regular agregada");
                            generadorEscritura.WriteLine("Boleta regular agregada");
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
                            Balance -= Boleta3D;
                            PrecioTotal += Boleta3D;
                            Console.WriteLine("Boleta 3D agregada");
                            generadorEscritura.WriteLine("Boleta 3D agregada");
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
                            Balance -= BoletaVIP;
                            PrecioTotal += BoletaVIP;
                            Console.WriteLine("Boleta VIP agregada");
                            generadorEscritura.WriteLine("Boleta VIP agregada");
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
                            Balance -= BoletaCombo;
                            PrecioTotal += BoletaCombo;
                            Console.WriteLine("Boleta con Combo agregada");
                            generadorEscritura.WriteLine("Boleta con Combo agregada");
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
            generadorEscritura.WriteLine("Su balance es de " + Balance + " pesos" + " y ha comprado " + Tickets.Count + " tickets"
            + " por un precio total de " + PrecioTotal + " pesos");
        }
        Console.WriteLine("Su balance es de " + Balance + " pesos" + " y ha comprado " + Tickets.Count + " tickets"
            + " por un precio total de " + PrecioTotal + " pesos");
    }
}