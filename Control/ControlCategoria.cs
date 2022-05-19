using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelo;
using System.Data;

namespace Control
{
    public class ControlCategoria
    {
        Persistencia persistencia = new Persistencia();

        public bool insertarCategoria(Categoria categoria) 
        {
            bool insert = false;
            string sql = "insert into categoria (id_categoria, nombre_categoria, estado) values (" + categoria.IdCategoria +",'"+categoria.NombreCategoria+"','"+categoria.Estado+"')";
            insert = persistencia.ejecutarCUD(sql);
            return insert;
        }
        public bool actualizarCategoria(Categoria categoria)
        {
            bool update = false;
            string sql = "UPDATE categoria SET nombre_categoria = '" + categoria.NombreCategoria + "' ," +
                "estado = '" + categoria.Estado + "' WHERE id_categoria = " + categoria.IdCategoria + " ;";
            update = persistencia.ejecutarCUD(sql);
            return update;
        }
        public bool eliminarCategoria(int id_categoria)
        {
            bool delete = false;
            string sql = "delete from categoria where id_categoria ='" + id_categoria + "'";
            delete = persistencia.ejecutarCUD(sql);
            return delete;
        }

        public DataSet consultarCategorias() 
        {
            DataSet datos = new DataSet();
            string sql = "select id_categoria, nombre_categoria, estado from categoria";
            datos = persistencia.ejecutoR(sql);
            return datos;
        }

    }
}