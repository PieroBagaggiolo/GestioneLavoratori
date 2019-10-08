using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Dipendenti : Lavoratori
    {
        public int Tasse { get; set; }
        public Dipendenti(string nome, string cognome, int mensilita, int stipendioMensile) : base(nome, cognome, mensilita, stipendioMensile)
        {
            if (0 < RAL || RAL < 6000)
            {
                Tasse = 0;
            }
            else if (6000 < RAL || RAL < 15000)
            {
                Tasse = RAL / (100*15);
            }
            else if (15000 < RAL || RAL < 25000)
            {
                Tasse = RAL / (100*30);
            }
            else if (25000 < RAL || RAL <= 35000)
            {
                Tasse = RAL / (100*40);
            }
            else if (RAL > 35000)
            {
                Tasse = RAL / (100*50);
            }
        }

        

        public string GetFinancial()
        {
            return "Tasse: " +Tasse;
        }

    }
}
