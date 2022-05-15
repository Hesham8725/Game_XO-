using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace game_XO
{

    public partial class Form2 : Form
    {
        static int cntClick = 0;
        Form1 fm1 = new Form1();
        static string firP, SecP;
        public Form2()
        {
            InitializeComponent();
        }
        public void reset()
        {
            button1.Text = ""; button2.Text = ""; button3.Text = "";
            button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";
            button1.BackColor = Color.Silver;
            button2.BackColor = Color.Silver;
            button3.BackColor = Color.Silver;
            button4.BackColor = Color.Silver;
            button5.BackColor = Color.Silver;
            button6.BackColor = Color.Silver;
            button7.BackColor = Color.Silver;
            button8.BackColor = Color.Silver;
            button9.BackColor = Color.Silver;
            cntClick = 0;
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            cntClick++;
             int ok = 1;
            Button n = (Button)sender;
            if (cntClick % 2 == 0 && n.Text == "")
            {
                n.Text = "O";
                n.ForeColor = Color.Black;
            }
            else if (n.Text == "")
            {
                n.Text = "X";
                n.BackColor = Color.MistyRose;
                n.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Error Have A Value !");
                cntClick--;
            }
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                 (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                 (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                 (button1.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                 (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                 (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
                 )
            {
                MessageBox.Show("First Win");
                int a = int.Parse(FirstWin.Text);
                a++;
                FirstWin.Text = Convert.ToString(a);
                reset();
                ok = 0;
            }

            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
                )
            {
                MessageBox.Show("Second Win");
                int b = int.Parse(SecWin.Text);
                b++;
                SecWin.Text = Convert.ToString(b);
                reset();
                ok = 0;
            }
            if (cntClick == 9 && ok==1)
            {
                MessageBox.Show("تعادل بين الطرفان");
                reset();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reset();
            this.Hide();

            fm1.Show();
        }
        public static void name_players(string s1, string s2)
        {
            firP = s1;
            SecP = s2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            first_Player.Text = firP;
            Second_Player.Text = SecP;
        }
    }
}
