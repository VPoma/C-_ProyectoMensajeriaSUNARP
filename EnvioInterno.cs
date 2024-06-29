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
    public partial class EnvioInterno : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string UserName = "Vpoma";
        public string UserId = "Vpoma";
        //public string IdCEI = "";
        //public string IdRE = "";

        DataTable dtdes = new DataTable();
        public EnvioInterno()
        {
            InitializeComponent();
        }

        private void EnvioInterno_Load(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgEnvioInterno, dtpFechaEnvioInterno.Value);

            this.dtgEnvioInterno.Columns[1].Visible = false;
            this.dtgEnvioInterno.Columns[2].Visible = false;
            this.dtgEnvioInterno.Columns[3].HeaderText = "Nº Documento";
            this.dtgEnvioInterno.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioInterno.Columns[4].HeaderText = "Fecha";
            this.dtgEnvioInterno.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioInterno.Columns[5].HeaderText = "Destino";
            this.dtgEnvioInterno.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioInterno.Columns[6].HeaderText = "Dirección";
            this.dtgEnvioInterno.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioInterno.Columns[7].HeaderText = "Lugar";
            this.dtgEnvioInterno.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioInterno.Columns[8].HeaderText = "Observación";
            this.dtgEnvioInterno.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioInterno.Columns[9].HeaderText = "Oficina";
            this.dtgEnvioInterno.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioInterno.Columns[10].HeaderText = "Portador";
            this.dtgEnvioInterno.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cmbNotificador.DisplayMember = "NombrePortador";
            cmbNotificador.ValueMember = "IdPortador";
            cmbNotificador.DataSource = datos.extraedatos("sp_CargarPortador");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgEnvioInterno.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_eliminarEnvioInterno";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@IDCEI", SqlDbType.VarChar).Value = a;
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
            MessageBox.Show("Retiro Exitoso ...!");
            CargaGridfilFecha(dtgEnvioInterno, dtpFechaEnvioInterno.Value);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgEnvioInterno.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarEnvioInterno";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@SalidaEI", SqlDbType.VarChar).Value = a;
                    string b = item.Cells[2].Value.ToString();
                    cmd.Parameters.Add("@IdRE", SqlDbType.VarChar).Value = b;
                    string Dest = cmbNotificador.SelectedValue.ToString().Trim();
                    cmd.Parameters.Add("@port", SqlDbType.VarChar).Value = Dest;
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
            MessageBox.Show("Portador Ingresado!");
            CargaGridfilFecha(dtgEnvioInterno, dtpFechaEnvioInterno.Value);
        }
        public void CargaGridfilFecha(DataGridView dtgEnvioInterno, DateTime Fecha)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BusquedaEnvioInternofilFech";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Fch", SqlDbType.Date).Value = Fecha;
            da.Fill(dt);
            cn.desconectar();
            dtgEnvioInterno.DataSource = dt;
        }
        private void dtpFechaEnvioInterno_ValueChanged(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgEnvioInterno, dtpFechaEnvioInterno.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImpListEnvioInterno i = new ImpListEnvioInterno();
            i.Fecha = dtpFechaEnvioInterno.Value;
            i.Show();
        }
    }
}
