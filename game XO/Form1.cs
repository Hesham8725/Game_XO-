using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Btnstartplay_Click(object sender, EventArgs e)
        {
            Form2.name_players(txtfir.Text , txtsec.Text);
            if (txtfir.Text == "" || txtsec.Text == "")
            {
                MessageBox.Show("Error Must Input Name Of Two Players");
            }
            else
            {
                Form2 fm2 = new Form2();
                this.Hide();
                fm2.Show();
               
            }   
        }
    }
}
