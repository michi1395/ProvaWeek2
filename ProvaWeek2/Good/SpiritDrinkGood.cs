using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2
{
    public class SpiritDrinkGood:Good
    {
        public Cocktail Tipo { get; set; }
        public decimal Gradazione { get; set; }

        public enum Cocktail 
        {
            Whisky,
            Wodka,
            Grappa,
            Gin,
            Other
        }
        public SpiritDrinkGood() { }

        public SpiritDrinkGood(Cocktail tipo,decimal grad, int cod, string descrizione, decimal prezzo, DateTime data, int quantita):base(cod,descrizione,prezzo,data,quantita)
        {
            Tipo = tipo;
            Gradazione = grad;
        }
        public override string ToString()
        {
            return base.ToString() + $" Cocktail: {Tipo}\n Gradazione: {Gradazione}";
        }
    }
}
