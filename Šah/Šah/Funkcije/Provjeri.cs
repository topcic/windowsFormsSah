using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InMemoryDB;
using Šah.figure;

namespace Šah.Funkcije
{
    public class Provjeri
    {
       
        public static void ProvjeriButtnonZaListeKretanja(int btnId, string bojaFigure = "")
        {
            string btnText = PomocneFunkcije.NapraviString(btnId);
            Button btn = DajMiButton(int.Parse(btnText.Substring(3)));
            if (bojaFigure != "")
            {
                if (bojaFigure == "BI")
                {
                    if (btn != null && (btn.Text == "" || btn.Text.Substring(0, 2) == "CR"))
                        InMmemoryDb.ListaKretanja.Add(btnId);
                }
                else
                {
                    if (btn != null && (btn.Text == "" || btn.Text.Substring(0, 2) == "BI"))
                        InMmemoryDb.ListaKretanja.Add(btnId);
                }
            }
            else
            {
                if (btn != null)
                    InMmemoryDb.ListaKretanja.Add(btnId);
            }
        }
        public static void ProvjeriButtnonZaListeNapad(int brojPolja)
        {
            string btnText = PomocneFunkcije.NapraviString(brojPolja);
            Button btn = DajMiButton(int.Parse(btnText.Substring(3)));
            if (InMmemoryDb.GdjeProtivnikMozeNapasti == null)
                InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
            if (btn != null)
                InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn);
        }
        private static void ProvjeriButtnonZaListeOdbranu(int brojPolja)
        {
            string btnText = PomocneFunkcije.NapraviString(brojPolja);
            Button btn = DajMiButton(int.Parse(btnText.Substring(3)));
            if (InMmemoryDb.BraneKralja == null)
                InMmemoryDb.BraneKralja = new List<Button>();
            if (btn != null)
                InMmemoryDb.BraneKralja.Add(btn);
        }       
        public static void ProvjeriObojeniButton()
        {
             foreach (var btn in InMmemoryDb.Svi)
             {
                 if (btn.BackColor == Color.Aquamarine)
                 {
                     if (InMmemoryDb.Dozvoli == null)
                     {
                         InMmemoryDb.Dozvoli = new List<Button>();
                     }
                     InMmemoryDb.Dozvoli.Add(btn);
                 }
             }
          

        } // SKratiti funkciju da je efikasnija
        public static void ProvjeriButtnonZaKralja(int brojPolja, string bojaFigure,string funkcija="")
        {
            string btn1Text = PomocneFunkcije.NapraviString(brojPolja);
            Button btn = ProvjeriDaLiPostoji(btn1Text);
            var rez = InMmemoryDb.ListaKretanja.Find(x => x == brojPolja);
            if (rez == brojPolja)
                return;
                   
            if (bojaFigure == "BI")
            {
                if (btn != null && (btn.Text == "" || btn.Text.Substring(0, 2) == "CR"))
                    if (funkcija == "kretanje")
                        DodajZaKretanjeKralja( brojPolja);
                else
                    btn.BackColor = Color.Aquamarine;
            }
            else
            {
                if (btn != null && (btn.Text == "" || btn.Text.Substring(0, 2) == "BI"))
                    if (funkcija == "kretanje")
                        DodajZaKretanjeKralja( brojPolja);
                else
                    btn.BackColor = Color.Aquamarine;
            }


        }

        private static void DodajZaKretanjeKralja( int brojPolja)
        {                 
                if (InMmemoryDb.KretanjeKralja == null)
                    InMmemoryDb.KretanjeKralja = new List<int>();
                InMmemoryDb.KretanjeKralja.Add(brojPolja);            
        }

        public static Button ProvjeriDaLiPostoji(string btnIme)//metoda prihvaća ime dugmica(string)  vraca null ili button sa tim imenom
        {
            return DajMiButton(int.Parse(btnIme.Substring(3)));
        }

        public static Button DajMiButton(int brojPolja)
        {
            if (NepostojecePolje(brojPolja))
                return null;
            int prvaCifra = PomocneFunkcije.GetPrviBroj(brojPolja);
            int drugaCifra = brojPolja % 10;
            int lokacija = (prvaCifra - 1) * 8 + drugaCifra - 1;
            if (lokacija < 0 || lokacija > 63)
                return null;
            Button btn = InMmemoryDb.Svi[lokacija];
            return btn;
        }

