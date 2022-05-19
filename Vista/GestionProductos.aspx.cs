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
        GridView gvProducto;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LimpiarCampos()
        {
            txtIdProducto.Text  = "";
            txtNombre.Text      = "";
            txtDescripcion.Text = "";
            txtPrecio.Text      = "";
            txtCantidad.Text    = "";
            DropDownListCategoria.Items.Clear();
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
            if (inserto)
            {
                LimpiarCampos();
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            idProducto      = int.Parse(txtIdProducto.Text);
            bool elimino    = controlProducto.eliminarProducto(idProducto);
            if (elimino)
            {
                LimpiarCampos();
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            idProducto      = int.Parse(txtIdProducto.Text);
            nombre          = txtNombre.Text;
            descripcion     = txtDescripcion.Text;
            precio          = int.Parse(txtPrecio.Text);
            cantidad        = int.Parse(txtCantidad.Text);
            categoriaId     = int.Parse(DropDownListCategoria.SelectedValue);

            Producto p = new Producto(idProducto, nombre, descripcion, precio, cantidad, categoriaId);
            bool actualizo = controlProducto.actualizarProducto(p);

            if (actualizo)
            {
                LimpiarCampos();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int categoria_id;
            ListItem i;
            idProducto = int.Parse(txtIdProducto.Text);
            DataSet producto = controlProducto.consultarProducto(idProducto);

            txtNombre.Text      = producto.Tables[0].Rows[0]["nombre_producto"].ToString();
            txtDescripcion.Text = producto.Tables[0].Rows[0]["descripcion_producto"].ToString();
            txtPrecio.Text      = producto.Tables[0].Rows[0]["precio"].ToString();
            txtCantidad.Text    = producto.Tables[0].Rows[0]["cantidad_producto"].ToString();

            DropDownListCategoria.Items.Clear();
            categoria_id = int.Parse(producto.Tables[0].Rows[0]["categoria_id"].ToString());
            DataSet categoria = controlCategoria.consultarCategoria(categoria_id);
            i = new ListItem(categoria.Tables[0].Rows[0]["nombre_categoria"].ToString(), categoria.Tables[0].Rows[0]["id_categoria"].ToString());
            DropDownListCategoria.Items.Add(i);
        }

        protected void btnBuscarCategorias_Click(object sender, EventArgs e)
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
    }
}