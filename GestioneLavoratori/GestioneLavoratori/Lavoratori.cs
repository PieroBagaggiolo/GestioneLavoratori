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
        public decimal tasse { get; set; }
        public Lavoratori() : base ()
        {

        }
        public Lavoratori(string nome, string cognome ,int mensilita, int stipendioMensile, DateTime dN, DateTime dA) : 
            base (nome, cognome, dN)
        {
            DataAssunzione = dA;
            DataNascita = dN;
            StipendioMens = stipendioMensile;
            Mensilita = mensilita;
            Anni = CalcolaAnni();
            RAL = StipendioMens * Mensilita;
            AnniServizio = DateTime.Now.Year - DataAssunzione.Year;
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + Environment.NewLine +
                "Stipendio mensile: "  + StipendioMens + Environment.NewLine +
                "Assunto il: "  + DataAssunzione + Environment.NewLine +
                "Anni di servizio: "  + AnniServizio + Environment.NewLine +
                "Mensilità: " + Mensilita+ Environment.NewLine +
                "Salario mensile: " + StipendioMens + Environment.NewLine +
                "RAL: "  + RAL ;
        }
        public virtual int CalcoloStipendio(int mensilità)
        {
            return RAL = StipendioMens*mensilità;
        }
        
        public override string DatiAnagrafici(string campo, string valore)
        {
            return base.DatiAnagrafici(campo, valore);
        }
        public override DateTime AddData(int gg, int mm, int yyyy, DateTime data)
        {
            return base.AddData(gg, mm, yyyy, data);
        }
        
       

        
    }
}
