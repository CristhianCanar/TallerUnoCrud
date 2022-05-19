using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Control;
using Modelo;

namespace Vista
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ControlCategoria controlCategoria = new ControlCategoria();
        int idCategoria;
        string nombreCategoria;
        string estado;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            idCategoria = int.Parse(txtIdCategoria.Text);
            nombreCategoria = txtNombreCategoria.Text;
            estado = txtEstado.Text;
            Categoria c = new Categoria(idCategoria, nombreCategoria, estado);
            bool inserto = controlCategoria.insertarCategoria(c);
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            idCategoria = int.Parse(txtIdCategoria.Text);
            bool elimino = controlCategoria.eliminarCategoria(idCategoria);
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            idCategoria = int.Parse(txtIdCategoria.Text);
            nombreCategoria = txtNombreCategoria.Text;
            estado = txtEstado.Text;
            Categoria c = new Categoria(idCategoria, nombreCategoria, estado);
            bool actualizo = controlCategoria.actualizarCategoria(c);
        }
    }
}