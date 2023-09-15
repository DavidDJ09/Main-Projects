using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND
{
    public class Producto
    {
        //Declaracion de atributos del producto
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioOferta { get; set; }
        public double Cantidad { get; set; }
        public double CantidadComprada { get; set; }
        public bool Activo { get; set; }
        public bool Granel { get; set; }
        public double TotalCompra { get { return Math.Round(PrecioVenta*CantidadComprada,2); } }

        //Constructor
        public Producto() { }
    }
}
