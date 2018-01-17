<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 186px;
        }
        .auto-style3 {
            width: 177px;
        }
        .auto-style4 {
            width: 177px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 108px;
        }
        .auto-style7 {
            width: 94px;
        }
        .auto-style8 {
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblSaludo" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 616px" Text="Cerrar Session" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Producto" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Listar Productos" />
            <br />
            <asp:GridView ID="GridListadoProducto" runat="server" DataKeyNames="Id_Producto" AutoGenerateColumns="False" OnSelectedIndexChanged="GridListadoProducto_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" />
                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                    <asp:CommandField HeaderText="Opción" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Ingresar Producto</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Descripción</td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Cantidad</td>
                <td>
                    <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Precio</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Panel ID="PanelOpciones" runat="server">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">Opciones</td>
                    <td class="auto-style7">&nbsp;&nbsp;
                        <asp:Button ID="btnGuardar" runat="server" OnClick="Button3_Click" Text="Guardar" />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
                    </td>
                    <td>&nbsp;<asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
