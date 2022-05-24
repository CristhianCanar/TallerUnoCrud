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
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btn_buscar" runat="server" OnClick="btn_buscar_Click" Text="Buscar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:GridView ID="gv_categorias" runat="server" AutoGenerateColumns="False" DataKeyNames="id_categoria,nombre_categoria,estado" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="id_categoria" HeaderText="Código" />
                                <asp:BoundField DataField="nombre_categoria" HeaderText="Nombre" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>


