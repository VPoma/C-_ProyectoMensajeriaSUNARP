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
    public partial class ppfe : Form
    {
        conexion cn = new conexion();
        xyzConsulta dat = new xyzConsulta();
        public ppfe()
        {
            InitializeComponent();
        }
        public string ap { get; set; }
        public string bp { get; set; }
        public string cp { get; set; }
        private void ppfe_Load(object sender, EventArgs e)
        {
            //CargaGridfil1(dtgPF1, txt2.Text);

            label1.Text = ap;
            label2.Text = bp;
            txt2.Text = bp;
            label3.Text = cp;

        }
        public void CargaGridfil1(DataGridView dtgPF1, string NC)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ABusANcons";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@ANcons", SqlDbType.Char, 10).Value = NC;
            da.Fill(dt);
            cn.desconectar();
            dtgPF1.DataSource = dt;
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            CargaGridfil1(dtgPF1,txt2.Text);
        }
    }
}
