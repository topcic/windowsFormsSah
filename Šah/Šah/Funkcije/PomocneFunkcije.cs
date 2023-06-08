using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InMemoryDB;
namespace Šah.Funkcije
{
    public class PomocneFunkcije
    {
        public static void RazvrstajListu(List<int> lista,  int brojPolja,ref List<int> lijeva,ref List<int> desna)// skratio
        {          
            desna = lista.Where(x => x > brojPolja).ToList();
            lijeva = lista.Where(x => x < brojPolja).ToList();
        }
        public static int SumaCifaraBroja(int v)
        {
            int suma = 0;
            while (v > 0)
            {
                int a = v % 10;
                suma += a;
                v /= 10;
            }
            return suma;
        }
        public static int GetPrviBroj(int c)
        {
            int temp;
            c /= 10;
            temp = c % 10;
            return temp;
        }
        public static List<int> SlobodnaPoljaKolona(string bojaFigure, int BrojPolja,string funkcija)
        {
            List<int> lista = new List<int>();
            List<int> listaPoljaSaFigurom = new List<int>();
            Univerzalna(lista, listaPoljaSaFigurom, BrojPolja, bojaFigure, 10,funkcija);
            if (funkcija != "kretanje")
                SpremiListu(listaPoljaSaFigurom, lista, BrojPolja);
            else
                SpremiListuZaKretanje( lista, BrojPolja,bojaFigure);
            return lista;
        }

        private static void SpremiListuZaKretanje( List<int> lista, int brojPolja, string bojaFigure)
        {
          

            if (InMmemoryDb.PomocnaTemp != null)
            {
                var kraljId = GetKinga(bojaFigure);
                var btnKing = Provjeri.DajMiButton(kraljId);
                var tekst = btnKing?.Text;

                var zastavica = InMmemoryDb.PomocnaTemp.Find(x => x == kraljId);
                if(btnKing!=null && zastavica == kraljId)
                {
                  
                    btnKing.Text = "";
                   // InMmemoryDb.PomocnaTemp = null;

                }
                foreach (var btn in InMmemoryDb.PomocnaTemp)
                {
                    int sljedbenik = 99;
                    int prethodnik = 0;
                    var boja = GetBoja(btn);
                    var dugmic = Provjeri.DajMiButton(btn);

                    if (btn > brojPolja && sljedbenik > btn && dugmic.Text != ""&& boja!=bojaFigure)
                    {

                        sljedbenik = btn;
                    }
                    else if (btn < brojPolja && prethodnik < btn && dugmic.Text != "" && boja != bojaFigure)
                    {
                        prethodnik = btn;
                    }
                    else
                        lista.Add(btn);

                    if (prethodnik != 0)
                    {
                        lista.Add(prethodnik);
                    }
                    if (sljedbenik != 99)
                    {
                        lista.Add(sljedbenik);
                    }
                }
                if (btnKing != null &&  btnKing.Text == "")
                    btnKing.Text = tekst;

                InMmemoryDb.PomocnaTemp = null;
            }
        }

        public static int GetKinga(string bojaFigure) //SKRATIO
        {
            if (bojaFigure == "CR")
            {
                return int.Parse(InMmemoryDb.Bijeli.Find(x => x.Text == "BI-Kralj").Name.Substring(3));
            }
            else
            {
                return int.Parse(InMmemoryDb.Crni.Find(x => x.Text == "CR-Kralj").Name.Substring(3));

            }
        }
   

        public static void Univerzalna(List<int> lista, List<int> listaPoljaSaFigurom, int brojPolja, string bojaFigure, int x,string funkcija="")
        {
            var vece = brojPolja;
            var manje = brojPolja;
  

            while (!Provjeri.NepostojecePolje(vece))
            {
                vece += x;
                if (funkcija != "kretanje")
                {
         
                        if (IsEmptyBrojPolja(vece, bojaFigure) == 1)// vraca 1 ako polje nema figure
                            lista.Add(vece);
                    if (IsEmptyBrojPolja(vece, bojaFigure) == 2) // vraca 2 ako polje ima figuru suprotne boje
                    {
                        listaPoljaSaFigurom.Add(vece);
                    }
                }
                else
                    IsEmpty(vece);

            }
            while (!Provjeri.NepostojecePolje(manje))
            {
                manje -= x;
                if (funkcija != "kretanje")
                {
                    if (IsEmptyBrojPolja(manje, bojaFigure) == 1)
                        lista.Add(manje);
                    if (IsEmptyBrojPolja(manje, bojaFigure) == 2)
                    {
                        listaPoljaSaFigurom.Add(manje);
                    }
                }
               else
                    IsEmpty(manje);
     
        }
        }

        private static void IsEmpty(int brojPolja)
        {
            string btnName = NapraviString(brojPolja);
            Button btn = Provjeri.ProvjeriDaLiPostoji(btnName);


            if (btn != null)
            {
                if (InMmemoryDb.PomocnaTemp == null)
                    InMmemoryDb.PomocnaTemp = new List<int>();
                InMmemoryDb.PomocnaTemp.Add(brojPolja);
              //  InMmemoryDb.ListaKretanja.Add(brojPolja);

            }
        }

