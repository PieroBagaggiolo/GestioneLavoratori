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
        public int Mensilità { get; set; }
        public Dipendenti(string nome, string cognome) : base(nome, cognome)
        {
            Mensilità = 0;
            Tasse = CalcoloStipendio(Mensilità);
        }

    }
}
