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
            Autonomi a1 = new Autonomi("Paolo", "Verdi")
            {
                DataNascita = new DateTime(1960, 12, 1),
                Genere = "M",
                DataAssunzione = new DateTime(1981, 11, 21),
                Mensilità = 12,
                
            };

            Dipendenti d1 = new Dipendenti("Marco","Domodossola")
            {
                DataNascita = new DateTime(1985,5,21),
                Genere = "M",
                DataAssunzione = new DateTime(2001,3,3),
                Mensilità = 13,

            }
        }
    }
}
