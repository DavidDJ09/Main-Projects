using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND.Modelos
{
    public class Empleado
    {
        //Declaracion de atributos del empleado
        public int Id { get; set; }
        public String Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public String Usuario { get; set; }
        public String Password { get; set; }
        public String NuevaPassword { get; set; }
        public string Puesto { get; set; }
        public bool Activo { get; set; }

        //Constructores
        public Empleado() { }
        public Empleado(int id) { Id=id; }
        public Empleado(string nombreCompleto, string nombreUsuario, string puesto, int id)
        {
            Usuario = nombreUsuario;
            Puesto = puesto;
            Id= id;
        }
    }
}
