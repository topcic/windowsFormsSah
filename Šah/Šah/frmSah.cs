using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using InMemoryDB;
using Šah.figure;
using Šah.Funkcije;

namespace Šah
{
  
    public partial class frmSah : Form
    {

        readonly Kralj _kralj = new Kralj();
        readonly Kraljica _kraljica = new Kraljica();
        readonly Top _top = new Top();
        readonly Pijun _pijun = new Pijun();
        readonly Bishop _bishop = new Bishop();
        readonly KnightF _knight = new KnightF();

        readonly string _prvi;
        readonly string _drugi;
        string _figuraKojaSeKrece;
        string _figuraKojaStoji="";
        int pozicijeFigureKojaSeKrece = 0;

        int _brojac = 0;
        int _brojacPoteza = 0;
        int _brojacPotezaCopy = 0;


        public static frmSah frm { get; set; }

        public frmSah(string prvi="Mahir", string drugi="Almin")
        {
            InitializeComponent();
            frm = this;
            _prvi = drugi;
            _drugi = prvi;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajParove();
           PoredajFigure();
           AllButton();
           PomocneFunkcije.CrniIBijeli();
           UcitajIgrace();
       
        }

        private void UcitajParove()
        {
            InMmemoryDb.Parovi = new List<Tuple<int, string>>();
            InMmemoryDb.Figure = new List<Tuple<string, string>>();
            InMmemoryDb.Parovi.Add(new Tuple<int, string> (1, "a"));
            InMmemoryDb.Parovi.Add(new Tuple<int, string>(2, "b"));
            InMmemoryDb.Parovi.Add(new Tuple<int, string>(3, "c"));
            InMmemoryDb.Parovi.Add(new Tuple<int, string>(4, "d"));
            InMmemoryDb.Parovi.Add(new Tuple<int, string>(5, "e"));
            InMmemoryDb.Parovi.Add(new Tuple<int, string>(6, "f"));
            InMmemoryDb.Parovi.Add(new Tuple<int, string>(7, "g"));
            InMmemoryDb.Parovi.Add(new Tuple<int, string>(8, "h"));

            InMmemoryDb.Figure.Add(new Tuple<string, string>("P", ""));
            InMmemoryDb.Figure.Add(new Tuple<string, string>("Kralj", "K"));
            InMmemoryDb.Figure.Add(new Tuple<string, string>("Kraljica", "Q"));
            InMmemoryDb.Figure.Add(new Tuple<string, string>("K", "N"));
            InMmemoryDb.Figure.Add(new Tuple<string, string>("B", "B"));
            InMmemoryDb.Figure.Add(new Tuple<string, string>("C", "C"));


        }

        private void UcitajIgrace()
        {
            lblPrvi.Text = _prvi;
            lblDrugi.Text = _drugi;
        }

