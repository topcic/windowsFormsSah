using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLibrary1;
using Šah.Funkcije;

namespace Šah.figure
{
    class KnightF:IFigure
    {
        public string Bijeli { get; set; }
        public string Crni { get; set; }
        public KnightF()
        {
            Bijeli = "BI-K";
            Crni = "CR-K";
        }
        public void Kretanje(int brojPolja, string funkcija = "")
        {
            var boja = PomocneFunkcije.GetBoja(brojPolja);
          Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 12,boja);
          Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 12,boja);
          Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 8, boja);
          Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 8, boja);
          Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 19,boja);
          Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 19,boja);
          Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 21, boja);
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 21, boja);
        }

        public void MouseLeave(int brojPolja)
        {
            FunkcijaVratiDefBoju.VratiBoju();

            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 12);
           FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 12);
           FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 8);
           FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 8);
           FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 19);
           FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 19);
           FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 21);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 21);
        }

        public void TackeNapada(int brojPolja)
        {
            var boja = PomocneFunkcije.GetBoja(brojPolja);
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 12, boja, "kretanje");
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 12, boja, "kretanje" );
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 8, boja , "kretanje" );
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 8, boja , "kretanje" );
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 19, boja, "kretanje" );
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 19, boja, "kretanje" );
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 21, boja, "kretanje" );
            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 21, boja, "kretanje") ;
        }
    }
}

