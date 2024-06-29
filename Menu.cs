using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistMensaSUNARP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegEnvioArea i = new RegEnvioArea();
            i.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Usuario i = new Usuario();
            i.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Destinos i = new Destinos();
            i.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Portador i = new Portador();
            i.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Oficina i = new Oficina();
            i.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListEnvios i = new ListEnvios();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaCargosRet i = new BusquedaCargosRet();
            i.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegCargosC i = new RegCargosC();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnvioExterno i = new EnvioExterno();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnvioInterno i = new EnvioInterno();
            i.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pp i = new pp();
            i.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteMensual i = new ReporteMensual();
            i.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Lugar i = new Lugar();
            i.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TipoDocumento i = new TipoDocumento();
            i.Show();
        }
    }
}
