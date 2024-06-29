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
    public partial class Destinos : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public string IdDst = "";
        public Destinos()
        {
            InitializeComponent();
        }
        public void CargaGrid(DataGridView dtgDestino)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarDestino";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgDestino.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarDestino";
            cmd.Parameters.Add("@IdDst", SqlDbType.VarChar).Value = int.Parse(IdDst);
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
            CargaGrid(dtgDestino);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarDestino";
            cmd.Parameters.Add("@IdDst", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@NomDst", SqlDbType.VarChar).Value = txtDestino.Text;
            cmd.Parameters.Add("@DrcDst", SqlDbType.VarChar).Value = txtDireccion.Text;
            string IdLg = cmbLugar.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@IdLug", SqlDbType.VarChar).Value = IdLg;
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
            CargaGrid(dtgDestino);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarDestino";
            cmd.Parameters.Add("@IdDst", SqlDbType.VarChar).Value = int.Parse(IdDst);
            cmd.Parameters.Add("@NomDst", SqlDbType.VarChar).Value = txtDestino.Text;
            cmd.Parameters.Add("@DrcDst", SqlDbType.VarChar).Value = txtDireccion.Text;
            string IdLg = cmbLugar.SelectedValue.ToString().Trim();
            cmd.Parameters.Add("@IdLug", SqlDbType.VarChar).Value = IdLg;
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
            CargaGrid(dtgDestino);
        }
        private void Destinos_Load(object sender, EventArgs e)
        {
            CargaGrid(dtgDestino);

            this.dtgDestino.Columns[0].Visible = false;
            this.dtgDestino.Columns[1].HeaderText = "Destino";
            this.dtgDestino.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgDestino.Columns[2].HeaderText = "Dirección";
            this.dtgDestino.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgDestino.Columns[3].HeaderText = "Lugar";
            this.dtgDestino.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cmbLugar.DataSource = datos.extraedatos("sp_cargaLugarV2");
            cmbLugar.DisplayMember = "NombLugar";
            cmbLugar.ValueMember = "IdLugar";
        }

        private void dtgDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdDst = this.dtgDestino.CurrentRow.Cells[0].Value.ToString();
            txtDestino.Text = this.dtgDestino.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = this.dtgDestino.CurrentRow.Cells[2].Value.ToString();
            cmbLugar.Text = this.dtgDestino.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lugar i = new Lugar();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lugar i = new Lugar();
            i.Show();
        }
    }
}
