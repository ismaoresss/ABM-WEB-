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
            </div>

            <div class="productosCompra" id="productosCompra"></div>
            <div class="total" id="total"></div>
            <button>Finalizar Compra</button>
        </div>

    </div>

</asp:Content>
