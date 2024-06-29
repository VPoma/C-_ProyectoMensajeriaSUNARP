using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
namespace SistMensaSUNARP
{
    public class xyzConsulta
    {
        conexion cn = new conexion();
        public void rellenacombo(ComboBox cmb, String campover, string campovalor,string nomsp) {
            cmb.DataSource = extraedatos(nomsp);
            cmb.DisplayMember = campovalor;
            cmb.ValueMember = campover;
            
        }

        public DataTable extraedatos(string nombresp) {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt; 
        
        }

        public DataTable extraedatos(string nombresp, string nomparam, string valorparam)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam, SqlDbType.NVarChar).Value = valorparam;
            da.Fill(dt);
            cn.desconectar();
            return dt;

        }
        public DataTable extraedatos(string nombresp, string nomparam, int valorparam)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam, SqlDbType.Int).Value = valorparam;
            da.Fill(dt);
            cn.desconectar();
            return dt;

        }
        public DataTable extraedatos(string nombresp, string nomparam1, double valorparam1, string nomparam2, double valorparam2)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam1, SqlDbType.Money).Value = valorparam1;
            da.SelectCommand.Parameters.Add(nomparam2, SqlDbType.Money).Value = valorparam2;
            da.Fill(dt);
            cn.desconectar();
            return dt;

        }

        public DataTable extraedatos(string nombresp, string nomparam1, string valorparam1, string nomparam2, string valorparam2)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            da.SelectCommand.Parameters.Add(nomparam2, SqlDbType.VarChar).Value = valorparam2;
            da.Fill(dt);
            cn.desconectar();
            return dt;

        }

        public DataTable extraedatos(string nombresp, string nomparam1, int valorparam1, string nomparam2, string valorparam2)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            da.SelectCommand.Parameters.Add(nomparam2, SqlDbType.VarChar).Value = valorparam2;
            da.Fill(dt);
            cn.desconectar();
            return dt;

        }


        public void envia_plantilla( int iduser, string digra, double tp_p, double ts_p, double tdur,  int num_muestra, string tipo_pulso, string tipo_muestra, byte numcaracter ) {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ins_plantilla";
            cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
            cmd.Parameters.Add("@digrafo", SqlDbType.VarChar).Value = digra;
            cmd.Parameters.Add("@ti_pp", SqlDbType.Decimal).Value = tp_p;
            cmd.Parameters.Add("@ti_sp", SqlDbType.Decimal).Value = ts_p;
            cmd.Parameters.Add("@ti_dur", SqlDbType.Decimal).Value = tdur;
            cmd.Parameters.Add("@num_muestra", SqlDbType.Int).Value = num_muestra;
            cmd.Parameters.Add("@tipo_pulsa", SqlDbType.VarChar).Value = tipo_pulso;
            cmd.Parameters.Add("@tipo_muestra", SqlDbType.VarChar).Value = tipo_muestra;
            cmd.Parameters.Add("@numcaracter", SqlDbType.SmallInt).Value = numcaracter;
            cn.conectar();
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }

        public void envia_usuario(string user, string pass)
        { 
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ins_user";
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            cn.conectar();
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }

        public void ingresa_col_matriz(DataTable ddtable, double [ , ] ma, int numcol ) {
            int numfilas=ddtable.Rows.Count;
            double ti_pp;
            int ma_filas, macols;
            ma_filas = ma.GetLength(0);
            macols = ma.GetLength(1);
            ma_filas = ma_filas + macols;
            for (int i = 0; i <numfilas ; i++)
            {
                ti_pp = double.Parse(ddtable.Rows[i][1].ToString());
                ma[i,numcol]=ti_pp; //ti_pp
                ma[i, numcol+1] = double.Parse(ddtable.Rows[i][2].ToString()); //ti_sp
                }
            }
        public void ingresa_col_matriz2(DataTable ddtable, double[,] ma, int numcol)
        {
            //string digrafo, Chart graf, Series serie
            int numfilas = ddtable.Rows.Count;
            double ti_ps;
            int ma_filas, macols;
            ma_filas = ma.GetLength(0);
            macols = ma.GetLength(1);
            ma_filas = ma_filas + macols;
            for (int i = 0; i < numfilas; i++)
            {
                ti_ps = double.Parse(ddtable.Rows[i][2].ToString());
                ma[i, numcol] = ti_ps; //ti_pp
                ma[i, numcol + 1] = double.Parse(ddtable.Rows[i][2].ToString()); //ti_sp
            }
        }
        //public void ingresa_valores_grafic(DataTable dtable, Series serie)
        //{   for (int i = 0; i < dtable.Rows.Count; i++)
        //    {
        //        //serie.Label = dtable.Rows[i][1].ToString();
        //        serie.Points.Add(double.Parse(dtable.Rows[i][0].ToString()));
        //        //  serie.Points.Add(ti_pp);
        //     }

        //}
        
        public void ingresa_col_vector( string [] digrafos, string nombre_sp, int iduser ) {
            DataTable dt = new DataTable();
            string digraf;
            dt = extraedatos(nombre_sp, "@iduser", iduser);
            int numfilas_dt=dt.Rows.Count;
            for (int i = 0; i < numfilas_dt; i++)
            {
                digrafos[i+1] = dt.Rows[i][1].ToString(); //estaba como i+1
                int y = i;
             }
        
            }
        }
    }
    


