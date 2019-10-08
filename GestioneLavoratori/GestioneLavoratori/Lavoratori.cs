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
        public int Mensilita { get; set; }

        public Lavoratori(string nome, string cognome ,int mensilita) : base (nome, cognome)
        {
            DataAssunzione = DateTime.Now;
            StipendioMens = 1500;
            AnniServizio = 0;
            Mensilita = mensilita;

            RAL = StipendioMens * Mensilita;
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + 
                Environment.NewLine + StipendioMens + 
                Environment.NewLine + DataAssunzione +
                Environment.NewLine + AnniServizio + 
                Environment.NewLine + Mensilita+
                Environment.;
        }

        public override int CalcolaAnni()
        {
            return base.CalcolaAnni();
        }
        public virtual int CalcoloStipendio(int mensilità)
        {
            return RAL = StipendioMens*mensilità;
        }

        public virtual string GetFinancial()
        {
            return GetDettaglioPersona();
        }
        
    }
}
