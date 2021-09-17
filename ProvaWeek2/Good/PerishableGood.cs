using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2
{
    public class PerishableGood : Good
    {
        public DateTime DataScadenza { get; set; }
        public Conservazione ModalitaConservazione { get; set; }

        public enum Conservazione
        {
            Freezer,
            Fridge,
            Shelf
        }
        public PerishableGood(){}
        public PerishableGood(DateTime scadenza, Conservazione conservazione, int cod, string descrizione, decimal prezzo, DateTime data, int quantita) : base(cod, descrizione, prezzo, data, quantita)
        {
            DataScadenza = scadenza;
            ModalitaConservazione = conservazione;
        }
        public override string ToString()
        {
            return base.ToString() + $" Data di Scadenza: {DataScadenza}\n Modalità di consevazione{ModalitaConservazione}";
        }
    }

}
