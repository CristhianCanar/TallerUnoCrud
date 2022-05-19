using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Categoria
    {
        private int idCategoria;
        private string nombreCategoria;
        private string estado;

        public Categoria(int idCategoria, string nombreCategoria, string estado)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.estado = estado;
        }

        public Categoria(){ }

        public int IdCategoria
        {
            get => idCategoria;
            set => idCategoria = value;
        }

        public string NombreCategoria
        {
            get => nombreCategoria;
            set => nombreCategoria = value;
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }

    }
}