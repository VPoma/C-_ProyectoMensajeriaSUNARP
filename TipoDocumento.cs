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
    public partial class TipoDocumento : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public TipoDocumento()
        {
            InitializeComponent();
        }
        public void CargaGrid(DataGridView dtgTipoDoc)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarTDoc";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgTipoDoc.DataSource = dt;
        }
        private void TipoDocumento_Load(object sender, EventArgs e)
        {
            CargaGrid(dtgTipoDoc);

            this.dtgTipoDoc.Columns[0].HeaderText = "Documento ID";
            this.dtgTipoDoc.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgTipoDoc.Columns[1].HeaderText = "Tipo";
            this.dtgTipoDoc.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RegistrarTDoc";
            cmd.Parameters.Add("@IdTD", SqlDbType.VarChar).Value = txtIdDoc.Text;
            cmd.Parameters.Add("@NomD", SqlDbType.VarChar).Value = txtTipo.Text;
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
            CargaGrid(dtgTipoDoc);
        }

        private void dtgTipoDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDoc.Text = this.dtgTipoDoc.CurrentRow.Cells[0].Value.ToString();
            txtTipo.Text = this.dtgTipoDoc.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ActualizarTDoc";
            cmd.Parameters.Add("@IdTD", SqlDbType.VarChar).Value = txtIdDoc.Text;
            cmd.Parameters.Add("@NomD", SqlDbType.VarChar).Value = txtTipo.Text;
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
            CargaGrid(dtgTipoDoc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_eliminarTDoc";
            cmd.Parameters.Add("@IdTD", SqlDbType.VarChar).Value = txtIdDoc.Text;
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
            CargaGrid(dtgTipoDoc);
        }
    }
}
