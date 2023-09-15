using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBotones
{
    public class KitBotonesEventArgs : EventArgs
    {
        public String tema { get; set; }
        public String modalidad { get; set; }

        public String tipoLetra { get; set; }
    }
}
