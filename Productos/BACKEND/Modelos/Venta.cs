using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND.Modelos
{
    public class Venta
    {
        //Declaracion de atributos de la venta
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        //Constructor
        public Venta() { }
    }
}
