using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xsi0
{
    public partial class FormIntro : Form
    {
        public string Nume_Player1;
        public string Nume_Player2;
        public FormIntro()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer1.Text == "" && textBoxPlayer2.Text == "")
            {
                MessageBox.Show("Va rog introduceti numele jucatorilor!");
            }
            else if(textBoxPlayer1.Text == "")
            {
                MessageBox.Show("Va rog introduceti numele jucatorului 1!");
            }
            else if(textBoxPlayer2.Text == "")
            {
                MessageBox.Show("Va rog introduceti numele jucatorului 2!");
            }
            else if(textBoxPlayer1.Text == textBoxPlayer2.Text)
            {
                MessageBox.Show("Cei doi jucatori nu pot avea acelasi nume!");
                textBoxPlayer1.Text = "";
                textBoxPlayer2.Text = "";
            }
            else
            {
                MessageBox.Show("Va incepe playerul ce va juca cu X");
                Nume_Player1 = textBoxPlayer1.Text;
                Nume_Player2 = textBoxPlayer2.Text;
                FormJoc fj = new FormJoc(Nume_Player1, Nume_Player2, 0, 0);
                fj.Show();
                this.Hide();

            }
                
        }
    }
}
