<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="HistorialMedico.aspx.cs" Inherits="ProyectoFinalP_PrograIII.HistorialMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <p>
        <br />
        <span style="font-size: large; text-align: center; font-weight: 700">_____ Historial Pacientes _____</span></p>
    <p>
        <span style="font-size: large">Nit Paciente&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" />
        </span>
    </p>
    <p>
        <span style="font-size: large">Citas Previas&nbsp;&nbsp;&nbsp; </span>
        <asp:DropDownList ID="DropDownList2" runat="server" style="font-size: large">
        </asp:DropDownList>
        <span style="font-size: large">&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonVisualizar" runat="server" Text="VER" />
    </p>
    <ul>
        <li>Fecha:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;Horario:&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </li>
        <li>Temperatura:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </li>
        <li>Presión:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </li>
        <li>Síntomas:<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </li>
        <li>Diagnóstico:&nbsp;
            <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea></li>
        <li>Tratamiento:
            <textarea id="TextArea2" cols="20" name="S2" rows="2"></textarea></li>
        <li>Receta:
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </li>
        <li>Costo de la consulta:
            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
&nbsp;<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                <Columns>
                    <asp:ImageField HeaderText="Imagen">
                    </asp:ImageField>
                    <asp:BoundField HeaderText="Descripcion " />
                </Columns>
            </asp:GridView>
        </li>
    </ul>
    <p>
    </p>
</asp:Content>
