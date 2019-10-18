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
            StringBuilder persona = new StringBuilder("Nome: " + Nome + Environment.NewLine);
            persona.Append("Cognome: " + Cognome + Environment.NewLine);
            persona.AppendLine("Data di nascita: " + DataNascita.ToString("d") + Environment.NewLine);
            persona.Append("Età: " + Anni + Environment.NewLine);

            return persona.ToString();
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
        /// <summary>
        /// Ideato allo scopo di inserire i valori di tipo stringa e gestirne al contempo le eccezzioni
        /// </summary>
        /// <param name="campo"></param>
        /// <param name="valore"></param>
        /// <returns></returns>
        public virtual string DatiAnagrafici(string campo, string valore)
        {
            try
            {
                Console.WriteLine("Inserisci il "+ campo + ": ");
                valore = Console.ReadLine();
                return valore;
            }
            catch(NullReferenceException ex)
            {
                throw new CustomException("Valore vuoto",ex);
            }
            catch
            {
                throw;
            }
        }
        public virtual int CalcolaAnni()
        {
            int result = DateTime.Now.Year - DataNascita.Year;
            return result;
        }
    }
}
