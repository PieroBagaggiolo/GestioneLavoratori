using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int quanto = 0;
            decimal[] tasse = null;
            GestoreEcc g1 = new GestoreEcc();
            Console.WriteLine("Quanti lavoratori vuoi inserire?");
            string num = (Console.ReadLine());
            try
            {
                g1.Coversione(num);
                quanto = Int32.Parse(num);
            }
            catch(CustomException ex)
            {
                Console.WriteLine("Rilevato errore");
                Console.WriteLine(ex.Message);
            }
            tasse = new decimal[quanto];
            Lavoratori[] lavoratori = new Lavoratori[quanto];
            for (int i=0; i < quanto; i++)
            {
                Lavoratori worker = new Lavoratori();
                string nome = "A", cognome = "", genere = "";
                int gA=0, mA = 0, yA = 0, gN = 0, mN = 0, yN = 0, stipMens = 0, mensilita = 0;
                DateTime assunzione = new DateTime();
                DateTime nascita = new DateTime();
                nome = worker.DatiAnagrafici("nome", nome);
                cognome = worker.DatiAnagrafici("cognome", cognome);
                genere = worker.DatiAnagrafici("sesso", genere);
                Console.WriteLine("Inserisci la data di nascita: ");
                nascita = worker.AddData(gN, mN, yN, nascita);
                Console.WriteLine("Inserisci la data di assunzione: ");
                assunzione = worker.AddData(gA,mA, yA, assunzione);
                Console.WriteLine("Inserisci lo stipendio mensile: ");
                stipMens = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci la mensilità: ");
                mensilita = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Vuoi inserire un lavoratore dipendente(1) o autonomo(2)?");
                int tipo = Int32.Parse(Console.ReadLine());
                if (tipo == 1)
                {
                    Autonomi aut = new Autonomi(nome, cognome, mensilita, stipMens, nascita, assunzione);
                    tasse[i] = aut.tasse;
                    lavoratori[i] = (Lavoratori)aut;

                }
                else if(tipo == 2)
                {
                    Dipendenti dip = new Dipendenti(nome, cognome, mensilita, stipMens, nascita, assunzione);
                    tasse[i] = dip.tasse;
                    lavoratori[i] = (Lavoratori)dip;
                }
            }//inserimento lavoratori
             /// <summary>
             /// metodo per gestire le eccezzioni che possono uscire 
             /// nell'operazioni di ordinamento
             /// </summary>
             /// <param name="scelta"></param>
             /// <param name="workers"></param>
            if(lavoratori.Length>1)
            {
                try
                {
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
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine("Non ci sono elementi");
                }
            }
            for(int i=0;i<lavoratori.Length;i++)
            {
                Console.WriteLine(lavoratori[i].GetDettaglioPersona()+ Environment.NewLine+" Tasse: " + tasse[i]);
            }
            Console.ReadLine();
        }
    }
}
