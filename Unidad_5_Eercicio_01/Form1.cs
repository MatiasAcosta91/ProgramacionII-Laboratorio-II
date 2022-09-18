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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                string saludo = "¡Hola Windows Forms!";
                string nombre = $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.comboBox1.Text}";
                Form2 formularioDos = new Form2(saludo, nombre);
                formularioDos.StartPosition = FormStartPosition.CenterScreen;
                formularioDos.ShowDialog();
            }
       
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Programacion I");
            this.comboBox1.Items.Add("Programacion II");
            this.comboBox1.Items.Add("Laboratorio I");
            this.comboBox1.Items.Add("Laboratorio II");
            this.comboBox1.Items.Add("Sistema y procesamiento de datos");
            this.comboBox1.Items.Add("Matematica I");
            this.comboBox1.Items.Add("Ingles I");
            this.comboBox1.Items.Add("Ingles II");
            this.comboBox1.Items.Add("Arquitectura de sistemas operativos");
            this.comboBox1.SelectedIndex = this.comboBox1.FindString("Programacion I");
            
        }
        private bool Validar ()
        {
            bool valido = true;
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("Se deben completar los siguientes campos: ");

            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                valido = false;
                mensaje.AppendLine("Nombre");
            }
            if (string.IsNullOrEmpty(this.txtApellido.Text))
            {
                valido = false;
                mensaje.AppendLine("Apellido");
            }
            
            if (valido == false)
            {
                MessageBox.Show(mensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valido;
        }
    }
}
