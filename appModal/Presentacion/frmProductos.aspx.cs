using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appModal.Presentacion
{
    public partial class frmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            int tamaño = fImagen.PostedFile.ContentLength;
            byte[] ImagenOriginal = new byte[tamaño];

            fImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, tamaño);
            Bitmap ImagenOriginalBinaria = new Bitmap(fImagen.PostedFile.InputStream);
        }
    }
}