        public static bool NepostojecePolje(int brojPolja)// metoda provjerava da li postoji polje
        {
            return (brojPolja < 11 || brojPolja > 88 || (brojPolja > 18 && brojPolja < 21) || (brojPolja > 28 && brojPolja < 31) || (brojPolja > 38 && brojPolja < 41) ||
              (brojPolja > 48 && brojPolja < 51) || (brojPolja > 58 && brojPolja < 61) || (brojPolja > 68 && brojPolja < 71) || (brojPolja > 78 && brojPolja < 81));
        }

        public static void ProvjeriButtnoIOboji(int brojPolja, string bojaFigure)
        {
            string btn1Text = PomocneFunkcije.NapraviString(brojPolja);
            Button btn = DajMiButton(int.Parse(btn1Text.Substring(3)));
            ObojiPolje(btn, bojaFigure);

        }
        public static void ProvjeriButtnonZaListeO(int brojPolja)
        {
            string btnText = PomocneFunkcije.NapraviString(brojPolja);
            Button btn = DajMiButton(int.Parse(btnText.Substring(3)));
            if (btn != null)
                btn.BackColor = Color.Aquamarine;
        }
     
        public static void ProvjeriButtnoIObojiZaKonja(int brojPoljaGdjeNapada, string bojaFigure, string funkcija = "", int brojPoljaFigure=0)
        {
            string btn1Text = PomocneFunkcije.NapraviString(brojPoljaGdjeNapada);
            if (NepostojecePolje(brojPoljaGdjeNapada))
                return;
            Button btn = DajMiButton(int.Parse(btn1Text.Substring(3)));

            if (funkcija == "")
            {

                ObojiPolje(btn, bojaFigure);
            }
            else if (funkcija == "napad")
            {
                InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                ProvjeriButtnonZaListeNapad(brojPoljaFigure);

                ProvjeriButtnonZaListeNapad(brojPoljaGdjeNapada);
            }
            else if (funkcija == "kretanje")
            {
                ProvjeriButtnonZaListeKretanja(brojPoljaGdjeNapada);
            }
            else
            {
                ProvjeriButtnonZaListeOdbranu(brojPoljaGdjeNapada);

            }

        }

