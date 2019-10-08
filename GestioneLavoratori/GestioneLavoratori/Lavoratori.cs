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
        public int RAL { get; set; }

        public Lavoratori(string nome, string cognome) : base (nome, cognome)
        {
            DataAssunzione = DateTime.Now;
            RAL = 0;
            StipendioMens = 1500;
            AnniServizio = 0;
        }
        public Lavoratori(string nome, string cognome, DateTime dataNascita, string genere): base (nome,cognome,dataNascita,genere)
        {

        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + 
                Environment.NewLine + StipendioMens + 
                Environment.NewLine + DataAssunzione +
                Environment.NewLine + AnniServizio;
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
