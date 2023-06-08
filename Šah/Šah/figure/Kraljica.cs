using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InMemoryDB;
using InterfaceLibrary1;
using Šah.Funkcije;

namespace Šah.figure
{
    public class Kraljica : IFigure
    {
        public string Bijeli { get; set; }
        public string Crni { get; set; }
        public Kraljica()
        {
            Bijeli = "BI-Kraljica";
            Crni = "CR-Kraljica";
        }
        public void Kretanje(int brojPolja, string funkcija = "")
        {
            Provjeri.ProvjeriButtnoIOboji(brojPolja + 10,PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.ProvjeriButtnoIOboji(brojPolja - 10, PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.ProvjeriButtnoIOboji(brojPolja + 1,PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.ProvjeriButtnoIOboji(brojPolja - 1,PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.ProvjeriButtnoIOboji(brojPolja + 9,PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.ProvjeriButtnoIOboji(brojPolja - 9, PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.ProvjeriButtnoIOboji(brojPolja + 11,PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.ProvjeriButtnoIOboji(brojPolja - 11, PomocneFunkcije.GetBoja(brojPolja));
            Provjeri.GlavnuDijagonalu(brojPolja);
            Provjeri.SporednuDijagonalu(brojPolja);
            Provjeri.Horizontalno(brojPolja);
            Provjeri.Vertikalno(brojPolja);

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
            if (InMmemoryDb.DesnaGD != null)
            {
                for (int i = 0; i < InMmemoryDb.DesnaGD.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.DesnaGD[i]);
                }
            }

            if (InMmemoryDb.LijevaGD != null)
            {
                for (int i = 0; i < InMmemoryDb.LijevaGD.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.LijevaGD[i]);
                }
            }
            if (InMmemoryDb.DesnaSD != null)
            {
                for (int i = 0; i < InMmemoryDb.DesnaSD.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.DesnaSD[i]);
                }
            }

            if (InMmemoryDb.LijevaSD != null)
            {
                for (int i = 0; i < InMmemoryDb.LijevaSD.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.LijevaSD[i]);
                }
            }
            if (InMmemoryDb.DesnaH != null)
            {
                for (int i = 0; i < InMmemoryDb.DesnaH.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.DesnaH[i]);
                }
            }

            if (InMmemoryDb.LijevaH != null)
            {
                for (int i = 0; i < InMmemoryDb.LijevaH.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.LijevaH[i]);
                }
            }


            if (InMmemoryDb.GornjaV != null)
            {
                for (int i = 0; i < InMmemoryDb.GornjaV.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.GornjaV[i]);
                }
            }
            if (InMmemoryDb.DonjaV != null)
            {
                for (int i = 0; i < InMmemoryDb.DonjaV.Count; i++)
                {
                    FunkcijaVratiDefBoju.VratiDefBojuPolja(InMmemoryDb.DonjaV[i]);
                }
            }
        }

        public void TackeNapada(int brojPolja)
        {
            var lista = InMmemoryDb.ListaKretanja;

            Provjeri.GlavnuDijagonalu(brojPolja, 0, "kretanje");
            var lista3 = InMmemoryDb.ListaKretanja;
            Provjeri.SporednuDijagonalu(brojPolja, 0, "kretanje");
            var lista2 = InMmemoryDb.ListaKretanja;

            Provjeri.Horizontalno(brojPolja, 0, "kretanje");
            Provjeri.Vertikalno(brojPolja, 0, "kretanje");
            var boja = PomocneFunkcije.GetBoja(brojPolja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 10, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 10,boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 1, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 1, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 9, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 9, boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja + 11,boja);
            Provjeri.ProvjeriButtnonZaListeKretanja(brojPolja - 11, boja);

        }
    }
}
