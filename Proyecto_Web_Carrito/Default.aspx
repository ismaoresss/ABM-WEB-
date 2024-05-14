<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_Web_Carrito.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav class="navbar bg-body-tertiary">
        <div class="d-flex" role="search">
            <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">

            <%--<button class="btn btn-outline-success" type="submit">Search</button>--%>
        </div>
    </nav>

    <h2>Lista articulos:</h2>
    <br>

    <div class="row row-cols-1 row-cols-sm-5 g-4 d-flex align-items: center">
        <% foreach (Dominio.Articulos articulo in ListaArticulos)
            { %>
        <div class="col">
            <div class="card h-100">
                <img src="<%: articulo.Imagen %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%: articulo.Nombre %></h5>
                    <p class="card-text"><%: articulo.Descripcion %></p>
                    <h3 class="card-text">$ <%: articulo.Precio %></h3>

                    <a href="DetalleArticulo.aspx?id=<%: articulo.IdArticulo %>">Ver más</a>

                </div>
                <a href="Carrito.aspx?id=<%: articulo.IdArticulo %>" class="btn btn-primary">Agregar al carrito</a>
            </div>
        </div>

        <% } %>
    </div>

    <asp:GridView ID="dgvArticulos" runat="server"></asp:GridView>

</asp:Content>
