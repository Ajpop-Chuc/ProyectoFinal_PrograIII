<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="HistorialMedico.aspx.cs" Inherits="ProyectoFinalP_PrograIII.HistorialMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <p class="text-center">
        <br />
        <span style="font-size: larger; text-align: center; font-weight: 700">_______________ Historial Pacientes _______________</span></p>
    <p>
        <span style="font-size: large"><strong>Nit Paciente&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxNit" runat="server" style="font-size: large" Width="134px"></asp:TextBox>
        &nbsp;<asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" />
        </span>
    </p>
    <p>
        <span style="font-size: large"><strong>Citas Previas</strong>&nbsp;&nbsp;&nbsp; </span>
        <asp:DropDownList ID="DropDownListCitas" runat="server" style="font-size: large">
        </asp:DropDownList>
        &nbsp;<asp:Button ID="ButtonVisualizar" runat="server" Text="VER" />
    </p>
     <p class="text-center" style="font-size: x-large">
         <strong>Datos de la Cita</strong></p>
    <ul>
        <li style="font-weight: 700">Fecha:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxFecha" runat="server" Enabled="False"></asp:TextBox>
&nbsp;Horario:&nbsp;
            <asp:TextBox ID="TextBoxHorario" runat="server" Enabled="False"></asp:TextBox>
        </li>
        <li style="font-weight: 700">Temperatura:&nbsp;
            <asp:TextBox ID="TextBoxTemperatura" runat="server" Enabled="False"></asp:TextBox>
        </li>
        <li><strong>Presión:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPresión" runat="server" Enabled="False"></asp:TextBox>
            </strong>
        </li>
        <li><strong>Síntomas:&nbsp; </strong><asp:GridView ID="GridViewSintomas" runat="server" Height="116px" Width="278px">
            </asp:GridView>
        </li>
        <li><strong>Diagnóstico:&nbsp;</strong></li>
    </ul>
<p>
    <strong>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxDiagnostico" runat="server" Enabled="False" Height="116px" TextMode="MultiLine" Width="278px"></asp:TextBox>
    </strong>
</p>
<ul>
        <li><strong>Tratamiento:&nbsp;
            </strong></li>
    </ul>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
    <asp:TextBox ID="TextBoxTratamiento" runat="server" Enabled="False" Height="116px" TextMode="MultiLine" Width="278px"></asp:TextBox>
    </strong>
</p>
<ul>
        <li><strong>Receta:
            </strong>
            <asp:GridView ID="GridViewReceta" runat="server" Height="116px" Width="278px">
            </asp:GridView>
        </li>
        <li><strong>Costo de la consulta:
            </strong>&nbsp;<asp:TextBox ID="TextBoxCosto" runat="server" Enabled="False" Width="116px"></asp:TextBox>
        </li>
        <li style="font-weight: 700"><span style="font-weight: normal">.</span><asp:GridView ID="GridViewImagenes" runat="server" AutoGenerateColumns="False" Width="278px">
            <Columns>
                <asp:ImageField HeaderText="Imagen">
                </asp:ImageField>
                <asp:BoundField HeaderText="Descripcion" />
            </Columns>
            </asp:GridView>
        </li>
    </ul>
    <p>
        &nbsp;</p>
</asp:Content>
