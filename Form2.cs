using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto
{
    public partial class Form2 : Form
    {
        string nombres;

        public Form2(string nombre)
        {
            InitializeComponent();
            nombres = nombre;


            }


    private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            int numero = int.Parse(ID.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje= "Señor" + nombres + "identificado con numero de identidad:" + ID + "registro exitoso";
            MessageBoxButtons botones = MessageBoxButtons.OK;
            MessageBox.Show(mensaje, "Registro", botones);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 frm = new Form4();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm = new Form3();

            frm.Show();
        }
    }
}
