using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appModal.Datos
{
    public class clConexion
    {
        SqlConnection conexion;

        public clConexion()
        {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=dbProducto;Integrated Security=True");
            conexion.Open();

        }

        public DataTable mtdDesconectado(string sql)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }

        public int mtdConectado(string sql)
        {
            SqlCommand comando = new SqlCommand(sql, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }
    }
}
