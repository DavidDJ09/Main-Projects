using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kitBotonesDatos1_Agregar_Click(object sender, KitBotones.KitBotonesEventArgs e)
        {
            MessageBox.Show("CLICK EN AGREGAR");
        }
    }
}
