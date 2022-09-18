using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_5_Ejercicio_en_clase_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Add(int.Parse(this.txtNumero.Text));
            this.txtNumero.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int cantidad = this.lstNumeros.Items.Count;
            bool ordenado = false;
            int aux;
            while (ordenado == false)
            {
                ordenado = true;
                for (int i = 0; i < cantidad - 1; i++)
                {
                    if (((int)this.lstNumeros.Items[i] < (int)this.lstNumeros.Items[i + 1] && this.rbtnDescendente.Checked == true)
                        || ((int)this.lstNumeros.Items[i] > (int)this.lstNumeros.Items[i + 1] && this.rbtnAscendente.Checked == true)
                        )
                    {
                        aux = (int)this.lstNumeros.Items[i];
                        this.lstNumeros.Items[i] = this.lstNumeros.Items[i + 1];
                        this.lstNumeros.Items[i + 1] = aux;
                        ordenado = false;
                    }
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control buscoLosGroupBoxEnLosControlesDelForm in this.Controls)
            {//recorro los controls del formulario principal
                if (buscoLosGroupBoxEnLosControlesDelForm is GroupBox)
                {//si alguno de los controles es tipo groupbox entro al if
                    foreach (Control buscoRadioTextList in buscoLosGroupBoxEnLosControlesDelForm.Controls)
                    { //vuelvo a recorrer buscando controles pero esta ves dentro del groupbox
                        if (buscoRadioTextList is TextBox)
                        {
                            ((TextBox)buscoRadioTextList).Clear();
                        }
                        else if (buscoRadioTextList is RadioButton)
                        {
                            ((RadioButton)buscoRadioTextList).Checked = false;
                        }
                        else if(buscoRadioTextList is ListBox)
                        {
                            ((ListBox)buscoRadioTextList).Items.Clear();
                        }
                    }
                }
            }
        }
    }
}

