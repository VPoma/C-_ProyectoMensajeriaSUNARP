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
    public partial class RegCargosC : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string IdCEE = "";
        public string IdDC = "";
        public RegCargosC()
        {
            InitializeComponent();
        }
        private void RegCargosC_Load(object sender, EventArgs e)
        {
            CargaGridfil(dtgCargaEnvios);

            CargaGridCrg(dtgCargaCargos);

            this.dtgCargaEnvios.Columns[0].Visible = false;
            this.dtgCargaEnvios.Columns[1].HeaderText = "Nº Salida";
            this.dtgCargaEnvios.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaEnvios.Columns[2].HeaderText = "Nº Documento";
            this.dtgCargaEnvios.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaEnvios.Columns[3].HeaderText = "Fecha";
            this.dtgCargaEnvios.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaEnvios.Columns[4].HeaderText = "Destino";
            this.dtgCargaEnvios.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaEnvios.Columns[5].HeaderText = "Lugar";
            this.dtgCargaEnvios.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaEnvios.Columns[6].HeaderText = "Oficina";
            this.dtgCargaEnvios.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaEnvios.Columns[7].HeaderText = "Estado";
            this.dtgCargaEnvios.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dtgCargaCargos.Columns[0].Visible = false;
            this.dtgCargaCargos.Columns[1].Visible = false;
            this.dtgCargaCargos.Columns[2].HeaderText = "Nº Salida";
            this.dtgCargaCargos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[3].HeaderText = "Nº Documento";
            this.dtgCargaCargos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[4].HeaderText = "Destino";
            this.dtgCargaCargos.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[5].HeaderText = "Lugar";
            this.dtgCargaCargos.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[6].HeaderText = "Fecha";
            this.dtgCargaCargos.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[7].HeaderText = "F. Entrega";
            this.dtgCargaCargos.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[8].HeaderText = "F. Retorno";
            this.dtgCargaCargos.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[9].HeaderText = "Dif Dias";
            this.dtgCargaCargos.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[10].HeaderText = "Nº Paquete";
            this.dtgCargaCargos.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCargaCargos.Columns[11].HeaderText = "Nº Remito";
            this.dtgCargaCargos.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cmbTdoc.DisplayMember = "NomDocumento";
            cmbTdoc.ValueMember = "idtipo";
            cmbTdoc.DataSource = datos.extraedatos("sp_cargaTipoDocumento");
        }
        public void calculardias()
        {
            DateTime x = dtpFechaRetorno.Value;
            DateTime y = dtpFechaEntrega.Value;
            TimeSpan t = x - y;
            txtDias.Text = t.Days.ToString();

        //    DateTime x = dtpFechaRetorno.Value;
        //    DateTime y = dtpFechaEntrega.Value;
        //    DateTime z = DateTime.Today.Date;

        //    DateTime dt;
        //    TimeSpan t = x - y;
        //    dt = Convert.ToDateTime(t.ToString());

        //    int contador = 0;
        //    DateTime fechaSelec;

        //    for (int i = 0; i <= t.Days; i++)
        //    {
        //        fechaSelec = y.AddDays(i);
        //        if (fechaSelec.DayOfWeek == DayOfWeek.Saturday || fechaSelec.DayOfWeek == DayOfWeek.Sunday)
        //        {
        //            contador = contador + 1;
        //        }
        //    }
        //    z.AddDays(contador);
        //    TimeSpan G = dt - z;
        //    txtDias.Text = G.Days.ToString();
        }

        public void CargaGridfil(DataGridView dtgCargaEnvios)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCarg";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgCargaEnvios.DataSource = dt;
        }
        public void CargaGridfilNumSali(DataGridView dtgCargaEnvios, string Salida)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCargFilNumSali";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@NS", SqlDbType.NVarChar, 100).Value = Salida;
            //da.SelectCommand.Parameters.Add("@NS", SqlDbType.NVarChar, 100).Value = NumDoc;
            da.Fill(dt);
            cn.desconectar();
            dtgCargaEnvios.DataSource = dt;
        }
        public void CargaGridfilNumDoc(DataGridView dtgCargaEnvios)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCargFilNumDoc";
            cn.conectar();
            da.SelectCommand = cmd;
            //string Dest = cmbTdoc.SelectedValue.ToString().Trim();
            //da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar).Value = Dest;
            //da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar, 100).Value = NumDoc;
            string tipdoc = cmbTdoc.SelectedValue.ToString().Trim() + txtNumDoc.Text.Trim();
            da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar).Value = tipdoc;
            da.Fill(dt);
            cn.desconectar();
            dtgCargaEnvios.DataSource = dt;
        }
        public void CargaGridfilFech(DataGridView dtgCargaEnvios, DateTime Fecha)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCargFilFech";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Fch", SqlDbType.Date).Value = Fecha;
            da.Fill(dt);
            cn.desconectar();
            dtgCargaEnvios.DataSource = dt;
        }
        public void CargaGridfilDest(DataGridView dtgCargaEnvios, string Destino)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCargFilDest";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Dst", SqlDbType.NVarChar, 100).Value = Destino;
            da.Fill(dt);
            cn.desconectar();
            dtgCargaEnvios.DataSource = dt;
        }
        public void CargaGridCrg(DataGridView dtgCargaCargos)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BusquedaCargo";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgCargaCargos.DataSource = dt;
        }
        private void txtSalida_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilNumSali(dtgCargaEnvios, txtSalida.Text);
        }
        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilDest(dtgCargaEnvios, txtDestino.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarCargo";
            cmd.Parameters.Add("@IdDscCarg", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@SalidaEE", SqlDbType.VarChar).Value = int.Parse(IdCEE);
            cmd.Parameters.Add("@NumPaqDC", SqlDbType.VarChar).Value = int.Parse(txtpaquete.Text);
            cmd.Parameters.Add("@FechaRetDC", SqlDbType.Date).Value = dtpFechaRetorno.Value;
            cmd.Parameters.Add("@FechaEntDC", SqlDbType.Date).Value = dtpFechaEntrega.Value;
            cmd.Parameters.Add("@DifDias", SqlDbType.VarChar).Value = int.Parse(txtDias.Text);
            cmd.Parameters.Add("@NumRemito", SqlDbType.VarChar).Value = int.Parse(txtRemito.Text);
            cmd.Parameters.Add("@Estd", SqlDbType.VarChar).Value = "Registrado";
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cargo Registrado ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            cn.desconectar();
            CargaGridfil(dtgCargaEnvios);
            CargaGridCrg(dtgCargaCargos);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarRegCargo";
            cmd.Parameters.Add("@IdDscCarg", SqlDbType.VarChar).Value = int.Parse(IdDC);
            cmd.Parameters.Add("@SalidaEE", SqlDbType.VarChar).Value = int.Parse(IdCEE);
            cmd.Parameters.Add("@NumPaqDC", SqlDbType.VarChar).Value = int.Parse(txtpaquete.Text);
            cmd.Parameters.Add("@FechaRetDC", SqlDbType.Date).Value = dtpFechaRetorno.Value;
            cmd.Parameters.Add("@FechaEntDC", SqlDbType.Date).Value = dtpFechaEntrega.Value;
            cmd.Parameters.Add("@DifDias", SqlDbType.VarChar).Value = int.Parse(txtDias.Text);
            cmd.Parameters.Add("@NumRemito", SqlDbType.VarChar).Value = int.Parse(txtRemito.Text);
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cargo Actualizado ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            cn.desconectar();
            CargaGridCrg(dtgCargaCargos);
        }

        private void dtgCargaCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdDC = this.dtgCargaCargos.CurrentRow.Cells[0].Value.ToString();
            IdCEE = this.dtgCargaCargos.CurrentRow.Cells[1].Value.ToString();
            dtpFechaEntrega.Text = this.dtgCargaCargos.CurrentRow.Cells[7].Value.ToString();
            dtpFechaRetorno.Text = this.dtgCargaCargos.CurrentRow.Cells[8].Value.ToString();
            txtDias.Text = this.dtgCargaCargos.CurrentRow.Cells[9].Value.ToString();
            txtpaquete.Text = this.dtgCargaCargos.CurrentRow.Cells[10].Value.ToString();
            txtRemito.Text = this.dtgCargaCargos.CurrentRow.Cells[11].Value.ToString();
        }
        private void dtgCargaEnvios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCEE = this.dtgCargaEnvios.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarRegCargo";
            cmd.Parameters.Add("@IdDscCarg", SqlDbType.VarChar).Value = int.Parse(IdDC);
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminacion Exitosa ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            cn.desconectar();
            CargaGridfil(dtgCargaEnvios);
            CargaGridCrg(dtgCargaCargos);
        }

        private void dtpFechaFillRegCargo_ValueChanged(object sender, EventArgs e)
        {
            CargaGridfilFech(dtgCargaEnvios, dtpFechaFillRegCargo.Value);
        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            calculardias();
        }

        private void cmbTdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGridfilNumDoc(dtgCargaEnvios);
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilNumDoc(dtgCargaEnvios);
        }
    }
}