        private void AllButton()
        {
            if (InMmemoryDb.Svi == null)
            {
                InMmemoryDb.Svi = new List<Button>();
            }
            InMmemoryDb.Svi.Add(btn11);
            InMmemoryDb.Svi.Add(btn12);
            InMmemoryDb.Svi.Add(btn13);
            InMmemoryDb.Svi.Add(btn14);
            InMmemoryDb.Svi.Add(btn15);
            InMmemoryDb.Svi.Add(btn16);
            InMmemoryDb.Svi.Add(btn17);
            InMmemoryDb.Svi.Add(btn18);
            InMmemoryDb.Svi.Add(btn21);
            InMmemoryDb.Svi.Add(btn22);
            InMmemoryDb.Svi.Add(btn23);
            InMmemoryDb.Svi.Add(btn24);
            InMmemoryDb.Svi.Add(btn25);
            InMmemoryDb.Svi.Add(btn26);
            InMmemoryDb.Svi.Add(btn27);
            InMmemoryDb.Svi.Add(btn28);
            InMmemoryDb.Svi.Add(btn31);
            InMmemoryDb.Svi.Add(btn32);
            InMmemoryDb.Svi.Add(btn33);
            InMmemoryDb.Svi.Add(btn34);
            InMmemoryDb.Svi.Add(btn35);
            InMmemoryDb.Svi.Add(btn36);
            InMmemoryDb.Svi.Add(btn37);
            InMmemoryDb.Svi.Add(btn38);
            InMmemoryDb.Svi.Add(btn41);
            InMmemoryDb.Svi.Add(btn42);
            InMmemoryDb.Svi.Add(btn43);
            InMmemoryDb.Svi.Add(btn44);
            InMmemoryDb.Svi.Add(btn45);
            InMmemoryDb.Svi.Add(btn46);
            InMmemoryDb.Svi.Add(btn47);
            InMmemoryDb.Svi.Add(btn48);
            InMmemoryDb.Svi.Add(btn51);
            InMmemoryDb.Svi.Add(btn52);
            InMmemoryDb.Svi.Add(btn53);
            InMmemoryDb.Svi.Add(btn54);
            InMmemoryDb.Svi.Add(btn55);
            InMmemoryDb.Svi.Add(btn56);
            InMmemoryDb.Svi.Add(btn57);
            InMmemoryDb.Svi.Add(btn58);
            InMmemoryDb.Svi.Add(btn61);
            InMmemoryDb.Svi.Add(btn62);
            InMmemoryDb.Svi.Add(btn63);
            InMmemoryDb.Svi.Add(btn64);
            InMmemoryDb.Svi.Add(btn65);
            InMmemoryDb.Svi.Add(btn66);
            InMmemoryDb.Svi.Add(btn67);
            InMmemoryDb.Svi.Add(btn68);
            InMmemoryDb.Svi.Add(btn71);
            InMmemoryDb.Svi.Add(btn72);
            InMmemoryDb.Svi.Add(btn73);
            InMmemoryDb.Svi.Add(btn74);
            InMmemoryDb.Svi.Add(btn75);
            InMmemoryDb.Svi.Add(btn76);
            InMmemoryDb.Svi.Add(btn77);
            InMmemoryDb.Svi.Add(btn78);
            InMmemoryDb.Svi.Add(btn81);
            InMmemoryDb.Svi.Add(btn82);
            InMmemoryDb.Svi.Add(btn83);
            InMmemoryDb.Svi.Add(btn84);
            InMmemoryDb.Svi.Add(btn85);
            InMmemoryDb.Svi.Add(btn86);
            InMmemoryDb.Svi.Add(btn87);
            InMmemoryDb.Svi.Add(btn88);


        }

        private int GetBtnID(Button btn)
        {
            return int.Parse(btn.Name.Substring(3));
        }
        private void PoredajFigure()
        {
            BijeleFigure();
             CrneFigure();
                  
          
         // testic();
//
           
         

        }

        private void CrneFigure()
        {
            btn11.Text = btn18.Text = _top.Crni;
            btn12.Text = btn17.Text = _knight.Crni;

            btn13.Text = btn16.Text = _bishop.Crni;
            btn14.Text = _kraljica.Crni;
            btn15.Text = _kralj.Crni;
            btn21.Text = btn22.Text = btn23.Text = btn24.Text = btn25.Text = btn26.Text = btn27.Text = btn28.Text = _pijun.Crni;
        }

        private void BijeleFigure()
        {
            btn81.Text = btn88.Text = _top.Bijeli;
            btn82.Text = btn87.Text = _knight.Bijeli;
            btn83.Text = btn86.Text = _bishop.Bijeli;
            btn84.Text = _kraljica.Bijeli;
            btn85.Text = _kralj.Bijeli;
            btn71.Text = btn72.Text = btn73.Text = btn74.Text = btn75.Text = btn76.Text = btn77.Text = btn78.Text = _pijun.Bijeli;
        }

        private void testic()
        {
            btn45.Text = _kraljica.Bijeli;
            btn15.Text = _kralj.Crni;
            // btn85.Text = _kralj.Bijeli;
            btn11.Text = _kralj.Bijeli;


        }

        public int GetKing(string bojaFigure)
        {
            if (bojaFigure == "BI")
            {
                foreach (var btn in InMmemoryDb.Bijeli)
                {
                    if (btn.Text == "BI-Kralj")
                        return GetBtnID(btn);                   
                }
            }
            else
            {
                foreach(var btn in InMmemoryDb.Crni)
                {
                    if (btn.Text == "CR-Kralj")
                        return GetBtnID(btn);
                }
            }
            return 0;
        }

