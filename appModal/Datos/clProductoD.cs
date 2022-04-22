using appModal.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appModal.Datos
{
    public class clProductoD
    {
        public clProductoE mtdProductoD(clProductoE objDatos)
        {
            string consulta = "select * from producto where referencia='" + objDatos.referencia + "'and nombreProducto='" + objDatos + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clProductoE objDatosProducto = new clProductoE();
            if (tblDatos.Rows.Count == 1)
            {
                objDatosProducto.idProducto = int.Parse(tblDatos.Rows[0]["idProducto"].ToString());
                objDatosProducto.referencia = tblDatos.Rows[0]["referencia"].ToString();
                objDatosProducto.nombreProducto = tblDatos.Rows[0]["nombreProducto"].ToString();
                objDatosProducto.cantidad = tblDatos.Rows[0]["cantidad"].ToString();
                objDatosProducto.precio = float.Parse(tblDatos.Rows[0]["precio"].ToString());
                objDatosProducto.descripcion = tblDatos.Rows[0]["descripcion"].ToString();

            }
            else
            {
                objDatosProducto = null;
            }
            return objDatosProducto;
        }

        public int mtdRegistrar(clProductoE objDatosProductos)
        {
            string sql = "insert into producto(referencia,nombreProducto,cantidad,precio,descripcion)values('" + objDatosProductos.referencia + "','" + objDatosProductos.nombreProducto + "'," +
                "'" + objDatosProductos.cantidad + "'," + objDatosProductos.precio + ",'" + objDatosProductos.descripcion + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;
        }
    }
}