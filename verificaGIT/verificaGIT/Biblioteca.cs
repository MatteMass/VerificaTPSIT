using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificaGIT
{
    internal class Biblioteca
    {
        public string nomeBiblioteca { get; set; }
        public string indirizzo { get; set; }
        public string orarioApertura { get; set; }
        public string orarioChiusura { get; set; }
        public List<Libro> elencoLibri { get; set; }

        public Biblioteca(string nomeBiblioteca, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            this.nomeBiblioteca = nomeBiblioteca;
            this.indirizzo = indirizzo;
            this.orarioApertura = orarioApertura;
            this.orarioChiusura = orarioChiusura;
        }
    }

    
}
