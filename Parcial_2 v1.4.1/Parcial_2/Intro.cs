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
    public partial class Intro : Form
    {
        bool text_v = false;    
        bool date_v = false;
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            //button2.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            this.Hide(); 
            Personajes frm = new Personajes(textBox1.Text);
            frm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value.AddYears(18);
            if (a.CompareTo(DateTime.Today) == -1)
                date_v = true;
            else
                date_v = false;
            Validacion();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 2)
                text_v = true;
            else
                text_v = false;
            Validacion();
        }

        private void Validacion()
        {
            if (text_v == true && date_v == true)
                button2.Visible = true;
            else
                button2.Visible = false;
        }
    }    
}
