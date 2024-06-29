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
    public partial class pp : Form
    {
        conexion cn = new conexion();
        xyzConsulta dat = new xyzConsulta();
        public string Cons = "2";
        public string NoCons = "1";
        public string Mens = "2";
        public pp()
        {
            InitializeComponent();
        }

        private void pp_Load(object sender, EventArgs e)
        {
            CargaGrid(dataGridView1);
            CargaGridFinal1(dtgF1);
            CargaGridFinal2(dtgF2);

            this.dataGridView1.Columns[0].Visible = false;

            cmbp.DisplayMember = "NombreDestino";
            cmbp.ValueMember = "IdDestino";
            cmbp.DataSource = dat.extraedatos("sp_cargaDestino");

            cmbTdoc.DisplayMember = "NomDocumento";
            cmbTdoc.ValueMember = "idtipo";
            cmbTdoc.DataSource = dat.extraedatos("sp_cargaTipoDocumento");
        }
        public string getdireccion()
        {
            string rpta = "";
            DataTable dt = new DataTable();
           
                int iddes = int.Parse(cmbp.SelectedValue.ToString());
                dt = dat.extraedatos("sp_cargaDireccion", "@idDestino", iddes);
                if (dt.Rows.Count > 0)
                    rpta = dt.Rows[0][0].ToString();
                else
                    rpta = "";
                return rpta;
        }
        public string getlugar()
        {
            string rpta = "";
            DataTable dt = new DataTable();

            int iddes = int.Parse(cmbp.SelectedValue.ToString());
            dt = dat.extraedatos("sp_cargaLugar", "@idDestino", iddes);
            if (dt.Rows.Count > 0)
                rpta = dt.Rows[0][0].ToString();
            else
                rpta = "";
            return rpta;
        }
        public string getSalida()
        {
            string rpta = "";
            DataTable dt = new DataTable();

            int iddes = int.Parse(cmbp.SelectedValue.ToString());
            dt = dat.extraedatos("sp_BuscarEnvRegCarg", "@NSalid", iddes);
            if (dt.Rows.Count > 0)
                rpta = dt.Rows[0][0].ToString();
            else
                rpta = "";
            return rpta;
        }
        private void cmbp_SelectedIndexChanged(object sender, EventArgs e)
        {
           txtdireccion.Text = getdireccion();
           txtLugar.Text = getlugar();
           
        }
        public void CargaGridFinal1(DataGridView dtgF1)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ABusNotAcons";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgF1.DataSource = dt;
        }
        public void CargaGridFinal2(DataGridView dtgF2)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ABusAcons";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgF2.DataSource = dt;
        }
        public void CargaGrid(DataGridView dataGridView1)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCarg";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dataGridView1.DataSource = dt;
        }
        public void CargaGridfil1(DataGridView dataGridView1, string Salida)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCargFilNumSali";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@NS", SqlDbType.NVarChar, 100).Value = Salida;
            //da.SelectCommand.Parameters.Add("@NS", SqlDbType.NVarChar, 100).Value = NumDoc;
            da.Fill(dt);
            cn.desconectar();
            dataGridView1.DataSource = dt;
        }
        public void CargaGridfil2(DataGridView dataGridView1)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarEnvRegCargFilNumDoc";
            cn.conectar();
            da.SelectCommand = cmd;
            //string Dest = cmbTdoc.SelectedValue.ToString().Trim();
            //da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar).Value = Dest;
            //da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar, 100).Value = NumDoc;
            string tipdoc = cmbTdoc.SelectedValue.ToString().Trim() + txtNumDoc.Text.Trim();
            da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar).Value = tipdoc;
            da.Fill(dt);
            cn.desconectar();
            dataGridView1.DataSource = dt;
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargaGridfil1(dataGridView1, txtSalida.Text);
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
            CargaGridfil2(dataGridView1);
        }

        private void cmbTdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGridfil2(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgF1.Rows)
            {
                //if (bool.Parse(item.Cells[0].Value.ToString()))
                //if ((Boolean)item.Cells[0].Value == true)
                  if (item.Cells[0].Value != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    cmd.Connection = cn.sqlcad;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_AModAcons";
                    string a = item.Cells[1].Value.ToString();
                    cmd.Parameters.Add("@IdA", SqlDbType.VarChar).Value = a;
                    string b = item.Cells[2].Value.ToString();
                    cmd.Parameters.Add("@AnDoc", SqlDbType.VarChar).Value = b;
                    string c = item.Cells[3].Value.ToString();
                    cmd.Parameters.Add("@ADirec", SqlDbType.VarChar).Value = c;
                    cmd.Parameters.Add("@Acons", SqlDbType.VarChar).Value = Cons;
                    //cmd.Parameters.Add("@IdA", SqlDbType.VarChar).Value = int.Parse(IdA);
                    //cmd.Parameters.Add("@AnDoc", SqlDbType.VarChar).Value = Ndoc;
                    //cmd.Parameters.Add("@ADirec", SqlDbType.VarChar).Value = Direc;
                    //cmd.Parameters.Add("@Acons", SqlDbType.VarChar).Value = Cons;
                    //cmd.Parameters.Add("@Acons", SqlDbType.Char).Value = txt1.Text;
                    cn.conectar();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                    }
                    cn.desconectar();
                }
            }
            MessageBox.Show("Actualizacion Exitosa ...!");
            CargaGridFinal1(dtgF1);
            CargaGridFinal2(dtgF2);
        }
        //private void dtgF1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    IdA = this.dtgF1.CurrentRow.Cells[1].Value.ToString();
        //    Ndoc = this.dtgF1.CurrentRow.Cells[2].Value.ToString();
        //    Direc = this.dtgF1.CurrentRow.Cells[3].Value.ToString();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgF2.Rows)
            {
                if (item.Cells[0].Value != null)
                {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AModAcons";
            string a = item.Cells[1].Value.ToString();
            cmd.Parameters.Add("@IdA", SqlDbType.VarChar).Value = a;
            string b = item.Cells[2].Value.ToString();
            cmd.Parameters.Add("@AnDoc", SqlDbType.VarChar).Value = b;
            string c = item.Cells[3].Value.ToString();
            cmd.Parameters.Add("@ADirec", SqlDbType.VarChar).Value = c;
            cmd.Parameters.Add("@Acons", SqlDbType.VarChar).Value = NoCons;
                    cn.conectar();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                    }
                    cn.desconectar();
                }
            }
            MessageBox.Show("Actualizacion Exitosa ...!");
            CargaGridFinal1(dtgF1);
            CargaGridFinal2(dtgF2);
        }
        public void ActuFinal1()
        {
            foreach (DataGridViewRow item in dtgF2.Rows)
            {
                  if (item.Cells[0].Value != null)
                {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AModANumcons";
            string a = item.Cells[1].Value.ToString();
            cmd.Parameters.Add("@IdA", SqlDbType.VarChar).Value = a;
            string b = item.Cells[2].Value.ToString();
            cmd.Parameters.Add("@AnDoc", SqlDbType.VarChar).Value = b;
            string c = item.Cells[3].Value.ToString();
            cmd.Parameters.Add("@ADirec", SqlDbType.VarChar).Value = c;
            cmd.Parameters.Add("@ANcons", SqlDbType.VarChar).Value = txt2.Text;
            //cmd.Parameters.Add("@Acons", SqlDbType.Char).Value = txt1.Text;
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            cn.desconectar();
                }
            }
            MessageBox.Show("Actualizacion Exitosa ...!");
            CargaGridFinal1(dtgF1);
            CargaGridFinal2(dtgF2);
        }
        public void ActuFinal2()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ARegCons";
            cmd.Parameters.Add("@IdA", SqlDbType.VarChar).Value = int.Parse(txt1.Text);
            cmd.Parameters.Add("@AnDoc", SqlDbType.VarChar).Value = txt2.Text;
            cmd.Parameters.Add("@ADirec", SqlDbType.VarChar).Value = txt3.Text;
            cmd.Parameters.Add("@Acons", SqlDbType.VarChar).Value = NoCons;
            cmd.Parameters.Add("@ANcons", SqlDbType.VarChar).Value = txt2.Text;
            cmd.Parameters.Add("@Amens", SqlDbType.VarChar).Value = Mens;
            //cmd.Parameters.Add("@Acons", SqlDbType.Char).Value = txt1.Text;
            cn.conectar();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reg Exitoso ...!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Reg");
            }
            cn.desconectar();
            CargaGridFinal1(dtgF1);
            CargaGridFinal2(dtgF2);
        }
        //private void dtgF2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    IdA2 = this.dtgF2.CurrentRow.Cells[0].Value.ToString();
        //    Ndoc2 = this.dtgF2.CurrentRow.Cells[1].Value.ToString();
        //    Direc2 = this.dtgF2.CurrentRow.Cells[2].Value.ToString();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            ActuFinal1();
            ActuFinal2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = this.dtgF1.CurrentRow.Cells[0].Value.ToString();
            //if (bool.Parse(s))
            //if (s != null)
                if (bool.Parse(s) == true)
            {
                ppfe i = new ppfe();
                i.ap = this.dtgF1.CurrentRow.Cells[1].Value.ToString();
                i.bp = this.dtgF1.CurrentRow.Cells[2].Value.ToString();
                i.cp = this.dtgF1.CurrentRow.Cells[3].Value.ToString();

                i.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView1.Columns[0].Visible = false;
        }

        //private void dtgCargaEnvios_VisibleChanged(object sender, EventArgs e)
        //{
        //    this.dtgCargaEnvios.Columns["IdConsEnvioEE"].Visible = false;
        //}
    }
}
