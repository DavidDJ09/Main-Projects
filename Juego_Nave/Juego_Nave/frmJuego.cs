using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Nave
{
    public partial class frmJuego : Form
    {
        List<PictureBox> ListaObstaculos = new List<PictureBox>();
        Random RnTipoObstaculo = new Random();
        int Velocidad = 3;
        int Vidas = 1;
        int ContadorBoost = 0;

        public frmJuego(Image img)
        {
            InitializeComponent();
            CrearObstaculo(ListaObstaculos, this, 10, 80, 150, 210);
            ptbJugador.Image = img;
        }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            //CAÍDA DE LOS OBSTÁCULOS
            foreach (PictureBox ImagenNave in ListaObstaculos)
            {
                int MovimientoY;
                MovimientoY = ImagenNave.Location.Y;
                MovimientoY = MovimientoY + Velocidad;
                ImagenNave.Location = new Point(ImagenNave.Location.X, MovimientoY);
            }

            //CREAR OTRO OBSTÁCULO
            if (ListaObstaculos.Count > 0)
            {
                if (ListaObstaculos[(ListaObstaculos.Count) - 1].Location.Y > 250)
                {
                    CrearObstaculo(ListaObstaculos, this, 10, 80, 150, 210);
                }
            }

            //VALIDAR SI LOS OBSTÁCULOS CHOCAN
            if (ListaObstaculos.Count > 0)
            {
                for (int i = 0; i < ListaObstaculos.Count; i++)
                {
                    //SI EL OBSTÁCULO SOBREPASA EL LÍMITE DEL FORMULARIO
                    if (ListaObstaculos[i].Location.Y > 400)
                    {
                        this.Controls.Remove(ListaObstaculos[i]);
                        ListaObstaculos.Remove(ListaObstaculos[i]);
                    }
                    //SI EL OBSTÁCULO CHOCA CON EL JUGADOR
                    if (ListaObstaculos[i].Bounds.IntersectsWith(ptbJugador.Bounds))
                    {
                        if (ListaObstaculos[i].Tag.ToString() == "1")
                        {
                            this.Controls.Remove(ListaObstaculos[i]);
                            int TotalPuntos = Convert.ToInt32(lblPuntos.Text);
                            Velocidad++;
                            TotalPuntos++;
                            prbRecord.PerformStep();
                            lblPuntos.Text = TotalPuntos.ToString();

                            //PARÁMETRO PARA OBTENER VIDAS EXTRA
                            ContadorBoost++;
                            if (ContadorBoost == 3)
                            {
                                ContadorBoost = 0;
                                Vidas++;
                                lblVidas.Text=Vidas.ToString();
                            }

                            ListaObstaculos.Remove(ListaObstaculos[i]);
                            CrearObstaculo(ListaObstaculos, this, 10, 80, 150, 210);
                        }
                        else
                        {
                            this.Controls.Remove(ListaObstaculos[i]);
                            ListaObstaculos.Remove(ListaObstaculos[i]);

                            //CONTAR DERROTAS
                            if (Vidas>=0) {Vidas--;}
                            lblVidas.Text=Vidas.ToString();
                            if (Vidas == 0)
                            {
                                //ACTUALIAR EL RECORD DEL JUGADOR
                                if (Convert.ToInt32(lblPuntos.Text)>=prbRecord.Maximum)
                                {
                                    prbRecord.Maximum = Convert.ToInt32(lblPuntos.Text);
                                    lblRecord.Text=prbRecord.Maximum.ToString();
                                }
                                tmrControl.Enabled = false;
                                //SI EL USUARIO PIERDE SE PREGUNTARA SI DESEA REINTENTAR
                                //SI LA RESPUESTA ES "SI" EL JUEGO REINICIARA
                                //SI LA RESPUESTA ES "NO" LA APLICACIÓ SE CERRARÁ
                                if (MessageBox.Show("PUNTAJE: "+ lblPuntos.Text + "\n¿Deseas reintentar?",
                                    "GAME OVER", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    ReiniciarJuego();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CrearObstaculo(List<PictureBox> ListaElementos, Form PanelJuego, 
            int Distancia1, int Distancia2, int Distancia3, int Distancia4)
        {
            int TipoObstaculo = RnTipoObstaculo.Next(1, 3);
            int UbicacionObstaculo = RnTipoObstaculo.Next(1, 5);
            int DistanciaUbicacionObstaculo=0;

            //DEPENDIENDO DEL NÚMERO ALEATORIO GENENRADO SE ASIGNARA UNA UBICACÓN
            switch (UbicacionObstaculo)
            {
                case 1:
                    DistanciaUbicacionObstaculo=Distancia1;
                    break;
                case 2:
                    DistanciaUbicacionObstaculo=Distancia2;
                    break;
                case 3:
                    DistanciaUbicacionObstaculo=Distancia3;
                    break;
                case 4:
                    DistanciaUbicacionObstaculo=Distancia4;
                    break;
            }

            PictureBox pb = new PictureBox();
            pb.Location = new Point(DistanciaUbicacionObstaculo, 0);
            //CREACIÓN DE OBSTÁCULOS O BOOSTS ALEATORIOS
            //AMBOS LLEVAN POR NOMBRE Obstaculo SEGUIDO DEL NÚMERO 1 (BOOST) O NÚMERO 2 (OBSTÁCULO) SIN ESPACIO
            //SE GENERA UN NÚMERO ALEATORIO CONCATENADO A LA PALABRA Obstaculo PARA LA CREACIÓN ALEATORIA
            pb.Image=(Image)Properties.Resources.ResourceManager.GetObject("Obstaculo" + TipoObstaculo);
            pb.BackColor = Color.Transparent;
            pb.Tag = TipoObstaculo+"";
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaElementos.Add(pb);
            PanelJuego.Controls.Add(pb);
            pb.BringToFront();
        }

        // REINICIAR TODOS LOS VALORES Y CREAR OBSTACULOS NUEVOS
        private void ReiniciarJuego()
        {
            tmrControl.Enabled = true;
            lblPuntos.Text = "0";
            lblVidas.Text = "1";
            ContadorBoost = 0;
            Vidas=1;
            Velocidad = 3;
            prbRecord.Value = 0;
            CrearObstaculo(ListaObstaculos, this, 10, 80, 150, 210);
        }

        // MOVER NAVE DE UN LADO AL OTRO AL DAR CLICK EN LA BARRA ESPACIADORA
        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right && ptbJugador.Left<=ptbJugador.Width*4)
            {
                ptbJugador.Left+=65;
            }
            else if(e.KeyCode == Keys.Left && ptbJugador.Left>=10)
            {
                ptbJugador.Left-=65;
            }
        }
        
        private void frmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
