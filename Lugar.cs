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
    public partial class Lugar : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string IdLg = "";
        public Lugar()
        {
            InitializeComponent();
        }

        private void Lugar_Load(object sender, EventArgs e)
        {
            CargaGrid(dtgLugar);

            this.dtgLugar.Columns[0].Visible = false;
            this.dtgLugar.Columns[1].HeaderText = "Nombre Lugar";
            this.dtgLugar.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void CargaGrid(DataGridView dtgLugar)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarLugar";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgLugar.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarLugar";
            cmd.Parameters.Add("@IdLug", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@NomLug", SqlDbType.VarChar).Value = txtLugar.Text;
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
            CargaGrid(dtgLugar);
        }

        private void dtgLugar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdLg = this.dtgLugar.CurrentRow.Cells[0].Value.ToString();
            txtLugar.Text = this.dtgLugar.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarLugar";
            cmd.Parameters.Add("@IdLug", SqlDbType.VarChar).Value = int.Parse(IdLg);
            cmd.Parameters.Add("@NomLug", SqlDbType.VarChar).Value = txtLugar.Text;
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
            CargaGrid(dtgLugar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarLugar";
            cmd.Parameters.Add("@IdLug", SqlDbType.VarChar).Value = int.Parse(IdLg);
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
            CargaGrid(dtgLugar);
        }
    }
}
