using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TOC_TOE_GAME
{
    public partial class Form1 : Form
    {
        Boolean Checker;
        int plusone;
        void Enable_False()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        void score()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = System.Drawing.Color.PowderBlue;
                btn2.BackColor = System.Drawing.Color.PowderBlue;
                btn3.BackColor = System.Drawing.Color.PowderBlue;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = System.Drawing.Color.Pink;
                btn4.BackColor = System.Drawing.Color.Pink;
                btn7.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = System.Drawing.Color.Crimson;
                btn5.BackColor = System.Drawing.Color.Crimson;
                btn9.BackColor = System.Drawing.Color.Crimson;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = System.Drawing.Color.CadetBlue;

                btn5.BackColor = System.Drawing.Color.CadetBlue;
                btn7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {

                btn2.BackColor = System.Drawing.Color.SlateBlue;
                btn5.BackColor = System.Drawing.Color.SlateBlue;
                btn8.BackColor = System.Drawing.Color.SlateBlue;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn1.BackColor = System.Drawing.Color.SlateBlue;
                btn4.BackColor = System.Drawing.Color.SlateBlue;
                btn7.BackColor = System.Drawing.Color.SlateBlue;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = System.Drawing.Color.Violet;
                btn6.BackColor = System.Drawing.Color.Violet;
                btn9.BackColor = System.Drawing.Color.Violet;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = System.Drawing.Color.DarkCyan;
                btn5.BackColor = System.Drawing.Color.DarkCyan;
                btn6.BackColor = System.Drawing.Color.DarkCyan;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = System.Drawing.Color.Azure;
                btn8.BackColor = System.Drawing.Color.Azure;
                btn9.BackColor = System.Drawing.Color.Azure;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone);
                Enable_False();
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            /// 
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = System.Drawing.Color.AliceBlue;
                btn2.BackColor = System.Drawing.Color.AliceBlue;
                btn3.BackColor = System.Drawing.Color.AliceBlue;
                MessageBox.Show("the winner is player O", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }

            if (btn1.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = System.Drawing.Color.LemonChiffon;
                btn5.BackColor = System.Drawing.Color.LemonChiffon;
                btn7.BackColor = System.Drawing.Color.LemonChiffon;
                MessageBox.Show("the winner is player O", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = System.Drawing.Color.CadetBlue;

                btn5.BackColor = System.Drawing.Color.CadetBlue;
                btn7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("the winner is player O", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {

                btn2.BackColor = System.Drawing.Color.SlateBlue;
                btn5.BackColor = System.Drawing.Color.SlateBlue;
                btn8.BackColor = System.Drawing.Color.SlateBlue;
                MessageBox.Show("the winner is player X", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn1.BackColor = System.Drawing.Color.SlateBlue;
                btn4.BackColor = System.Drawing.Color.SlateBlue;
                btn7.BackColor = System.Drawing.Color.SlateBlue;
                MessageBox.Show("the winner is player O", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "0")
            {
                btn3.BackColor = System.Drawing.Color.Violet;
                btn6.BackColor = System.Drawing.Color.Violet;
                btn9.BackColor = System.Drawing.Color.Violet;
                MessageBox.Show("the winner is player O", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = System.Drawing.Color.DarkCyan;
                btn5.BackColor = System.Drawing.Color.DarkCyan;
                btn6.BackColor = System.Drawing.Color.DarkCyan;
                MessageBox.Show("the winner is player O", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = System.Drawing.Color.Azure;
                btn8.BackColor = System.Drawing.Color.Azure;
                btn9.BackColor = System.Drawing.Color.Azure;
                MessageBox.Show("the winner is player O", "TicTocToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerx.Text);
                lblplayerx.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn1.Text = "X";
                Checker = true;
            }
            else
            {
                btn1.Text = "O";
                Checker = false;
            }
            score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn2.Text = "X";
                Checker = true;
            }
            else
            {
                btn2.Text = "O";
                Checker = false;
            }
            score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn3.Text = "X";
                Checker = true;
            }
            else
            {
                btn3.Text = "O";
                Checker = false;
            }
            score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn4.Text = "X";
                Checker = true;
            }
            else
            {
                btn4.Text = "O";
                Checker = false;
            }
            score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn5.Text = "X";
                Checker = true;
            }
            else
            {
                btn5.Text = "O";
                Checker = false;
            }
            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn6.Text = "X";
                Checker = true;
            }
            else
            {
                btn6.Text = "O";
                Checker = false;
            }
            score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn7.Text = "X";
                Checker = true;
            }
            else
            {
                btn7.Text = "O";
                Checker = false;
            }
            score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn8.Text = "X";
                Checker = true;
            }
            else
            {
                btn8.Text = "O";
                Checker = false;
            }
            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                btn9.Text = "X";
                Checker = true;
            }
            else
            {
                btn9.Text = "O";
                Checker = false;
            }
            score();
            btn9.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {


                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;


                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";

                btnnewgame.Enabled = true;
                btn1.BackColor = Color.WhiteSmoke;
                btn2.BackColor = Color.WhiteSmoke;
                btn3.BackColor = Color.WhiteSmoke;
                btn4.BackColor = Color.WhiteSmoke;
                btn5.BackColor = Color.WhiteSmoke;
                btn6.BackColor = Color.WhiteSmoke;
                btn7.BackColor = Color.WhiteSmoke;
                btn8.BackColor = Color.WhiteSmoke;
                btn9.BackColor = Color.WhiteSmoke;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;


            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            lblplayerx.Text = "0";
            lblplayery.Text = "0";

            btn1.BackColor = Color.WhiteSmoke;
            btn2.BackColor = Color.WhiteSmoke;
            btn3.BackColor = Color.WhiteSmoke;
            btn4.BackColor = Color.WhiteSmoke;
            btn5.BackColor = Color.WhiteSmoke;
            btn6.BackColor = Color.WhiteSmoke;
            btn7.BackColor = Color.WhiteSmoke;
            btn8.BackColor = Color.WhiteSmoke;
            btn9.BackColor = Color.WhiteSmoke; 




         
    }

        private void btnexit_Click(object sender, EventArgs e)
        {
           try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("conrfirm if you want to exit", "TicTacToe", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if(iExit==DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}

