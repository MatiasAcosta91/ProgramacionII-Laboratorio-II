using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "TITULO DE LA VENTANA DEL FORM";
            this.BackColor = Color.Aqua; //cambio el color del form1_load
            this.button1.BackColor = Color.Coral;//cambio el color del boton 1
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo!!", "tiulo de mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.button1.BackColor = Color.Orange; //cambio el boton luego de que se produce el evento.

            string texto = this.textBox1.Text;
            this.Text += texto;


            this.listBox1.Items.Add(this.textBox1.Text);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red; //cuando paso el mouse sobre la superficie cambio el color de la fuente
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black; //cuando saco el cursor vuelve a negro.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close(); //si apreto ESCAPE se cierra
            }
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form2 frm = new Form2();
                frm.Show();       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
  
        }
    }
}
