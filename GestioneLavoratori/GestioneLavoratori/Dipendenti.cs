using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Dipendenti : Lavoratori
    {
        public int RAL { get; set; }
        public int Tasse { get; set; }
        public int Mensilità { get; set; }
        public Dipendenti(string nome, string cognome) : base(nome, cognome)
        {
            Mensilità = 0;
            Tasse = 0;
            RAL = CalcoloStipendio(Mensilità);
        }

        public int CalcoloTasse()
        {
            if(0<RAL || RAL<6000)
            {
                return RAL;
            }
            else if(6000<RAL || RAL<15000)
            {
                return RAL / (15 / 100);
            }
            else if(15000<RAL || RAL<25000)
            {
                return RAL / (30 / 100);
            }
            else if(25000<RAL || RAL<=35000)
            {
                return RAL / (40 / 100);
            }
            else if(RAL>35000)
            {
                return RAL / (50 / 100);
            }
        }

    }
}
