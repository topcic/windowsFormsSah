using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceLibrary1;
using Šah.Funkcije;

namespace Šah.figure
{
    public class Kralj : IFigure
    {
        public string Bijeli { get; set; }
        public string Crni { get; set; }
        public Kralj()
        {
            Bijeli = "BI-Kralj";
            Crni = "CR-Kralj";
        }
        public void Kretanje(int brojPolja,string funkcija="")

        {
            //FunkcijeZaProvjeruPolja.ProtivnikMjestaNapada(PomocneFunkcije.GetBoja(brojPolja));
           // GlavneFunkcije.ProtivnikMjestaNapada(PomocneFunkcije.GetBoja(brojPolja));
            /*for(int i = 0; i < InMemoryDB.InMmemoryDb.GdjeProtivnikMozeNapasti.Count; i++)
            {
                Button btn = InMemoryDB.InMmemoryDb.GdjeProtivnikMozeNapasti[i] as Button;
                System.Windows.Forms.MessageBox.Show($"{i}   {btn.Name}");
            }*/
            var boja= PomocneFunkcije.GetBoja(brojPolja);
            Provjeri.ProvjeriButtnonZaKralja(brojPolja + 10,boja,funkcija);
            Provjeri.ProvjeriButtnonZaKralja(brojPolja - 10,boja,funkcija );
            Provjeri.ProvjeriButtnonZaKralja(brojPolja + 1, boja,funkcija);
            Provjeri.ProvjeriButtnonZaKralja(brojPolja - 1, boja,funkcija);
            Provjeri.ProvjeriButtnonZaKralja(brojPolja + 9, boja,funkcija);
            Provjeri.ProvjeriButtnonZaKralja(brojPolja - 9, boja,funkcija);
            Provjeri.ProvjeriButtnonZaKralja(brojPolja + 11,boja,funkcija);
            Provjeri.ProvjeriButtnonZaKralja(brojPolja - 11, boja,funkcija);
        }

        public void MouseLeave(int brojPolja)
        {
            FunkcijaVratiDefBoju.VratiBoju();

            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 10);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 10);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 1);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 1);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 9);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 9);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja + 11);
            FunkcijaVratiDefBoju.VratiDefBojuPolja(brojPolja - 11);
        }

        public void TackeNapada(int brojPolja)
        {
            var boja = PomocneFunkcije.GetBoja(brojPolja);

            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 10, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 10, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 1, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 1, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 9, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 9, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 11, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 11, boja);

        }
    }
}
