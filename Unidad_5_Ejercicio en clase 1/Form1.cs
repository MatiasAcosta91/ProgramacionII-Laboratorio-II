using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unida_5_Ejercicio_en_clase_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSaludo.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Text = "Hola Mundo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSaludo.Visible = true;
        }
    }
}
