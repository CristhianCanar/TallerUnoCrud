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
    public partial class WebForm1 : System.Web.UI.Page
    {
        ControlCategoria controlCategoria = new ControlCategoria();
        int idCategoria;
        string nombreCategoria;
        string estado;

        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }

        public void mostrarCategorias()
        {
            DataSet datos = new DataSet();
            datos = controlCategoria.consultarCategorias();
            gv_categorias.DataSource = datos;
            gv_categorias.DataBind();
        }

        private void mostrarCategorias(int idCategoria)
        {
            DataSet datos = new DataSet();
            datos = controlCategoria.consultarCategorias(idCategoria);
            gv_categorias.DataSource = datos;
            gv_categorias.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            idCategoria = int.Parse(txtIdCategoria.Text);
            nombreCategoria = txtNombreCategoria.Text;
            estado = txtEstado.Text;
            Categoria c = new Categoria(idCategoria, nombreCategoria, estado);
            bool inserto = controlCategoria.insertarCategoria(c);
            if (inserto)
            {
                mostrarCategorias();
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            idCategoria = int.Parse(txtIdCategoria.Text);
            bool elimino = controlCategoria.eliminarCategoria(idCategoria);
            if (elimino)
            {
                mostrarCategorias();
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            idCategoria = int.Parse(txtIdCategoria.Text);
            nombreCategoria = txtNombreCategoria.Text;
            estado = txtEstado.Text;
            Categoria c = new Categoria(idCategoria, nombreCategoria, estado);
            bool actualizo = controlCategoria.actualizarCategoria(c);
            if (actualizo)
            {
                mostrarCategorias();
            }
        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            idCategoria = int.Parse(txtIdCategoria.Text);
            DataSet ds = new DataSet();
            ds = controlCategoria.consultarCategorias(idCategoria);
            if (ds != null)
            {
                txtNombreCategoria.Text = ds.Tables[0].Rows[0]["nombre_categoria"].ToString();
                txtEstado.Text = ds.Tables[0].Rows[0]["estado"].ToString();
                mostrarCategorias(idCategoria);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}