using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Autonomi : Lavoratori
    {
        public int Tasse { get; set; }
        public int Mensilità { get; set; }
        public Autonomi(string nome, string cognome) : base(nome, cognome)
        {
            Mensilità = 0;
            Tasse = 0;
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + Tasse;
        }
    }
}
