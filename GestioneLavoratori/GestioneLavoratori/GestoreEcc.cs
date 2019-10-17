using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class GestoreEcc
    {
        /// <summary>
        /// 
        /// </summary>
        private int Valore { get; set; }
        public void Coversione(string elemento)
        {

            try
            {
                Valore = Int32.Parse(elemento);
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException("il valore inserito è vuoto,  inserire un valore corretto", ex);
            }
            catch (OverflowException ex)
            {
                throw new CustomException("Il valore è troppo grande o piccolo, inserire un valore corretto", ex);
            }
            //catch (FormatException ex)
            //{
            //    throw new CustomException("Il valore inserito non va bene, inserisci un valore numerico", ex);
            //}
            catch
            {
                throw;
            }
        }

    }
}
