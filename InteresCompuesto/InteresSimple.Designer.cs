
namespace InteresCompuesto
{
    partial class InteresSimple
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
            this.txt_capInicial = new System.Windows.Forms.TextBox();
            this.txt_tasaInteres = new System.Windows.Forms.TextBox();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.txt_is_Total = new System.Windows.Forms.TextBox();
            this.cmb_tiempo_AnuMens = new System.Windows.Forms.ComboBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa de interés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interés simple total:";
            // 
            // txt_capInicial
            // 
            this.txt_capInicial.Location = new System.Drawing.Point(144, 29);
            this.txt_capInicial.Name = "txt_capInicial";
            this.txt_capInicial.Size = new System.Drawing.Size(196, 20);
            this.txt_capInicial.TabIndex = 4;
            this.txt_capInicial.Tag = "";
            this.txt_capInicial.Text = "0.00";
            this.txt_capInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_tasaInteres
            // 
            this.txt_tasaInteres.Location = new System.Drawing.Point(144, 97);
            this.txt_tasaInteres.Name = "txt_tasaInteres";
            this.txt_tasaInteres.Size = new System.Drawing.Size(76, 20);
            this.txt_tasaInteres.TabIndex = 5;
            this.txt_tasaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Location = new System.Drawing.Point(122, 172);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(98, 20);
            this.txt_tiempo.TabIndex = 6;
            this.txt_tiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_is_Total
            // 
            this.txt_is_Total.Enabled = false;
            this.txt_is_Total.Location = new System.Drawing.Point(122, 238);
            this.txt_is_Total.Name = "txt_is_Total";
            this.txt_is_Total.Size = new System.Drawing.Size(218, 20);
            this.txt_is_Total.TabIndex = 7;
            this.txt_is_Total.Text = "Q 0.00";
            this.txt_is_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_tiempo_AnuMens
            // 
            this.cmb_tiempo_AnuMens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tiempo_AnuMens.FormattingEnabled = true;
            this.cmb_tiempo_AnuMens.Items.AddRange(new object[] {
            "Dias",
            "Meses",
            "Bimestres",
            "Trimestres",
            "Semestres",
            "Años"});
            this.cmb_tiempo_AnuMens.Location = new System.Drawing.Point(238, 171);
            this.cmb_tiempo_AnuMens.Name = "cmb_tiempo_AnuMens";
            this.cmb_tiempo_AnuMens.Size = new System.Drawing.Size(102, 21);
            this.cmb_tiempo_AnuMens.TabIndex = 9;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(36, 290);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(118, 36);
            this.btn_Calcular.TabIndex = 10;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(199, 290);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(118, 36);
            this.btn_Borrar.TabIndex = 11;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InteresSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.cmb_tiempo_AnuMens);
            this.Controls.Add(this.txt_is_Total);
            this.Controls.Add(this.txt_tiempo);
            this.Controls.Add(this.txt_tasaInteres);
            this.Controls.Add(this.txt_capInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InteresSimple";
            this.Text = "InteresSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_capInicial;
        private System.Windows.Forms.TextBox txt_tasaInteres;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.TextBox txt_is_Total;
        private System.Windows.Forms.ComboBox cmb_tiempo_AnuMens;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}