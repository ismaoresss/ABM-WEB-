<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Proyecto_Web_Carrito.Carrito1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>

        <header id="header">
            <h1>Elementos del carrito</h1>
            <div>
                <img id="carrito" class="carrito" src="https://cdn-icons-png.flaticon.com/128/2098/2098528.png" alt="">
                <div id="numero"></div>
            </div>
        </header>

        <main>
            <div id="contenedor" class="contenedor"></div>
        </main>

        <div id="contenedorCompra">
            <div class="informacionCompra" id="informacionCompra">
                <h2>ACA FIGURARAN LOS ELEMENTOS</h2>
                <p class="x" id="x">x</p>
                <asp:GridView ID="dgvCarrito" runat="server"></asp:GridView>
                <a href="Default.aspx" class="btn btn-secondary">Volver a la lista de productos</a>
            </div>

            <div class="productosCompra" id="productosCompra"></div>
            <div class="total" id="total"></div>
            <asp:Button Text="Finalizar Compra" ID="FinalizarCompra" OnClick="FinalizarCompra_Click" runat="server" />
        </div>
        <a href="/" class="btn btn-secondary" >Volver</a>

    </div>

</asp:Content>
