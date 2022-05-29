<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroCitas.aspx.cs" Inherits="ProyectoFinalP_PrograIII.RegistroCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <span style="font-size: large"><strong> Menú </strong></span></p>
    <asp:Menu ID="Menu1" runat="server" BackColor="#999999" BorderColor="#CCCCCC" BorderStyle="Outset" ForeColor="White" StaticSubMenuIndent="16px" style="font-size: large; font-weight: 700" OnMenuItemClick="Menu1_MenuItemClick">
        <Items>
            <asp:MenuItem Text="Agendar Nueva Cita" Value="NuevaCita"></asp:MenuItem>
            <asp:MenuItem Text="Eliminar Citas" Value="EliminarCitas"></asp:MenuItem>
        </Items>
    </asp:Menu>
    <p class="text-left" style="font-size: large">
        &nbsp;</p>
    <p class="text-left" style="font-size: large">
        <strong>Datos Paciente</strong></p>
    <span style="font-size: large">Nit&nbsp;</span>
    <asp:DropDownList ID="DropDownListNit" runat="server">
    </asp:DropDownList>
    <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" style="font-size: xx-small" Text="Buscar" Visible="False" />
    <span style="font-size: xx-small">&nbsp; </span>&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Horario"></asp:Label>
    <p class="text-left" style="font-size: large">
        <strong>Datos Cita</strong>
    </p>
    <p style="font-size: large">
        Fecha&nbsp;
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="189px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="369px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
            <TodayDayStyle BackColor="#CCCC99" />
        </asp:Calendar>
        Incio&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxHInicio" runat="server" style="font-size: large" Width="96px"></asp:TextBox>
        <br />
        Finalizacion&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxHFinalizacion" runat="server" style="font-size: large" Width="92px"></asp:TextBox>
    </p>
    <p style="font-size: large; text-align: center;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAgendar" runat="server" OnClick="ButtonAgendar_Click" style="font-size: medium" Text="Programar Cita" Visible="False" />
        <span style="font-size: medium">&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:Button ID="ButtonEliminar" runat="server" OnClick="ButtonEliminar_Click" style="font-size: medium" Text="Eliminar Cita" Visible="False" />
    </p>
</asp:Content>
