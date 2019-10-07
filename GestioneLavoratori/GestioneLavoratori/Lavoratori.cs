using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Lavoratori : Persona
    {
        public int RAL { get; set; }
        public DateTime DataAssunzione;
        public int AnniServizio { get; set; }
        public int StipendioMens;

        public Lavoratori(string nome, string cognome) : base (nome, cognome)
        {
            DataAssunzione = DateTime.Now;
            RAL = 0;
            StipendioMens = 0;
            AnniServizio = 0;
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + 
                Environment.NewLine + RAL + 
                Environment.NewLine + DataAssunzione +
                Environment.NewLine + AnniServizio;
        }
    }
}
