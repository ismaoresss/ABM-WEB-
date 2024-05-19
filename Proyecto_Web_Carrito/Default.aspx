<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_Web_Carrito.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Mochiy+Pop+One&display=swap">
    <link href="EstilosParaIsma.css" rel="stylesheet" />

    <div class="reflected-header">
        <h1>PROGRAMACIÓN III</h1>
    </div>

    <nav class="position-relative py-2 px-4 text-bg-secondary border border-secondary rounded-pill">
        <div class="d-flex" role="search">
            <asp:TextBox placeholder="Buscar producto..." AutoPostBack="true" ID="txtBuscar" CssClass="form-control me-2" runat="server" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>
        </div>
    </nav>
    <br>


<p class="fs-1 fw-bolder">Lista artículos:</p>


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
                                </div>

                                <div class="mt-auto">

                                    <button class="btnVerDetalle btn btn-primary">
                                        <a href='<%# "DetalleArticulo.aspx?IdArticulo=" + Eval("IdArticulo") %>'>Detalle del Artículo</a>
                                    </button>

                                    <asp:Button class="btnVerDetalle btn btn-success" ID="btnAgregarAlCarrito" runat="server" Text="Agregar al carrito" OnClick="btnAgregarAlCarrito_Click" CommandArgument='<%# Eval("IdArticulo") %>' CommandName="IdArticulo" />

                                </div>


                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>



    <asp:GridView ID="dgvArticulos" runat="server"></asp:GridView>
</asp:Content>
