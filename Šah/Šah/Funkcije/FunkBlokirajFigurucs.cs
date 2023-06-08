using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InMemoryDB;

namespace Šah.Funkcije
{
    public class FunkBlokirajFigurucs
    {
        public static bool MoguciNapadFigure(Button btnTrenutni,int kralj,string boja="")
        {
            PomocneFunkcije.CrniIBijeli();
            string bojaFigure;
            var _napad = "napad";
            var nazivFigure = btnTrenutni.Text;          
            btnTrenutni.Text = "";
            if (boja != "")
                bojaFigure = boja;
            else
                bojaFigure = nazivFigure.Substring(0, 2);//PomocneFunkcije.GetBojaStringa(nazivFigure); 

            if (bojaFigure == "CR")
            {
                foreach (var btn in InMmemoryDb.Bijeli)

                {
                    var BijeliBtnId = int.Parse(btn.Name.Substring(3));
                          if(btn.Text == "BI-P")
                          {
                              InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                              Provjeri.KretanjePijuna(BijeliBtnId, _napad);                   
                              if (DaLiNapadaKralja(kralj) == 2)
                              {
                                  btnTrenutni.Text = nazivFigure;
                                  return true;
                              }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else  if (btn.Text == "BI-K")
                    {
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId + 12, "BI", _napad,BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId - 12, "BI", _napad,BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId + 8,  "BI", _napad,BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId - 8,  "BI", _napad,BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId + 19, "BI", _napad,BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId - 19, "BI", _napad,BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId + 21, "BI", _napad,BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(BijeliBtnId - 21, "BI", _napad, BijeliBtnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else  if (btn.Text == "BI-C")
                    {
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                       Provjeri.Horizontalno(BijeliBtnId, kralj, _napad, btn);                   
                        if (DaLiNapadaKralja(kralj)==2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(BijeliBtnId, kralj, _napad, btn); /// dodao
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                    }
                    else if(btn.Text == "BI-B")
                    {
                        Provjeri.GlavnuDijagonalu(BijeliBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(BijeliBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                    }
                    else if(btn.Text == "BI-Kraljica")
                    {
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                        Provjeri.Horizontalno(BijeliBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            //btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(BijeliBtnId, kralj, _napad, btn); //dodao
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.GlavnuDijagonalu(BijeliBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(BijeliBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }

                }
            }
            else
            {
                foreach (var btn in InMmemoryDb.Crni)
                {
                    var CrniBtnId = int.Parse(btn.Name.Substring(3));
                      if (btn.Text == "CR-P")
                      {
                          InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                          Provjeri.KretanjePijuna(CrniBtnId, _napad);
                          if (DaLiNapadaKralja(kralj) == 2)
                          {
                              btnTrenutni.Text = nazivFigure;
                              return true;
                          }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-K")
                    {
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 12, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 12, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 8, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 8, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 19, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 19, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 21, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 21, "CR", _napad);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-C")
                    {
                        Provjeri.Horizontalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-B")
                    {
                        Provjeri.GlavnuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-Kraljica")
                    {
                        Provjeri.Horizontalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.GlavnuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }

                }
            }
            btnTrenutni.Text = nazivFigure;
            return false;

        }

        public static int DaLiNapadaKralja(int kralj)
        {
                 if (InMmemoryDb.GdjeProtivnikMozeNapasti != null)
                  {
                if (DaLiGaIma(kralj))
                  

                    
                        return 2;
                  }
                  return 3;
          //  return kralj == brojPolja;
        }

        public static bool DaLiGaMozeZastiti(int brojPolja,string naziv, int kraljId, Button btn)
        {
            if (btn.Text == "")
                return false;
            var _odbrana = "odbrana";
            var bojaFigure = naziv.Substring(0, 2);// PomocneFunkcije.GetBojaStringa(naziv);
            if (InMmemoryDb.BraneKralja != null)
            {
                if ( DaLiMozeOdbraniti())
                { 
                    return true;
                        }
            }
            else
            {                          
                if (bojaFigure == "CR")
                {
                    if (btn.Text == "CR-P")
                    {                   
                        Provjeri.KretanjePijuna(brojPolja, _odbrana);
                        if (DaLiMozeOdbraniti())
                        {
                            return true;
                        }
                        InMmemoryDb.BraneKralja = null;
                    }
                    else if (btn.Text == "CR-K")
                    {
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 12, "CR", _odbrana);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 12, "CR", _odbrana);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 8, "CR",  _odbrana);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 8, "CR",  _odbrana);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 19, "CR", _odbrana);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 19, "CR", _odbrana);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 21, "CR", _odbrana);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 21, "CR", _odbrana);
                        if (DaLiMozeOdbraniti())
                        {
                            return true;
                        }
                        InMmemoryDb.BraneKralja = null;
                    }

                    else if (btn.Text == "CR-C")
                        {
                            Provjeri.Horizontalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.Vertikalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti() )
                            {
                                return true;
                            }
                        InMmemoryDb.BraneKralja = null;
                    }
                    else if (btn.Text == "CR-B")
                        {
                            Provjeri.GlavnuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.SporednuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                    }
                    else if (btn.Text == "CR-Kraljica")
                        {
                            Provjeri.Horizontalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti() )
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.Vertikalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti() )
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.GlavnuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti()) 
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.SporednuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;                        
                    }
                }
                
                else
                {
                    {
                        if (btn.Text == "BI-P")
                        {
                            InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                            Provjeri.KretanjePijuna(brojPolja,  _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                        }
                        else if (btn.Text == "BI-K")
                        {
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 12, "BI", _odbrana);
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 12, "BI", _odbrana);
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 8,  "BI", _odbrana);
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 8,  "BI", _odbrana);
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 19, "BI", _odbrana);
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 19, "BI", _odbrana);
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja + 21, "BI", _odbrana);
                            Provjeri.ProvjeriButtnoIObojiZaKonja(brojPolja - 21, "BI", _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                        }
                        else   if (btn.Text == "BI-C")
                        {
                            Provjeri.Horizontalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.Vertikalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                        }
                        else if (btn.Text == "BI-B")
                        {
                            Provjeri.SporednuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.GlavnuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                        }
                        else if (btn.Text == "BI-Kraljica")
                        {
                            Provjeri.Horizontalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }

