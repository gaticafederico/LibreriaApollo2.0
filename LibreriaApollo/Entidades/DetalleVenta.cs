using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaApollo.Entidades
{
    class DetalleVenta
    {
        private int idProducto;
        private int cantidadProducto;
        private float precioUnitario;

        public DetalleVenta (int idProducto, int cantidadProducto, float precioUnitario)
        {
            this.idProducto = idProducto;
            this.cantidadProducto = cantidadProducto;
            this.precioUnitario = precioUnitario;
        }
        public int getIdProducto()
        {
            return this.idProducto;
        }

        public int getCantidadProducto()
        {
            return this.cantidadProducto;

        }

        public float getPrecioUnitario()
        {
            return this.precioUnitario;
        }
        

    }
}
