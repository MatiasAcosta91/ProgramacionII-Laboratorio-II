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

namespace Clase07_Form_Veterinaria
{
    public partial class FrmPrincipal : Form
    {
        private Veterinaria veterinaria;
        private StringBuilder sb;
        public FrmPrincipal()
        {
            InitializeComponent();

            this.veterinaria = new Veterinaria(5);//Creo una veterinaria con capacidad 5
            this.txtVeterinaria.ReadOnly = true; //hago el textbox solo para lectura
            this.sb = new StringBuilder(); //Creo un stringbuilder
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgrega nuevoFrmAgrega = new FrmAgrega();//creo un formulario para agregar

            if (nuevoFrmAgrega.ShowDialog() == DialogResult.OK)
            //Se mostrara el nuevo formulario de agregar
            //En dicho formulario se ingresaran el nombre y la edad en los textbox, al apretar aceptar
            //el dialog result sera OK (se establece en el evento de presionar el boton aceptar)
            //, y entonces a su atributo mascota (que es un puntero que guardara
            //la direccion de mascota) se le cargara la direccion de la  nueva mascota creada
            {
                if (this.veterinaria.Agregar(nuevoFrmAgrega.mascotita))
                //a la veterinaria le agrego la mascota que fue creada en el form de agregar mascota
                {
                    this.sb.AppendLine(nuevoFrmAgrega.mascotita.ToString());
                }
                else
                {
                    MessageBox.Show("No hay lugar");
                }
            }
            this.Refrescar(sb); //actualizo el valor contenido en el textbox donde se listaran mas mascotas
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        //Entro cuando desdce el form principal presiono el boton de eliminar
        {
             FrmElimina m = new FrmElimina();
            //creo un nuevo form de eliminacion
            if (m.ShowDialog() == DialogResult.OK)
            // Muestro el nuevo formulario de eliminacion
            //Al presionar el boton aceptar se genera el evento que establece dialog result en OK
            // y ademas se crea la nueva mascota con los datos ingresados en los textbox.
            //se asigna esa mascota creada al atributo mascotita (que seria un puntero)
 
            {
                if (this.veterinaria.Eliminar(m.mascotita)) //si se pudo eliminar la mascota entro al if
                {
                    this.sb.Clear(); //limpio el stringbuilder
                    foreach (Mascota item in this.veterinaria.lista)
                    {
                        //recorro la lista y vuelvo a cargar todo en el string builder
                        this.sb.AppendLine(item.ToString());
                    }
                }
                
                      
            }
            this.Refrescar(this.sb);

        }
        public void Refrescar(StringBuilder sb)
        {
            this.txtVeterinaria.Text = sb.ToString();
        }
    }
}
