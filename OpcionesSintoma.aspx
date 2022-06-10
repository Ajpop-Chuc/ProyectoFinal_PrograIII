<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OpcionesSintoma.aspx.cs" Inherits="ProyectoFinalP_PrograIII.OpcionesSintoma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align: center">
    <br />
    <em><strong>__________ Sintomas__________</strong></em></h1>
    <p class="text-left">
        Menu</p>
    <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" BorderStyle="Outset" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="10px">
        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#F7F6F3" />
        <DynamicSelectedStyle BackColor="#5D7B9D" />
        <Items>
            <asp:MenuItem Text="Agregar Sintoma" Value="AgregarSintoma"></asp:MenuItem>
            <asp:MenuItem Text="Actualizar Sintoma" Value="ActualizarSintoma"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#5D7B9D" />
    </asp:Menu>
<ul>
    <li><span style="font-size: large">Codigo Sintoma&nbsp;&nbsp;
        </span>
        <asp:TextBox ID="TextBoxCodigoSintoma" runat="server" style="font-size: large"></asp:TextBox>
        <span style="font-size: large">&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="ValidacionCodigoS" runat="server" ControlToValidate="TextBoxCodigoSintoma" Enabled="False" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        &nbsp; </span>
        <asp:Button ID="ButtonBuscarSintoma" runat="server" OnClick="ButtonBuscarSintoma_Click" Text="Buscar" style="font-size: large" Visible="False" />
    </li>
</ul>
<p>
    &nbsp;</p>
<ul>
    <li><span style="font-size: large">Descripcion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:TextBox ID="TextBoxDescripcionSintoma" runat="server" style="font-size: large"></asp:TextBox>
    </li>
</ul>
<p>
    &nbsp;</p>
<p class="text-left" style="text-align: center">
    <asp:Button ID="ButtonAgregarSintoma" runat="server" OnClick="ButtonAgregarSintoma_Click" Text="Agregar" style="font-size: large" Visible="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonActualizarSintoma" runat="server" OnClick="ButtonActualizarSintoma_Click" Text="Actualizar" style="font-size: large" Visible="False" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
