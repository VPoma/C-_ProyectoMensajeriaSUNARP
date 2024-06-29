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
    public partial class ReportePorMes : Form
    {
        public ReportePorMes()
        {
            InitializeComponent();
        }
        public DateTime F1 { get; set; }
        public DateTime F2 { get; set; }
        private void ReportePorMes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.sp_CantEnvios' Puede moverla o quitarla según sea necesario.
            this.sp_CantEnviosTableAdapter.Fill(this.DataSetReportes.sp_CantEnvios,F1,F2);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.sp_CantCargos' Puede moverla o quitarla según sea necesario.
            this.sp_CantCargosTableAdapter.Fill(this.DataSetReportes.sp_CantCargos,F1,F2);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.sp_CantCargosNoRetornados' Puede moverla o quitarla según sea necesario.
            this.sp_CantCargosNoRetornadosTableAdapter.Fill(this.DataSetReportes.sp_CantCargosNoRetornados,F1,F2);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.sp_ListarCargosNoRetornados' Puede moverla o quitarla según sea necesario.
            this.sp_ListarCargosNoRetornadosTableAdapter.Fill(this.DataSetReportes.sp_ListarCargosNoRetornados,F1,F2);

            this.reportViewer1.RefreshReport();
        }
    }
}
