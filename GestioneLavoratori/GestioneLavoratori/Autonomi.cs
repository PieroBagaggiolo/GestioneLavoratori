using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Autonomi : Lavoratori
    {
        public double Tasse { get; set; }
        public Autonomi(string nome, string cognome ,int mensilita) : base(nome, cognome, mensilita)
        {
            if (RAL < 50000)
            {
                Tasse = RAL / (15 / 100);
            }
            else if (RAL >= 500000)
            {
                Tasse = RAL / (30 / 100);
            }
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + Tasse;
        }
    }
}
