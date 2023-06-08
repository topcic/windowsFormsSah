using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Šah.Funkcije
{
  public  class Sortiraj
    {
        public static void Silazno(List<int> donja)
        {
            int temp;
            bool prolaz = true;
            int j = 0;
            while (prolaz)
            {
                prolaz = false;
                j++;

                for (int i = 0; i < donja.Count - j; i++)
                {
                    if (donja[i] < donja[i + 1])
                    {
                        temp = donja[i];
                        donja[i] = donja[i + 1];
                        donja[i + 1] = temp;
                        prolaz = true;
                    }
                }
            }
        }
        public static void Uzlazno(List<int> donja)
        {

            int temp;
            bool prolaz = true;
            int j = 0;
            while (prolaz)
            {
                prolaz = false;
                j++;

                for (int i = 0; i < donja.Count - j; i++)
                {
                    if (donja[i] > donja[i + 1])
                    {
                        temp = donja[i];
                        donja[i] = donja[i + 1];
                        donja[i + 1] = temp;
                        prolaz = true;
                    }
                }
            }
        }
    }
}
