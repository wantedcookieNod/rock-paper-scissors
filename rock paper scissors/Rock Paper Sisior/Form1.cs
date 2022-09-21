using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rock_Paper_Sisior
{
    public partial class Form1 : Form
    {
        int cpu_point = 0; int user_point = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            You.Visible = true;
            CPU.Visible = true;
            if (Rock.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
            }
            if (Paper.Checked == true)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox1.Visible = false;
            }
            if (Sisior.Checked == true)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }

            pictureBox4.Visible = true;

            //gerate a randon for CPU input ====================================



            int cpu;
            Random rand = new Random();
            cpu = rand.Next(1, 4);




            if (cpu == 1)
            {
                pictureBox7.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (cpu == 2)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
            if (cpu == 3)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
                pictureBox5.Visible = false;
            }

            // Main Calcuation for compitiation===================================

            if (pictureBox1.Visible == true && pictureBox7.Visible == true)
                MessageBox.Show("Draw", "Resualt");
            else if (pictureBox1.Visible == true && pictureBox5.Visible == true)
            {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("You Win", "Resualt");
                user_point = user_point + 1;
            }

            else if (pictureBox1.Visible == true && pictureBox6.Visible == true)
            {
                MessageBox.Show("You Lose", "Resualt");
                cpu_point = cpu_point + 1;
            }

            if (pictureBox2.Visible == true && pictureBox7.Visible == true)
            {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("You Win", "Resualt");
                user_point = user_point + 1;
            }
            else if (pictureBox2.Visible == true && pictureBox5.Visible == true)
            {
                MessageBox.Show("You Lose", "Resualt");
                cpu_point = cpu_point + 1;
            }
            else if (pictureBox2.Visible == true && pictureBox6.Visible == true)
                MessageBox.Show("Draw", "Resualt");

            if (pictureBox3.Visible == true && pictureBox7.Visible == true)
            {
                MessageBox.Show("You Lose", "Resualt");
                cpu_point = cpu_point + 1;
            }
            else if (pictureBox3.Visible == true && pictureBox5.Visible == true)
                MessageBox.Show("Draw", "Resualt");
            else if (pictureBox3.Visible == true && pictureBox6.Visible == true)
            {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("You Win", "Resualt");
                user_point = user_point + 1;
            }

            You.Text = "You : " + user_point;
            CPU.Text = "CPU : " + cpu_point;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void You_Click(object sender, EventArgs e)
        {

        }
    }
}
