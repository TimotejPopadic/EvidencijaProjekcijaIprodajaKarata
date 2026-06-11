using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba_3_evid_projekcijaIprodajaKarata
{
    public partial class Registrujse : Form
    {
        public Registrujse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ulogujse form3 = new Ulogujse();
            form3.Show();
            this.Hide();
        }
    }
}
