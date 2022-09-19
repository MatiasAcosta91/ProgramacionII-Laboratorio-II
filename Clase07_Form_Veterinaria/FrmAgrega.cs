using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_7_Form_Veterinaria;
using Clase07_Form_Veterinaria;
namespace Clase07_Form_Veterinaria
{
    
    public partial class FrmAgrega : Form
    {
        public Mascota mascotita;
        public FrmAgrega()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.mascotita = new Mascota(this.txtNombre.Text,int.Parse(this.txtEdad.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
