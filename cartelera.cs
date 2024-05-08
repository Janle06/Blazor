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
        double Boleta3D = 325; //Precio de boleto
        double BoletaVIP = 500; //Precio de boleto
        double PrecioTotal = 0; //El Precio total de todas las boletas

        //Combos de comida y sus precios
        double Combo1 = 325; //Combo de palomitas con refresco
        double Combo2 = 325; //Combo de hotdog con refresco
        double Combo3 = 325; //Combo de nachos con queso y refresco

        //Balance para agregar
        double Saldo1 = 400; //Para agregar 400 pesos al balance
        double Saldo2 = 800; //Para agregar 800 pesos al balance
        double Saldo3 = 1200; //Para agregar 1200 pesos al balance

        //Cantidad de tickets
        List<int> Tickets = new List<int>();
        List<int> Combos = new List<int>();




        //Generador de escritura
        string filepath = "Cartelera.txt";
        using (StreamWriter generadorEscritura = new StreamWriter(filepath))
        {

            //Interfaz de la cartelera 
            Console.WriteLine("---------------------");
            Console.WriteLine("------CARTELERA------");
            Console.WriteLine("---------------------");
            Console.WriteLine("Balance disponible: " + Balance);
            Console.WriteLine("Por favor seleccione una opcion:");
            Console.WriteLine("1. Compra de Boleto");
            Console.WriteLine("2. Compra de Combo");
            Console.WriteLine("3. Agregar Balance");
            Console.WriteLine("4. Salir");
            int MenuSeleccion = int.Parse(Console.ReadLine()!);

            bool salir = true;
            while (salir)
            {
                bool volver = false;
                while (!volver)
                {
                    switch (MenuSeleccion)
                    {

                        case 1:
                            {
                                Console.WriteLine("---------------------");
                                Console.WriteLine("------Boleteria------");
                                Console.WriteLine("---------------------");
                                Console.WriteLine("1. Boleta Regular");
                                Console.WriteLine("2. Boleta 3D");
                                Console.WriteLine("3. Boleta VIP");
                                Console.WriteLine("4. Volver al menu");
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
                                        {
                                            volver = true;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Introduzca una opcion valida..");
                                        break;
                                }

                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("----------------------");
                                Console.WriteLine("--------COMBOS--------");
                                Console.WriteLine("----------------------");
                                Console.WriteLine("1. Combo de Palomitas con refresco");
                                Console.WriteLine("2. Combo de Hotdog con refresco");
                                Console.WriteLine("3. Combo de Nachos con queso y refresco");
                                Console.WriteLine("4. Volver al menu");
                                int Cafeteria = int.Parse(Console.ReadLine()!);

                                switch (Cafeteria)
                                {
                                    case 1:
                                        if (Balance >= Combo1)
                                        {
                                            Balance -= Combo1;
                                            PrecioTotal += Combo1;
                                            Console.WriteLine("Combo de Palomitas con refresco agregado");
                                            generadorEscritura.WriteLine("Combo de Palomitas con refresco agregado");
                                            Combos.Add(1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No tienes suficiente balance");
                                        }
                                        break;
                                    case 2:
                                        if (Balance >= Combo2)
                                        {
                                            Balance -= Combo2;
                                            PrecioTotal += Combo2;
                                            Console.WriteLine("Combo de Hotdog con refresco agregado");
                                            generadorEscritura.WriteLine("Combo de Hotdog con refresco agregado");
                                            Combos.Add(1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No tienes suficiente balance");
                                        }
                                        break;
                                    case 3:
                                        if (Balance >= Combo3)
                                        {
                                            Balance -= Combo3;
                                            PrecioTotal += Combo3;
                                            Console.WriteLine("Combo de Nachos con queso y refresco agregado");
                                            generadorEscritura.WriteLine("Combo de Nachos con queso y refresco agregado");
                                            Combos.Add(1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No tienes suficiente balance");
                                        }
                                        break;
                                    case 4:
                                        {
                                            volver = true;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Introduzca una opcion valida..");
                                        break;
                                }

                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("--------BALANCE--------");
                                Console.WriteLine("-----------------------");
                                Console.WriteLine("1. Agregar 400 pesos al balance");
                                Console.WriteLine("2. Agregar 800 pesos al balance");
                                Console.WriteLine("3. Agregar 1200 pesos al balance");
                                Console.WriteLine("4. Volver al menu");
                                int AgregarBalance = int.Parse(Console.ReadLine()!);

                                switch (AgregarBalance)
                                {
                                    case 1:
                                        if (Balance >= Saldo1)
                                        {
                                            Balance += Saldo1;
                                            PrecioTotal += Saldo1;
                                            Console.WriteLine("400 pesos han sido añadidos a su balance");
                                            generadorEscritura.WriteLine("400 pesos han sido añadidos a su balance");
                                        }
                                        break;
                                    case 2:
                                        if (Balance >= Saldo2)
                                        {
                                            Balance += Saldo2;
                                            PrecioTotal += Saldo2;
                                            Console.WriteLine("800 pesos han sido añadidos a su balance");
                                            generadorEscritura.WriteLine("800 pesos han sido añadidos a su balance");
                                        }
                                        break;
                                    case 3:
                                        if (Balance >= Saldo3)
                                        {
                                            Balance += Saldo3;
                                            PrecioTotal += Saldo3;
                                            Console.WriteLine("1200 pesos han sido añadidos a su balance");
                                            generadorEscritura.WriteLine("1200 pesos han sido añadidos a su balance");
                                        }
                                        break;
                                    case 4:
                                        {
                                            volver = true;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Introduzca una opcion valida..");
                                        break;
                                }
                            }
                            break;
                        case 4:
                            {
                                salir = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Introduzca una opcion valida..");
                            break;

                    }

                }
            }

            generadorEscritura.WriteLine("Su balance es de " + Balance + " pesos" + " y ha comprado " + Tickets.Count + " tickets"
        + " por un precio total de " + PrecioTotal + " pesos");

            Console.WriteLine("Su balance es de " + Balance + " pesos" + " y ha comprado " + Tickets.Count + " tickets"
            + " por un precio total de " + PrecioTotal + " pesos");

        }

    }
}