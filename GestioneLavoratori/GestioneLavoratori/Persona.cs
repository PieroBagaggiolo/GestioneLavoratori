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
        public Persona()
        {

        }

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            Nome = nome;
            Cognome = cognome;
            dataNascita = DataNascita;

            var AnnoAtt = DateTime.Now.Year;
            var AnnoNascita = dataNascita.Year;

            Anni = AnnoAtt - AnnoNascita;
        }

        public virtual string GetDettaglioPersona()
        {
            return
                "Nome: " + Nome + System.Environment.NewLine +
                "Cognome: " + Cognome + System.Environment.NewLine +
                "Età: " + Anni + System.Environment.NewLine +
                "Genere: " + Genere + System.Environment.NewLine +
                "Nato il: " + DataNascita;
        }

        public virtual DateTime AddData(int gg, int mm, int yyyy, DateTime data)
        {
            try
            {
                Console.WriteLine("Giorno");
                gg = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mese");
                mm = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anno");
                yyyy = Int32.Parse(Console.ReadLine());

                data = new DateTime(yyyy, mm, gg);

                return data;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new CustomException("Il valore inserito è troppo piccolo o troppo grande", ex);
            }
        }

        //public virtual string DatiAnagrafici(string nome, string cognome, string genere)
        //{

        //}
        public virtual int CalcolaAnni()
        {
            int result = DateTime.Now.Year - DataNascita.Year;
            return result;
        }
    }
}
