
namespace Unidad_5_Ejercicio_en_clase_2
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
            this.IstTabla = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texNumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IstTabla
            // 
            this.IstTabla.FormattingEnabled = true;
            this.IstTabla.ItemHeight = 15;
            this.IstTabla.Location = new System.Drawing.Point(12, 79);
            this.IstTabla.Name = "IstTabla";
            this.IstTabla.Size = new System.Drawing.Size(185, 199);
            this.IstTabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un numero:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // texNumero
            // 
            this.texNumero.Location = new System.Drawing.Point(128, 32);
            this.texNumero.Name = "texNumero";
            this.texNumero.Size = new System.Drawing.Size(69, 23);
            this.texNumero.TabIndex = 2;
            this.texNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texNumero_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IstTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox IstTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texNumero;
        private System.Windows.Forms.Button button1;
    }
}

