using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InMemoryDB;

namespace Šah.Funkcije
{
    public class FunkcijaVratiDefBoju
    {

        public static void VratiDefBojuPolja(int v,Button btn=null)
        {
           
            if (v != 0)
            {
                string btn1 = PomocneFunkcije.NapraviString(v);
                Button btn2 = Provjeri.ProvjeriDaLiPostoji(btn1);

                if (btn2 != null)
                {
                    int temp = PomocneFunkcije.SumaCifaraBroja(v);
                    if (temp % 2 == 0)
                    {
                        //System.Drawing.SystemColors.ControlDarkDark;
                        btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    }
                    else
                    {

                        btn2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    }
                }
                }
                else {
                if (btn != null)
                {
                    var btnId = int.Parse(btn.Name.Substring(3));
                    int temp = PomocneFunkcije.SumaCifaraBroja(btnId);
                    if (temp % 2 == 0)
                    {
                        //System.Drawing.SystemColors.ControlDarkDark;
                        btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    }
                    else
                    {

                        btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    }
                }
            }
        }

        public static void VratiBoju()
        {
            if (InMmemoryDb.ObojenoPolje != null)
            {
                for (int i = 0; i < InMmemoryDb.ObojenoPolje.Count; i++)
                {
                    VratiDefBojuPolja(0, InMmemoryDb.ObojenoPolje[i]);
                }
                InMmemoryDb.ObojenoPolje = null;
            }
        }
    }
}
