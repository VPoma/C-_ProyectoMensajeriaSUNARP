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
    public partial class ReporteMensual : Form
    {
        public ReporteMensual()
        {
            InitializeComponent();
        }

        private void ReporteMensual_Load(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportePorMes i = new ReportePorMes();
            i.F1 = dtpFI.Value;
            i.F2 = dtpFF.Value;
            i.Show();
        }

    }
}
