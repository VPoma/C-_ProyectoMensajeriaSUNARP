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
    public partial class AgregarConsolidado : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string UserName = "Vpoma";
        public string UserId = "Vpoma";
        public DateTime g;
        public string t = "";
        public AgregarConsolidado()
        {
            InitializeComponent();
        }

        private void AgregarConsolidado_Load(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgListadoC, dtpFechaListadoC.Value);

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
            this.timer1.Enabled = true;

            cmbdestino.DisplayMember = "NombreDestino";
            cmbdestino.ValueMember = "IdDestino";
            cmbdestino.DataSource = datos.extraedatos("sp_cargaDestino");
        }
        public string getdireccion()
        {
            string rpta = "";
            DataTable dt = new DataTable();

            int iddes = int.Parse(cmbdestino.SelectedValue.ToString());
            dt = datos.extraedatos("sp_cargaDireccion", "@idDestino", iddes);
            if (dt.Rows.Count > 0)
                rpta = dt.Rows[0][0].ToString();
            else
                rpta = "";
            return rpta;
        }
        public string getlugar()
        {
            string rpta = "";
            DataTable dt = new DataTable();

            int iddes = int.Parse(cmbdestino.SelectedValue.ToString());
            dt = datos.extraedatos("sp_cargaLugar", "@idDestino", iddes);
            if (dt.Rows.Count > 0)
                rpta = dt.Rows[0][0].ToString();
            else
                rpta = "";
            return rpta;
        }
        public void CargaGridfilFecha(DataGridView dtgListadoC, DateTime Fecha)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvioAderivarfilFechConsl";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Fch", SqlDbType.Date).Value = Fecha;
            da.Fill(dt);
            cn.desconectar();
            dtgListadoC.DataSource = dt;
        }

        private void dtpFechaListadoC_ValueChanged(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgListadoC, dtpFechaListadoC.Value);
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
                    cmd.CommandText = "sp_ActualizarEnvioConsl";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = a;
                    cmd.Parameters.Add("@Consl", SqlDbType.VarChar).Value = "1";
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
            CargaGridfilFecha(dtgListadoC, dtpFechaListadoC.Value);
            g = dtpFechaListadoC.Value;
        }

        private void cmbdestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDireccion.Text = getdireccion();
            txtLugar.Text = getlugar();
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
                    cmd.Parameters.Add("@Consl", SqlDbType.VarChar).Value = "3";
                    cmd.Parameters.Add("@NConsl", SqlDbType.VarChar).Value = txtNum.Text;
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
            CargaGridfilFecha(dtgListadoC, dtpFechaListadoC.Value);
        }
        public void RegConsl()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarEnvio";
            cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@NumDocRE", SqlDbType.VarChar).Value = txtNum.Text;
            cmd.Parameters.Add("@FechRE", SqlDbType.Date).Value = dtpFechaListadoC.Value;
            cmd.Parameters.Add("@hora", SqlDbType.Char).Value = t;
            cmd.Parameters.Add("@ObserRE", SqlDbType.VarChar).Value = txtObsRef.Text;
            cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = UserId;
            string Dest = cmbdestino.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@IdDest", SqlDbType.VarChar).Value = Dest;
            cmd.Parameters.Add("@Cons", SqlDbType.VarChar).Value = "1";
            cmd.Parameters.Add("@NCons", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@RegCons", SqlDbType.VarChar).Value = "2";
            cmd.Parameters.Add("@Dt", SqlDbType.VarChar).Value = "ofi";
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reg Exitoso ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Reg");
            }
            cn.desconectar();
            CargaGridfilFecha(dtgListadoC, dtpFechaListadoC.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActNConsl();
            RegConsl();
            g = dtpFechaListadoC.Value;
        }

        private void dtgListadoC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbdestino.Text = this.dtgListadoC.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = this.dtgListadoC.CurrentRow.Cells[5].Value.ToString();
            txtLugar.Text = this.dtgListadoC.CurrentRow.Cells[6].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = DateTime.Now.ToLongTimeString();
        }
    }
}
