
namespace InteresCompuesto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_interesSimple = new System.Windows.Forms.Button();
            this.btn_interesCompuesto = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INTERÉS SIMPLE Y COMPUESTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_interesCompuesto);
            this.groupBox1.Controls.Add(this.btn_interesSimple);
            this.groupBox1.Location = new System.Drawing.Point(36, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // btn_interesSimple
            // 
            this.btn_interesSimple.Location = new System.Drawing.Point(42, 32);
            this.btn_interesSimple.Name = "btn_interesSimple";
            this.btn_interesSimple.Size = new System.Drawing.Size(140, 36);
            this.btn_interesSimple.TabIndex = 0;
            this.btn_interesSimple.Text = "Interés Simple";
            this.btn_interesSimple.UseVisualStyleBackColor = true;
            this.btn_interesSimple.Click += new System.EventHandler(this.btn_interesSimple_Click);
            // 
            // btn_interesCompuesto
            // 
            this.btn_interesCompuesto.Location = new System.Drawing.Point(42, 122);
            this.btn_interesCompuesto.Name = "btn_interesCompuesto";
            this.btn_interesCompuesto.Size = new System.Drawing.Size(140, 36);
            this.btn_interesCompuesto.TabIndex = 1;
            this.btn_interesCompuesto.Text = "Interés Compuesto";
            this.btn_interesCompuesto.UseVisualStyleBackColor = true;
            this.btn_interesCompuesto.Click += new System.EventHandler(this.btn_interesCompuesto_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(42, 212);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(140, 36);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CALCULADORA DE:";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_interesCompuesto;
        private System.Windows.Forms.Button btn_interesSimple;
    }
}

