﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Autonomi a1 = new Autonomi("Paolo", "Verdi", 12, 1200, new DateTime(1960, 12, 1), new DateTime(1981, 11, 21))
            {
                Genere = "M",
            };

            Dipendenti d1 = new Dipendenti("Marco", "Domodossola", 13, 1300,
               new DateTime(1985, 5, 21), new DateTime(2001, 3, 3))
            {
                Genere = "M",
            };

            Console.WriteLine("I dettagli del lavoratore a1 sono: " +
                System.Environment.NewLine + a1.GetDettaglioPersona() +
                 System.Environment.NewLine + a1.GetFinancial()
                );
            Console.WriteLine("I dettagli del lavoratore d1 sono: " + 
                System.Environment.NewLine + d1.GetDettaglioPersona()+ 
                System.Environment.NewLine + d1.GetFinancial());*/

            string scelta;
            int quanto;
            Console.WriteLine("Vuoi inserire lavoratori dipendenti (d) o lavoratori autonomi (a)?");
            scelta = Console.ReadLine();
            do
            {
                if (scelta == "d")
                {

                }
                else if (scelta == "a")
                {

                }
                else
                {
                    Console.WriteLine("L'opzione non è contemplata." + Environment.NewLine + "Inserisci (a) per lavoratori autonomi " +
                        "oppure (d) per lavoratori dipendenti");
                }
            }
            while (scelta != "d" || scelta != "a");

            Console.ReadLine();
        }
    }
}
