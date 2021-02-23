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
            MessageBox.Show("Hola Clase!!");
        }

<<<<<<< HEAD
        private void button4_Click(object sender, EventArgs e)
        {
            //Mensaje aleatorio que se muestra al hacer click sobre el botón 4.
            MessageBox.Show("Hola, qué tal. Wenas tarde.");
=======
<<<<<<< HEAD
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atun con tomate");
            pictureBox1.Image = Image.FromFile("C:/GIT/descarga.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

>>>>>>> 456uj
=======
        private void button7_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ayy mi madre el bicho");

            this.BackgroundImage = Image.FromFile(@"C:\Git\PruebaGitHub\Imgs\guiza.jpg");
         
>>>>>>> IgnacioHergueta
>>>>>>> 1083f8681a400c0bc73935e00c44de67a7bfeb40
        }
    }
}
