using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Šah.Igraci
{
    public partial class frmIgraci : Form
    {
        public frmIgraci()
        {
            InitializeComponent();
        }

        private void frmIgraci_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            var prvi = txtPrvi.Text;
            var drugi = txtDrugi.Text;
            (new frmSah(prvi, drugi)).Show();
         //   if ((new frmSah(prvi, drugi)).ShowDialog() == DialogResult.Yes)
         //     this.Close();

        }
    }
}
