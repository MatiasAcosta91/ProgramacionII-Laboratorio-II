 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//inicio el form en el centro de la pantalla
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //evento donde se carga el form
            this.button1.BackColor = Color.Beige;//en esta linea establezco el color del boton 1
            this.Text = "Cambio el load";
            this.BackColor = Color.SteelBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //acciones que se desencadenan al presionar el boton
            this.button1.BackColor = Color.Olive;//cambio de color
            string texto = this.textBox1.Text; //atrapo el texto en el textbox
            this.Text += texto; //le agrego lo ingresado al TEXT(encabezado)
            this.listBox1.Items.Add(texto); //agrego al listbox lo ingreado en el textbox
            MessageBox.Show("Item agregado, ademas se sumo mas texto al titulo de la ventana.");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //acciones que se desencadenan al pasar el mouse sobre el boton
            this.button1.BackColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //acciones q se ejecutan cuando saco el mouse del boton
            this.button1.BackColor = Color.Aqua;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cuando este dentro del textbox si presiono la z mayuscula me mostra el mensaje.
           if(e.KeyChar == (char)Keys.Z)
            {
                MessageBox.Show(e.KeyChar.ToString());
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creo un nuevo form
            FrmForm2 nuevoForm = new FrmForm2();
            this.StartPosition = FormStartPosition.CenterScreen;
            //muestro el nuevo form
            //nuevoForm.Show(this);
            nuevoForm.ShowDialog();//FORMULARIO MODAL:con esto el nuevo formulario no pierde el foco, no voy a poder 
            //volver al form anterior hasta q no cierre el actual.

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Continua con la app??","OJO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
