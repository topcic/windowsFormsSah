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
    
    public class FunkcijeFigura
    {
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
        public static bool IsEmptyKolona(int c, int i)
        {
            int temp = i * 10 + c;
            string btn1 = NapraviString(temp);
            Button btn2 = ProvjeraFunkcija.ProvjeriDaLiPostoji(btn1);
            if (btn2 != null && btn2.Text == "")
                return true;
            return false;
        }
        public static List<int> SlobodnaPoljaKolona(int temp)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                if (IsEmptyKolona(temp, i + 1))
                    lista.Add((i + 1) * 10 + temp);
            }
            return lista;
        }
        public static string NapraviString(int v)
        {
            string temp = "btn" + v;
            return temp;
        }
       
        public static bool IsEmpty(int c, int i)
        {
            int temp = c * 10 + i;
            string btn1 = NapraviString(temp);
            Button btn2 = ProvjeraFunkcija.ProvjeriDaLiPostoji(btn1);
            if (btn2 != null && btn2.Text == "")
                return true;
            return false;
        }
        public static List<int> SlobodnaPoljaRed(int temp)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                if (IsEmpty(temp, i + 1))
                    lista.Add(temp * 10 + i + 1);
            }
            return lista;
        }
  


    }
}

