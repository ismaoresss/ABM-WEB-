<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Proyecto_Web_Carrito.Carrito1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>

        <header id="header">
            <%-- <h1 class="text-info d-flex justify-content-center">Mi carrito de compras </h1>--%>
            <div>
                <img id="carrito" class="carrito rounded mx-auto d-block" src="https://cdn-icons-png.flaticon.com/128/2098/2098528.png" alt="">
                <h1 class="text-info d-flex justify-content-center">Mi carrito de compras </h1>
                <br />
                <div id="numero"></div>
            </div>
        </header>

        <main>
            <div id="contenedor" class="contenedor"></div>
        </main>

        <div id="contenedorCompra">
            <div class="informacionCompra" id="informacionCompra">

                <section class="body-def">
                    

                    <asp:Repeater runat="server" ID="repListado">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-3 mb-4 article-card">
                                    <div class="card border border-dark font-weight-bold mx-auto h-100" style="width: 18rem;">
                                        <div class="card-body">
                                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                            <p class="card-text"><%# Eval("Descripcion") %></p>
                                            <p class="card-text">Precio: $ <%#Eval("Precio") %></p>
                                            <asp:Button CssClass="btn-primary" Text="Eliminar" ID="btnEliminar" onclick="btnEliminar_Click" runat="server" CommandArgument='<%# Eval("IdArticulo") %>' CommandName="IdArticulo" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <section />

<%--                    <asp:GridView ID="dgvCarrito" runat="server" CssClass="table table-hover" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="CodArticulo" HeaderText="Codigo Articulo" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Categorias.Descripcion" HeaderText="Categoria" />

                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />

                    </Columns>
                </asp:GridView>--%>
                    <a href="Default.aspx" class="btn btn-primary">Volver a la lista de productos</a>

                    <asp:Button Text="Finalizar Compra" CssClass="btn btn-success" OnClick="FinalizarCompra_Click" runat="server" />
            </div>

            <div class="productosCompra" id="productosCompra"></div>
            <div class="total" id="total"></div>

        </div>
    </div>

</asp:Content>
