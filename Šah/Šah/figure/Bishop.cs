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
    public class Bishop : IFigure
    {
        public string Bijeli { get; set; }
        public string Crni { get; set; }
       
        public  Bishop()
        {
            Bijeli = "BI-B";
            Crni = "CR-B";
        }

        public void Kretanje(int brojPolja,string funkcija="")
        {
            Provjeri.GlavnuDijagonalu(brojPolja);
            Provjeri.SporednuDijagonalu(brojPolja);
        }

        public void MouseLeave(int brojPolja)
        {
            FunkcijaVratiDefBoju.VratiBoju();

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

        }

        public void TackeNapada(int brojPolja)
        {
          
            Provjeri.GlavnuDijagonalu(brojPolja ,0  , "kretanje");
            Provjeri.SporednuDijagonalu(brojPolja,0, "kretanje");
        }
    }
}
