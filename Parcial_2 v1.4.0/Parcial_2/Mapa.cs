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
    public partial class Mapa : Form
    {
        int anchobtn = 80;
        int altobtn = 60;
        Image j_img;
        Image piso = Properties.Resources.piso2;
        Label label = new Label();
        Random rnd = new Random();

        public Mapa(int img, string nombre)
        {
            InitializeComponent();
            label.Text = "Nombre:  " + nombre;
            switch (img)
            {
                case 1:
                    j_img = Properties.Resources.asesino_pcb;
                    break;
                case 2:
                    j_img = Properties.Resources.campeon_pcb;
                    break;
                case 3:
                    j_img = Properties.Resources.Hechi_pcb;
                    break;
            }
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            GenerateMap();
            BackgroundImage = Properties.Resources.Mapa1;
            BackgroundImageLayout = ImageLayout.Tile;
            label.TextAlign = ContentAlignment.BottomLeft;
            label.Font = new Font("Arial Black", 12);
            label.Location = new Point(0, altobtn * 10);
            label.Size = new Size(this.ClientSize.Width, 500);
            label.Dock = DockStyle.Bottom;
        }

        private void GenerateMap()
        {
            int casilla_spawn = rnd.Next(0, 99);
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                Casilla csl = new Casilla(i);
                if (i == casilla_spawn)
                {
                    csl.Image = j_img;
                    csl.BackgroundImage = Properties.Resources.movimiento2;
                    csl.BackgroundImageLayout = ImageLayout.Stretch;
                }
                    
                this.Controls.Add(csl);
                this.Controls.Add(label);
            }
        }        
      
        private void Mapa_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Mapa_KeyUp(object sender, KeyEventArgs e)
        {
            Casilla csl_j = new Casilla();
            foreach (Control csl in Controls)
            {
                if (typeof(Casilla) == csl.GetType() && ((Casilla)csl).Image == j_img)
                {
                    csl_j = (Casilla)csl;// Con esto sabemos en que control esta el personaje
                }
                    
            }
            if (e.KeyCode == Keys.Left && csl_j.Location.X != 0)
            {
                foreach (Control csl in Controls)
                {
                    if (csl.Location.X == csl_j.Location.X - anchobtn &&
                        csl.Location.Y == csl_j.Location.Y)
                    {
                        ((Casilla)csl).Image = csl_j.Image;
                        csl.BackgroundImage = csl_j.BackgroundImage;
                        csl_j.Image = null;
                        csl.BackgroundImageLayout = ImageLayout.Stretch;

                    }
                }
            }
            else if(e.KeyCode == Keys.Right && csl_j.Location.X < anchobtn*9)
            {
                foreach (Control csl in Controls)
                {
                    if (csl.Location.X == csl_j.Location.X + anchobtn &&
                        csl.Location.Y == csl_j.Location.Y)
                    {
                        ((Casilla)csl).Image = csl_j.Image;
                        csl.BackgroundImage = csl_j.BackgroundImage;
                        csl_j.Image = null;
                        csl.BackgroundImageLayout = ImageLayout.Stretch;

                    }
                }
            }
            else if (e.KeyCode == Keys.Up && csl_j.Location.Y != 0)
            {
                foreach (Control csl in Controls)
                {
                    if (csl.Location.X == csl_j.Location.X &&
                        csl.Location.Y == csl_j.Location.Y - altobtn)
                    {
                        ((Casilla)csl).Image = csl_j.Image;
                        csl.BackgroundImage = csl_j.BackgroundImage;
                        csl_j.Image = null;
                        csl.BackgroundImageLayout = ImageLayout.Stretch;

                    }
                }
            }
            else if (e.KeyCode == Keys.Down && csl_j.Location.Y < altobtn * 9)
            {
                foreach (Control csl in Controls)
                {
                    if (csl.Location.X == csl_j.Location.X &&
                        csl.Location.Y == csl_j.Location.Y + altobtn)
                    {
                        ((Casilla)csl).Image = csl_j.Image;
                        csl.BackgroundImage = csl_j.BackgroundImage;
                        csl.BackgroundImageLayout = ImageLayout.Stretch;

                        csl_j.Image = null;
                    }
                }
            }
        }
    }

}


