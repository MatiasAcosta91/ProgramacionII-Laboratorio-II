using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_5_Ejercicio_en_clase_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double valorIngresado;
            double porcDescuento= 0;
            double descuento;
            double totalPago;
            valorIngresado = double.Parse(this.txtCobro.Text);
            if (valorIngresado <= 5000 && valorIngresado >= 3000)
            {
                porcDescuento = 0.10;
            }
            else if(valorIngresado >5000)
            {
                porcDescuento = 0.20;
            }
            descuento = valorIngresado * porcDescuento;
            totalPago = valorIngresado - descuento;
            this.txtDescuento.Text = descuento.ToString();
            this.txtTotal.Text = totalPago.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control controles in this.groupBox1.Controls)
            {
                if ( controles is TextBox )
                {
                    ((TextBox)controles).Clear();
                    //controles dentro puede en este caso contener labels o textbox, dado que en
                    //los controladores del groupbox tenemos esos objetos.
                    //por lo cual se debe castear el control al tipo textbox.
                    // si no hiciera el if para verificar que lo que esta dentro del control sea
                    //un textbox, al momento de que encuentre un control tipo label u otro
                    //rompe el programa
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCobro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                btnAceptar_Click(sender, e);
            }
        }
    }
}
