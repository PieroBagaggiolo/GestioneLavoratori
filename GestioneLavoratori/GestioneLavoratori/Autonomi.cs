using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Autonomi : Lavoratori
    {
        public decimal Tasse { get; set; }
        public Autonomi() : base()
        {

        }
        public Autonomi(string nome, string cognome ,int mensilita, int stipendioMensile, DateTime dN, DateTime dA) 
            : base(nome, cognome, mensilita, stipendioMensile, dN, dA)
        {
            if (RAL < 50000)
            {
                Tasse = RAL / (100*15);
            }
            else if (RAL >= 500000)
            {
                Tasse = RAL / (100*30);
            }
        }

        public string GetFinancial()
        {
            return "Tasse: " + Tasse;
        }
    }
}
