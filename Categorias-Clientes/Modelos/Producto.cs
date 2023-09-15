using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Producto
    {
        public int IdProductos { get; set; }
        public int CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public bool VentaPorUnidad { get; set; }
        public bool VentaAGranel { get; set; }
        public bool VentaPorPaquete { get; set; }
        public double PrecioCosto { get; set; }
        public double Ganancia { get; set; }
        public double PrecioVenta { get; set; }
        public int Categorias { get; set; }
        public int Cantidad { get; set; }
        public double TotalCompra { get { return Math.Round(PrecioVenta*Cantidad,2); } }

        public Producto() { }

    }
}
