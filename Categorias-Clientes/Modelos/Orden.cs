using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Orden
    {
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Orden() { }

    }
}
