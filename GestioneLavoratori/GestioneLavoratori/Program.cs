using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Program
    {
        static void Main(string[] args)
        {
            int quanto = 0;
            decimal[] tasse = null;
            Lavoratori[] lavoratori = null;
            GestoreEcc g1 = new GestoreEcc();
            Console.WriteLine("Quanti lavoratori vuoi inserire?");
            string num = (Console.ReadLine());
            try
            {
                g1.Coversione(num);
                quanto = Int32.Parse(num);
                tasse = new decimal[quanto];
                lavoratori = new Lavoratori[quanto];
            }
            catch(CustomException ex)
            {
                Console.WriteLine("Rilevato errore");
                Console.WriteLine(ex.Message);
            }
            for (int i=0; i < quanto; i++)
            {
                Console.WriteLine("Inserisci il nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Inserisci il cognome: ");
                string cognome = Console.ReadLine();
                Console.WriteLine("Inserisci il sesso: ");
                string genere = Console.ReadLine();
                Console.WriteLine("Inserisci la data di nascita: ");
                Console.WriteLine("Giorno:");
                int gN = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mese:");
                int mN = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anno:");
                int yN = Int32.Parse(Console.ReadLine());
                DateTime natoIl = new DateTime(yN, mN, gN);
                Console.WriteLine("Inserisci la data di assunzione: ");
                Console.WriteLine("Giorno:");
                int gA = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Mese:");
                int mA = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anno:");
                int yA = Int32.Parse(Console.ReadLine());
                DateTime assunzione = new DateTime(yA, mA, gA);
                Console.WriteLine("Inserisci lo stipendio mensile: ");
                int stipMens = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci la mensilità: ");
                int mensilita = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Vuoi inserire un lavoratore dipendente(1) o autonomo(2)?");
                int tipo = Int32.Parse(Console.ReadLine());
                if (tipo == 1)
                {
                    Autonomi aut = new Autonomi(nome, cognome, mensilita, stipMens, natoIl, assunzione);
                    tasse[i] = aut.tasse;
                    lavoratori[i] = (Lavoratori)aut;

                }
                else if(tipo == 2)
                {
                    Dipendenti dip = new Dipendenti(nome, cognome, mensilita, stipMens, natoIl, assunzione);
                    tasse[i] = dip.tasse;
                    lavoratori[i] = (Lavoratori)dip;
                }
            }//inserimento lavoratori
            try
            {

            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Non ci sono elementi");
            }
            Console.WriteLine("Gli vuoi ordinati per stipendio(1) o per anzianità?(2)");
                        int scelta = Int32.Parse(Console.ReadLine());
                        if(scelta == 1)
                        {
                            for(int i = 0; i<lavoratori.Length; i++)
                            {
                                int index = i;
                                for(int j = i+1; j<lavoratori.Length;j++)
                                {
                                    if(lavoratori[j].StipendioMens<lavoratori[index].StipendioMens)
                                    {
                                        index = j;
                                    }
                                    Lavoratori temp = new Lavoratori();
                                    temp = lavoratori[index];
                                    lavoratori[index] = lavoratori[i];
                                    lavoratori[i] = temp;

                                }
                    
                            }
                        }
                        else if(scelta == 2)
                        {
                            for (int i = 0; i < lavoratori.Length; i++)
                            {
                                int index = i;
                                for (int j = i + 1; j < lavoratori.Length; j++)
                                {
                                    if (lavoratori[j].AnniServizio < lavoratori[index].AnniServizio)
                                    {
                                        index = j;
                                    }
                                    Lavoratori temp = new Lavoratori();
                                    temp = lavoratori[index];
                                    lavoratori[index] = lavoratori[i];
                                    lavoratori[i] = temp;

                                }

                            }
                        }
                        for(int i=0;i<lavoratori.Length;i++)
                        {
                            Console.WriteLine(lavoratori[i].GetDettaglioPersona()+ Environment.NewLine+" Tasse: " + tasse[i] + Environment.NewLine);
                        }
                        Console.ReadLine();
            
            
        }
    }
}
