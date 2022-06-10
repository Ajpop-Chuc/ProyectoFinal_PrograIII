<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OpcionesMedicamento.aspx.cs" Inherits="ProyectoFinalP_PrograIII.OpcionesMedicamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center" style="text-align: center">
        <br />
        __________<strong><em>Medicamentos__________</em></strong></h1>
    <p class="text-left">
        Menu</p>
    <asp:Menu ID="Menu1" runat="server" BorderStyle="Outset" OnMenuItemClick="Menu1_MenuItemClick">
        <Items>
            <asp:MenuItem Text="Agregar Medicamento" Value="AgregarMedicamento"></asp:MenuItem>
            <asp:MenuItem Text="Actualizar Medicamento" Value="ActualizarMedicamento"></asp:MenuItem>
        </Items>
    </asp:Menu>
    <ul>
        <li><strong><span style="font-size: large">Codigo Medicamento</span></strong><span style="font-size: large">&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:TextBox ID="TextBoxCodigoMedicamento" runat="server" style="font-size: large"></asp:TextBox>
            <span style="font-size: large">&nbsp;
            <asp:RequiredFieldValidator ID="Validacioncodigom" runat="server" ControlToValidate="TextBoxCodigoMedicamento" Enabled="False" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="ButtonBuscarMedicamento" runat="server" OnClick="ButtonBuscarMedicamento_Click" Text="Buscar" style="font-size: large" Visible="False" />
        </li>
    </ul>
<p>
    &nbsp;</p>
<ul>
        <li><strong><span style="font-size: large">Ingrediente Generico</span></strong><span style="font-size: large">&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:TextBox ID="TextBoxIngredienteGenerico" runat="server" style="font-size: large"></asp:TextBox>
        </li>
    </ul>
<p>
    &nbsp;</p>
<ul>
        <li><strong><span style="font-size: large">Laboratorio </span></strong><span style="font-size: large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:TextBox ID="TextBoxLaboratorio" runat="server" style="font-size: large"></asp:TextBox>
        </li>
    </ul>
    <p>
        &nbsp;</p>
    <p style="text-align: center">
        <asp:Button ID="ButtonAgregarMedicamento" runat="server" OnClick="ButtonAgregarMedicamento_Click" Text="Agregar " style="font-size: large" Visible="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonActualizarMedicamento" runat="server" OnClick="ButtonActualizarMedicamento_Click" Text="Actualizar" style="font-size: large" Visible="False" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
