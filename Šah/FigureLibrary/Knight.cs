using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLibrary1;
using FunkcijeFiguraLibrary;
namespace FigureLibrary
{
    public class Knight : IFigure
    {
        public  void Kretanje(int brojPolja)
        {
           ProvjeraFunkcija.ProvjeriButtnon(brojPolja + 12);
            ProvjeraFunkcija.ProvjeriButtnon(brojPolja - 12);
            ProvjeraFunkcija.ProvjeriButtnon(brojPolja + 8);
            ProvjeraFunkcija.ProvjeriButtnon(brojPolja - 8);
            ProvjeraFunkcija.ProvjeriButtnon(brojPolja + 19);
            ProvjeraFunkcija.ProvjeriButtnon(brojPolja - 19);
            ProvjeraFunkcija.ProvjeriButtnon(brojPolja + 21);
            ProvjeraFunkcija.ProvjeriButtnon(brojPolja - 21);
        }

        public  void MouseLeave(int brojPolja)
        {
            VratiDefBoju.VratiDefBojuPolja(brojPolja + 12);
            VratiDefBoju.VratiDefBojuPolja(brojPolja - 12);
            VratiDefBoju.VratiDefBojuPolja(brojPolja + 8);
            VratiDefBoju.VratiDefBojuPolja(brojPolja - 8);
            VratiDefBoju.VratiDefBojuPolja(brojPolja + 19);
            VratiDefBoju.VratiDefBojuPolja(brojPolja - 19);
            VratiDefBoju.VratiDefBojuPolja(brojPolja + 21);
            VratiDefBoju.VratiDefBojuPolja(brojPolja - 21);
        }
    }
}
