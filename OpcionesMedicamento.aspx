<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OpcionesMedicamento.aspx.cs" Inherits="ProyectoFinalP_PrograIII.OpcionesMedicamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center">
        <br />
        __________<strong><em>Agregar/Actualizar Medicamento__________</em></strong></h1>
    <ul>
        <li><strong><span style="font-size: large">Codigo Medicamento</span></strong>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCodigoMedicamento" runat="server"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="Validacioncodigom" runat="server" ControlToValidate="TextBoxCodigoMedicamento" Enabled="False" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonBuscarMedicamento" runat="server" OnClick="ButtonBuscarMedicamento_Click" Text="Buscar" />
        </li>
    </ul>
<p>
    &nbsp;</p>
<ul>
        <li><strong><span style="font-size: large">Ingrediente Generico</span></strong>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxIngredienteGenerico" runat="server"></asp:TextBox>
        </li>
    </ul>
<p>
    &nbsp;</p>
<ul>
        <li><strong><span style="font-size: large">Laboratorio </span></strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxLaboratorio" runat="server"></asp:TextBox>
        </li>
    </ul>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAgregarMedicamento" runat="server" OnClick="ButtonAgregarMedicamento_Click" Text="Agregar " />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonActualizarMedicamento" runat="server" OnClick="ButtonActualizarMedicamento_Click" Text="Actualizar" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
