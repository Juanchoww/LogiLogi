using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlBotones()
        {
            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsLetter))
            {
                button2.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if (!(nombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(nombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su nombre");
                }
                button2.Enabled = false;
                nombre.Focus();
            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form2 ventanaForm2 = new Form2(nombre.Text))
                ventanaForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form5 ventanaform5= new Form5(nombre.Text))
            ventanaForm5.showdialog();
        }
    }


}
