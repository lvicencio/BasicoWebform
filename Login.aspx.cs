using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Negocio;

public partial class Login : System.Web.UI.Page
{
    public E_Usuario objEntUsuario = new E_Usuario();
    public N_Usuarios objNegUsuario = new N_Usuarios();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngreso_Click(object sender, EventArgs e)
    {

        if ((txtUserName.Text != "") || (txtPassword.Text != ""))
        {
            DataSet ds = new DataSet();
            var UserName = txtUserName.Text;
            var Password = txtPassword.Text;
            ds = objNegUsuario.Login(UserName, Password);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var rol = ds.Tables[0].Rows[0]["id_rol"].ToString();
                var username = ds.Tables[0].Rows[0]["UserName"].ToString();
                //lblRol.Text = Convert.ToString(rol);
                Session["Rol"] = rol;
                Session["UserName"] = username;
                switch (rol)
                {
                    case "1":
                        Response.Redirect("Admin.aspx");
                        break;
                    case "2":
                        Response.Redirect("User.aspx");
                        break;

                    default:
                        break;
                }

            }
            else
                LalblMsg.Text = "Clave o Password incorrectos";

        }
        else
            LalblMsg.Text = "Ingrese Username y Password";

    }
}