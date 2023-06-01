
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_interesCompuesto = new System.Windows.Forms.Button();
            this.btn_interesSimple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "INTERÉS SIMPLE Y COMPUESTO";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btn_Salir.FlatAppearance.BorderSize = 3;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Palatino Linotype", 9.6F, System.Drawing.FontStyle.Bold);
            this.btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.btn_Salir.Location = new System.Drawing.Point(84, 241);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(140, 36);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_interesCompuesto
            // 
            this.btn_interesCompuesto.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_interesCompuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_interesCompuesto.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btn_interesCompuesto.FlatAppearance.BorderSize = 3;
            this.btn_interesCompuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_interesCompuesto.Font = new System.Drawing.Font("Palatino Linotype", 9.6F, System.Drawing.FontStyle.Bold);
            this.btn_interesCompuesto.ForeColor = System.Drawing.Color.Black;
            this.btn_interesCompuesto.Location = new System.Drawing.Point(84, 152);
            this.btn_interesCompuesto.Name = "btn_interesCompuesto";
            this.btn_interesCompuesto.Size = new System.Drawing.Size(140, 36);
            this.btn_interesCompuesto.TabIndex = 1;
            this.btn_interesCompuesto.Text = "Interés Compuesto";
            this.btn_interesCompuesto.UseVisualStyleBackColor = false;
            this.btn_interesCompuesto.Click += new System.EventHandler(this.btn_interesCompuesto_Click);
            // 
            // btn_interesSimple
            // 
            this.btn_interesSimple.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_interesSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_interesSimple.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btn_interesSimple.FlatAppearance.BorderSize = 3;
            this.btn_interesSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_interesSimple.Font = new System.Drawing.Font("Palatino Linotype", 9.6F, System.Drawing.FontStyle.Bold);
            this.btn_interesSimple.ForeColor = System.Drawing.Color.Black;
            this.btn_interesSimple.Location = new System.Drawing.Point(84, 65);
            this.btn_interesSimple.Name = "btn_interesSimple";
            this.btn_interesSimple.Size = new System.Drawing.Size(140, 36);
            this.btn_interesSimple.TabIndex = 0;
            this.btn_interesSimple.Text = "Interés Simple";
            this.btn_interesSimple.UseVisualStyleBackColor = false;
            this.btn_interesSimple.Click += new System.EventHandler(this.btn_interesSimple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InteresCompuesto.Properties.Resources.conta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Salir;
            this.ClientSize = new System.Drawing.Size(309, 350);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_interesCompuesto);
            this.Controls.Add(this.btn_interesSimple);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA DE:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_interesCompuesto;
        private System.Windows.Forms.Button btn_interesSimple;
    }
}

