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
        public Dipendenti(string nome, string cognome, int mensilita) : base(nome, cognome, mensilita)
        {
            if (0 < RAL || RAL < 6000)
            {
                Tasse = RAL;
            }
            else if (6000 < RAL || RAL < 15000)
            {
                Tasse = RAL / (15 / 100);
            }
            else if (15000 < RAL || RAL < 25000)
            {
                Tasse = RAL / (30 / 100);
            }
            else if (25000 < RAL || RAL <= 35000)
            {
                Tasse = RAL / (40 / 100);
            }
            else if (RAL > 35000)
            {
                Tasse = RAL / (50 / 100);
            }
        }

        

        public override string GetFinancial()
        {
            return base.GetFinancial() + Environment.NewLine;
        }

    }
}
