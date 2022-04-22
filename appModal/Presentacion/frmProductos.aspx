<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="appModal.Presentacion.frmProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/bootstrap.min.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-control my-5">

        <div class="mb-3 mt-3">
            <label for="Referencia" class="form-label">Referencia:</label>
            <asp:TextBox ID="txtReferencia" runat="server" CssClass="form-control" placeholder="Referencia" TextMode="Multiline"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="Nombre Producto" class="form-label">Nombre Producto:</label>
            <asp:TextBox ID="txtNombreProducto" runat="server" CssClass="form-control" placeholder="Nombre Producto" TextMode="Multiline"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="Cantidad" class="form-label">Cantidad:</label>
            <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" placeholder="Cantidad" TextMode="Multiline"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="Precio" class="form-label">Precio:</label>
            <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" placeholder="Precio" TextMode="Multiline"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="Precio" class="form-label">Precio:</label>
            <asp:TextBox ID="txtLugar" runat="server" CssClass="form-control" placeholder="Precio" TextMode="Multiline"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="Descripcion" class="form-label">Descripcion:</label>
            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" placeholder="Descripcion" TextMode="Multiline"></asp:TextBox>

            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

            <div class="container">
                <div class="col-md-border-border-4 col-md-offset-4">
                    Imagen Agregada
                    <asp:FileUpload ID="fImagen" accept=".jpg" runat="server" CssClass="form-control" />
                    <asp:Label ID="lblMensajes" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btnRegistrarProducto" runat="server" Text="Registrar Producto" CssClass="btn btn-success" OnClick="btnRegistrarProducto_Click" />
                </div>


            </div>

            <div class="form-check mb-3">
                <label class="form-check-label">
                    <input class="form-check-input" type="checkbox" name="remember">
                    Remember me
                </label>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </div>
</asp:Content>
