using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InMemoryDB;
using Šah;

namespace FunkcijeFiguraLibrary
{


    public class ProvjeraFunkcija
    {
        public static Button ProvjeriDaLiPostoji(string btn1)
        {
            Button btn2 = null;
            foreach (var control in Form1.frm.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = control as Button;
                    if (btn.Name == btn1)
                        return btn;

                }
                //   return btn2;
            }
            return btn2;
        }
        public static bool ProvjeriDaLiButoonImaText(int v)
        {
            string btn1 = FunkcijeFigura.NapraviString(v);
            Button btn2 = ProvjeriDaLiPostoji(btn1);
            if (btn2 != null && btn2.Text != "")
                return true;
            return false;
        }
        public static void ProvjeriButtnon(int v)
        {
            string btn1 = FunkcijeFigura.NapraviString(v);
            Button btn2 = ProvjeriDaLiPostoji(btn1);
            if (btn2 != null && btn2.Text == "")
                btn2.BackColor = Color.Aquamarine;
        }
        public static void ProvjeriVertikalno(int BrojPolja)
        {
            List<int> gornja = new List<int>();
            List<int> donja = new List<int>();
        
            int temp = BrojPolja % 10;
            List<int> lista = FunkcijeFigura.SlobodnaPoljaKolona(temp);
            if (lista.Count == 7)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                   ProvjeriButtnon(lista[i]);
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                if (BrojPolja < lista[i])
                {
                    gornja.Add(lista[i]);

                }
                if (BrojPolja > lista[i])
                {

                    donja.Add(lista[i]);

                }

            }

            ProvjeriGornju(gornja, BrojPolja);
            ProvjeriDonju(donja, BrojPolja);
        }
        public static void ProvjeriDonju(List<int> donja, int c)
        {

            int x = 1;
            for (int i = donja.Count - 1; i >= 0; i--)
            {
                if (c - x * 10 == donja[i])
                {
                    ProvjeriButtnon(donja[i]);
                    if (InMmemoryDb.DonjaV == null)
                    {
                        InMmemoryDb.DonjaV = new List<int>();
                    }
                    InMmemoryDb.DonjaV.Add(donja[i]);

                }
                else
                    return;
                x++;
            }

        }
        public static void ProvjeriGornju(List<int> gornja, int c)
        {
            for (int i = 0; i < gornja.Count; i++)
            {
                if (c + (i + 1) * 10 == gornja[i])
                {
                    ProvjeriButtnon(gornja[i]);
                    if (InMmemoryDb.GornjaV == null)
                    {
                        InMmemoryDb.GornjaV = new List<int>();
                    }
                    InMmemoryDb.GornjaV.Add(gornja[i]);

                }
                else
                    return;
            }
        }


        public static void ProvjeriHorizontalno(int BrojPolja)
        {
            List<int> desna = new List<int>();
            List<int> lijeva = new List<int>();

            int temp = FunkcijeFigura.GetPrviBroj(BrojPolja);
            List<int> lista = FunkcijeFigura.SlobodnaPoljaRed(temp);
            if (lista.Count == 7)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    ProvjeriButtnon(lista[i]);
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                if (BrojPolja < lista[i])
                {
                    desna.Add(lista[i]);

                }
                if (BrojPolja > lista[i])
                {

                    lijeva.Add(lista[i]);

                }

            }

            ProvjeriDesnu(desna, BrojPolja);
            ProvjeriLijevu(lijeva, BrojPolja);


        }
        private static void ProvjeriDesnu(List<int> desna, int c)
        {
            for (int i = 0; i < desna.Count; i++)
            {
                if (c + i + 1 == desna[i])
                {
                   ProvjeriButtnon(desna[i]);
                    if (InMmemoryDb.DesnaH == null)
                    {
                        InMmemoryDb.DesnaH = new List<int>();
                    }
                    InMmemoryDb.DesnaH.Add(desna[i]);
                }
                else
                    return;
            }
        }
        private static void ProvjeriLijevu(List<int> lijeva, int c)
        {
            int x = 1;
            for (int i = lijeva.Count - 1; i >= 0; i--)
            {
                if (c - x == lijeva[i])
                {
                  ProvjeriButtnon(lijeva[i]);
                    if (InMmemoryDb.LijevaH == null)
                    {
                        InMmemoryDb.LijevaH = new List<int>();
                    }

                    InMmemoryDb.LijevaH.Add(lijeva[i]);
                }
                else
                    return;
                x++;
            }
        }

    }
}
