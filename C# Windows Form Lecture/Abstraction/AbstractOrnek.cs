using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.Abstraction
{
    public partial class AbstractOrnek : Form
    {
        public AbstractOrnek()
        {
            InitializeComponent();
        }

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            InstagramPaylasimi insta = new InstagramPaylasimi();
        }
    }
}
