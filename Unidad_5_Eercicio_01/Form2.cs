using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_5_Eercicio_01
{
    public partial class Form2 : Form
    {
        public Form2(string saludo, string nombre)
        {
            InitializeComponent();
            this.lblSaludo.Text = saludo;
            this.lblCatNombre.Text = nombre;
        }
    }
}
