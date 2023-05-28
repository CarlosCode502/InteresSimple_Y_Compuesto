
namespace InteresCompuesto
{
    partial class InteresCompuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_capInicial_IC = new System.Windows.Forms.TextBox();
            this.txt_Interes_IC = new System.Windows.Forms.TextBox();
            this.txt_Tiempo_IC = new System.Windows.Forms.TextBox();
            this.txt_capFinal_IC = new System.Windows.Forms.TextBox();
            this.btn_calcular_IC = new System.Windows.Forms.Button();
            this.btn_borrar_IC = new System.Windows.Forms.Button();
            this.btn_salir_IC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital incial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo (años):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capital final:";
            // 
            // txt_capInicial_IC
            // 
            this.txt_capInicial_IC.Location = new System.Drawing.Point(160, 23);
            this.txt_capInicial_IC.Name = "txt_capInicial_IC";
            this.txt_capInicial_IC.Size = new System.Drawing.Size(170, 20);
            this.txt_capInicial_IC.TabIndex = 4;
            this.txt_capInicial_IC.Text = "0.00";
            this.txt_capInicial_IC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Interes_IC
            // 
            this.txt_Interes_IC.Location = new System.Drawing.Point(160, 86);
            this.txt_Interes_IC.Name = "txt_Interes_IC";
            this.txt_Interes_IC.Size = new System.Drawing.Size(100, 20);
            this.txt_Interes_IC.TabIndex = 5;
            // 
            // txt_Tiempo_IC
            // 
            this.txt_Tiempo_IC.Location = new System.Drawing.Point(160, 149);
            this.txt_Tiempo_IC.Name = "txt_Tiempo_IC";
            this.txt_Tiempo_IC.Size = new System.Drawing.Size(91, 20);
            this.txt_Tiempo_IC.TabIndex = 6;
            // 
            // txt_capFinal_IC
            // 
            this.txt_capFinal_IC.BackColor = System.Drawing.Color.White;
            this.txt_capFinal_IC.Enabled = false;
            this.txt_capFinal_IC.Location = new System.Drawing.Point(160, 212);
            this.txt_capFinal_IC.Name = "txt_capFinal_IC";
            this.txt_capFinal_IC.Size = new System.Drawing.Size(170, 20);
            this.txt_capFinal_IC.TabIndex = 7;
            this.txt_capFinal_IC.Text = "Q 00.00";
            this.txt_capFinal_IC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_calcular_IC
            // 
            this.btn_calcular_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular_IC.Location = new System.Drawing.Point(12, 273);
            this.btn_calcular_IC.Name = "btn_calcular_IC";
            this.btn_calcular_IC.Size = new System.Drawing.Size(115, 46);
            this.btn_calcular_IC.TabIndex = 8;
            this.btn_calcular_IC.Text = "Calcular";
            this.btn_calcular_IC.UseVisualStyleBackColor = true;
            this.btn_calcular_IC.Click += new System.EventHandler(this.btn_calcular_IC_Click);
            // 
            // btn_borrar_IC
            // 
            this.btn_borrar_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_IC.Location = new System.Drawing.Point(225, 273);
            this.btn_borrar_IC.Name = "btn_borrar_IC";
            this.btn_borrar_IC.Size = new System.Drawing.Size(115, 46);
            this.btn_borrar_IC.TabIndex = 9;
            this.btn_borrar_IC.Text = "Borrar";
            this.btn_borrar_IC.UseVisualStyleBackColor = true;
            this.btn_borrar_IC.Click += new System.EventHandler(this.btn_borrar_IC_Click);
            // 
            // btn_salir_IC
            // 
            this.btn_salir_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir_IC.Location = new System.Drawing.Point(120, 334);
            this.btn_salir_IC.Name = "btn_salir_IC";
            this.btn_salir_IC.Size = new System.Drawing.Size(115, 46);
            this.btn_salir_IC.TabIndex = 10;
            this.btn_salir_IC.Text = "Salir";
            this.btn_salir_IC.UseVisualStyleBackColor = true;
            this.btn_salir_IC.Click += new System.EventHandler(this.btn_salir_IC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(137, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(135, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "%";
            // 
            // InteresCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 403);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_salir_IC);
            this.Controls.Add(this.btn_borrar_IC);
            this.Controls.Add(this.btn_calcular_IC);
            this.Controls.Add(this.txt_capFinal_IC);
            this.Controls.Add(this.txt_Tiempo_IC);
            this.Controls.Add(this.txt_Interes_IC);
            this.Controls.Add(this.txt_capInicial_IC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InteresCompuesto";
            this.Text = "Interés Compuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_capInicial_IC;
        private System.Windows.Forms.TextBox txt_Interes_IC;
        private System.Windows.Forms.TextBox txt_Tiempo_IC;
        private System.Windows.Forms.TextBox txt_capFinal_IC;
        private System.Windows.Forms.Button btn_calcular_IC;
        private System.Windows.Forms.Button btn_borrar_IC;
        private System.Windows.Forms.Button btn_salir_IC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}