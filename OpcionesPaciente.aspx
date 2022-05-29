<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OpcionesPaciente.aspx.cs" Inherits="ProyectoFinalP_PrograIII.OpcionesPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
        <p class="text-justify">
        <asp:Menu ID="Menu1" runat="server" BackColor="#999999" BorderColor="#999999" BorderStyle="Outset" ForeColor="White" OnMenuItemClick="Menu1_MenuItemClick1" StaticSubMenuIndent="16px" style="font-size: large">
            <Items>
                <asp:MenuItem Text="Agregar Nuevo Paciente " Value="AgregarPaciente "></asp:MenuItem>
                <asp:MenuItem Text="Actualizar Paciente " Value="ActualizarPaciente "></asp:MenuItem>
            </Items>
    </asp:Menu>
        <div class="text-left">
            <strong>
            <br style="font-size: large" />
            </strong><span style="font-size: large"><strong>Nit&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></span>&nbsp;<strong><asp:TextBox ID="TextBoxNit" runat="server" style="font-size: large"></asp:TextBox>
            <span style="font-size: large">&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="ButtonBuscar" runat="server" style="font-size: small" Text="Buscar" Visible="False" OnClick="ButtonBuscar_Click" />
            <br style="font-size: large" />
            </strong><span style="font-size: large"><strong>Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></span><strong>
            <asp:TextBox ID="TextBoxNombre" runat="server" style="font-size: large"></asp:TextBox>
            <br style="font-size: large" />
            </strong><span style="font-size: large"><strong>Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong></span><strong><asp:TextBox ID="TextBoxApellido" runat="server" style="font-size: large"></asp:TextBox>
            <br style="font-size: large" />
            </strong><span style="font-size: large"><strong>Direccion&nbsp;&nbsp;&nbsp;</strong></span><strong><asp:TextBox ID="TextBoxDireccion" runat="server" style="font-size: large"></asp:TextBox>
            <br style="font-size: large" />
            </strong><span style="font-size: large"><strong>Fecha de Nacimiento&nbsp; </strong>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="189px" NextPrevFormat="FullMonth" Width="343px" DayNameFormat="Shortest">
            <DayHeaderStyle Font-Bold="True" Font-Size="7pt" BackColor="#CCCCCC" ForeColor="#333333" Height="10pt" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
            <TodayDayStyle BackColor="#CCCC99" />
    </asp:Calendar>
        </span><strong>
        <br style="font-size: large" />
        </strong><span style="font-size: large"><strong>Teléfono&nbsp;&nbsp;&nbsp;&nbsp; </strong></span><strong>
        <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
        </strong>
    </p>
    <p class="text-center">
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAgregar" runat="server" style="font-size: large" Text="Agregar" Visible="False" OnClick="ButtonAgregar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonActualizar" runat="server" style="font-size: large" Text="Actualizar" Visible="False" OnClick="ButtonActualizar_Click" />
        </strong>
    </p>
</asp:Content>
