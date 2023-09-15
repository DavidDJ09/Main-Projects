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
    public partial class frmSeleccionarPersonaje : Form
    {
        public frmSeleccionarPersonaje()
        {
            InitializeComponent();
            var pos = this.PointToScreen(lblTitulo.Location);
            pos = pictureBox1.PointToClient(pos);
            lblTitulo.Parent = pictureBox1;
            lblTitulo.Location = pos;
            lblTitulo.BackColor = Color.Transparent;
        }

        SoundPlayer seleccion;

        private void btnPikachu_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("pikachu"));
            frm.Show();
            this.Hide();
        }

        private void btnCharmander_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("charmander"));
            frm.Show();
            this.Hide();
        }

        private void btnSquirtle_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("squirtle"));
            frm.Show();
            this.Hide();
        }

        private void btnBullbasaur_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("bullbasaur"));
            frm.Show();
            this.Hide();
        }

        private void frmSeleccionarPersonaje_Load(object sender, EventArgs e)
        {

        }

        private void btnJigglypuff_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("jigglypuff"));
            frm.Show();
            this.Hide();
        }

        private void btnMeowth_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("meowth"));
            frm.Show();
            this.Hide();
        }

        private void btnPsyduck_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("psyduck"));
            frm.Show();
            this.Hide();
        }

        private void btnSnorlax_Click(object sender, EventArgs e)
        {
            seleccion = new SoundPlayer(Application.StartupPath + @"\Sonidos\Seleccion.wav");
            seleccion.Play();
            Thread.Sleep(800);
            frmJuego frm = new frmJuego((Image)Properties.Resources.
                ResourceManager.GetObject("snorlax"));
            frm.Show();
            this.Hide();
        }

        private void frmSeleccionarPersonaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
