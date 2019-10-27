using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Personajes : Form
    {
        int img;
        string nombre;
        public Personajes(string nom)
        {
            InitializeComponent();
            nombre = nom;
        }
        private void Personajes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mapa frm = new Mapa(img, nombre);
            frm.Show();
        }   

        private void radioButton1_Validated(object sender, EventArgs e)
        {
            img = 1;
        }

        private void radioButton2_Validated(object sender, EventArgs e)
        {
            img = 2;
        }

        private void radioButton3_Validated(object sender, EventArgs e)
        {
            img = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
