using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xsi0
{
    public partial class FormJoc : Form
    {
        public string Nume_Player1, Nume_Player2;
        public int[] UsedGrid = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public int Player1_Turn = 0, Player2_Turn = 0;
        public int alegere_player1, alegere_player2;
        public string[] optiuni = new string[3] { "#", "X", "0" };
        public int ScorPlayer1 = 0, ScorPlayer2 = 0;
        public FormJoc(string player1, string player2, int scor_p1, int scor_p2)
        {
            InitializeComponent();
            Nume_Player1 = player1;
            Nume_Player2 = player2;
            labelPlayer1.Text = Nume_Player1 + ": ";
            labelPlayer2.Text = Nume_Player2 + ": ";
            labelScorePlayer1.Text = Nume_Player1 + ": " + scor_p1;
            labelScorePlayer2.Text = Nume_Player2 + ": " + scor_p2;
            ScorPlayer1 = scor_p1;
            ScorPlayer2 = scor_p2;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FormJoc_Load(object sender, EventArgs e)
        {

            Random rnd = new Random();
            alegere_player1 = rnd.Next(1, 3);
            if(alegere_player1 == 1)
            {
                MessageBox.Show(String.Format("Incepe {0}", Nume_Player1));
                Player1_Turn = 1;
                alegere_player2 = 2;
                labelPlayer1.Text += "X";
                labelPlayer2.Text += "0";
            }
            else
            {
                MessageBox.Show(String.Format("Incepe {0}", Nume_Player2));
                alegere_player2 = 1;
                Player2_Turn = 1;
                labelPlayer1.Text += "0";
                labelPlayer2.Text += "X";
            }


        }

        private void buttonAnotherGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormJoc fj = new FormJoc(Nume_Player1, Nume_Player2, ScorPlayer1, ScorPlayer2);
            fj.Show();
        }

        private void Grid1_Click(object sender, EventArgs e)
        {
            if (UsedGrid[1] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid1.ForeColor = Color.Blue;
                    Grid1.Text = optiuni[alegere_player1];
                    
                    UsedGrid[1] = 1;
                    if ((Grid1.Text == Grid2.Text && Grid2.Text == Grid3.Text) ||
                        (Grid1.Text == Grid4.Text && Grid4.Text == Grid7.Text) ||
                        (Grid1.Text == Grid5.Text && Grid5.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                        
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for(int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if(ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }

                }
                else
                {
                    Grid1.ForeColor = Color.Red;
                    Grid1.Text = optiuni[alegere_player2];
                    
                    UsedGrid[1] = 1;
                    if ((Grid1.Text == Grid2.Text && Grid2.Text == Grid3.Text) ||
                        (Grid1.Text == Grid4.Text && Grid4.Text == Grid7.Text) ||
                        (Grid1.Text == Grid5.Text && Grid5.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
            
        }

        private void Grid2_Click(object sender, EventArgs e)
        {
            if (UsedGrid[2] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid2.ForeColor = Color.Blue;
                    Grid2.Text = optiuni[alegere_player1];
                    
                    UsedGrid[2] = 1;
                    if ((Grid1.Text == Grid2.Text && Grid2.Text == Grid3.Text) ||
                        (Grid2.Text == Grid5.Text && Grid5.Text == Grid8.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }

                }
                else
                {
                    Grid2.ForeColor = Color.Red;
                    Grid2.Text = optiuni[alegere_player2];
                    
                    UsedGrid[2] = 1;
                    if ((Grid1.Text == Grid2.Text && Grid2.Text == Grid3.Text) ||
                        (Grid2.Text == Grid5.Text && Grid5.Text == Grid8.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }

        private void Grid3_Click(object sender, EventArgs e)
        {
            if (UsedGrid[3] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid3.ForeColor = Color.Blue;
                    Grid3.Text = optiuni[alegere_player1];
                    
                    UsedGrid[3] = 1;
                    if ((Grid1.Text == Grid2.Text && Grid2.Text == Grid3.Text) ||
                        (Grid3.Text == Grid6.Text && Grid6.Text == Grid9.Text) ||
                        (Grid3.Text == Grid5.Text && Grid5.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }

                }
                else
                {
                    Grid3.ForeColor = Color.Red;
                    Grid3.Text = optiuni[alegere_player2];
                    
                    UsedGrid[3] = 1;
                    if ((Grid1.Text == Grid2.Text && Grid2.Text == Grid3.Text) ||
                        (Grid3.Text == Grid6.Text && Grid6.Text == Grid9.Text) ||
                        (Grid3.Text == Grid5.Text && Grid5.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }

        private void Grid4_Click(object sender, EventArgs e)
        {
            if (UsedGrid[4] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid4.ForeColor = Color.Blue;
                    Grid4.Text = optiuni[alegere_player1];
                    
                    UsedGrid[4] = 1;
                    if ((Grid4.Text == Grid5.Text && Grid5.Text == Grid6.Text) ||
                        (Grid1.Text == Grid4.Text && Grid4.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
                else
                {
                    Grid4.ForeColor = Color.Red;
                    Grid4.Text = optiuni[alegere_player2];
                    
                    UsedGrid[4] = 1;
                    if ((Grid4.Text == Grid5.Text && Grid5.Text == Grid6.Text) ||
                        (Grid1.Text == Grid4.Text && Grid4.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }

        private void Grid5_Click(object sender, EventArgs e)
        {
            if (UsedGrid[5] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid5.ForeColor = Color.Blue;
                    Grid5.Text = optiuni[alegere_player1];
                    
                    UsedGrid[5] = 1;
                    if ((Grid4.Text == Grid5.Text && Grid5.Text == Grid6.Text) ||
                        (Grid2.Text == Grid5.Text && Grid5.Text == Grid8.Text) ||
                        (Grid1.Text == Grid5.Text && Grid5.Text == Grid9.Text) ||
                        (Grid3.Text == Grid5.Text && Grid5.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }

                }
                else
                {
                    Grid5.ForeColor = Color.Red;
                    Grid5.Text = optiuni[alegere_player2];
                    
                    UsedGrid[5] = 1;
                    if ((Grid4.Text == Grid5.Text && Grid5.Text == Grid6.Text) ||
                        (Grid2.Text == Grid5.Text && Grid5.Text == Grid8.Text) ||
                        (Grid1.Text == Grid5.Text && Grid5.Text == Grid9.Text) ||
                        (Grid3.Text == Grid5.Text && Grid5.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }

        private void Grid6_Click(object sender, EventArgs e)
        {
            if (UsedGrid[6] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid6.ForeColor = Color.Blue;
                    Grid6.Text = optiuni[alegere_player1];
                    
                    UsedGrid[6] = 1;
                    if ((Grid4.Text == Grid5.Text && Grid5.Text == Grid6.Text) ||
                        (Grid3.Text == Grid6.Text && Grid6.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
                else
                {
                    Grid6.ForeColor = Color.Red;
                    Grid6.Text = optiuni[alegere_player2];
                    
                    UsedGrid[6] = 1;
                    if ((Grid4.Text == Grid5.Text && Grid5.Text == Grid6.Text) ||
                        (Grid3.Text == Grid6.Text && Grid6.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }


        private void Grid7_Click(object sender, EventArgs e)
        {
            if (UsedGrid[7] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid7.ForeColor = Color.Blue;
                    Grid7.Text = optiuni[alegere_player1];
                    
                    UsedGrid[7] = 1;
                    if ((Grid7.Text == Grid8.Text && Grid8.Text == Grid9.Text) ||
                        (Grid1.Text == Grid4.Text && Grid4.Text == Grid7.Text) ||
                        (Grid3.Text == Grid5.Text && Grid5.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
                else
                {
                    Grid7.ForeColor = Color.Red;
                    Grid7.Text = optiuni[alegere_player2];
                    
                    UsedGrid[7] = 1;
                    if ((Grid7.Text == Grid8.Text && Grid8.Text == Grid9.Text) ||
                        (Grid1.Text == Grid4.Text && Grid4.Text == Grid7.Text) ||
                        (Grid3.Text == Grid5.Text && Grid5.Text == Grid7.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }

        private void Grid8_Click(object sender, EventArgs e)
        {
            if (UsedGrid[8] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid8.ForeColor = Color.Blue;
                    Grid8.Text = optiuni[alegere_player1];
                    
                    UsedGrid[8] = 1;
                    if ((Grid2.Text == Grid5.Text && Grid5.Text == Grid8.Text) ||
                        (Grid7.Text == Grid8.Text && Grid8.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
                else
                {
                    Grid8.ForeColor = Color.Red;
                    Grid8.Text = optiuni[alegere_player2];
                    
                    UsedGrid[8] = 1;
                    if ((Grid2.Text == Grid5.Text && Grid5.Text == Grid8.Text) ||
                        (Grid7.Text == Grid8.Text && Grid8.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }

        private void Grid9_Click(object sender, EventArgs e)
        {
            if (UsedGrid[9] == 0)
            {
                if (Player1_Turn == 1)
                {
                    Grid9.ForeColor = Color.Blue;
                    Grid9.Text = optiuni[alegere_player1];
                    
                    UsedGrid[9] = 1;
                    if ((Grid3.Text == Grid6.Text && Grid6.Text == Grid9.Text) ||
                        (Grid7.Text == Grid8.Text && Grid8.Text == Grid9.Text) ||
                        (Grid1.Text == Grid5.Text && Grid5.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player1));
                        ScorPlayer1++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                    Player2_Turn = 1;
                    Player1_Turn = 0;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }

                }
                else
                {
                    Grid9.ForeColor = Color.Red;
                    Grid9.Text = optiuni[alegere_player2];
                    
                    UsedGrid[9] = 1;
                    if ((Grid3.Text == Grid6.Text && Grid6.Text == Grid9.Text) ||
                        (Grid7.Text == Grid8.Text && Grid8.Text == Grid9.Text) ||
                        (Grid1.Text == Grid5.Text && Grid5.Text == Grid9.Text))
                    {
                        MessageBox.Show(String.Format("{0} a castigat!", Nume_Player2));
                        ScorPlayer2++;
                        labelScorePlayer1.Text = Nume_Player1 + ": " + ScorPlayer1;
                        labelScorePlayer2.Text = Nume_Player2 + ": " + ScorPlayer2;
                    }
                        
                    Player2_Turn = 0;
                    Player1_Turn = 1;
                    int ok = 1;
                    for (int i = 1; i <= 9; i++)
                        if (UsedGrid[i] == 0)
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    {
                        MessageBox.Show("Remiza. Nu a castigat nimeni!");
                    }
                }
            }
            else
                MessageBox.Show("Casuta deja folosita!");
        }
    }
}
