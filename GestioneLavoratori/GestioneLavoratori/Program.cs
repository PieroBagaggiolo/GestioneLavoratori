using System;
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
            Autonomi a1 = new Autonomi("Paolo", "Verdi", 12, 1200)
            {
                DataNascita = new DateTime(1960, 12, 1),
                Genere = "M",
                DataAssunzione = new DateTime(1981, 11, 21),
            };

            Dipendenti d1 = new Dipendenti("Marco", "Domodossola", 13, 1300)
            {
                DataNascita = new DateTime(1985, 5, 21),
                Genere = "M",
                DataAssunzione = new DateTime(2001, 3, 3),
            };

            Console.WriteLine("I dettagli del lavoratore a1 sono: " +
                System.Environment.NewLine + a1.GetDettaglioPersona() +
                 System.Environment.NewLine + a1.GetFinancial()
                );
            Console.WriteLine("I dettagli del lavoratore d1 sono: " + 
                System.Environment.NewLine + d1.GetDettaglioPersona()+ 
                System.Environment.NewLine + d1.GetFinancial());

            Console.ReadLine();
        }
    }
}
