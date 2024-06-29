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
    public partial class Login : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
      
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ValidarNomPass";
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = txtUser.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPass.Text;
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                Menu i = new Menu();
                i.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o Contraeña Incorrectos");
            }
            cn.desconectar();

        }
    }
}
