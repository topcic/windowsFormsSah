using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLibrary1;
using Šah.Funkcije;
using InMemoryDB;

namespace Šah.figure
{
    public class Top : IFigure
    {
        public string Bijeli { get; set; }
        public string Crni { get; set; }
        public Top()
        {
            Bijeli = "BI-C";
            Crni = "CR-C";
        }
        public void Kretanje(int brojPolja, string funkcija = "")
        {
            Provjeri.Horizontalno(brojPolja);
            Provjeri.Vertikalno(brojPolja);
        }

        public void MouseLeave(int brojPolja)
        {
            FunkcijaVratiDefBoju.VratiBoju();
                    
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
            Provjeri.Horizontalno(brojPolja, 0, "kretanje");
            Provjeri.Vertikalno(brojPolja, 0, "kretanje");
        }
    }
}
