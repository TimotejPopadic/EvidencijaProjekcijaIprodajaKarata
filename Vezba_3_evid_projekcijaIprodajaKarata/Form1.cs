namespace Vezba_3_evid_projekcijaIprodajaKarata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ulogujse form1 = new Ulogujse();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrujse form2 = new Registrujse();
            form2.Show();
            this.Hide();
        }
    }
}
