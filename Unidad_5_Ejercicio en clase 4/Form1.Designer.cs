
namespace Unidad_5_Ejercicio_en_clase_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendente = new System.Windows.Forms.RadioButton();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbIngreso.SuspendLayout();
            this.gbOrden.SuspendLayout();
            this.gbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.btnAgregar);
            this.gbIngreso.Controls.Add(this.txtNumero);
            this.gbIngreso.Location = new System.Drawing.Point(12, 12);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(267, 100);
            this.gbIngreso.TabIndex = 0;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingrese un nuevo número";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(177, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(21, 47);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 0;
            // 
            // gbOrden
            // 
            this.gbOrden.Controls.Add(this.btnOrdenar);
            this.gbOrden.Controls.Add(this.rbtnDescendente);
            this.gbOrden.Controls.Add(this.rbtnAscendente);
            this.gbOrden.Location = new System.Drawing.Point(12, 118);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(267, 100);
            this.gbOrden.TabIndex = 1;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Orden";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(177, 45);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rbtnDescendente
            // 
            this.rbtnDescendente.AutoSize = true;
            this.rbtnDescendente.Location = new System.Drawing.Point(21, 68);
            this.rbtnDescendente.Name = "rbtnDescendente";
            this.rbtnDescendente.Size = new System.Drawing.Size(93, 19);
            this.rbtnDescendente.TabIndex = 1;
            this.rbtnDescendente.TabStop = true;
            this.rbtnDescendente.Text = "Descendente";
            this.rbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rbtnAscendente
            // 
            this.rbtnAscendente.AutoSize = true;
            this.rbtnAscendente.Location = new System.Drawing.Point(21, 33);
            this.rbtnAscendente.Name = "rbtnAscendente";
            this.rbtnAscendente.Size = new System.Drawing.Size(87, 19);
            this.rbtnAscendente.TabIndex = 0;
            this.rbtnAscendente.TabStop = true;
            this.rbtnAscendente.Text = "Ascendente";
            this.rbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.lstNumeros);
            this.gbLista.Location = new System.Drawing.Point(285, 12);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(158, 293);
            this.gbLista.TabIndex = 2;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista de números";
            this.gbLista.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 15;
            this.lstNumeros.Location = new System.Drawing.Point(6, 22);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(146, 259);
            this.lstNumeros.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(33, 256);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(220, 49);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 316);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbOrden);
            this.Controls.Add(this.gbIngreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.gbOrden.ResumeLayout(false);
            this.gbOrden.PerformLayout();
            this.gbLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rbtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendente;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

