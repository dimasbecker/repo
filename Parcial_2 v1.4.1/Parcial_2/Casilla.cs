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
    class Casilla : PictureBox
    {
        bool descubierto = false;
        bool caminable = true;
        int anchobtn = 80;
        int altobtn = 60;

        public Casilla()
        {

        }
        public Casilla(int i)
        {
            Size = new Size(anchobtn, altobtn);
            Location = new Point(((i % 10)) * anchobtn, ((i / 10)) * altobtn);
            BackColor = Color.Transparent;            
        }

        public void Mostrar()
        { }
    }
}
