using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Juego_Nave
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            var pos = this.PointToScreen(lblDescripcion.Location);
            pos = pictureBox1.PointToClient(pos);
            lblDescripcion.Parent = pictureBox1;
            lblDescripcion.Location = pos;
            lblDescripcion.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(lblTitulo.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            lblTitulo.Parent = pictureBox1;
            lblTitulo.Location = pos2;
            lblTitulo.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(pcbNave.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            pcbNave.Parent = pictureBox1;
            pcbNave.Location = pos3;
            pcbNave.BackColor = Color.Transparent;
        }

        SoundPlayer boton;

    private void btnJugar_Click(object sender, EventArgs e)
        {
            boton=new SoundPlayer(Application.StartupPath + @"\Sonidos\Boton.wav");
            boton.Play();
            this.Hide();
            frmSeleccionarPersonaje frm = new frmSeleccionarPersonaje();
            frm.Show();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            boton=new SoundPlayer(Application.StartupPath + @"\Sonidos\Boton.wav");
            boton.Play();
            this.Hide();
            frmTutorial frmTutorial = new frmTutorial();
            frmTutorial.Show();
            
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
