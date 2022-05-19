using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Control;
using Modelo;
using System.Data;

namespace Vista
{
    public partial class GestionProductos : System.Web.UI.Page
    {
        ControlCategoria controlCategoria = new ControlCategoria();
        ControlProducto  controlProducto  = new ControlProducto();
        int idProducto;
        string nombre;
        string descripcion;
        int precio;
        int cantidad;
        int categoriaId;
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem i;
            DataSet categorias = controlCategoria.consultarCategorias();

            foreach (DataRow dr in categorias.Tables[0].Rows)
            {
                if (dr["estado"].ToString() == "Activo")
                {
                    i = new ListItem(dr["nombre_categoria"].ToString(), dr["id_categoria"].ToString());
                    DropDownListCategoria.Items.Add(i);
                }
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            idProducto      = int.Parse(txtIdProducto.Text);
            nombre          = txtNombre.Text;
            descripcion     = txtDescripcion.Text;
            precio          = int.Parse(txtPrecio.Text);
            cantidad        = int.Parse(txtCantidad.Text);
            categoriaId     = int.Parse(DropDownListCategoria.SelectedValue);
            
            Producto p = new Producto(idProducto, nombre, descripcion, precio, cantidad, categoriaId);
            bool inserto = controlProducto.insertarProducto(p);
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {

        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
    }
}