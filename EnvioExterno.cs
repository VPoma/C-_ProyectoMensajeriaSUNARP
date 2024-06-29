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
    public partial class EnvioExterno : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string UserName = "Vpoma";
        public string UserId = "Vpoma";

        DataTable dtdes = new DataTable();
        public EnvioExterno()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgEnvioExterno.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarEnvioExternoNSali";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@SalidaEE", SqlDbType.VarChar).Value = a;
                    string b = item.Cells[2].Value.ToString();
                    cmd.Parameters.Add("@IdRE", SqlDbType.VarChar).Value = b;
                    cmd.Parameters.Add("@NSali", SqlDbType.VarChar).Value = int.Parse(txtdato.Text);
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
            MessageBox.Show("Parametros Actualizados!");
            CargaGridfilFecha(dtgEnvioExterno, dtpFechaEnvioExterno.Value);
        }
        private void EnvioExterno_Load(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgEnvioExterno, dtpFechaEnvioExterno.Value);

            this.dtgEnvioExterno.Columns[1].Visible = false;
            this.dtgEnvioExterno.Columns[2].Visible = false;
            this.dtgEnvioExterno.Columns[3].HeaderText = "Nº de Salida";
            this.dtgEnvioExterno.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[4].HeaderText = "Nº Documento";
            this.dtgEnvioExterno.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[5].HeaderText = "Fecha";
            this.dtgEnvioExterno.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[6].HeaderText = "Destino";
            this.dtgEnvioExterno.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[7].HeaderText = "Dirección";
            this.dtgEnvioExterno.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[8].HeaderText = "Lugar";
            this.dtgEnvioExterno.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[9].HeaderText = "Observación";
            this.dtgEnvioExterno.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[10].HeaderText = "Oficina";
            this.dtgEnvioExterno.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[11].HeaderText = "Servicio";
            this.dtgEnvioExterno.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[12].HeaderText = "Cod de Peso";
            this.dtgEnvioExterno.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioExterno.Columns[13].HeaderText = "Guia Remision";
            this.dtgEnvioExterno.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void CargaGrid(DataGridView dtgEnvioExterno)
        {
        }
        public void CargaGridfilFecha(DataGridView dtgEnvioExterno, DateTime Fecha)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BusquedaEnvioExternofilFech";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Fch", SqlDbType.Date).Value = Fecha;
            da.Fill(dt);
            cn.desconectar();
            dtgEnvioExterno.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgEnvioExterno.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_eliminarEnvioExterno";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@IDCEE", SqlDbType.VarChar).Value = a;
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
            CargaGridfilFecha(dtgEnvioExterno, dtpFechaEnvioExterno.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImpListEnvioExterno i = new ImpListEnvioExterno();
            i.Fecha = dtpFechaEnvioExterno.Value;
            i.Show();
        }

        private void dtpFechaEnvioExterno_ValueChanged(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgEnvioExterno, dtpFechaEnvioExterno.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgEnvioExterno.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarEnvioExternoServ";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@SalidaEE", SqlDbType.VarChar).Value = a;
                    string b = item.Cells[2].Value.ToString();
                    cmd.Parameters.Add("@IdRE", SqlDbType.VarChar).Value = b;
                    cmd.Parameters.Add("@Servi", SqlDbType.VarChar).Value = txtdato.Text;
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
            MessageBox.Show("Parametros Actualizados!");
            CargaGridfilFecha(dtgEnvioExterno, dtpFechaEnvioExterno.Value);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgEnvioExterno.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarEnvioExternoCPes";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@SalidaEE", SqlDbType.VarChar).Value = a;
                    string b = item.Cells[2].Value.ToString();
                    cmd.Parameters.Add("@IdRE", SqlDbType.VarChar).Value = b;
                    cmd.Parameters.Add("@CPeso", SqlDbType.VarChar).Value = int.Parse(txtdato.Text);
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
            MessageBox.Show("Parametros Actualizados!");
            CargaGridfilFecha(dtgEnvioExterno, dtpFechaEnvioExterno.Value);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgEnvioExterno.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarEnvioExternoGuiaR";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@SalidaEE", SqlDbType.VarChar).Value = a;
                    string b = item.Cells[2].Value.ToString();
                    cmd.Parameters.Add("@IdRE", SqlDbType.VarChar).Value = b;
                    cmd.Parameters.Add("@GuiaR", SqlDbType.VarChar).Value = int.Parse(txtdato.Text);
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
            MessageBox.Show("Parametros Actualizados!");
            CargaGridfilFecha(dtgEnvioExterno, dtpFechaEnvioExterno.Value);
        }
    }
}
