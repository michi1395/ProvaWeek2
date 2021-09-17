using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2
{
    public class ElectronicGood:Good
    {
        public string Produttore { get; set; }
        public ElectronicGood() { }

        public ElectronicGood(string prod, int cod, string descrizione, decimal prezzo, DateTime data, int quantita) : base(cod, descrizione, prezzo, data, quantita)
        {
            Produttore = prod;
            
        }
        public override string ToString()
        {
            return base.ToString() + $" Produttore: {Produttore}";
        }
    }
}
