using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Šah.promocija
{
    public partial class frmPromocija : Form
    {
        string _boja;
        public frmPromocija( string boja)
        {
            InitializeComponent();
            _boja = boja;
        }

        private void frmPromocija_Load(object sender, EventArgs e)
        {
            UcitajFigure();
            
        }

        private void UcitajFigure()
        {
            btnKraljica.Text = $"{_boja}-Kraljica";
            btnKnight.Text= $"{_boja}-K";
            btnTop.Text= $"{_boja}-C";
            btnBishop.Text= $"{_boja}-B";
        }

        private void btnKraljica_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnBishop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;

        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;

        }
    }
}
