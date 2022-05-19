using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelo;
using System.Data;


namespace Control
{
    public class ControlProducto
    {
        Persistencia persistencia = new Persistencia();

        public bool insertarProducto(Producto producto)
        {
            bool insert = false;
            string sql = "insert into producto (id_producto, nombre_producto, descripcion_producto, precio, cantidad_producto, categoria_id) values (" + producto.Id + ",'" + producto.Nombre + "','" + producto.Descripcion + "',"+producto.Precio+","+producto.Cantidad+","+producto.CategoriaId+")";
            Console.WriteLine(sql);
            insert = persistencia.ejecutarCUD(sql);

            return insert;

        }
        public bool actualizarProducto(Producto producto)
        {
            bool update = false;
            string sql = "UPDATE Producto SET nombre_Producto = '" + producto.Nombre + "' ," +
                "descripcion_producto = '" + producto.Descripcion+"', precio = "+producto.Precio+" ,"+
                "cantidad_producto = "+producto.Cantidad+", categoria_id = "+producto.CategoriaId +" WHERE id_producto = " + producto.Id + " ;";
            update = persistencia.ejecutarCUD(sql);
            return update;
        }
        public bool eliminarProducto(int idProducto)
        {
            bool delete = false;
            string sql = "delete from producto where id_producto ='" + idProducto + "'";
            delete = persistencia.ejecutarCUD(sql);
            return delete;
        }

        public DataSet consultarProductos()
        {
            DataSet datos = new DataSet();
            string sql = "select id_producto, nombre_producto, descripcion_producto, precio, cantidad_producto, categoria_id from producto";
            datos = persistencia.ejecutoR(sql);
            return datos;
        }

        public DataSet consultarProducto(int id)
        {
            DataSet datos = new DataSet();
            string sql = "select id_producto, nombre_producto, descripcion_producto, precio, cantidad_producto, categoria_id FROM producto "+
                         "WHERE id_producto = "+id+";";
            datos = persistencia.ejecutoR(sql);
            return datos;
        }




    }
}