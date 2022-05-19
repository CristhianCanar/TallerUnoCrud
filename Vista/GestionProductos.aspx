<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionProductos.aspx.cs" Inherits="Vista.GestionProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 341px;
        }
        .auto-style2 {
            width: 434px;
        }
        .auto-style3 {
            width: 341px;
            height: 33px;
        }
        .auto-style4 {
            width: 434px;
            height: 33px;
        }
        .auto-style5 {
            height: 33px;
        }
        .auto-style6 {
            width: 341px;
            height: 26px;
        }
        .auto-style7 {
            width: 434px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="3" style="text-align: center">GESTION PRODUCTOS</td>
                </tr>
                <tr>
                    <td class="auto-style3">Código:&nbsp;</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtIdProducto" runat="server" Width="272px" TextMode="Number"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Categoria:</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownListCategoria" runat="server" Width="281px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Eliminar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtNombre" runat="server" Width="271px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar" OnClick="btn_actualizar_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Descripcion:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtDescripcion" runat="server" Width="271px" Height="88px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Precio:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPrecio" runat="server" Width="271px" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Cantidad:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCantidad" runat="server" Width="271px" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