                            InMmemoryDb.BraneKralja = null;
                            Provjeri.Vertikalno(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.SporednuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                            Provjeri.GlavnuDijagonalu(brojPolja, kraljId, _odbrana);
                            if (DaLiMozeOdbraniti())
                            {
                                return true;
                            }
                            InMmemoryDb.BraneKralja = null;
                        }
                    }
                }

            }
            return false;            
        }

        internal static bool DaLiPraviSah(Button btn, int kralj, string obrnutaBoja)
        {
            string bojaFigure;
            var _napad = "napad";
            if (btn == null)
                return false;
            var nazivFigure = btn.Text;
            var btnId = int.Parse(btn.Name.Substring(3));
          //  btnTrenutni.Text = "";
            
                bojaFigure = obrnutaBoja;
          

            if (bojaFigure == "CR")
            {
                
                    if (btn.Text == "BI-P")
                    {
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.KretanjePijuna(btnId, _napad);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btn.Text = nazivFigure;
                            return true;
                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "BI-K")
                    {
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId + 12, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btn.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId - 12, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btn.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId + 8, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btn.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId - 8, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btn.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId + 19, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            btn.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId - 19, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                          //  btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId + 21, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                           // btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        Provjeri.ProvjeriButtnoIObojiZaKonja(btnId - 21, "BI", _napad, btnId);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            //btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "BI-C")
                    {
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Horizontalno(btnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                          //  btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(btnId, kralj, _napad, btn); /// dodao
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                         //   btnTrenutni.Text = nazivFigure;
                            return true;
                        }
                    }
                    else if (btn.Text == "BI-B")
                    {
                        Provjeri.GlavnuDijagonalu(btnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                           // btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(btnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            //btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                    }
                    else if (btn.Text == "BI-Kraljica")
                    {
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                        Provjeri.Horizontalno(btnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                            //btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(btnId, kralj, _napad, btn); //dodao
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                          //  btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.GlavnuDijagonalu(btnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                          //  btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(btnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                         //   btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }

                
            }
            else
            {
               
                    var CrniBtnId = int.Parse(btn.Name.Substring(3));
                    if (btn.Text == "CR-P")
                    {
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.KretanjePijuna(CrniBtnId, _napad);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                           // btnTrenutni.Text = nazivFigure;
                           return true;
                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-K")
                    {
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 12, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 12, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 8, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 8, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 19, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 19, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId + 21, "CR", _napad);
                        Provjeri.ProvjeriButtnoIObojiZaKonja(CrniBtnId - 21, "CR", _napad);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                         //   btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-C")
                    {
                        Provjeri.Horizontalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                       //     btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                        //    btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-B")
                    {
                        Provjeri.GlavnuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                        //    btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                        //    btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }
                    else if (btn.Text == "CR-Kraljica")
                    {
                        Provjeri.Horizontalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                         //   btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.Vertikalno(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                          //  btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.GlavnuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                          //  btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;
                        Provjeri.SporednuDijagonalu(CrniBtnId, kralj, _napad, btn);
                        if (DaLiNapadaKralja(kralj) == 2)
                        {
                         //   btnTrenutni.Text = nazivFigure;
                            return true;

                        }
                        InMmemoryDb.GdjeProtivnikMozeNapasti = null;

                    }

                
            }
          //  btnTrenutni.Text = nazivFigure;
            return false;

        }

        private static bool DaLiMozeOdbraniti()
        {
            if (InMmemoryDb.BraneKralja == null)
                return false;



            foreach (var btn in InMmemoryDb.BraneKralja)
            {
                var btnId = int.Parse(btn.Name.Substring(3));
                var boja = PomocneFunkcije.GetBoja(btnId);
                if (InMmemoryDb.PutanjaPremaKralju != null)
                {
                    var rez = InMmemoryDb.PutanjaPremaKralju.Find(x => int.Parse(x.Name.Substring(3)) == btnId);
                    if (rez != null)
                    {
                            Provjeri.ObojiPolje(rez, boja, "odbrana");

                        return true;
                    }
                }
                // var BTN = Provjeri.DajMiButton(btnId);
             //   if (InMmemoryDb.PutanjaPremaKralju != null)
             //   {

               /*     for (int i = 0; i < InMemoryDB.InMmemoryDb.PutanjaPremaKralju.Count; i++)
                    {
                        var btnuskoci = int.Parse(InMmemoryDb.PutanjaPremaKralju[i].Name.Substring(3));
                        if (btnId == btnuskoci)
                        {
                            Provjeri.ObojiPolje(btn, boja, "odbrana");
                            return true;
                        }
                    }
                }*/
                
            }
            return false;
        }

        private static bool DaLiGaIma(int kralj)
        {         
             var rez = InMmemoryDb.GdjeProtivnikMozeNapasti.Find(x => int.Parse(x.Name.Substring(3)) == kralj);        
          return rez != null;
          
        }
    }
}
