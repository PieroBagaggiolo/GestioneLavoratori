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
            Autonomi a1 = new Autonomi("Paolo", "Verdi")
            {
                DataNascita = new DateTime(1960, 12, 1),
                Genere = "M",
                DataAssunzione = new DateTime(1981, 11, 21),
                RAL = 48500,
                Mensilità = 12,
                
            };
        }
    }
}
