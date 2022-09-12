using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_5_Ejercicio_en_clase_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void texNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            int numero;
            if(e.KeyChar == (char) Keys.Enter)
            {
                this.IstTabla.Items.Clear();
                numero = int.Parse(this.texNumero.Text);
                for (int i = 1; i <= 10; i++)
                {
                    this.IstTabla.Items.Add(($"{i} x {numero} = {i * numero}"));                   
                }
            }        
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.IstTabla.Items.Clear();
        }
    }
}
