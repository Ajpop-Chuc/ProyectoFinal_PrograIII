<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ConsultaNueva.aspx.cs" Inherits="ProyectoFinalP_PrograIII.ConsultaNueva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <p class="text-center">
        <br />
        <span style="font-size: larger; text-align: center; font-weight: 700">_______________ Consulta Nueva _______________</span></p>
    <p>
        <span style="font-size: large"><strong><em>&nbsp;&nbsp;&nbsp; Nit Paciente</em>&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxNit" runat="server" style="font-size: large" Width="134px"></asp:TextBox>
        &nbsp;<asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
        </span>
    </p>
     <p class="text-center" style="font-size: x-large; text-decoration: underline;">
         <strong><em>Datos de la Cita</em></strong></p>
    <ul>
        <li style="font-weight: 700"><em>Temperatura:&nbsp;
            <asp:TextBox ID="TextBoxTemperatura" runat="server"></asp:TextBox>
            </em>&nbsp;<span style="font-weight: normal"><em>[°F]
            <asp:RequiredFieldValidator ID="Validacion1" runat="server" ControlToValidate="TextBoxTemperatura" Enabled="False" ErrorMessage="Campo Requerido" BackColor="#CC0000" ForeColor="White"></asp:RequiredFieldValidator>
            </em>
            </span>
        </li>
        <li><strong><em>Presión:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPresión" runat="server"></asp:TextBox>
            &nbsp;
            </em>
            </strong>
            <em>[ml-Mercurío]&nbsp; <span style="font-weight: normal">
            <asp:RequiredFieldValidator ID="Validacion2" runat="server" ControlToValidate="TextBoxPresión" Enabled="False" ErrorMessage="Campo Requerido" BackColor="#CC0000" ForeColor="White"></asp:RequiredFieldValidator>
            </span>
            </em>
        </li>
        <li><strong><em>Síntomas:&nbsp; </em> </strong><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListSintomas" runat="server" Height="16px" Width="124px">
            </asp:DropDownList>
&nbsp;<asp:Button ID="ButtonAgregarSintoma" runat="server" Text="Agregar Sintoma" Visible="False" OnClick="ButtonAgregarSintoma_Click" />
            </em>
        </li>
        <li><strong><em>Diagnóstico:&nbsp;</em></strong></li>
    </ul>
<p>
    <strong><em>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxDiagnostico" runat="server" Height="116px" TextMode="MultiLine" Width="278px"></asp:TextBox>
    </em>
    </strong>
</p>
<ul>
        <li><strong><em>Tratamiento:&nbsp;
            </em>
            </strong></li>
    </ul>
<p>
    <em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </em> <strong>
    <em>
    <asp:TextBox ID="TextBoxTratamiento" runat="server" Height="116px" TextMode="MultiLine" Width="278px"></asp:TextBox>
    </em>
    </strong>
</p>
         <ul>
             <li><strong><em>Receta:</em></strong><ul>
                 <li><em>Medicamento: </em> <strong><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:DropDownList ID="DropDownListMedicamento" runat="server" OnSelectedIndexChanged="DropDownListMedicamento_SelectedIndexChanged" ValidateRequestMode="Disabled" Width="121px">
                     </asp:DropDownList>
                     </em>
                     </strong></li>
                 <li><em>Dosis:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxDosis" runat="server"></asp:TextBox>
&nbsp;[mlg] </em></li>
                 <li><em>Administración Cada: <asp:TextBox ID="TextBoxHorarioAdmin" runat="server"></asp:TextBox>
&nbsp;[Horas]&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="ButtonAgregarReceta" runat="server" Text="Agregar" Visible="False" OnClick="ButtonAgregarReceta_Click" />
                     </em>
                 </li>
                 </ul>
             </li>
             <li><strong><em>Costo de la consulta:
            </em>
            </strong><em>&nbsp;&nbsp;
                 <asp:TextBox ID="TextBoxCosto" runat="server" Width="116px"></asp:TextBox>
&nbsp; [Quetzales]&nbsp; <strong>
                 <span style="font-weight: normal">
            <asp:RequiredFieldValidator ID="Validacion3" runat="server" ControlToValidate="TextBoxTemperatura" Enabled="False" ErrorMessage="Campo Requerido" BackColor="#CC0000" ForeColor="White" style="font-size: x-small"></asp:RequiredFieldValidator>
            </span>
    </strong>
                 </em></li>
             <li style="font-weight: 700"><em>Imagenes&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="FileUploadImagen" runat="server" />
                 </em></li>
         </ul>
    <p>
        <em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonGuardarConsulta" runat="server" Text="GUARDAR CUNSULTA" Visible="False" OnClick="ButtonGuardarConsulta_Click" />
         </em>
         </p>
</asp:Content>