        private void Prikazi(Button btn)  // mjesta gdje se figura moze pomjeriti
        {
            if (btn.Text == "")
                return;

            InMemoryDB.InMmemoryDb.Dozvoli = null;
            InMemoryDB.InMmemoryDb.Dozvoli = new List<Button>();

            var boja = btn.Text.Substring(0,2); //PomocneFunkcije.GetBojaStringa(btn.Text)

            if (_brojac % 2 != 0 && boja == "BI")
                return;
            else if (_brojac % 2 == 0 && boja == "CR")
                return;
                InMmemoryDb.BraneKralja = null;
            InMmemoryDb.GdjeProtivnikMozeNapasti = null;
            PomocneFunkcije.CrniIBijeli();
                                                                             //  InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
        
            var naziv = btn.Text;
                                                                                                //    GlavneFunkcije.ProtivnikMjestaNapada(boja); // mjesta gdje protivnik moze napasti
          var KraljId = GetKing(boja); // broj btn gdje se nalazi kralj
                                       // ProvjeriKralja(btn,boja);
                                       //  InMmemoryDb.GdjeProtivnikMozeNapasti = null;
            if (btn.Text != "BI-Kralj" && btn.Text != "CR-Kralj")
            {

                   if (FunkBlokirajFigurucs.MoguciNapadFigure(btn, KraljId))
                   {
              //      MessageBox.Show("sah");
                    btn.Text = naziv;
                    InMmemoryDb.PutanjaPremaKralju = null;
                       InMmemoryDb.PutanjaPremaKralju = new List<Button>();
                       InMmemoryDb.PutanjaPremaKralju = InMmemoryDb.GdjeProtivnikMozeNapasti;
              

                if (FunkBlokirajFigurucs.DaLiGaMozeZastiti(int.Parse(btn.Name.Substring(3)), btn.Text, KraljId, btn))
                {
                    InMmemoryDb.BraneKralja = null;
                    Provjeri.ProvjeriObojeniButton();
                    return;

                }
                else
                    return;
            }
             
         
          }

            OcistiIAlociraj();
            //  var boja = PomocneFunkcije.GetBojaStringa(btn.Text);
            GlavneFunkcije.ProtivnikMjestaNapada(boja);
            int BrojPolja = GetBtnID(btn);
            if (_brojac%2 == 0)
                BijeliIgra(btn, BrojPolja);
            else
            CrniIgra(btn, BrojPolja);
        }

        private void OcistiIAlociraj()
        {
            InMmemoryDb.GdjeProtivnikMozeNapasti = null;
            InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
            InMmemoryDb.GdjeSeProtivnikKrece = null;
            InMmemoryDb.GdjeSeProtivnikKrece = new List<Button>();
            InMmemoryDb.ListaKretanja = null;
            InMmemoryDb.ListaKretanja = new List<int>();
        }

