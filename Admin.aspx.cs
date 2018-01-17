using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Negocio;

public partial class Admin : System.Web.UI.Page
{

    public E_Producto objEntProducto = new E_Producto();
    public N_Productos objNegProducto = new N_Productos();

    public E_Usuario objEntUsuario = new E_Usuario();
    public N_Usuarios objNegUsuario = new N_Usuarios();


    protected void Page_Load(object sender, EventArgs e)
    {
        int sessionrol = Convert.ToInt16(Session["Rol"]);


        if (sessionrol != 1)
        {
            Response.Write("<script>window.alert('Aviso: No esta autorizado')</script>");
            Response.Redirect("Login.aspx");
        }
        else
        {
            lblSaludo.Text = "Bienvenido Sr(a)  " + Session["UserName"].ToString();
        }
       // EscondeControl();
    }


    private void Limpiar()
    {
        txtCantidad.Text = string.Empty;
        txtDescripcion.Text = string.Empty;
        txtNombre.Text = string.Empty;
        txtPrecio.Text = string.Empty;
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Login.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
       
        ds = objNegProducto.ListadoProductos();

        if (ds.Tables[0].Rows.Count > 0)
        {
            GridListadoProducto.DataSource = ds.Tables[0];
            GridListadoProducto.DataBind();
            GridListadoProducto.Visible = true;
        }
        else
            Response.Write("<script>window.alert('Aviso: No existen productos')</script>");

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int nGrabados = -1;

        objEntProducto.CantidadProducto = int.Parse(txtCantidad.Text);
        objEntProducto.DescripcionProducto = txtDescripcion.Text;
        objEntProducto.NombreProducto = txtNombre.Text;
        objEntProducto.Precio = int.Parse(txtPrecio.Text);

        nGrabados = objNegProducto.abcProducto("INSERTAR", objEntProducto);

        if (nGrabados != -1)
        {
            lblMsg.Text = "Producto Grabado";
            Limpiar();
        }
        else
        {
            lblMsg.Text = "Error al Guardar Producto";
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        var NombreProducto = txtBuscar.Text;
        ds = objNegProducto.BuscarProducto(NombreProducto);

        if (ds.Tables[0].Rows.Count > 0)
        {

            GridListadoProducto.DataSource = ds.Tables[0];
            GridListadoProducto.DataBind();
            GridListadoProducto.Visible = true;
        }
    }

    protected void GridListadoProducto_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        objEntProducto.Id_Producto = Convert.ToInt16(GridListadoProducto.DataKeys[GridListadoProducto.SelectedIndex].Value.ToString());

        ds = objNegProducto.SeleccionaProducto(objEntProducto.Id_Producto);

        if (ds.Tables[0].Rows.Count > 0)
        {

            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtDescripcion.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
            txtCantidad.Text = ds.Tables[0].Rows[0]["Cantidad"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();

            //EscondeControl();
            //pnlIngresos.Visible = true;
            btnGuardar.Visible = false;
        }
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        int nResultado = -1;

        objEntProducto.Id_Producto = Convert.ToInt16(GridListadoProducto.DataKeys[GridListadoProducto.SelectedIndex].Value.ToString());

        objEntProducto.CantidadProducto = int.Parse(txtCantidad.Text);
        objEntProducto.DescripcionProducto = txtDescripcion.Text;
        objEntProducto.NombreProducto = txtNombre.Text;
        objEntProducto.Precio = int.Parse(txtPrecio.Text);
        
        nResultado = objNegProducto.abcProducto("MODIFICAR", objEntProducto);

        if (nResultado != -1)
        {
            Response.Write("<script>window.alert('Aviso: El producto fue modificado con exito')</script>");
            Response.Redirect("Admin.aspx");
        }
        else
        {
            Response.Write("<script>window.alert('Aviso: NO se modifico el producto')</script>");
        }
    }




    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        int nResultado = -1;

        objEntProducto.Id_Producto = Convert.ToInt16(GridListadoProducto.DataKeys[GridListadoProducto.SelectedIndex].Value.ToString());

        objEntProducto.CantidadProducto = int.Parse(txtCantidad.Text);
        objEntProducto.DescripcionProducto = txtDescripcion.Text;
        objEntProducto.NombreProducto = txtNombre.Text;
        objEntProducto.Precio = int.Parse(txtPrecio.Text);

        nResultado = objNegProducto.abcProducto("BORRAR", objEntProducto);

        if (nResultado != -1)
        {
            Response.Write("<script>window.alert('Aviso: El producto fue modificado con exito')</script>");
            Response.Redirect("Admin.aspx");
        }
        else
        {
            Response.Write("<script>window.alert('Aviso: NO se Elimino el producto')</script>");
        }
    }
}