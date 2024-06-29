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
    public partial class BusquedaCargosRet : Form
    {
        conexion cn = new conexion();
        xyzConsulta datos = new xyzConsulta();
        public BusquedaCargosRet()
        {
            InitializeComponent();
        }

        private void BusquedaCargosRet_Load(object sender, EventArgs e)
        {
            CargaGrid(dtgBuscarCargo);

            this.dtgBuscarCargo.Columns[0].HeaderText = "Nº Salida";
            this.dtgBuscarCargo.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[1].HeaderText = "Nº Documento";
            this.dtgBuscarCargo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[2].HeaderText = "Destino";
            this.dtgBuscarCargo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[3].HeaderText = "Lugar";
            this.dtgBuscarCargo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[4].HeaderText = "Oficina";
            this.dtgBuscarCargo.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[5].HeaderText = "Fecha";
            this.dtgBuscarCargo.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[6].HeaderText = "Guia Remisión";
            this.dtgBuscarCargo.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[7].HeaderText = "F. Entrega";
            this.dtgBuscarCargo.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[8].HeaderText = "F. Retorno";
            this.dtgBuscarCargo.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[9].HeaderText = "Nº Paquete";
            this.dtgBuscarCargo.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgBuscarCargo.Columns[10].HeaderText = "Nº Remito";
            this.dtgBuscarCargo.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;



            cmbTdoc.DisplayMember = "NomDocumento";
            cmbTdoc.ValueMember = "idtipo";
            cmbTdoc.DataSource = datos.extraedatos("sp_cargaTipoDocumento");
        }
        private void txtLugar_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilLug(dtgBuscarCargo, txtLugar.Text);
        }
        public void CargaGrid(DataGridView dtgBuscarCargo)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarCargReg";
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            dtgBuscarCargo.DataSource = dt;
        }
        public void CargaGridfilNumSali(DataGridView dtgBuscarCargo, string Salida)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarCargRegFilNumSali";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@NS", SqlDbType.NVarChar, 100).Value = Salida;
            //da.SelectCommand.Parameters.Add("@NS", SqlDbType.NVarChar, 100).Value = NumDoc;
            da.Fill(dt);
            cn.desconectar();
            dtgBuscarCargo.DataSource = dt;
        }
        public void CargaGridfilNumDoc(DataGridView dtgBuscarCargo)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarCargRegFilNumDoc";
            cn.conectar();
            da.SelectCommand = cmd;
            //string Dest = cmbTdoc.SelectedValue.ToString().Trim();
            //da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar).Value = Dest;
            //da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar, 100).Value = NumDoc;
            string tipdoc = cmbTdoc.SelectedValue.ToString().Trim() + txtNumDoc.Text.Trim();
            da.SelectCommand.Parameters.Add("@ND", SqlDbType.VarChar).Value = tipdoc;
            da.Fill(dt);
            cn.desconectar();
            dtgBuscarCargo.DataSource = dt;
        }
        public void CargaGridfilFech(DataGridView dtgBuscarCargo, DateTime Fecha)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarCargRegFilFech";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Fch", SqlDbType.Date).Value = Fecha;
            da.Fill(dt);
            cn.desconectar();
            dtgBuscarCargo.DataSource = dt;
        }
        public void CargaGridfilDest(DataGridView dtgBuscarCargo, string Destino)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarCargRegFilDest";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Dst", SqlDbType.NVarChar, 100).Value = Destino;
            da.Fill(dt);
            cn.desconectar();
            dtgBuscarCargo.DataSource = dt;
        }
        public void CargaGridfilLug(DataGridView dtgBuscarCargo, string Lugar)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarCargRegFilLug";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@Lgr", SqlDbType.NVarChar, 50).Value = Lugar;
            da.Fill(dt);
            cn.desconectar();
            dtgBuscarCargo.DataSource = dt;
        }
        public void CargaGridfilNumPaq(DataGridView dtgBuscarCargo, string Paquete)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_BuscarCargRegFilNumPaq";
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add("@NP", SqlDbType.NVarChar, 100).Value = Paquete;
            //da.SelectCommand.Parameters.Add("@NS", SqlDbType.NVarChar, 100).Value = NumDoc;
            da.Fill(dt);
            cn.desconectar();
            dtgBuscarCargo.DataSource = dt;
        }
        private void txtSalida_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilNumSali(dtgBuscarCargo, txtSalida.Text);
        }

        private void cmbTdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGridfilNumDoc(dtgBuscarCargo);
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilNumDoc(dtgBuscarCargo);
        }
        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilDest(dtgBuscarCargo, txtDestino.Text);
        }

        private void txtNumPaquete_TextChanged(object sender, EventArgs e)
        {
            CargaGridfilNumPaq(dtgBuscarCargo, txtNumPaquete.Text);
        }

        private void dtpFechaBuscarCargo_ValueChanged(object sender, EventArgs e)
        {
            CargaGridfilFech(dtgBuscarCargo, dtpFechaBuscarCargo.Value);
        }
    }
}
