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
    public partial class ImpListEnvioExterno : Form
    {
        public ImpListEnvioExterno()
        {
            InitializeComponent();
        }

        public DateTime Fecha { get; set; }
        private void ImpListEnvioExterno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.sp_BusquedaEnvioExternoImp' Puede moverla o quitarla según sea necesario.
            this.sp_BusquedaEnvioExternoImpTableAdapter.Fill(this.DataSetReportes.sp_BusquedaEnvioExternoImp,Fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
