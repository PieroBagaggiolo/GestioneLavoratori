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

            int quanto;
            
            Console.WriteLine("Quanti lavoratori vuoi inserire?");
            quanto = Int32.Parse(Console.ReadLine());
            

            Lavoratori[] lavoratori = new Lavoratori[quanto];
            for (int i=0; i < quanto; i++)
            {
                int mensilita, stipMens, gN,mN,yN, gA, mA, yA;
                Console.WriteLine("Inserisci il nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome: ");
                string cognome = Console.ReadLine();
                Console.WriteLine("Inserisci il sesso: ");
                string genere = Console.ReadLine();

                Console.WriteLine("Vuoi inserire un lavoratore dipendente(1) o autonomo(2)?");
                int tipo = Int32.Parse(Console.ReadLine());
                if (tipo == 1)
                {
                    Autonomi aut = new
                }
            }
            
            

            //Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
