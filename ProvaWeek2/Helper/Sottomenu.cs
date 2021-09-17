using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.Helper
{
    public class Sottomenu
    {
        public static void Aggiugi(Warehouse magazzino)
        {
            Console.Clear();
            Console.WriteLine("Scegli la merce da aggiungere nella tua lista Merci");
            Console.WriteLine();
            Console.WriteLine("[1] - ElectronicGood \n[2] - PerishableGood \n[3] - SpiritDrinkGood");
            int choice = 0;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.Write("Puoi inserire solo 1, 2 o 3! Riprova:");
            }

            switch (choice)
            {
                case 1:
                    ElectronicGood good = new ElectronicGood();
                    Console.Write("Inserisci il Codice Merce: ");
                    good.CodiceMerce = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci descrizione Prodotto: ");
                    good.Descrizione = Console.ReadLine();
                    Console.Write("Inserisci prezzo: ");
                    good.Prezzo = decimal.Parse(Console.ReadLine());
                    Console.Write("Inserisci data ricevimento merce: ");
                    good.DataDiRicevimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("Inserisci quantità in giacenza: ");
                    good.QuantitaInGiacenza = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci Produttore: ");
                    good.Produttore = Console.ReadLine();

                    magazzino += good;


                    break;


                case 2:
                    PerishableGood good2 = new PerishableGood();
                    Console.Write("Inserisci il Codice Merce: ");
                    good2.CodiceMerce = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci descrizione Prodotto: ");
                    good2.Descrizione = Console.ReadLine();
                    Console.Write("Inserisci prezzo: ");
                    good2.Prezzo = decimal.Parse(Console.ReadLine());
                    Console.Write("Inserisci data ricevimento merce: ");
                    good2.DataDiRicevimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("Inserisci quantità in giacenza: ");
                    good2.QuantitaInGiacenza = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci Data Scadenza: ");
                    good2.DataScadenza = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci Conservazione ");
                    good2.ModalitaConservazione = Function.InserisciConservazione();
                    magazzino += good2;
                    break;
                case 3:
                    SpiritDrinkGood good3 = new SpiritDrinkGood();
                    Console.Write("Inserisci il Codice Merce: ");
                    good3.CodiceMerce = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci descrizione Prodotto: ");
                    good3.Descrizione = Console.ReadLine();
                    Console.Write("Inserisci prezzo: ");
                    good3.Prezzo = decimal.Parse(Console.ReadLine());
                    Console.Write("Inserisci data ricevimento merce: ");
                    good3.DataDiRicevimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("Inserisci quantità in giacenza: ");
                    good3.QuantitaInGiacenza = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci Gradazione: ");
                    good3.Gradazione = decimal.Parse(Console.ReadLine());
                    Console.Write("Inserisci  ");
                    good3.Tipo = Function.InserisciCocktail();
                    magazzino += good3;
                    break;
                default:
                    Menu.Start();
                    break;
            }
        }

        internal static void Rimuovi(Warehouse magazzino)
        {
            Console.Clear();
            Console.WriteLine("Scegli la merce da eliminare nella tua lista Merci");
            int count = 1;
            
            foreach(Good g in magazzino.MerciInGiacenza)
            {
                Console.WriteLine($"Merce #{count}");
                g.ToString();
                count++;
            }
            int numMerci = 0;
            bool isInt = false;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out numMerci);
            } while (!isInt || numMerci < 0 || numMerci > magazzino.MerciInGiacenza.Count);

            Good goodDaEliminare = magazzino.MerciInGiacenza.ElementAt(numMerci - 1);
            magazzino -= goodDaEliminare;


        }
    }
}
