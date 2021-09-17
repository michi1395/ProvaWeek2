using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProvaWeek2.PerishableGood;
using static ProvaWeek2.SpiritDrinkGood;

namespace ProvaWeek2.Helper
{
    public class Function
    {
        public static Conservazione InserisciConservazione()
        {

            Console.WriteLine($"Premi {(int)Conservazione.Freezer} per creare un task con priorità {Conservazione.Freezer}");
            Console.WriteLine($"Premi {(int)Conservazione.Fridge} per creare un task con priorità {Conservazione.Fridge}");
            Console.WriteLine($"Premi {(int)Conservazione.Shelf} per creare un task con priorità {Conservazione.Shelf}");
            int tipo = Check();
            return (Conservazione)tipo;


        }
        public static int Check()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num > 2)
            {
                Console.Write("Puoi inserire solo 0, 1 o 2! Riprova:");
            }

            return num;

        }

        public static Cocktail InserisciCocktail()
        {
            Console.WriteLine($"Premi {(int)Cocktail.Whisky} per creare un task con priorità {Cocktail.Whisky}");
            Console.WriteLine($"Premi {(int)Cocktail.Wodka} per creare un task con priorità {Cocktail.Wodka}");
            Console.WriteLine($"Premi {(int)Cocktail.Grappa} per creare un task con priorità {Cocktail.Grappa}");
            Console.WriteLine($"Premi {(int)Cocktail.Gin} per creare un task con priorità {Cocktail.Gin}");
            Console.WriteLine($"Premi {(int)Cocktail.Other} per creare un task con priorità {Cocktail.Other}");

            int tipo = Check1();
            return (Cocktail)tipo;
        }

        public static int Check1()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num > 4)
            {
                Console.Write("Puoi inserire solo numeri compresi tra 0 e 4! Riprova: ");
            }

            return num;
        }
    }
}
