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
    public partial class Portador : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public Portador()
        {
            InitializeComponent();
        }
        public void CargaGrid(DataGridView dtgPortador)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarPortador";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgPortador.DataSource = dt;
        }
        private void Portador_Load(object sender, EventArgs e)
        {
            CargaGrid(dtgPortador);

            this.dtgPortador.Columns[0].HeaderText = "Portador ID";
            this.dtgPortador.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgPortador.Columns[1].HeaderText = "Nombres";
            this.dtgPortador.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgPortador.Columns[2].HeaderText = "Observaciones";
            this.dtgPortador.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarPortador";
            cmd.Parameters.Add("@IdPrt", SqlDbType.VarChar).Value = txtIdPortador.Text;
            cmd.Parameters.Add("@NomPrt", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@Obs", SqlDbType.VarChar).Value = txtObservaciones.Text;
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
            CargaGrid(dtgPortador);
        }

        private void dtgPortador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPortador.Text = this.dtgPortador.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dtgPortador.CurrentRow.Cells[1].Value.ToString();
            txtObservaciones.Text = this.dtgPortador.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarPortador";
            cmd.Parameters.Add("@IdPrt", SqlDbType.VarChar).Value = txtIdPortador.Text;
            cmd.Parameters.Add("@NomPrt", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@Obs", SqlDbType.VarChar).Value = txtObservaciones.Text;
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
            CargaGrid(dtgPortador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarPortador";
            cmd.Parameters.Add("@IdPrt", SqlDbType.VarChar).Value = txtIdPortador.Text;
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
            CargaGrid(dtgPortador);
        }
    }
}
