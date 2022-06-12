using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalP_PrograIII
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlLogin.listaDatosLogin.Clear();
            ControlLogin.leerJson(Server.MapPath("Login.json"));
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string user = Login1.UserName;
            string pasword = Login1.Password;

            foreach (var x in ControlLogin.listaDatosLogin)
            {
                if ((x.usuario == user) && (x.contraseña == pasword))
                {
                    FormsAuthenticationTicket tkt;
                    string cookiestr;
                    HttpCookie ck;
                    tkt = new FormsAuthenticationTicket(1, Login1.UserName, DateTime.Now,
                    DateTime.Now.AddMinutes(30), Login1.RememberMeSet, "2");
                    cookiestr = FormsAuthentication.Encrypt(tkt);
                    ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                    if (Login1.RememberMeSet)
                        ck.Expires = tkt.Expiration;
                    ck.Path = FormsAuthentication.FormsCookiePath;
                    Response.Cookies.Add(ck);
                    string strRedirect = "Login.aspx";
                    if (x.modulo == 1)
                    {
                        strRedirect = "Default.aspx";
                    }
                    else if (x.modulo == 2)
                    {
                        strRedirect = "InicioM2.aspx";
                    }
                    Response.Redirect(strRedirect, true);
                }
            }

        }
    }
}