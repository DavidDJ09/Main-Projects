using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND.Modelos
{
    public class DetalleVenta
    {
        //Declaracion de atributos del detalle de venta
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public double PrecioVenta { get; set; }
        public double Cantidad { get; set; }
        public bool Activo{ get; set; }
        public string Producto { get; set; }

        //Constructor
        public DetalleVenta() { }
    }
}
