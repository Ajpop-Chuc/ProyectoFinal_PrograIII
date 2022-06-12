<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ReporteConsultas.aspx.cs" Inherits="ProyectoFinalP_PrograIII.ReporteConsultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h1 style="text-align: center"><strong>REPORTES DE CONSULTA</strong></h1>
    <p>
        &nbsp;<asp:RadioButton ID="RBEnfermedades" runat="server" Text="Enfermedades más comunes" />
      </p>
    <p>
        <asp:RadioButton ID="RBEdades" runat="server" Text="Edad promedio de pacientes" />
    </p>
    <p>
        <asp:RadioButton ID="RBMedicamentos" runat="server" Text="Medicamentos recetados" />
    </p>
    <p>
        <asp:RadioButton ID="RBIngresos" runat="server" Text="Total de dinero ingresado" OnCheckedChanged="RBIngresos_CheckedChanged" />
    </p>
    <h1>
        <asp:Button ID="btnVer" runat="server" Height="24px" OnClick="btnVer_Click" Text="Ver" Width="160px" />
        <asp:GridView ID="GridViewReporteC" runat="server" Visible="False">
        </asp:GridView>
        <asp:Label ID="LabelEdadPromedio" runat="server" Visible="False"></asp:Label>
    &nbsp;</h1>
      <h1>
          <asp:DropDownList ID="DropDownListMes1" runat="server">
          </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownListMes2" runat="server">
          </asp:DropDownList>
    </h1>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
