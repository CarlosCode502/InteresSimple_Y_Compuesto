using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteresCompuesto
{
    public partial class InteresCompuesto : Form
    {
        public Double CapInicial;
        public Double Interes;
        public int Tiempo;
        public Double CapitalFinal;
        public Decimal valor;

        public InteresCompuesto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;            
        }

        public void RatonMove(object sender, MouseEventArgs e)
        {
            var boton = (Button)sender;
            boton.FlatAppearance.BorderColor = Color.Goldenrod;
            boton.FlatAppearance.BorderSize = 4;
        }

        public void RatonLeave(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            boton.FlatAppearance.BorderColor = Color.Black;
            boton.FlatAppearance.BorderSize = 2;
        }

        private void btn_calcular_IC_Click(object sender, EventArgs e)
        {
            //Primer validación que verificara que los campos requeridos no se encuentren vacios
            if (String.IsNullOrWhiteSpace(txt_capInicial_IC.Text) || txt_capInicial_IC.Text == "0.00" || String.IsNullOrWhiteSpace(txt_Interes_IC.Text) || txt_Interes_IC.Text == "0.0" || String.IsNullOrWhiteSpace(txt_Tiempo_IC.Text) || txt_Tiempo_IC.Text == "0")
            {
                MessageBox.Show("¡Ingrese los valores que desea calcular!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {                 
                //if(txt_capFinal_IC.Text != "Q 00.00" && txt_capFinal_IC.Text != " ")
                //{
                //    //el capital inicial sera ahora el capital final anterior
                //    txt_capInicial_IC.Text = valor.ToString("Q 0,0.00");
                //    txt_Interes_IC.Clear();
                //    txt_Tiempo_IC.Clear();
                //    txt_capFinal_IC.Text = "Q 00.00";
                //}

                ////vuelve a validar si existe un valor o resultado en txt capital final para irlo sumando año a año aumentando
                //if(txt_capFinal_IC.Text != "Q 00.00")
                //{
                //    //si el campo final el distinto a cero es decir si ya tiene una operación se va a proceder a lo siguiente
                //    //obtenemos el valor 

                //    //el valor del cfinal pasa a capital inicial
                //    txt_capInicial_IC.Text = txt_capFinal_IC.Text;

                //    Interes = Convert.ToDouble(txt_Interes_IC.Text);

                //    Tiempo = int.Parse(txt_Tiempo_IC.Text);

                //    CapitalFinal += valor * (1 + (Interes / 100)) * (1 + (Interes / 100));
                //    CapitalFinal = valor;

                //    txt_capFinal_IC.Text = CapitalFinal.ToString("Q 0,0.00");
                //}
                //else
                //{

                //else
                //{
                //FUNCIONAL
                CapInicial = Convert.ToDouble(txt_capInicial_IC.Text);

                Interes = Convert.ToDouble(txt_Interes_IC.Text);

                Tiempo = int.Parse(txt_Tiempo_IC.Text);

                Double forIn = (1 + (Interes / 100));//se realiza una operación de suma y división aparte y en un orden especifico 
                Double potencia1 = Math.Pow(forIn,Tiempo);//el resultado de la op anterior pasa a una variable que forma parte de otra op para 2cuad

                CapitalFinal = CapInicial * potencia1;
                valor = Convert.ToDecimal(CapitalFinal);
                txt_capFinal_IC.Text = CapitalFinal.ToString("Q 0,0.00");
                //}

                //Double potencia = Math.Pow(Tiempo, Op);
                //potencia = potencia + CapInicial;

                ////CapitalFinal = CapInicial * potencia;

                //txt_capFinal_IC.Text = potencia.ToString("Q 0,0.00");

                //Decimal op = 1 + Interes / 100;
                //CapitalFinal = CapInicial * op ^ 4;
                ////CapitalFinal += CapitalFinal ^ Tiempo;
                ////Double potencia = Math.Pow(CapitalFinal, Tiempo);
                ////valor = CapitalFinal;

                //txt_capFinal_IC.Text = potencia.ToString("Q 0,0.00");
                //}                               
            }
        }

        private void btn_borrar_IC_Click(object sender, EventArgs e)
        {
            txt_capInicial_IC.Text = "0.00";
            txt_Interes_IC.Text = "0.0";
            txt_Tiempo_IC.Text = "0";
            txt_capFinal_IC.Text = "Q 0,0.00";
        }

        private void lbl_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para obtener el interés compuesto es: \n(CapInicial) * (1 + (Intéres / 100))ʌTiempo", "Fórmula", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbl_ayuda_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_text.Visible = true;
        }

        private void lbl_ayuda_MouseLeave(object sender, EventArgs e)
        {
            lbl_text.Visible = false;
        }

        private void btn_salir_IC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
