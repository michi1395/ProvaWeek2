using ProvaWeek2.Helper;
using System;

namespace ProvaWeek2
{
    public class Menu
    {
        public static void Start()
        {
            Console.WriteLine("BENVENUTO NELLA SEZIONE MAGAZZINO");
            Warehouse magazzino = new Warehouse()
            {
                IdMagazzino = 1234567,
                Indirizzo = "Via delle Peonie, 13",
                DataUltimaOperazione = DateTime.Now
            };

            

            int scelta = 0;
            do
            {
                Console.Clear();
                magazzino.StockList();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Clicca \n[1] - Aggiungere merce \n[2] - Rimuovere merce");

                bool isInt = true;

                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                    if (!isInt)
                    {
                        Console.WriteLine("La scelta è sbagliata... Riprova");
                    }
                } while (!isInt);
                switch (scelta)
                {
                    case 1:
                        Sottomenu.Aggiugi(magazzino);
                        break;
                    case 2:
                        Sottomenu.Rimuovi(magazzino);
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata... Riprova");
                        break;

                }
            } while (scelta != 0);
            
                    
        }

    }
}