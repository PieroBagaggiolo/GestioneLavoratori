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
        public Autonomi(string nome, string cognome ,int mensilita, int stipendioMensile, DateTime dN, DateTime dA, string genere, decimal tasse) 
            : base(nome, cognome, mensilita, stipendioMensile, dN, dA, genere)
        {
            if (RAL < 50000)
            {
                tasse = RAL / (100 * 15);
            }
            else if (RAL >= 500000)
            {
                tasse = RAL / (100*30);
            }
            Tasse = tasse;
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + Environment.NewLine + "Tasse: " + Tasse;
        }

        
    }
}
