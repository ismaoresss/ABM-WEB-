<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Proyecto_Web_Carrito.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--    <asp:Label CssClass="contador" ID="contador" runat="server" Text="">0</asp:Label>--%>

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

<div class="imagen-container">
    <asp:Repeater runat="server" ID="repDetalle">
        <ItemTemplate>
            <img src='<%# Container.DataItem %>' alt="Imagen" />
        </ItemTemplate>
    </asp:Repeater>
</div>


</asp:Content>

