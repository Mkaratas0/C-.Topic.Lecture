using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.Interfaces
{
    public partial class FrmEvrim : Form
    {
        public FrmEvrim()
        {
            InitializeComponent();
        }

        private void btnEvrim_Click(object sender, EventArgs e)
        {
            Dinozor tRex = new Dinozor();
            GriKurt kurt = new GriKurt();

            //MessageBox.Show(tRex.Turler[tRex.Seviye]);
            MessageBox.Show(kurt.Turler[kurt.Seviye]);
            //MessageBox.Show(tRex.AdapteOl());

            MessageBox.Show(kurt.EvrimGecir("Şivava"));

        }
    }
}
