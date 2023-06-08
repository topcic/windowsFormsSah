using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InMemoryDB
{
    public class InMmemoryDb
    {
        public static List<Tuple<int, string>> Parovi;
        public static List<Tuple<string, string>> Figure;
        public static List<int> KretanjeKralja { get; set; }

        public static List<int> DesnaH { get; set; }
        public static List<int> LijevaH { get; set; }
        public static List<int> GornjaV { get; set; }
        public static List<int> DonjaV { get; set; }
        public static List<int> ListaKretanja { get; set; }

        public static List<int> DesnaGD { get; set; }
        public static List<int> LijevaGD { get; set; }
        public static List<int> PomocnaTemp { get; set; }

        public static List<int> DesnaSD { get; set; }
        public static List<int> LijevaSD { get; set; }
        public static List<Button> Dozvoli { get; set; }
        public static List<Button> CopyDozvoli { get; set; }

        public static List<Button> ObojenoPolje { get; set; }


        public static List<Button> GdjeProtivnikMozeNapasti { get; set; }
        public static List<Button> GdjeSeProtivnikKrece { get; set; }

        public static List<Button> PutanjaPremaKralju { get; set; }
        public static List<Button> NapadnuteFigure { get; set; }
     

        public static List<Button> BraneKralja { get; set; }
        public static List<Button> Svi { get; set; }
        public static List<Button> Bijeli { get; set; }
        public static List<Button> Crni { get; set; }
        public InMmemoryDb()
        {
            Svi = new List<Button>();
          
            //GdjeProtivnikMozeNapasti = new List<Button>();
        }
    }
}
