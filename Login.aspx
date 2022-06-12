<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoFinalP_PrograIII.Login" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Mi aplicación ASP.NET</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <style type="text/css">
        .auto-style1 {
            font-size: larger;
        }
    </style>

    </head>
<body>
    <form runat="server">

        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    &nbsp;</div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                    </ul>
                </div>
            </div>
        </div>
        <div class="container body-content">
            
            <span class="auto-style1"><strong>
            
            <br />
            ______________________________________________________________________________________________________________________________</strong><asp:Login ID="Login1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" Height="213px" OnAuthenticate="Login1_Authenticate" Width="1138px">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
            <strong>______________________________________________________________________________________________________________________________<br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            </strong></span>
            <footer>
                <p>&copy; <%: DateTime.Now.Year %> - ProyectoFinal Progra_III</p>
            </footer>
        </div>

    </form>
</body>
</html>