        private void CrniIgra(Button btn, int BrojPolja)
        {
            if ( btn.Text == "CR-P")
            {
                Pijun pijun = new Pijun();
                pijun.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if ( btn.Text == "CR-K")
            {
                KnightF konj = new KnightF();
                konj.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if ( btn.Text == "CR-C")
            {
                Top top = new Top();
                top.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if ( btn.Text == "CR-B")
            {
                Bishop bishop = new Bishop();
                bishop.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if ( btn.Text == "CR-Kralj")
            {
                Kralj kralj = new Kralj();
                kralj.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if ( btn.Text == "CR-Kraljica")
            {
                Kraljica kraljica = new Kraljica();
                kraljica.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }

        }

        private void BijeliIgra(Button btn, int BrojPolja)
        {
            if (btn.Text == "BI-P" )
            {
                Pijun pijun = new Pijun();
                pijun.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if (btn.Text == "BI-K" )
            {
                KnightF konj = new KnightF();
                konj.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if (btn.Text == "BI-C" )
            {
                Top top = new Top();
                top.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if (btn.Text == "BI-B" )
            {
                Bishop bishop = new Bishop();
                bishop.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if (btn.Text == "BI-Kralj" )
            {
                Kralj kralj = new Kralj();
                kralj.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
            else if (btn.Text == "BI-Kraljica" )
            {
                Kraljica kraljica = new Kraljica();
                kraljica.Kretanje(BrojPolja);
                Provjeri.ProvjeriObojeniButton();
            }
        }

        private void Vrati(Button btn)
        {
            string temp = btn.Name;
            string novi = "";
            for (int i = 3; i < temp.Length; i++)
            {
                novi += temp[i];
            }
            int BrojPolja = Int16.Parse(novi);
            if (btn.Text == "BI-P" || btn.Text == "CR-P")
            {
                Pijun pijun = new Pijun();
                pijun.MouseLeave(BrojPolja);
            }
           else if (btn.Text == "BI-K" || btn.Text == "CR-K")
            {
                KnightF konj = new KnightF();
                konj.MouseLeave(BrojPolja);
            }
            else if (btn.Text == "BI-C" || btn.Text == "CR-C")
            {
                Top top = new Top();
                top.MouseLeave(BrojPolja);
            }
            else if (btn.Text == "BI-B" || btn.Text == "CR-B")
            {
                Bishop bishop = new Bishop();
                bishop.MouseLeave(BrojPolja);
            }
            else if (btn.Text == "BI-Kralj" || btn.Text == "CR-Kralj")
            {
                Kralj kralj = new Kralj();
                kralj.MouseLeave(BrojPolja);
            }
            else if (btn.Text == "BI-Kraljica" || btn.Text == "CR-Kraljica")
            {
                Kraljica kraljica = new Kraljica();
                kraljica.MouseLeave(BrojPolja);
            }
          
        }


        private void btn14_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Prikazi(btn);
        }

        private void btn14_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Vrati(btn);
        }

     
        private void btn87_MouseDown(object sender, MouseEventArgs e)
        {
          
            for (int i = 0; i < InMemoryDB.InMmemoryDb.Dozvoli.Count; i++)
            {
                InMmemoryDb.Dozvoli[i].AllowDrop = true;
            }
            var btn = sender as Button;
           

            if (btn.Text != "")
            {
                pozicijeFigureKojaSeKrece = int.Parse(btn.Name.Substring(3));

            }

            //if(   ((Button)sender).DoDragDrop(((Button)sender).Text, DragDropEffects.Move)!= DragDropEffects.None)
            if (btn.DoDragDrop(btn.Text, DragDropEffects.Move) != DragDropEffects.None)
            {
                pozicijeFigureKojaSeKrece = 0;
                var figura = btn.Text;
              
                btn.Text = "";
                DaLiPraviSah(figura);
            }
          
        }

        private void DaLiPraviSah(string figura)
        {
            var btn = InMmemoryDb.CopyDozvoli.Find(x => x.Text == figura);
            var boja = figura.Substring(0, 2); //PomocneFunkcije.GetBojaStringa(figura);
            var obrnutaBoja = ObrniBoju(boja);
            var KraljId = GetKing(obrnutaBoja);
         

            if (FunkBlokirajFigurucs.DaLiPraviSah(btn, KraljId, obrnutaBoja)|| FunkBlokirajFigurucs.MoguciNapadFigure(btn, KraljId,obrnutaBoja)) // Radi za jedan btn
            {
                InMmemoryDb.PutanjaPremaKralju = null;
                InMmemoryDb.PutanjaPremaKralju = new List<Button>();
                InMmemoryDb.PutanjaPremaKralju = InMmemoryDb.GdjeProtivnikMozeNapasti;
                if (DaLiFigureMoguOdbraniti(KraljId, obrnutaBoja))
                    MessageBox.Show("Sah");
                else if (DaLiKraljMozePobjeci(btn, KraljId))
                    MessageBox.Show("Sah");
                else
                {
                    var br = txtTabla.Text.Length;
                    var txt = txtTabla.Text.Substring(0, br - 1) + "#";
                    txtTabla.Text = txt;
                    MessageBox.Show("Sah mat");
                 
                }
            }
        }

        private bool DaLiFigureMoguOdbraniti(int kraljId, string boja)
        {
            PomocneFunkcije.CrniIBijeli();
            if (boja == "CR")
            {
                foreach (var btn in InMmemoryDb.Crni)
                {
              //      if (int.Parse(btn.Name.Substring(3)) == 14) {
                        if (FunkBlokirajFigurucs.DaLiGaMozeZastiti(int.Parse(btn.Name.Substring(3)), btn.Text, kraljId, btn))
                        {
                            InMmemoryDb.BraneKralja = null;

                            return true;
                        }
                        
               //     }
                }
                return false;
            }
            else
            {
                foreach (var btn in InMmemoryDb.Bijeli)
                {

                    if (FunkBlokirajFigurucs.DaLiGaMozeZastiti(int.Parse(btn.Name.Substring(3)), btn.Text, kraljId, btn))
                    {
                        InMmemoryDb.BraneKralja = null;

                        return true;

                    }
                }
                return false;
            }
        }

        private bool DaLiKraljMozePobjeci(Button btn, int kraljId)
        {


            var boja = btn.Text.Substring(0, 2); // PomocneFunkcije.GetBojaStringa(btn.Text);
            OcistiIAlociraj2();
            
            var obrutaBoja = ObrniBoju(boja);
            PomocneFunkcije.CrniIBijeli();

            //  var boja = PomocneFunkcije.GetBojaStringa(btn.Text);
            GlavneFunkcije.ProtivnikMjestaNapada(obrutaBoja);
            Kralj kralj = new Kralj();
            kralj.Kretanje(kraljId,"kretanje");
            return DaLiSeKraljMozeKretati();
        }

        private void OcistiIAlociraj2()
        {
            InMmemoryDb.GdjeProtivnikMozeNapasti = null;
            InMmemoryDb.GdjeProtivnikMozeNapasti = new List<Button>();
            InMmemoryDb.GdjeSeProtivnikKrece = null;
            InMmemoryDb.GdjeSeProtivnikKrece = new List<Button>();
            InMmemoryDb.KretanjeKralja = null;
            InMmemoryDb.KretanjeKralja = new List<int>();
            InMmemoryDb.ListaKretanja = null;
            InMmemoryDb.ListaKretanja = new List<int>();
        }

        private bool DaLiSeKraljMozeKretati()
        {
            return InMmemoryDb.KretanjeKralja.Count > 0;
        }

        private void btn87_DragEnter(object sender, DragEventArgs e)
        {
            var btn = sender as Button;
            e.Effect = DragDropEffects.Move;
        }

        private void btn87_DragDrop(object sender, DragEventArgs e)
        {
            var btn = (Button)sender;
           // int figuraKojaStojiPrvaCifra  = 0;
           // var figuraKojaStojiDrugaCifra = 0;
            _figuraKojaStoji = btn.Text;
          //  if (btn.Text != "")
          //  {

          //}
            btn.Text =_figuraKojaSeKrece= e.Data.GetData(DataFormats.Text).ToString();

            var boja = btn.Text.Substring(0, 2);// PomocneFunkcije.GetBojaStringa(btn.Text);
              // var obrnutaBoja = ObrniBoju(boja);
               var brojPolja = int.Parse(btn.Name.Substring(3));
            var prvaCifra = PomocneFunkcije.GetPrviBroj(brojPolja);
            var drugaCifra = brojPolja % 10;
            UnesiUTablu(prvaCifra,drugaCifra);
              
             if((btn.Text == "BI-P" && prvaCifra==1) || (btn.Text == "CR-P" && prvaCifra == 8))
             {
                 var rez = (new promocija.frmPromocija(boja)).ShowDialog();
                 if (rez == DialogResult.OK)
                     btn.Text = $"{boja}-Kraljica";
                 else if(rez==DialogResult.Yes)
                     btn.Text = $"{boja}-B";
                 else if(DialogResult.No==rez)
                     btn.Text = $"{boja}-K";
                 else
                     btn.Text= $"{boja}-C";
             }
               _brojac++;
            MoveList();
        }

        private void UnesiUTablu(int prvaCifra, int drugaCifra)
        {
            var par = InMmemoryDb.Parovi.Find(x => x.Item1 == drugaCifra);
            if (_brojac % 2 == 0)
                _brojacPoteza++;
            var figura = _figuraKojaSeKrece.Substring(3);
            var oznaka = InMmemoryDb.Figure.Find(x => x.Item1 == figura);
            if (_brojacPoteza != _brojacPotezaCopy)
            {
                if (_figuraKojaStoji == "")
                    txtTabla.Text += $"{_brojacPoteza}. {oznaka.Item2}{par.Item2}{prvaCifra} ";
                else
                {
                    var poz1 = pozicijeFigureKojaSeKrece % 10;
                    var par2 = InMmemoryDb.Parovi.Find(x => x.Item1 == poz1);
                    if(oznaka.Item2=="")
                       txtTabla.Text += $"{_brojacPoteza}. {par2.Item2}{oznaka.Item2}x{par.Item2}{prvaCifra} ";
                    else
                        txtTabla.Text += $"{_brojacPoteza}. {oznaka.Item2}x{par.Item2}{prvaCifra} ";

                }


            }
            else
            {
                if (_figuraKojaStoji == "")
                    txtTabla.Text += $"{oznaka.Item2}{par.Item2}{prvaCifra} ";
                else
                {
                    var poz1 = pozicijeFigureKojaSeKrece % 10;
                    var par2 = InMmemoryDb.Parovi.Find(x => x.Item1 == poz1);
                    if (oznaka.Item2 == "")
                        txtTabla.Text += $"{par2.Item2}{oznaka.Item2}x{par.Item2}{prvaCifra} ";
                    else
                        txtTabla.Text += $"{oznaka.Item2}x{par.Item2}{prvaCifra} ";

                }

            }

            _brojacPotezaCopy = _brojacPoteza;
          
        }

        private void MoveList()
        {
            if (InMmemoryDb.CopyDozvoli == null)
                InMmemoryDb.CopyDozvoli = new List<Button>();
            foreach (var btn in InMmemoryDb.Dozvoli)
            {
                InMmemoryDb.CopyDozvoli.Add(btn);
                btn.AllowDrop = false;
            }
        }

     
        private string ObrniBoju(string boja)
        {
            if (boja == "BI")
                return "CR";
            else
                return "BI";


        }

    
    }
    }
    
    
    
    
    

