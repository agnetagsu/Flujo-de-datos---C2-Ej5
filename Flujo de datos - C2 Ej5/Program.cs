﻿using System;

namespace Flujo_de_datos___C2_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un día de la semana");
            string dia = Console.ReadLine();
           
            switch(dia)
            {
                case "lunes":
                    Console.WriteLine("{0} no es fin de semana",dia);
                    break;

                case "martes":
                    Console.WriteLine("{0} no es fin de semana",dia);
                    break;

                case "miercoles":
                    Console.WriteLine("{0} no es fin de semana",dia);
                    break;

                case "jueves":
                    Console.WriteLine("{0} no es fin de semana",dia);
                    break;

                case "viernes":
                    Console.WriteLine("{0} no es fin de semana",dia);
                    break;

                case "sabado":
                    Console.WriteLine("{0} es fin de semana",dia);
                    break;

                case "domingo":
                    Console.WriteLine("{0} es fin de semana",dia);
                    break;

                default:
                    Console.WriteLine("{0} no corresponde a ningún día de la semana",dia);
                    break;

            }


        }
    }
}
