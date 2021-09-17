using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2
{
    public abstract class Good
    {
        public int CodiceMerce { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public DateTime DataDiRicevimento { get; set; }
        public int QuantitaInGiacenza { get; set; }
        public Good() { }

        public Good (int cod, string descrizione, decimal prezzo, DateTime data, int quantita)
        {
            CodiceMerce = cod;
            Descrizione = descrizione;
            Prezzo = prezzo;
            DataDiRicevimento = data;
            QuantitaInGiacenza = quantita;
        }

        public override string ToString()
        {
            return $" Codice Merce: {CodiceMerce} \n Descrizione: {Descrizione}\n Prezzo: {Prezzo}\n"
                +$"Data di Ricevimento: {DataDiRicevimento.Date.ToShortDateString()}\n Quantità in Giacenza: {QuantitaInGiacenza}\n";
        }
    }
}
