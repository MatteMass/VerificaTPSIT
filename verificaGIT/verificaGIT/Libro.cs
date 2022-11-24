using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificaGIT
{
    internal class Libro
    {
        public string autore { get; set; }
        public string nomeDelLibro { get; set; }
        public int annoDiPubblicazione { get; set; }    
        public string editore { get; set; }
        public int numeroDiPagine { get; set; }
        
        public Libro(string autore, string nomeDelLibro, int annoDiPubblicazione, string editore, int numeroDiPagine)
        {
            this.autore = autore;
            this.nomeDelLibro = nomeDelLibro;
            this.annoDiPubblicazione = annoDiPubblicazione;
            this.editore = editore;
            this.numeroDiPagine = numeroDiPagine;
        }
        
        //metodi
        public string toString(Libro libro)
        {
            string informazioniLibro = libro.autore + '\n' + libro.nomeDelLibro + '\n' + libro.annoDiPubblicazione.ToString() + '\n' + libro.editore + '\n' + libro.numeroDiPagine.ToString();
            return informazioniLibro;
        }

        public string readingTime(Libro libro)
        {
            string tempoDiLettura = "";
            int numeroDiPagine = libro.numeroDiPagine;

            if (numeroDiPagine < 100)
            {
                tempoDiLettura = "tempo di lettura: 1h";
            }
            if (numeroDiPagine < 100 && numeroDiPagine < 200)
            {
                tempoDiLettura = "tempo di lettura: 2h";
            }
            if (numeroDiPagine > 200 )
            {
                tempoDiLettura = "tempo di lettura: più di 2h";
            }
            return tempoDiLettura;
        }

    }
}
