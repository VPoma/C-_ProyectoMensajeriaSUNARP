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
    public partial class RegEnvioArea : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string UserName="Vpoma";
        public string UserId="Vpoma";
        public string IdRE = "";
        public string h = "";

        DataTable dtdes = new DataTable();
        public RegEnvioArea()
        {
            InitializeComponent();
        }
        //public string generaNumEnvo() { 
        //    Random rm= new Random();
        //    string ne = rm.Next(100000000).ToString();
        //    return ne;
        //}
        private void RegEnvioArea_Load(object sender, EventArgs e)
        {
            //CargaGrid(dtgEnvioArea);
            CargaGridfilFecha(dtgEnvioArea, dtpRegistroEnvioArea.Value);

            this.dtgEnvioArea.Columns[0].Visible = false;
            this.dtgEnvioArea.Columns[1].HeaderText = "Nº Documento";
            this.dtgEnvioArea.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioArea.Columns[2].HeaderText = "Fecha";
            this.dtgEnvioArea.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioArea.Columns[3].HeaderText = "Hora";
            this.dtgEnvioArea.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioArea.Columns[4].HeaderText = "Destino";
            this.dtgEnvioArea.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioArea.Columns[5].HeaderText = "Dirección";
            this.dtgEnvioArea.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioArea.Columns[6].HeaderText = "Lugar";
            this.dtgEnvioArea.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioArea.Columns[7].HeaderText = "Observaión";
            this.dtgEnvioArea.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgEnvioArea.Columns[8].HeaderText = "Usuario";
            this.dtgEnvioArea.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.timer1.Enabled = true;

            cmbtipodoc.DisplayMember = "NomDocumento";
            cmbtipodoc.ValueMember = "idtipo";
            cmbtipodoc.DataSource = datos.extraedatos("sp_cargaTipoDocumento");
                        
            cmbdestino.DisplayMember = "NombreDestino";
            cmbdestino.ValueMember = "IdDestino";
            cmbdestino.DataSource = datos.extraedatos("sp_cargaDestino");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarEnvio";
            cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = "";
            //string tipdoc = cmbtipodoc.SelectedValue.ToString().Trim() + nudNumdoc.Value.ToString().Trim();
            string tipdoc = cmbtipodoc.SelectedValue.ToString().Trim() + txtNum.Text.ToString().Trim();
            cmd.Parameters.Add("@NumDocRE", SqlDbType.VarChar).Value = tipdoc;
            cmd.Parameters.Add("@FechRE", SqlDbType.Date).Value = dtpRegistroEnvioArea.Value;
            cmd.Parameters.Add("@hora", SqlDbType.Char).Value = h;
            cmd.Parameters.Add("@ObserRE", SqlDbType.VarChar).Value = txtObsRef.Text;
            cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = UserId;
            string Dest = cmbdestino.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@IdDest", SqlDbType.VarChar).Value = Dest;
            cmd.Parameters.Add("@Cons", SqlDbType.VarChar).Value = "1";
            cmd.Parameters.Add("@NCons", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@RegCons", SqlDbType.VarChar).Value = "1";
            string td = cmbtipodoc.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@Dt", SqlDbType.VarChar).Value = td;
            cn.conectar();
            try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Exitoso ...!");
                }
                catch(Exception)
                {
                MessageBox.Show("Error al registrar");
                }
            cn.desconectar();
            //CargaGrid(dtgEnvioArea);
            CargaGridfilFecha(dtgEnvioArea, dtpRegistroEnvioArea.Value);
        }

        public string getdireccion()
        {
            string rpta = "";
            DataTable dt = new DataTable();

                int iddes = int.Parse(cmbdestino.SelectedValue.ToString());
                dt = datos.extraedatos("sp_cargaDireccion", "@idDestino", iddes);
                if (dt.Rows.Count > 0)
                    rpta=dt.Rows[0][0].ToString();
                else
                    rpta= "";
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
        //public void CargaGrid(DataGridView dtgEnvioArea)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable dt = new DataTable();
        //    cmd.Connection = cn.sqlcad;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "sp_BuscarEnvioArea";
        //    cn.conectar();
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    cn.desconectar();
        //    dtgEnvioArea.DataSource = dt; 
        //}
        public void CargaGridfilFecha(DataGridView dtgEnvioArea, DateTime Fecha)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvioAreafilFech";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Fch", SqlDbType.Date).Value = Fecha;
            da.Fill(dt);
            cn.desconectar();
            dtgEnvioArea.DataSource = dt;
        }
        private void cmbdestino_SelectedIndexChanged(object sender, EventArgs e)
        {

                txtDireccion.Text = getdireccion();
                txtLugar.Text = getlugar();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarEnvio";
            cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = int.Parse(IdRE);
            string tipdoc = cmbtipodoc.SelectedValue.ToString().Trim() + txtNum.Text.ToString().Trim();
            cmd.Parameters.Add("@NumDocRE", SqlDbType.VarChar).Value = tipdoc;
            cmd.Parameters.Add("@FechRE", SqlDbType.Date).Value = dtpRegistroEnvioArea.Value;
            cmd.Parameters.Add("@hora", SqlDbType.Char).Value = h;
            cmd.Parameters.Add("@ObserRE", SqlDbType.VarChar).Value = txtObsRef.Text;
            cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = UserId;
            string Dest = cmbdestino.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@IdDest", SqlDbType.VarChar).Value = Dest;
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizacion Exitosa ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Actualizar");
            }
            cn.desconectar();
            //CargaGrid(dtgEnvioArea);
            CargaGridfilFecha(dtgEnvioArea, dtpRegistroEnvioArea.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarEnvio ";
            cmd.Parameters.Add("@IDRE", SqlDbType.VarChar).Value = int.Parse(IdRE);
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminacion Exitosa ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Eliminar");
            }
            cn.desconectar();
            //CargaGrid(dtgEnvioArea);
            CargaGridfilFecha(dtgEnvioArea, dtpRegistroEnvioArea.Value);
        }

        private void dtgEnvioArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRE = this.dtgEnvioArea.CurrentRow.Cells[0].Value.ToString();
            //txtIdRegEnv.Text = this.dtgEnvioArea.CurrentRow.Cells[1].Value.ToString();
            dtpRegistroEnvioArea.Text = this.dtgEnvioArea.CurrentRow.Cells[2].Value.ToString();
            cmbdestino.Text = this.dtgEnvioArea.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = this.dtgEnvioArea.CurrentRow.Cells[5].Value.ToString();
            txtLugar.Text = this.dtgEnvioArea.CurrentRow.Cells[6].Value.ToString();
            txtObsRef.Text = this.dtgEnvioArea.CurrentRow.Cells[7].Value.ToString();

            //string tipdoc = cmbtipodoc.SelectedValue.ToString().Trim() + nudNumdoc.Value.ToString().Trim();
            //cmd.Parameters.Add("@NumDocRE", SqlDbType.VarChar).Value = tipdoc;
        }

        private void dtpRegistroEnvioArea_ValueChanged(object sender, EventArgs e)
        {
            CargaGridfilFecha(dtgEnvioArea, dtpRegistroEnvioArea.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Destinos i = new Destinos();
            i.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            h = DateTime.Now.ToLongTimeString();
        }
    }
}