        public static string NapraviString(int brojPolja)
        {
            string temp = "btn" + brojPolja;
            return temp;
        }
        public static int IsEmptyBrojPolja(int brojPolja,string bojaFigure)
        {
           
            string btnName = NapraviString(brojPolja);
            Button btn = Provjeri.ProvjeriDaLiPostoji(btnName);
           
            if (bojaFigure == "BI")
            {
                if (btn != null )
                {
                    var bojaDugmica = btn.Text == ""?"": btn.Text.Substring(0, 2);// PomocneFunkcije.GetBojaStringa(btn.Text);
                    if (btn.Text == "")
                        return 1;
                    else if (bojaDugmica == "CR")
                        return 2;
                }
            }
            else
            {
                if (btn != null )
                {
                    var bojaDugmica = btn.Text == "" ? "" : btn.Text.Substring(0, 2);// PomocneFunkcije.GetBojaStringa(btn.Text);
                    if (btn.Text == "")
                        return 1;
                    else if (bojaDugmica == "BI")
                        return 2;
                }

            }
            return 0;

        }
       public static List<int> SlobodnaPoljaRed(string bojaPolja,int BrojPolja,string funkcija)
        {
            List<int> lista = new List<int>();
            List<int> listaPoljaSaFigurom = new List<int>();
            Univerzalna(lista, listaPoljaSaFigurom, BrojPolja, bojaPolja, 1,funkcija);
            if (funkcija != "kretanje")
                SpremiListu(listaPoljaSaFigurom, lista, BrojPolja);
            else
                SpremiListuZaKretanje( lista, BrojPolja,bojaPolja);
           
            return lista;
        }

        public static List<int> SlobodnaPoljaGlavnaDijagonala(int brojPolja,string bojaPolja, string funkcija)
        {       
            List<int> lista = new List<int>();
            List<int> listaPoljaSaFigurom = new List<int>();          
            Univerzalna(lista, listaPoljaSaFigurom, brojPolja, bojaPolja, 11,funkcija);
            if (funkcija != "kretanje")
                SpremiListu(listaPoljaSaFigurom, lista, brojPolja);
            else
                SpremiListuZaKretanje(lista, brojPolja, bojaPolja);
            return lista;
        }
        public static List<int> SlobodnaPoljaSporednaDijagonala(int brojPolja,string bojaPolja, string funkcija)
        {
            List<int> lista = new List<int>();          
            List<int> listaPoljaSaFigurom = new List<int>();
            Univerzalna(lista, listaPoljaSaFigurom, brojPolja, bojaPolja, 9,funkcija);
            if (funkcija != "kretanje")
                SpremiListu(listaPoljaSaFigurom, lista, brojPolja);
            else
                SpremiListuZaKretanje(lista, brojPolja, bojaPolja);
            return lista;
        }

        public static void SpremiListu(List<int> listaPoljaSaFigurom, List<int> lista, int brojPolja)//SKRATIO
        {
            int sljedbenik = 99;
            int prethodnik = 0;
            foreach (var btnId in listaPoljaSaFigurom)          
            {
                if (btnId > brojPolja && sljedbenik > btnId)
                    sljedbenik = btnId;
                else if(btnId < brojPolja && prethodnik < btnId)
                    prethodnik = btnId;
            }
            if (prethodnik != 0)
                lista.Add(prethodnik);
            if (sljedbenik != 99)
                lista.Add(sljedbenik);
        }

        public static string GetBoja(int brojPolja)

        {
            string btnText =NapraviString(brojPolja);
            Button btn = Provjeri.ProvjeriDaLiPostoji(btnText);
            string boja = "";
            if (btn != null && !string.IsNullOrEmpty(btn.Text))
                boja = btn.Text.Substring(0, 2);          
            return boja;
        }
        public static string GetBojaStringa(string nazivBtn)
        {
            if (nazivBtn == "")
                return nazivBtn;     
            return nazivBtn.Substring(0, 2);
            /*   string boja = "";
               boja = nazivBtn.Substring(0, 2);
               for (int i = 0; i < 2; i++)
                   boja += nazivBtn[i];
               return boja;*/
        }
        public  static void CrniIBijeli()//SKRATIO
        {
            InMmemoryDb.Crni = InMmemoryDb.Bijeli = null;
            InMmemoryDb.Bijeli = InMmemoryDb.Crni=new List<Button>();
            InMmemoryDb.Bijeli = InMmemoryDb.Svi.Where(x =>x.Text!="" && x.Text.Substring(0, 2) == "BI").ToList();
            InMmemoryDb.Crni = InMmemoryDb.Svi.Where(x => x.Text != "" &&  x.Text.Substring(0, 2) == "CR").ToList();

            /*       for (int i = 0; i < InMmemoryDb.Svi.Count; i++)
                   {
                       var btnText =InMmemoryDb.Svi[i].Name;
                       var brojBtn = int.Parse(btnText.Substring(3));
                       if (GetBoja(brojBtn) == "CR")
                       {
                           if (InMmemoryDb.Crni == null)
                               InMmemoryDb.Crni = new List<Button>();
                           InMmemoryDb.Crni.Add(InMmemoryDb.Svi[i]);
                       }
                       else if(GetBoja(brojBtn) == "BI")
                       {
                           if (InMmemoryDb.Bijeli == null)
                               InMmemoryDb.Bijeli = new List<Button>();
                           InMmemoryDb.Bijeli.Add(InMmemoryDb.Svi[i]);
                       }
                   }*/
        }

    }
}
