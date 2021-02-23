using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHola_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Clase!!!");
        }


        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hola, qué tal. Wenas tarde.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atun con tomate");
            pictureBox1.Image = Image.FromFile("C:/GIT/descarga.jpg");
            pictureBox2.Image = Image.FromFile("C:/GIT/shrek.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
            private void button7_Click(object sender, EventArgs e)
            {

                MessageBox.Show("Ayy mi madre el bicho");

                this.BackgroundImage = Image.FromFile(@"C:\Git\PruebaGitHub\Imgs\guiza.jpg");


            }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
    }

