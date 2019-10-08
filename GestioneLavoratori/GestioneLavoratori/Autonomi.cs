﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Autonomi : Lavoratori
    {
        public double Tasse { get; set; }
        public int Mensilità { get; set; }
        public Autonomi(string nome, string cognome) : base(nome, cognome)
        {

        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + Tasse;
        }

        public 
        public double CalcoloTasse()
        {
            if(RAL<50000)
            {
                return RAL / (15 / 100);
            }
            else if(RAL >= 500000)
            {
                return RAL / (30 / 100);
            }
        }
    }
}
