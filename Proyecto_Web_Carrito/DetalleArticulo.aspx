<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Proyecto_Web_Carrito.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Mochiy+Pop+One&display=swap">
    <link href="EstilosParaIsma.css" rel="stylesheet" />

    <div class="detalle-articulo">
        <h1>DETALLE ARTICULO</h1>
    

    <div class="form-group">
        <asp:Label ID="lblnombre" runat="server" Text="Nombre:" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion:" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblprecio" runat="server" Text="Precio: $" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Lblmarca" runat="server" Text="Marca: " CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtmarca" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblcategoria" runat="server" Text="Categoria: " CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>

</div>
    <div class="imagen-container">
        <asp:Repeater runat="server" ID="repDetalle">
            <ItemTemplate>
                <div class="card h-100">
                    <img src='<%# Container.DataItem %>' alt="Imagen" class="container mt-4" onerror="this.src='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSt4xXXEwlOngpYGhvok77NVHkRONev9pOY_XHZ3M29aA&s';" />
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <div class="button-container d-flex justify-content-between mt-4">
        <a href="Default.aspx" class="btn btn-primary btn-back">Volver</a>
        <asp:Button CssClass="btn btn-success" ID="btnAgregarAlCarrito" runat="server" Text="Agregar al Carrito" OnClick="btnAgregarAlCarrito_Click" CommandArgument='<%# Request.QueryString["IdArticulo"] %>' /> 
    </div>


</asp:Content>

