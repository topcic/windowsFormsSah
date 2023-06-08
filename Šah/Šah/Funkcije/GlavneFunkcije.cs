
using System.Windows.Forms;
using InMemoryDB;
using Šah.figure;

namespace Šah.Funkcije
{
    public class GlavneFunkcije
    {
       public static void ProtivnikMjestaNapada(string boja) 
        {          
            if (boja == "CR")
            {
                for (int i = 0; i < InMmemoryDb.Bijeli.Count; i++)
                {
                    Button btn = InMmemoryDb.Bijeli[i];
                    int BrojPolja = int.Parse(btn.Name.Substring(3));              
                    if (btn.Text == "BI-K")
                    {
                        KnightF konj = new KnightF();
                        konj.TackeNapada(BrojPolja);                     
                    }
                    else if (btn.Text == "BI-C")
                    {
                        Top top = new Top();
                        top.TackeNapada(BrojPolja);                      
                    }
                    else if (btn.Text == "BI-B")
                    {
                        Bishop bishop = new Bishop();
                        bishop.TackeNapada(BrojPolja);                      
                    }
                     else if (btn.Text == "BI-Kralj")
                     {
                         Kralj kralj = new Kralj();
                         kralj.TackeNapada(BrojPolja);                   
                     }
                    else if (btn.Text == "BI-Kraljica")
                    {
                        Kraljica kraljica = new Kraljica();
                        kraljica.TackeNapada(BrojPolja);
                    }
                    else if (btn.Text == "BI-P")
                    {
                        Pijun pijun = new Pijun();
                        pijun.TackeNapada(BrojPolja);                     
                   }
                }
            }
            else
            {
                for (int i = 0; i < InMmemoryDb.Crni.Count; i++)
                {
                    Button btn = InMmemoryDb.Crni[i];
                    int BrojPolja = int.Parse(btn.Name.Substring(3));             
                    if (btn.Text == "CR-K")
                    {
                        KnightF konj = new KnightF();
                        konj.TackeNapada(BrojPolja);
                    }
                    else if (btn.Text == "CR-C")
                    {
                        Top top = new Top();
                        top.TackeNapada(BrojPolja);
                    }
                    else if (btn.Text == "CR-B")
                    {
                        Bishop bishop = new Bishop();
                        bishop.TackeNapada(BrojPolja);
                    }
                       else if (btn.Text == "CR-Kralj")
                       {
                           Kralj kralj = new Kralj();
                           kralj.TackeNapada(BrojPolja);
                       }
                    else if (btn.Text == "CR-Kraljica")
                    {
                        Kraljica kraljica = new Kraljica();
                        kraljica.TackeNapada(BrojPolja);
                    }
                    else if (btn.Text == "CR-P")
                    {
                        Pijun pijun = new Pijun();
                        pijun.TackeNapada(BrojPolja);
                   }
                }
            }
        }
    }
}
