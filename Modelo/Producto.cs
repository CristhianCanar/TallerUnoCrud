using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int precio;
        private int cantidad;
        private int categoriaId;

        public Producto(int id, string nombre, string descripcion, int precio, int cantidad, int categoriaId)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
            this.categoriaId = categoriaId;
        }

        public Producto(){ }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public int Precio
        {
            get => precio;
            set => precio = value;
        }
        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        public int CategoriaId
        {
            get => categoriaId;
            set => categoriaId = value;
        }

    }
}