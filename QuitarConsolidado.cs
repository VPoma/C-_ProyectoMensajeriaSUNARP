using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistMensaSUNARP
{
    public partial class QuitarConsolidado : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string UserName = "Vpoma";
        public string UserId = "Vpoma";
        public DateTime g;
        public QuitarConsolidado()
        {
            InitializeComponent();
        }
        public string IdReg { get; set; }
        public string Cns { get; set; }
        public string Fch { get; set; }
        public string Dst { get; set; }
        public string Drc { get; set; }
        public string Lgr { get; set; }
        public string Obs { get; set; }
        private void QuitarConsolidado_Load(object sender, EventArgs e)
        {
            txtNum.Text = Cns;
            dtpFechaListadoC.Text = Fch;
            cmbdestino.Text = Dst;
            txtDireccion.Text = Drc;
            txtLugar.Text = Lgr;
            txtObsRef.Text = Obs;

            this.dtgListadoC.Columns[1].Visible = false;
            this.dtgListadoC.Columns[2].HeaderText = "Nº Documento";
            this.dtgListadoC.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListadoC.Columns[3].HeaderText = "Fecha";
            this.dtgListadoC.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListadoC.Columns[4].HeaderText = "Destino";
            this.dtgListadoC.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListadoC.Columns[5].HeaderText = "Dirección";
            this.dtgListadoC.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListadoC.Columns[6].HeaderText = "Lugar";
            this.dtgListadoC.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListadoC.Columns[7].HeaderText = "Observación";
            this.dtgListadoC.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListadoC.Columns[8].HeaderText = "Oficina";
            this.dtgListadoC.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListadoC.Columns[9].HeaderText = "Usuario";
            this.dtgListadoC.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void CargaGridfilFecha(DataGridView dtgListadoC, string NC)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvioAderivarfilFechNConsl";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@NConsl", SqlDbType.Char, 10).Value = NC;
            da.Fill(dt);
            cn.desconectar();
            dtgListadoC.DataSource = dt;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgListadoC,txtNum.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActNConsl();
            QutConsl();
            g = dtpFechaListadoC.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgListadoC.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarEnvioNConsl";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = a;
                    cmd.Parameters.Add("@Consl", SqlDbType.VarChar).Value = "1";
                    cmd.Parameters.Add("@NConsl", SqlDbType.VarChar).Value = "";
                    cn.conectar();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                    }
                    cn.desconectar();
                }
            }
            CargaGridfilFecha(dtgListadoC, txtNum.Text);
            g = dtpFechaListadoC.Value;
        }
        public void ActNConsl()
        {
            foreach (DataGridViewRow item in dtgListadoC.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarEnvioNConsl";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = a;
                    cmd.Parameters.Add("@Consl", SqlDbType.VarChar).Value = "1";
                    cmd.Parameters.Add("@NConsl", SqlDbType.VarChar).Value = "";
                    cn.conectar();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                    }
                    cn.desconectar();
                }
            }
            MessageBox.Show("Actualizacion Exitosa ...!");
            CargaGridfilFecha(dtgListadoC, txtNum.Text);
        }
        public void QutConsl()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarEnvio ";
            cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = int.Parse(IdReg);
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminacion Exitosa ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Reg");
            }
            cn.desconectar();
            CargaGridfilFecha(dtgListadoC, txtNum.Text);
        }
    }
}
