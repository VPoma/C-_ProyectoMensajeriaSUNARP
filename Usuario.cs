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
    public partial class Usuario : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            CargaGrid(dtgUsuarios);

            this.dtgUsuarios.Columns[0].HeaderText = "Usuario ID";
            this.dtgUsuarios.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgUsuarios.Columns[1].HeaderText = "Nombres";
            this.dtgUsuarios.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgUsuarios.Columns[2].HeaderText = "Apellidos";
            this.dtgUsuarios.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgUsuarios.Columns[3].HeaderText = "Contraseña";
            this.dtgUsuarios.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgUsuarios.Columns[4].HeaderText = "Oficina";
            this.dtgUsuarios.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cmboficina.DataSource = datos.extraedatos("sp_cargaoficina");
            cmboficina.DisplayMember = "NombreOficina";
            cmboficina.ValueMember = "idOficina";
        }
        public void CargaGrid(DataGridView dtgUsuarios)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarUsuario";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgUsuarios.DataSource = dt;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarUsuario";
            cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = txtIdUser.Text;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPass.Text;
            string IdOf = cmboficina.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@IdOf", SqlDbType.VarChar).Value = IdOf;
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
            CargaGrid(dtgUsuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarUsuario";
            cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = txtIdUser.Text;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPass.Text;
            string IdOf = cmboficina.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@IdOf", SqlDbType.VarChar).Value = IdOf;
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
            CargaGrid(dtgUsuarios);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarUsuario";
            cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = txtIdUser.Text;
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
            CargaGrid(dtgUsuarios);
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUser.Text = this.dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = this.dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtPass.Text = this.dtgUsuarios.CurrentRow.Cells[3].Value.ToString();
            cmboficina.Text = this.dtgUsuarios.CurrentRow.Cells[4].Value.ToString();
        }

    }
}
