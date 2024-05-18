<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_Web_Carrito.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Mochiy+Pop+One&display=swap">
    <link href="EstilosParaIsma.css" rel="stylesheet" />


    <div class="reflected-header" style="text-shadow: 2px 2px #a732da;">
        <h1>PROGRAMACIÓN 3</h1>
    </div>

    <nav class="position-relative py-2 px-4 text-bg-secondary border border-secondary rounded-pill">
        <div class="d-flex" role="search">
            <asp:TextBox placeholder="Buscar producto..." AutoPostBack="true" ID="txtBuscar" CssClass="form-control me-2" runat="server" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>
        </div>
    </nav>
    <br>
    <h2>Lista artículos:</h2>

    <section class="body-def">
        <div class="container">
            <div class="row">

                <asp:Repeater runat="server" ID="idRep">
                    <ItemTemplate>

                        <div class="col-md-3 mb-4 article-card">
                            <div class="card h-100">
                                <img src="<%# Eval("Imagen") %>" class="card-img-top" onerror="this.src='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSt4xXXEwlOngpYGhvok77NVHkRONev9pOY_XHZ3M29aA&s';">
                                <div class="card-body">
                                    <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                    <p class="card-text"><%#Eval("Descripcion") %></p>
                                    <h3 class="card-text">$ <%#Eval("Precio") %></h3>

                                    <a href="DetalleArticulo.aspx?id=<%#Eval("IdArticulo") %>">Ver más</a>
                                </div>
                                <asp:Button ID="btnAgregarAlCarrito" runat="server" CssClass="btn btn-primary" Text="Agregar al carrito" OnClick="btnAgregarAlCarrito_Click" CommandArgument='<%# Eval("IdArticulo") %>' CommandName="IdArticulo" />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>



    <asp:GridView ID="dgvArticulos" runat="server"></asp:GridView>
    <%--    <div class="row row-cols-1 row-cols-sm-5 g-4 d-flex align-items: center">
        <% foreach (Dominio.Articulos articulo in ListaArticulos)
            { %>

        <% } %>
    </div>--%>
</asp:Content>
