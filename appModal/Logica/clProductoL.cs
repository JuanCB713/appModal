using appModal.Datos;
using appModal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appModal.Logica
{
    public class clProductoL
    {
        public int mtdRegistrar(clProductoE objDatos)
        {
            clProductoD objDatosD = new clProductoD();
            int resultado = objDatosD.mtdRegistrar(objDatos);
            return resultado;
         
        }
    }
}