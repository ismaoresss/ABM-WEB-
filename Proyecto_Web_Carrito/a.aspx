<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="a.aspx.cs" Inherits="Proyecto_Web_Carrito.Carrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="a.aspx.designer.cs">a.aspx.designer.cs</a>
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
    </form>
</body>
</html>


