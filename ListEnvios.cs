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
    public partial class ListEnvios : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string UserName = "Vpoma";
        public string UserId = "Vpoma";

        DataTable dtdes = new DataTable();
        public ListEnvios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgListado.Rows)
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
                    cmd.Parameters.Add("@Consl", SqlDbType.VarChar).Value = "2";
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
            CargaGridfilFecha(dtgListado, dtpFechaListadoEnvio.Value);

            AgregarConsolidado i = new AgregarConsolidado();
            DialogResult res = i.ShowDialog();

            if (res == DialogResult.OK)
            {
                dtpFechaListadoEnvio.Value = i.g;
            }
        }

        private void ListEnvios_Load(object sender, EventArgs e)
        {
            //CargaGrid(dtgListado);
            CargaGridfilFecha(dtgListado, dtpFechaListadoEnvio.Value);

            this.dtgListado.Columns[1].Visible = false;
            this.dtgListado.Columns[2].HeaderText = "Nº Documento";
            this.dtgListado.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[3].HeaderText = "Fecha";
            this.dtgListado.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[4].HeaderText = "Hora";
            this.dtgListado.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[5].HeaderText = "Destino";
            this.dtgListado.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[6].HeaderText = "Dirección";
            this.dtgListado.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[7].HeaderText = "Lugar";
            this.dtgListado.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[8].HeaderText = "Observación";
            this.dtgListado.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[9].HeaderText = "Oficina";
            this.dtgListado.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[10].HeaderText = "Usuario";
            this.dtgListado.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[11].HeaderText = "Externo";
            this.dtgListado.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgListado.Columns[12].HeaderText = "Interno";
            this.dtgListado.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //RowsColorEnvioExterno();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string s = this.dtgListado.CurrentRow.Cells[0].Value.ToString();

            //if (bool.Parse(s) == true)
            //{
                QuitarConsolidado i = new QuitarConsolidado();
                i.IdReg = this.dtgListado.CurrentRow.Cells[1].Value.ToString();
                i.Cns = this.dtgListado.CurrentRow.Cells[2].Value.ToString();
                i.Fch = this.dtgListado.CurrentRow.Cells[3].Value.ToString();
                i.Dst = this.dtgListado.CurrentRow.Cells[5].Value.ToString();
                i.Drc = this.dtgListado.CurrentRow.Cells[6].Value.ToString();
                i.Lgr = this.dtgListado.CurrentRow.Cells[7].Value.ToString();
                i.Obs = this.dtgListado.CurrentRow.Cells[8].Value.ToString();
                DialogResult res = i.ShowDialog();

                if (res == DialogResult.OK)
                {
                    dtpFechaListadoEnvio.Value = i.g;
                }
            //}
            //else
            //{
 
            //}
        }
        private void button5_Click(object sender, EventArgs e)
        {
             foreach (DataGridViewRow item in dtgListado.Rows)
            {
                  if (item.Cells[0].Value != null)
                {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarEnvioInterno";
            cmd.Parameters.Add("@SalidaEI", SqlDbType.VarChar).Value = "";
            string a = item.Cells[1].Value.ToString();
            cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = int.Parse(a);
            cmd.Parameters.Add("@Portador", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Inte", SqlDbType.VarChar).Value = "Derivado";
            cmd.Parameters.Add("@Pt", SqlDbType.VarChar).Value = "Vpoma";
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            cn.desconectar();
            //CargaGrid(dtgListado);
                }
            }
             MessageBox.Show("Derivacion Exitosa ...!");
             CargaGridfilFecha(dtgListado, dtpFechaListadoEnvio.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgListado.Rows)
            {
                  if (item.Cells[0].Value != null)
                {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarEnvioExterno";
            cmd.Parameters.Add("@SalidaEE", SqlDbType.VarChar).Value = "";
            string a = item.Cells[1].Value.ToString();
            cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = int.Parse(a);
            cmd.Parameters.Add("@NSali", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Servi", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@CPeso", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@GuiaR", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@Exte", SqlDbType.VarChar).Value = "Derivado";
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            cn.desconectar();
            //CargaGrid(dtgListado);
                }
            }
             MessageBox.Show("Derivacion Exitosa ...!");
             CargaGridfilFecha(dtgListado, dtpFechaListadoEnvio.Value);
        }
        //public void RowsColorEnvioExterno()
        //{
        //            //this.dtgListado.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
        //            for (int i = 0; i < dtgListado.Rows.Count; i++)
        //            {
        //                //int val = Int32.Parse(dtgListado.Rows[i].Cells[10].Value.ToString());
        //                if (dtgListado.Rows[i].Cells[10].Value != null)
        //                    //if (val == 39)
        //                {
        //                    //this.dtgListado.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
        //                    this.dtgListado.Rows[i].Cells[10].Style.BackColor = Color.LightGreen;
        //                }
        //            }
        //    }
        public void CargaGridfilFecha(DataGridView dtgListado, DateTime Fecha)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvioAderivarfilFech";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Fch", SqlDbType.Date).Value = Fecha;
            da.Fill(dt);
            cn.desconectar();
            dtgListado.DataSource = dt;
        }

        private void dtpFechaListadoEnvio_ValueChanged(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgListado, dtpFechaListadoEnvio.Value);
            //RowsColorEnvioExterno();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImpEtiquetaConsolidado i = new ImpEtiquetaConsolidado();
            i.C = this.dtgListado.CurrentRow.Cells[2].Value.ToString();
            i.Show();
            //DialogResult res = i.ShowDialog();

            //if (res == DialogResult.OK)
            //{
            //    dtpFechaListadoEnvio.Value = i.g;
            //}
        }
    }
}
