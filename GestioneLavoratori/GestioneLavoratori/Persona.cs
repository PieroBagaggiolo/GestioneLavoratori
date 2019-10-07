using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public int Anni { get; set; }
        public string Genere { get; set; }

        //public int Anni { get; set; }

        public Persona(string nome, string cognome, DateTime dataNascita, string genere)
        {
            Nome = nome;
            Cognome = cognome;
            dataNascita = DataNascita;
            Genere = genere;

            var AnnoAtt = DateTime.Now.Year;
            var AnnoNascita = dataNascita.Year;

            Anni = AnnoAtt - AnnoNascita;
        }
    }
}
