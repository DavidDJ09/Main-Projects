using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    public partial class TICTACTOE : Form
    {
        //ARREGLO PARA ADMINISTRAR EL JUEGO
        private char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //VARIABLES DE CONTROL
        private bool currentPlayer = true; //true=jugador X; false=jugador O/IA
        private int victoriasX = 0;
        private int victoriasO = 0;

        public TICTACTOE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblX.Text=victoriasX+"";
            lblO.Text=victoriasO+"";
        }

        //CADA BOTON LLAMA AL MISMO METODO QUE VALIDARA EL MODO DE JUEGO Y REACCIONARA DEPENDIENDO DE DICHO MODO
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index,button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = int.Parse(button.Name.Substring(6)) - 1;
            move(index, button);
        }

        //CADA RADIO BUTTON CAMBIARA AL MODO DE JUEGO QUE ESTA ASIGNADO Y REINICARA TODAS LAS VARIABLES
        private void rdbJugvsJug_CheckedChanged(object sender, EventArgs e)
        {
            resetGame();
            resetWins();
            btnIAvsIA.Visible=false;
            btnIAvsIA.Enabled=false;
            btnCederTurno.Enabled=false;
            btnCederTurno.Visible=false;
        }

        private void rdbJugvsIA_CheckedChanged(object sender, EventArgs e)
        {
            resetGame();
            resetWins();
            btnIAvsIA.Visible=false;
            btnIAvsIA.Enabled=false;
            btnCederTurno.Enabled=true;
            btnCederTurno.Visible=true;
        }

        private void rdbIAvsIA_CheckedChanged(object sender, EventArgs e)
        {
            btnIAvsIA.Visible=true;
            btnIAvsIA.Enabled=true;
            btnCederTurno.Enabled=false;
            btnCederTurno.Visible=false;
        }

        //METODO QUE REALIZA LA JUGADA EN EL BOTON PRESIONADO
        private void move(int buttonID, Button button)
        {
            btnCederTurno.Visible=false;
            //VERIFICAR MODO DE JUEGO
            if (rdbJugvsIA.Checked)
            {
                //VERIFICAR QUE LA CASILLA PRESIONADA ESTA LIBRE
                if (isValidMove(buttonID))
                {
                    button.Text = "X";
                    button.ForeColor= Color.Red;
                    board[buttonID] = 'X';

                    if (checkWinnner('X'))
                    {
                        MessageBox.Show("HAS GANADO!!!");
                        //ACTUALIZAR CONTADOR DE VICTORIAS
                        victoriasX++;
                        lblX.Text = victoriasX+"";
                        resetGame();
                    }
                    //SI EL TABLERO SE LLENO SIN UN GANADOR
                    else if (isBoardFull())
                    {
                        MessageBox.Show("EMPATE!!!");
                        resetGame();
                    }
                    else
                    {
                        //SI EL TABLERO TIENE CASILLAS LIBRES SE CAMBIA DE TURNO Y EL JUEGO CONTINUA
                        currentPlayer = false;
                        IAMove();
                    }
                }
            }
            //EL MODO JUGADOR VS JUGADOR ESTA ACTIVO
            else
            {
                //VERIFICAR SI LA CASILLA PRESIONADA ESTA LIBRE
                if (isValidMove(buttonID))
                {
                    if (currentPlayer==true)
                    {
                        button.Text = "X";
                        button.ForeColor= Color.Red;
                        board[buttonID] = 'X';
                    }
                    else
                    {
                        button.Text = "O";
                        button.ForeColor= Color.Blue;
                        board[buttonID] = 'O';
                    }

                    //VERIFICAR SI HAY VICTORIA DE ALGUN JUGADOR
                    if (checkWinnner('X'))
                    {
                        MessageBox.Show("GANADOR: X");
                        //ACTUALIZAR CONTADOR DE VICTORIAS
                        victoriasX++;
                        lblX.Text = victoriasX+"";
                        resetGame();
                    }
                    else if (checkWinnner('O'))
                    {
                        MessageBox.Show("GANADOR: O");
                        //ACTUALIZAR CONTADOR DE VICTORIAS
                        victoriasO++;
                        lblO.Text = victoriasO+"";
                        resetGame();
                    }
                    //VERIFICA SI EL TABLERO ESTA LLENO
                    else if (isBoardFull())
                    {
                        MessageBox.Show("EMPATE!!!");
                        resetGame();
                    }
                    else
                    {
                        //SI EL TABLERO TIENE CASILLAS LIBRES SE CAMBIA DE TURNO Y EL JUEGO CONTINUA
                        currentPlayer=!currentPlayer;
                        if (currentPlayer)
                        {
                            lblTurno.Text="X";
                            lblTurno.ForeColor= Color.Red;
                        }
                        else
                        {
                            lblTurno.Text="O";
                            lblTurno.ForeColor= Color.Blue;
                        }
                    }
                }
            }
        }

        //HACER MOVIMINETO IA
        private void IAMove()
        {
            int move = getIAMove();
            if (rdbIAvsIA.Checked)
            {
                //VERIFICAR EL JUGADOR ACTUAL Y HACER LA JUGADA
                if (currentPlayer)
                {
                    board[move] = 'X';
                    Button buttonP = (Button)panel1.Controls["button" + (move + 1)];
                    buttonP.Text = "X";
                    buttonP.ForeColor= Color.Red;
                }
                else
                {
                    board[move] = 'O';
                    Button buttonP = (Button)panel1.Controls["button" + (move + 1)];
                    buttonP.Text = "O";
                    buttonP.ForeColor= Color.Blue;
                }

                //VERIFICAR SI HAY UN GANADOR
                if (checkWinnner('O'))
                {
                    MessageBox.Show("GANADOR: O");
                    //ACTUALIZAR CONTADOR DE VICTORIAS
                    victoriasO++;
                    lblO.Text = victoriasO+"";
                    resetGame();
                }
                else if (checkWinnner('X'))
                {
                    MessageBox.Show("GANADOR: X");
                    //ACTUALIZAR CONTADOR DE VICTORIAS
                    victoriasX++;
                    lblX.Text = victoriasX+"";
                    resetGame();
                }
                else if (isBoardFull())
                {
                    //SI HAY EMPATE
                    MessageBox.Show("EMPATE!!!");
                    resetGame();
                }
                else
                {
                    //EL TURNO CAMBIA Y SIGUE EL JUEGO
                    currentPlayer = !currentPlayer;
                    IAMove();
                }
            }
            else
            {
                //MISMAS CARACTERISTICAS PERO SOLO SE REALIZA EL MOVIMIENTO DE UNA IA CUANDO SE JUEGA CONTRA EL HUMANO
                board[move] = 'O';
                Button button = (Button)panel1.Controls["button" + (move + 1)];
                button.Text = "O";
                button.ForeColor= Color.Blue;

                if (checkWinnner('O'))
                {
                    MessageBox.Show("GANADOR: IA");
                    //ACTUALIZAR CONTADOR DE VICTORIAS
                    victoriasO++;
                    lblO.Text = victoriasO+"";
                    resetGame();
                }
                else if (isBoardFull())
                {
                    MessageBox.Show("EMPATE!!!");
                    resetGame();
                }
                else
                {
                    currentPlayer = true;
                }
            }
            
        }

        //LA IA DETERMINA SU MOVIENTO
        private int getIAMove()
        {
            //OBTENER LAS CASILLAS LIBRES
            List<int> availableMoves = new List<int>();
            for (int i = 0; i < board.Length; i++)
            {
                if (isValidMove(i))
                {
                    availableMoves.Add(i);
                }
            }

            //INTENTAR GANAR
            for (int i = 0; i < board.Length; i++)
            {
                if (isValidMove(i))
                {
                    board[i] = 'O';
                    if (checkWinnner('O'))
                    {
                        board[i] = ' ';
                        return i;
                    }
                    board[i] = ' ';
                }
            }

            //INTENTAR TAPAR ADVERSARIO
            for (int i = 0; i < board.Length; i++)
            {
                if (isValidMove(i))
                {
                    board[i] = 'X';
                    if (checkWinnner('X'))
                    {
                        board[i] = 'O';
                        return i;
                    }
                    board[i] = ' ';
                }
            }

            //PRIORIZAR CASILLA CENTRAL SI ESTA LIBRE
            if (isValidMove(4))
            {
                return 4;
            }

            //PRIORIZAR JUGAR EN UNA ESQUNIA
            List<int> corners = new List<int> { 0, 2, 6, 8 };
            foreach (int corner in corners)
            {
                if (isValidMove(corner))
                {
                    return corner;
                }
            }

            //SI NINGUNA DE LAS OPCIONES ES POSIBLE TOMAR CASILLA ALEATORIA
            Random random = new Random();
            int randomIndex = random.Next(availableMoves.Count);
            return availableMoves[randomIndex];
        }

        //VERIFICAR SI LA CASILLA ESTA LIBRE
        private bool isValidMove(int move)
        {
            return board[move] != 'X' && board[move] != 'O';
        }

        //VERIFICAR GANANDOR
        private bool checkWinnner(char symbol)
        {
            return (board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
                   (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
                   (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
                   (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
                   (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
                   (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
                   (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
                   (board[2] == symbol && board[4] == symbol && board[6] == symbol);
        }

        //VERIFICAR SI EL TABLERO SE LLENO
        private bool isBoardFull()
        {
            foreach (char cell in board)
            {
                if (cell != 'X' && cell != 'O')
                {
                    return false;
                }
            }
            return true;
        }

        //REINICIAR JUEGO
        private void resetGame()
        {
            //REINICIAR ARREGLO Y BOTONES
            board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.Text = "";
                }
            }

            if (rdbJugvsIA.Checked)
            {
                btnCederTurno.Visible=true;
                btnCederTurno.Enabled=true;
            }
            
            //ESTABLECER TURNO
            currentPlayer = true;
            lblTurno.Text = "X";
            lblTurno.ForeColor= Color.Red;
        }

        private void resetWins()
        {
            //REINICIAR CONTADORES
            victoriasO=0;
            victoriasX=0;
            lblO.Text= victoriasO+"";
            lblX.Text=victoriasX+"";
        }

        private void btnIAvsIA_Click(object sender, EventArgs e)
        {
            //REALIZAR JUEGO IA VS IA
            IAMove();
        }

        private void btnCederTurno_Click(object sender, EventArgs e)
        {
            //CEDER PRIMER TURNO A LA IA
            currentPlayer=false;
            btnCederTurno.Enabled=false;
            IAMove();
        }
    }
}
