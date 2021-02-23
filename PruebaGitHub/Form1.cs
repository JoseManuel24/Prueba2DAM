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

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 10; i != 0; i--){
                MessageBox.Show("cuenta atras:"+i);
            }
            
        }
    }
}
