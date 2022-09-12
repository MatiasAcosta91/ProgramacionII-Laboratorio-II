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
            lblImporte.Text = "Ingresed el importe a cobrar:";
            lblDescuento.Text = "Descuento Recibido:";
            lblTotal.Text = "Total a pagar:";
            btnAceptar.Text = "Acepter";
            btnLimpiar.Text = "Limpiar";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float importe = int.Parse(this.lblImporte.Text);
            float porcDesc = 0;
            float totalDescuento;
            float importeFinal;
            if (importe < 3000)
            {
                porcDesc = 0.1F;
            }
            else if (importe <= 5000)
            {
                porcDesc = .2F;
            }
            totalDescuento = importe * porcDesc;
            importeFinal = importe - totalDescuento;
       
        }
    }
}
