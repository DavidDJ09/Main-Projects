using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Nave
{
    public partial class frmTutorial : Form
    {
        public frmTutorial()
        {
            InitializeComponent();
            var pos = this.PointToScreen(lblDescripcion.Location);
            pos = pictureBox1.PointToClient(pos);
            lblDescripcion.Parent = pictureBox1;
            lblDescripcion.Location = pos;
            lblDescripcion.BackColor = Color.Transparent;
        }

        SoundPlayer boton;

        private void button1_Click(object sender, EventArgs e)
        {
            boton=new SoundPlayer(Application.StartupPath + @"\Sonidos\Boton.wav");
            boton.Play();
            this.Close();
            frmSeleccionarPersonaje frmInicio = new frmSeleccionarPersonaje();
            frmInicio.Show();
        }

        private void frmTutorial_Load(object sender, EventArgs e)
        {

        }
    }
}
