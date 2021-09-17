using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2
{
    public class Warehouse
    {
        public int IdMagazzino { get; set; }
        public string Indirizzo { get; set; }
        public int ImportoTotaleMerciInGiacenza { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public List<Good> MerciInGiacenza=new List<Good>();

        public Warehouse() { }
        public Warehouse(int id,string indirizzo,DateTime data) : this(id,indirizzo,0,data, null){ }
        public Warehouse(int id, string indirizzo, int totMerci, DateTime lastOp, List <Good> merci)
        {
            IdMagazzino = id;
            Indirizzo = indirizzo;
            ImportoTotaleMerciInGiacenza = totMerci;
            DataUltimaOperazione = lastOp;
            MerciInGiacenza = merci;
        }

        public static Warehouse operator +(Warehouse a, Good b)
        {
            a.MerciInGiacenza.Add(b);
            a.DataUltimaOperazione = DateTime.Now;
            ++a.ImportoTotaleMerciInGiacenza;
            return a;
        }

        public static Warehouse operator -(Warehouse a, Good b)
        {
            a.MerciInGiacenza.Remove(b);
            a.DataUltimaOperazione = DateTime.Now;
            ++a.ImportoTotaleMerciInGiacenza;
            return a;
        }

        public void StockList()
        {
            Console.Clear();
            Console.WriteLine("LE INFORMAZIONI RIGUARDANTI IL TUO MAGAZZINO");
            Console.WriteLine();
            Console.WriteLine($"- ID Magazzino: {IdMagazzino} \n- Indirizzo: {Indirizzo} \n- Importo totale Merci in Giacenza: {ImportoTotaleMerciInGiacenza}");
            Console.WriteLine($"- Data Ultima operazione: {DataUltimaOperazione} \n- Merci in giacenza:");

            if (MerciInGiacenza.Count!=0)
            {
                foreach (Good g in MerciInGiacenza)
                {
                    Console.WriteLine();
                    Console.WriteLine("========================================");
                    Console.Write(g.ToString());
                    Console.WriteLine("\n========================================");
                }
            }
            else
                Console.WriteLine(" >> Non sono presenti merci");
            

        }


    }
}
