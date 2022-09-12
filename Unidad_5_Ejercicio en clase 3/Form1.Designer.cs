
namespace Unidad_5_Ejercicio_en_clase_3
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
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(12, 54);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(38, 15);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "label1";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(12, 98);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(38, 15);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "label2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 137);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 15);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label3";
            this.lblTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(201, 54);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(52, 23);
            this.txtImporte.TabIndex = 3;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(201, 95);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(52, 23);
            this.txtDescuento.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(201, 134);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(52, 23);
            this.txtTotal.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(57, 196);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(196, 196);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "button2";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 275);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImporte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

