<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportesAdmin.aspx.cs" Inherits="ProyectoFinalP_PrograIII.ReportesAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: x-large">
        <strong>________ REPORTE ADMIN _______</strong></p>
    <asp:Menu ID="Menu1" runat="server" BackColor="#333333" BorderColor="#666666" BorderStyle="Outset" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="White" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="10px" style="font-size: large; text-align: left">
        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#F7F6F3" />
        <DynamicSelectedStyle BackColor="#5D7B9D" />
        <Items>
            <asp:MenuItem Text="Día Del Mes Con Más Pacientes" Value="Día Del Mes Con Más Pacientes"></asp:MenuItem>
            <asp:MenuItem Text="Pacientes atendidos Entre Dos Fechas" Value="Pacientes atendidos Entre Dos Fechas"></asp:MenuItem>
            <asp:MenuItem Text="Pacientes Que No se Presetnaron a Consulta" Value="Pacientes Que No se Presetnaron a Consulta"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#5D7B9D" />
    </asp:Menu>
    <br />
    <ul>
        <li>&nbsp;
            <asp:Label ID="Label1" runat="server" style="font-size: large; font-weight: 700" Text="Del Mes:" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" style="font-size: large; font-weight: 700" Text="Entre El Mes:" Visible="False"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownListMes1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Visible="False">
            </asp:DropDownList>
&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" style="font-size: large; font-weight: 700" Text="Y" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListMes2" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Visible="False">
            </asp:DropDownList>
        </li>
        <li>
            <asp:Button ID="ButtonMostrar" runat="server" Height="36px" OnClick="Button1_Click" Text="Ver Reporte" Visible="False" />
        </li>
    </ul>
    <p>
        <asp:Label ID="Label4" runat="server" style="font-weight: 700; text-decoration: underline" Text="."></asp:Label>
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
</asp:Content>
