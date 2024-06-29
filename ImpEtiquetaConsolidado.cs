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
    public partial class ImpEtiquetaConsolidado : Form
    {
        public ImpEtiquetaConsolidado()
        {
            InitializeComponent();
        }
        public string C { get; set; }
        private void ImpEtiquetaConsolidado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.sp_BuscarEnvioConslImp' Puede moverla o quitarla según sea necesario.
            this.sp_BuscarEnvioConslImpTableAdapter.Fill(this.DataSetReportes.sp_BuscarEnvioConslImp, C);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.sp_BuscarEnvioConslDocImp' Puede moverla o quitarla según sea necesario.
            this.sp_BuscarEnvioConslDocImpTableAdapter.Fill(this.DataSetReportes.sp_BuscarEnvioConslDocImp, C);

            this.reportViewer1.RefreshReport();
        }
    }
}
