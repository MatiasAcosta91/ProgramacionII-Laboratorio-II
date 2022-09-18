
namespace Unidad_5_Ejercicio_02
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
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBin = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.cbCPlus = new System.Windows.Forms.CheckBox();
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.gbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.nudEdad);
            this.gbDetalles.Controls.Add(this.txtDireccion);
            this.gbDetalles.Controls.Add(this.txtNombre);
            this.gbDetalles.Controls.Add(this.lblEdad);
            this.gbDetalles.Controls.Add(this.lblDireccion);
            this.gbDetalles.Controls.Add(this.lblNombre);
            this.gbDetalles.Location = new System.Drawing.Point(12, 12);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(286, 209);
            this.gbDetalles.TabIndex = 0;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles del usuario";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(123, 150);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 23);
            this.nudEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(123, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(120, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(33, 150);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(33, 94);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBin);
            this.gbGenero.Controls.Add(this.rbFem);
            this.gbGenero.Controls.Add(this.rbMasc);
            this.gbGenero.Location = new System.Drawing.Point(336, 12);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(143, 151);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbNoBin
            // 
            this.rbNoBin.AutoSize = true;
            this.rbNoBin.Location = new System.Drawing.Point(26, 113);
            this.rbNoBin.Name = "rbNoBin";
            this.rbNoBin.Size = new System.Drawing.Size(81, 19);
            this.rbNoBin.TabIndex = 2;
            this.rbNoBin.TabStop = true;
            this.rbNoBin.Text = "No binario";
            this.rbNoBin.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(26, 77);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(78, 19);
            this.rbFem.TabIndex = 1;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(26, 43);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(80, 19);
            this.rbMasc.TabIndex = 0;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.cbJava);
            this.gbCursos.Controls.Add(this.cbCPlus);
            this.gbCursos.Controls.Add(this.cbCSharp);
            this.gbCursos.Location = new System.Drawing.Point(336, 178);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(143, 134);
            this.gbCursos.TabIndex = 2;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(26, 102);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(48, 19);
            this.cbJava.TabIndex = 2;
            this.cbJava.Text = "Java";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // cbCPlus
            // 
            this.cbCPlus.AutoSize = true;
            this.cbCPlus.Location = new System.Drawing.Point(26, 68);
            this.cbCPlus.Name = "cbCPlus";
            this.cbCPlus.Size = new System.Drawing.Size(50, 19);
            this.cbCPlus.TabIndex = 1;
            this.cbCPlus.Text = "C++";
            this.cbCPlus.UseVisualStyleBackColor = true;
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(26, 33);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(41, 19);
            this.cbCSharp.TabIndex = 0;
            this.cbCSharp.Text = "C#";
            this.cbCSharp.UseVisualStyleBackColor = true;
            // 
            // lstPais
            // 
            this.lstPais.FormattingEnabled = true;
            this.lstPais.ItemHeight = 15;
            this.lstPais.Location = new System.Drawing.Point(12, 246);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(286, 124);
            this.lstPais.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(336, 335);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 35);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Text = "Ingresar";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(13, 228);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "País";
            this.lstPais.Items.Add("Argentina");
            this.lstPais.Items.Add("Chile");
            this.lstPais.Items.Add("Uruguay");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 389);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstPais);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDetalles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            
            

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.RadioButton rbNoBin;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.CheckBox cbCPlus;
        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.ListBox lstPais;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPais;
    }
}

