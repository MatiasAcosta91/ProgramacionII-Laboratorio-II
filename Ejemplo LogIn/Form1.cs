using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.tb_Usser.Text == "usuario" && this.tb_Pass.Text =="pass")
            {
                MessageBox.Show("Usuario Logueado.","Login Ok",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Datos incorrectos.","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.tb_Pass.Text = string.Empty;
                this.tb_Usser.Text = string.Empty;//limpio los cuadros de texto
            }
        }
    }
}
