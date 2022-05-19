<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionCategoria.aspx.cs" Inherits="Vista.WebForm1" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="3" style="text-align: center">GESTION CATEGORIAS</td>
                </tr>
                <tr>
                    <td class="auto-style3">Código Categoria:&nbsp;</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtIdCategoria" runat="server" Width="272px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre Categoria:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtNombreCategoria" runat="server" Width="269px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Eliminar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Estado:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEstado" runat="server" Width="268px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar" OnClick="btn_actualizar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>


