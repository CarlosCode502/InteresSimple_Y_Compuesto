
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteresSimple));
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_capInicial
            // 
            this.txt_capInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_capInicial, "txt_capInicial");
            this.txt_capInicial.Name = "txt_capInicial";
            this.txt_capInicial.Tag = "";
            // 
            // txt_tasaInteres
            // 
            this.txt_tasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_tasaInteres, "txt_tasaInteres");
            this.txt_tasaInteres.Name = "txt_tasaInteres";
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_tiempo, "txt_tiempo");
            this.txt_tiempo.Name = "txt_tiempo";
            // 
            // txt_is_Total
            // 
            this.txt_is_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_is_Total, "txt_is_Total");
            this.txt_is_Total.Name = "txt_is_Total";
            this.txt_is_Total.ReadOnly = true;
            // 
            // cmb_tiempo_AnuMens
            // 
            this.cmb_tiempo_AnuMens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmb_tiempo_AnuMens, "cmb_tiempo_AnuMens");
            this.cmb_tiempo_AnuMens.ForeColor = System.Drawing.Color.Goldenrod;
            this.cmb_tiempo_AnuMens.FormattingEnabled = true;
            this.cmb_tiempo_AnuMens.Items.AddRange(new object[] {
            resources.GetString("cmb_tiempo_AnuMens.Items"),
            resources.GetString("cmb_tiempo_AnuMens.Items1"),
            resources.GetString("cmb_tiempo_AnuMens.Items2"),
            resources.GetString("cmb_tiempo_AnuMens.Items3"),
            resources.GetString("cmb_tiempo_AnuMens.Items4"),
            resources.GetString("cmb_tiempo_AnuMens.Items5")});
            this.cmb_tiempo_AnuMens.Name = "cmb_tiempo_AnuMens";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Calcular.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_Calcular, "btn_Calcular");
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            this.btn_Calcular.MouseLeave += new System.EventHandler(this.RatonLeave);
            this.btn_Calcular.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RatonMove);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Borrar.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_Borrar, "btn_Borrar");
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            this.btn_Borrar.MouseLeave += new System.EventHandler(this.RatonLeave);
            this.btn_Borrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RatonMove);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Name = "label6";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Cerrar.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btn_Cerrar, "btn_Cerrar");
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            this.btn_Cerrar.MouseLeave += new System.EventHandler(this.RatonLeave);
            this.btn_Cerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RatonMove);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // InteresSimple
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Cerrar);
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
            this.HelpButton = true;
            this.Name = "InteresSimple";
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
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}