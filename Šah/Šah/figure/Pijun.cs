using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLibrary1;
using Šah.Funkcije;

namespace Šah.figure
{
    class Pijun : IFigure
    {
        public string Bijeli { get; set; }
        public string Crni { get; set; }
        public Pijun()
        {
            Bijeli = "BI-P";
            Crni = "CR-P";
        }
        public void Kretanje(int brojPolja, string funkcija = "")
        {
            Provjeri.KretanjePijuna(brojPolja);
        }

        public void MouseLeave(int brojPolja)
        {
            FunkcijaVratiDefBoju.VratiBoju();

            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 10);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 20);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 11);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 9);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 10);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 20);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 11);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 9);

        }

        public void TackeNapada(int brojPolja)
        {
            //  NapadOdbrana.PijunNapadOdbrana(brojPolja, PomocneFunkcije.GetBoja(brojPolja), "napad");
            Provjeri.KretanjePijuna(brojPolja, "kretanje");
           
        }
    }
}