        public static void ObojiPolje(Button btn, string bojaFigure, string funkcija = "")
        {
            if (funkcija == "odbrana")
            {
                btn.BackColor = Color.Aquamarine;
                if (InMmemoryDb.ObojenoPolje == null)
                    InMmemoryDb.ObojenoPolje = new List<Button>();
                InMmemoryDb.ObojenoPolje.Add(btn);
            }

            if (bojaFigure == "BI")
            {
                if (btn != null && (btn.Text == "" || (btn.Text != "" && btn.Text.Substring(0, 2) == "CR")))
                    btn.BackColor = Color.Aquamarine;
                if (InMmemoryDb.ObojenoPolje == null)
                    InMmemoryDb.ObojenoPolje = new List<Button>();
                InMmemoryDb.ObojenoPolje.Add(btn);
            }
            else
            {
                if (btn != null && (btn.Text == "" || (btn.Text!="" && btn.Text.Substring(0, 2) == "BI")))
                    btn.BackColor = Color.Aquamarine;
                if (InMmemoryDb.ObojenoPolje == null)
                    InMmemoryDb.ObojenoPolje = new List<Button>();
                InMmemoryDb.ObojenoPolje.Add(btn);
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////
        //                   FUNKCIJE ZA PROVJERU KRETANJA VERTIKALNO

        public static void Vertikalno(int BrojPolja, int kralj = 0, string funkcija = "", Button btn = null)
        {
            List<int> gornja = new List<int>(); // spadaju btn veci od brojpolja
            List<int> donja = new List<int>();  // spadaju btn manji od brojpolja       
            var boja = PomocneFunkcije.GetBoja(BrojPolja);
            List<int> lista = PomocneFunkcije.SlobodnaPoljaKolona( boja, BrojPolja,funkcija);
            PomocneFunkcije.RazvrstajListu(lista,BrojPolja,ref donja,ref gornja);
            Sortiraj.Uzlazno(donja);
            Sortiraj.Uzlazno(gornja);
            
                gornja = SrediListu(gornja,boja, funkcija);
                donja = SrediListuObrnuto(donja, boja, funkcija);
                Sortiraj.Silazno(donja);
            
            GV(gornja, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;
            InMmemoryDb.GdjeProtivnikMozeNapasti = null;
            DV(donja, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;

        }
        public static void DV(List<int> donja, int BrojPolja, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            int x = 1;
            for (int i = 0; i < donja.Count; i++)
            {
                var next = BrojPolja - x * 10;
                var btnId = donja[i];
                if (next == btnId)
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);
                        if (InMmemoryDb.DonjaV == null)
                        {
                            InMmemoryDb.DonjaV = new List<int>();
                        }
                        InMmemoryDb.DonjaV.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
                x++;
            }

        }

        private static void DodajBtnZaNapad(Button btn)
        {
            if (InMmemoryDb.GdjeProtivnikMozeNapasti == null)
                InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
            if (btn != null)
                InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn);
        }

        public static void GV(List<int> gornja, int c, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            for (int i = 0; i < gornja.Count; i++)
            {
                var next = c + (i + 1) * 10;
                var btnId = gornja[i];
                if (next == btnId)
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);
                        if (InMmemoryDb.GornjaV == null)
                        {
                            InMmemoryDb.GornjaV = new List<int>();
                        }
                        InMmemoryDb.GornjaV.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////
        //                FUNKCIJE ZA PROVJERU KRETANJA HORIZONTALNO

        public static void Horizontalno(int BrojPolja, int kralj = 0, string funkcija = "", Button btn = null)
        {
            List<int> desna = new List<int>();    // spadaju btn veci od brojpolja
            List<int> lijeva = new List<int>();   // spadaju btn manji od brojpolja
            var boja = PomocneFunkcije.GetBoja(BrojPolja);
            List<int> lista = PomocneFunkcije.SlobodnaPoljaRed( boja, BrojPolja,funkcija);
            PomocneFunkcije.RazvrstajListu(lista,  BrojPolja, ref lijeva, ref desna);
            Sortiraj.Silazno(lijeva);
            Sortiraj.Uzlazno(desna);
            //if (funkcija != "kretanje")
            //{
                lijeva = SrediListu(lijeva,boja,funkcija);
                desna = SrediListu(desna,boja,funkcija);
         //   }
            DH(desna, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;
            InMmemoryDb.GdjeProtivnikMozeNapasti = null;
            LH(lijeva, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;
            //    InMmemoryDb.GdjeProtivnikMozeNapasti = null;
        }

        private static bool DaLiJeKraljNapadnut(string funkcija, int kralj)
        {
            if (funkcija == "napad" && kralj != 0)
            {
                if (FunkBlokirajFigurucs.DaLiNapadaKralja(kralj) == 2)
                    return true;
            }

            return false;
        }

        private static List<int> SrediListu(List<int> lijeva,string boja,string funkcija)
        {
            var kraljId =PomocneFunkcije.GetKinga(boja);
            var temp = new List<int>();
            foreach (var btnID in lijeva)
            {
                var btn = Provjeri.DajMiButton(btnID);
                var brPolja = int.Parse(btn.Name.Substring(3));
                temp.Add(brPolja);
                if (funkcija == "kretanje")
                {
                    if (btn.Text != "" && btnID != kraljId)
                        return temp;
                }
                else
                      if (btn.Text != "" )
                    return temp;
            }
            return lijeva;
        }
        private static List<int> SrediListuObrnuto(List<int> lijeva,string boja,string funkcija)
        {
            var kraljId = PomocneFunkcije.GetKinga(boja);

            var temp = new List<int>();
            for (int i = lijeva.Count - 1; i >= 0; i--)
            {
                var btnID = lijeva[i];
                var btn = Provjeri.DajMiButton(btnID);
                var brPolja = int.Parse(btn.Name.Substring(3));
                temp.Add(brPolja);
                if (funkcija == "kretanje")
                {
                    if (btn.Text != "" && btnID != kraljId)
                        return temp;
                }
                else
                      if (btn.Text != "")
                    return temp;
            }
            return lijeva;
        }
        private static void DH(List<int> desna, int c, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            for (int i = 0; i < desna.Count; i++)
            {
                var next = c + i + 1;
                var btnId = desna[i];
                if (next == btnId)
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);
                        if (InMmemoryDb.DesnaH == null)
                        {
                            InMmemoryDb.DesnaH = new List<int>();
                        }
                        InMmemoryDb.DesnaH.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
            }
        }
        private static void LH(List<int> lijeva, int c, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            int x = 1;
            for (int i = 0; i < lijeva.Count; i++)
            {
                var next = c - x;
                var btnId = lijeva[i];
                if (next == btnId)
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);
                        if (InMmemoryDb.LijevaH == null)
                        {
                            InMmemoryDb.LijevaH = new List<int>();
                        }

                        InMmemoryDb.LijevaH.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
                x++;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////
        //                FUNKCIJE ZA PROVJERU KRETANJA GLAVNOM DIJAGONALOM
        public static void GlavnuDijagonalu(int BrojPolja, int kralj = 0, string funkcija = "", Button btn = null)
        {
            List<int> desna = new List<int>(); // spadaju btn veci od brojpolja
            List<int> lijeva = new List<int>();// spadaju btn manji od brojpolja
            var boja = PomocneFunkcije.GetBoja(BrojPolja);
            List<int> lista = PomocneFunkcije.SlobodnaPoljaGlavnaDijagonala(BrojPolja, boja,funkcija);
            PomocneFunkcije.RazvrstajListu(lista, BrojPolja, ref lijeva, ref desna);
            Sortiraj.Uzlazno(lijeva);
            Sortiraj.Uzlazno(desna);
                desna = SrediListu(desna, boja, funkcija);
                lijeva = SrediListuObrnuto(lijeva, boja, funkcija);
                Sortiraj.Uzlazno(lijeva);
            

            DGV(desna, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;
            InMmemoryDb.GdjeProtivnikMozeNapasti = null;
            LGD(lijeva, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;
        }
        private static void DGV(List<int> desna, int brojPolja, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            for (int i = 0; i < desna.Count; i++)
            {
                var next = brojPolja + (i + 1) * 11;
                var btnId = desna[i];
                if (next == btnId)
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);
                        if (InMmemoryDb.DesnaGD == null)
                        {
                            InMmemoryDb.DesnaGD = new List<int>();
                        }
                        InMmemoryDb.DesnaGD.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
            }
        }


        private static void LGD(List<int> lijeva, int brojPolja, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            int x = 11;
            for (int i = lijeva.Count - 1; i >= 0; i--)
            {
                var next = brojPolja - x;
                var btnId = lijeva[i];
                if (next == lijeva[i])
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);

                        if (InMmemoryDb.LijevaGD == null)
                        {
                            InMmemoryDb.LijevaGD = new List<int>();
                        }

                        InMmemoryDb.LijevaGD.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
                x += 11;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////
        //                FUNKCIJE ZA PROVJERU KRETANJA SPOREDNOM DIJAGONALOM
        public static void SporednuDijagonalu(int BrojPolja, int kralj = 0, string funkcija = "", Button btn = null)
        {
            List<int> manja = new List<int>();
            List<int> veca = new List<int>();
            var boja = PomocneFunkcije.GetBoja(BrojPolja);
            List<int> lista = PomocneFunkcije.SlobodnaPoljaSporednaDijagonala(BrojPolja, boja, funkcija);
            PomocneFunkcije.RazvrstajListu(lista,  BrojPolja, ref manja, ref veca);
            Sortiraj.Uzlazno(manja);
            Sortiraj.Uzlazno(veca);
          
                veca = SrediListu(veca, boja, funkcija);
                //  Sortiraj.Silazno(lijeva);
                Sortiraj.Uzlazno(veca);

                manja = SrediListuObrnuto(manja, boja, funkcija);
                Sortiraj.Uzlazno(manja);
            

            LSD(manja, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;
            DSD(veca, BrojPolja, funkcija, btn);
            if (DaLiJeKraljNapadnut(funkcija, kralj))
                return;
        }
        private static void DSD(List<int> desna, int brojPolja, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            for (int i = 0; i < desna.Count; i++)
            {
                var next = brojPolja + (i + 1) * 9;
                var btnId = desna[i];
                if (next == desna[i])
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);
                        if (InMmemoryDb.DesnaSD == null)
                        {
                            InMmemoryDb.DesnaSD = new List<int>();
                        }
                        InMmemoryDb.DesnaSD.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
            }
        }
        private static void LSD(List<int> lijeva, int brojPolja, string funkcija, Button btn = null)
        {
            if (funkcija == "napad")
            {
                DodajBtnZaNapad(btn);
            }
            int x = 9;
            for (int i = lijeva.Count - 1; i >= 0; i--)
            // for(int i=0;i<desna.Count;i++)
            {
                var next = brojPolja - x;
                var btnId = lijeva[i];
                if (next == btnId)
                {
                    if (funkcija == "")
                    {
                        ProvjeriButtnonZaListeO(btnId);
                        if (InMmemoryDb.LijevaSD == null)
                        {
                            InMmemoryDb.LijevaSD = new List<int>();
                        }

                        InMmemoryDb.LijevaSD.Add(btnId);
                    }
                    else if (funkcija == "napad")
                    {
                        ProvjeriButtnonZaListeNapad(btnId);
                    }
                    else if (funkcija == "kretanje")
                    {
                        ProvjeriButtnonZaListeKretanja(btnId);

                    }
                    else
                    {
                        ProvjeriButtnonZaListeOdbranu(btnId);
                    }
                }
                else
                    return;
                x += 9;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////
        //      FUNKCIJE ZA PROVJERU KRETANJA PIJUNA
        public static void ProvjeriButtnonZaPijunaO(int brojPolja)
        {
            string btn1 = PomocneFunkcije.NapraviString(brojPolja);
            Button btn2 = DajMiButton(int.Parse(btn1.Substring(3)));
            if (btn2 != null && btn2.Text == "")
            {
                btn2.BackColor = Color.Aquamarine;
            }

        }



        public static void KretanjePijuna(int BrojPolja, string funkcija = "") //2 cr
        {
            var BojaFigure = PomocneFunkcije.GetBoja(BrojPolja);
            int prvaCifra = PomocneFunkcije.GetPrviBroj(BrojPolja);

            if (prvaCifra == 2 && BojaFigure == "CR")
            {
                if (funkcija == "")
                {
                    ProvjeriZaStartPozicije(BrojPolja + 10, BrojPolja + 20);
                    PijunDijagonalnoZaCrne(BrojPolja, BojaFigure, funkcija);

                }
                else if (funkcija == "napad")
                {
                    PijunDijagonalnoZaCrne(BrojPolja, BojaFigure, funkcija);
                }
                else if (funkcija == "kretanje")
                {
                    PijunDijagonalnoZaCrne(BrojPolja, BojaFigure, funkcija);
                }
                else
                {
                    ProvjeriZaStartPozicije(BrojPolja + 10, BrojPolja + 20, "odbrana");
                    PijunDijagonalnoZaCrne(BrojPolja, BojaFigure, funkcija);
                }
            }
            else if (prvaCifra > 2 && BojaFigure == "CR")
            {
                PijunDijagonalnoKretanje(BrojPolja + 11, BrojPolja + 9, BrojPolja + 10, BojaFigure, funkcija);

            }
            else if (prvaCifra == 7 && BojaFigure == "BI")

            {
                if (funkcija == "")
                {
                    ProvjeriZaStartPozicije(BrojPolja - 10, BrojPolja - 20);
                    PijunDijagonalnaOdbranaZaBijele(BrojPolja, BojaFigure);
                }
                else if (funkcija == "napad")
                {
                    PijunDijagonalnaOdbranaZaBijele(BrojPolja, BojaFigure, "napad");
                }
                else if (funkcija == "kretanje")
                {
                    PijunDijagonalnoZaCrne(BrojPolja, BojaFigure, funkcija);
                }
                else
                {
                    ProvjeriZaStartPozicije(BrojPolja - 10, BrojPolja - 20, "odbrana");
                    PijunDijagonalnaOdbranaZaBijele(BrojPolja, BojaFigure, "odbrana");
                }
            }
            else  //(prvaCifra < 7 && BojaFigure == "BI")
            {
                PijunDijagonalnoKretanje(BrojPolja - 11, BrojPolja - 9, BrojPolja - 10, BojaFigure, funkcija);
            }
        }

        private static void ProvjeriZaStartPozicije(int brojPolja1, int brojPolja2, string funkcija = "")
        {
            string btn1Text = PomocneFunkcije.NapraviString(brojPolja1);
            Button btn1 = DajMiButton(int.Parse(btn1Text.Substring(3)));

            string btn2Text = PomocneFunkcije.NapraviString(brojPolja2);
            Button btn2 = DajMiButton(int.Parse(btn2Text.Substring(3)));
            if (funkcija == "")
            {

                if (btn1 != null && btn1.Text == "")
                {
                    btn1.BackColor = Color.Aquamarine;
                }
                else
                    return;
                if (btn2 != null && btn2.Text == "")
                {
                    btn2.BackColor = Color.Aquamarine;
                }
            }
            else if (funkcija == "napad")
            {
                if (InMmemoryDb.GdjeProtivnikMozeNapasti == null)
                    InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
                if (btn1 != null && btn1.Text == "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn1);
                }
                else
                    return;
                if (btn2 != null && btn2.Text == "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn2);

                }
            }
            else if (funkcija == "kretanje")
            {
                if (InMmemoryDb.GdjeSeProtivnikKrece == null)
                    InMmemoryDb.GdjeSeProtivnikKrece = new List<Button>();
                if (btn1 != null && btn1.Text == "")
                {
                    InMmemoryDb.GdjeSeProtivnikKrece.Add(btn1);
                }
                else
                    return;
                if (btn2 != null && btn2.Text == "")
                {
                    InMmemoryDb.GdjeSeProtivnikKrece.Add(btn2);

                }
            }
            else
            {
                if (InMmemoryDb.BraneKralja == null)
                    InMmemoryDb.BraneKralja = new List<Button>();
                if (btn1 != null && btn1.Text == "")
                {
                    InMmemoryDb.BraneKralja.Add(btn1);
                }
                else
                    return;
                if (btn2 != null && btn2.Text == "")
                {
                    InMmemoryDb.BraneKralja.Add(btn2);

                }
            }
        }

        private static void PijunDijagonalnaOdbranaZaBijele(int brojPolja, string bojaFigure, string funkcija = "")
        {
            var btn1Text = PomocneFunkcije.NapraviString(brojPolja - 11);
            var btn2Text = PomocneFunkcije.NapraviString(brojPolja - 9);
            var btn1 = DajMiButton(int.Parse(btn1Text.Substring(3)));
            var btn2 = DajMiButton(int.Parse(btn2Text.Substring(3)));
            if (funkcija == "")
            {
                if (btn1 != null && PomocneFunkcije.GetBoja(brojPolja - 11) != bojaFigure && btn1.Text != "")
                {
                    btn1.BackColor = Color.Aquamarine;

                }
                if (btn2 != null && PomocneFunkcije.GetBoja(brojPolja - 9) != bojaFigure && btn2.Text != "")
                {
                    btn2.BackColor = Color.Aquamarine;

                }
            }
            else if (funkcija == "napad")
            {
                if (InMmemoryDb.GdjeProtivnikMozeNapasti == null)
                    InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
                if (btn1 != null && PomocneFunkcije.GetBoja(brojPolja - 11) != bojaFigure && btn1.Text != "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn1);
                }
                if (btn2 != null && PomocneFunkcije.GetBoja(brojPolja - 9) != bojaFigure && btn2.Text != "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn2);
                }
            }
            else
            {
                if (InMmemoryDb.BraneKralja == null)
                    InMmemoryDb.BraneKralja = new List<Button>();
                if (btn1 != null && PomocneFunkcije.GetBoja(brojPolja - 11) != bojaFigure && btn1.Text != "")
                {
                    InMmemoryDb.BraneKralja.Add(btn1);
                }
                if (btn2 != null && PomocneFunkcije.GetBoja(brojPolja - 9) != bojaFigure && btn2.Text != "")
                {
                    InMmemoryDb.BraneKralja.Add(btn2);
                }
            }
        }
        private static void PijunDijagonalnoKretanje(int btn1BrPolja, int btn2BrPolja, int btn3BrPolja, string bojaFigure, string funkcija = "")
        {
            var btn1Text = PomocneFunkcije.NapraviString(btn1BrPolja);
            var btn2Text = PomocneFunkcije.NapraviString(btn2BrPolja);
            var btn3Text = PomocneFunkcije.NapraviString(btn3BrPolja);


            var btn1Boja = PomocneFunkcije.GetBoja(btn1BrPolja);
            var btn2Boja = PomocneFunkcije.GetBoja(btn2BrPolja);
      //      var btn3Boja = PomocneFunkcije.GetBoja(btn3BrPolja);



            var btn1 = DajMiButton(int.Parse(btn1Text.Substring(3)));
            var btn2 = DajMiButton(int.Parse(btn2Text.Substring(3)));
            var btn3 = DajMiButton(int.Parse(btn3Text.Substring(3)));

            if (funkcija == "")
            {
                if (btn1 != null && btn1Boja != bojaFigure && btn1.Text != "")
                {
                    btn1.BackColor = Color.Aquamarine;

                }
                if (btn2 != null && btn2Boja != bojaFigure && btn2.Text != "")
                {
                    btn2.BackColor = Color.Aquamarine;

                }
                if (btn3 != null && btn3.Text == "")
                {
                    btn3.BackColor = Color.Aquamarine;
                }
            }
            else if (funkcija == "napad")
            {
                if (InMmemoryDb.GdjeProtivnikMozeNapasti == null)
                    InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
                if (btn1 != null && btn1Boja != bojaFigure && btn1.Text != "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn1);
                }
                if (btn2 != null && btn2Boja != bojaFigure && btn2.Text != "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn2);
                }
              /*  if (btn3 != null && btn3.Text == "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn3);

                }*/
            }
            else if (funkcija == "kretanje")
            {
                if (InMmemoryDb.ListaKretanja == null)
                    InMmemoryDb.ListaKretanja = new List<int>();
                if (btn1 != null )
                {
                    InMmemoryDb.ListaKretanja.Add(btn1BrPolja);
                }
                if (btn2 != null )
                {
                    InMmemoryDb.ListaKretanja.Add(btn2BrPolja);
                }
             /*   if (btn3 != null && btn3.Text == "")
                {
                    InMmemoryDb.GdjeSeProtivnikKrece.Add(btn3);

                }*/
            }
            else
            {
                if (InMmemoryDb.BraneKralja == null)
                    InMmemoryDb.BraneKralja = new List<Button>();
                if (btn1 != null && btn1Boja != bojaFigure && btn1.Text != "")
                {
                    InMmemoryDb.BraneKralja.Add(btn1);
                }
                if (btn2 != null && btn2Boja != bojaFigure && btn2.Text != "")
                {
                    InMmemoryDb.BraneKralja.Add(btn2);
                }
                if (btn3 != null && btn3.Text == "")
                {
                    InMmemoryDb.BraneKralja.Add(btn3);

                }
            }
        }


        private static void PijunDijagonalnoZaCrne(int brojPolja, string bojaFigure, string funkcija = "")
        {
            var btn1Pozicija = brojPolja + 11;
            var btn2Pozicija = brojPolja + 9;

            var btn1Boja = PomocneFunkcije.GetBoja(btn1Pozicija);
            var btn2Boja = PomocneFunkcije.GetBoja(btn2Pozicija);


            var btn1Text = PomocneFunkcije.NapraviString(btn1Pozicija);
            var btn2Text = PomocneFunkcije.NapraviString(btn2Pozicija);

            var btn1 = DajMiButton(int.Parse(btn1Text.Substring(3)));
            var btn2 = DajMiButton(int.Parse(btn2Text.Substring(3)));

            if (funkcija == "")
            {
                if (btn1 != null && btn1Boja != bojaFigure && btn1.Text != "")
                {
                    btn1.BackColor = Color.Aquamarine;
                }
                if (btn2 != null && btn2Boja != bojaFigure && btn2.Text != "")
                {
                    btn2.BackColor = Color.Aquamarine;
                }
            }
            else if (funkcija == "napad")
            {

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (InMmemoryDb.GdjeProtivnikMozeNapasti == null)
                    InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();

                if (btn1 != null && btn1Boja != bojaFigure && btn1.Text != "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn1);
                }
                if (btn2 != null && btn2Boja != bojaFigure && btn2.Text != "")
                {
                    InMmemoryDb.GdjeProtivnikMozeNapasti.Add(btn2);
                }
            }
            else if (funkcija == "kretanje")
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (btn1 != null && btn1Boja != bojaFigure && btn1.Text != "")
                {
                    InMmemoryDb.GdjeSeProtivnikKrece.Add(btn1);
                }
                if (btn2 != null && btn2Boja != bojaFigure && btn2.Text != "")
                {
                    InMmemoryDb.GdjeSeProtivnikKrece.Add(btn2);
                }
            }
            else
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (btn1 != null && btn1Boja != bojaFigure && btn1.Text != "")
                {
                    InMmemoryDb.BraneKralja.Add(btn1);
                }
                if (btn2 != null && btn2Boja != bojaFigure && btn2.Text != "")
                {
                    InMmemoryDb.BraneKralja.Add(btn2);
                }
            }
        }

    }

       
}
