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
    public partial class Oficina : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string IdOf = "";
        public Oficina()
        {
            InitializeComponent();
        }
        public void CargaGrid(DataGridView dtgOficinas)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarOficina";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgOficinas.DataSource = dt;
        }
        private void Oficina_Load(object sender, EventArgs e)
        {
            CargaGrid(dtgOficinas);

            this.dtgOficinas.Columns[0].Visible = false;
            this.dtgOficinas.Columns[1].HeaderText = "Oficina";
            this.dtgOficinas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgOficinas.Columns[2].HeaderText = "Observación";
            this.dtgOficinas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarOficina";
            cmd.Parameters.Add("@IdOf", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@NomOf", SqlDbType.VarChar).Value = txtNombreOficina.Text;
            cmd.Parameters.Add("@Obs", SqlDbType.VarChar).Value = txtObserOfi.Text;
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar");
            }
            cn.desconectar();
            CargaGrid(dtgOficinas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarOficina";
            cmd.Parameters.Add("@IdOf", SqlDbType.VarChar).Value = int.Parse(IdOf);
            cmd.Parameters.Add("@NomOf", SqlDbType.VarChar).Value = txtNombreOficina.Text;
            cmd.Parameters.Add("@Obs", SqlDbType.VarChar).Value = txtObserOfi.Text;
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
            CargaGrid(dtgOficinas);
        }

        private void dtgOficinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdOf = this.dtgOficinas.CurrentRow.Cells[0].Value.ToString();
            txtNombreOficina.Text = this.dtgOficinas.CurrentRow.Cells[1].Value.ToString();
            txtObserOfi.Text = this.dtgOficinas.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarOficina";
            cmd.Parameters.Add("@IdOf", SqlDbType.VarChar).Value = int.Parse(IdOf);
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
            CargaGrid(dtgOficinas);
        }

    }
}
