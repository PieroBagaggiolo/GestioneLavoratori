using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Dipendenti : Lavoratori
    {
        public decimal Tasse { get; set; }
        public Dipendenti(string nome, string cognome, int mensilita, int stipendioMensile, DateTime dn, DateTime dA, string genere, decimal tasse) 
            : base(nome, cognome, mensilita, stipendioMensile, dn, dA, genere)
        {//calcolo delle tasse
            if (0 < RAL || RAL < 6000)
            {
                tasse = 0;
            }
            else if (6000 < RAL || RAL < 15000)
            {
                tasse = RAL / (100*15);
            }
            else if (15000 < RAL || RAL < 25000)
            {
                tasse = RAL / (100*30);
            }
            else if (25000 < RAL || RAL <= 35000)
            {
                tasse = RAL / (100*40);
            }
            else if (RAL > 35000)
            {
                tasse = RAL / (100*50);
            }

            Tasse = tasse;
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + Environment.NewLine + "Tasse: " + Tasse; ;
        }

    }
}
