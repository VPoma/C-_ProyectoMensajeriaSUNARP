using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace SistMensaSUNARP
{
    public class conexion
    {

        public SqlConnection sqlcad = new SqlConnection("Data source=.; initial catalog=SistMnsjSUNARP; Integrated security=True");

        public void conectar() {
            sqlcad.Open();
        }
        public void desconectar() {
            sqlcad.Close();
        }
    }
}