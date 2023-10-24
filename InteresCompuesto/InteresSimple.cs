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
    public partial class InteresSimple : Form
    {
        private Decimal CapitalIni;
        private Decimal Interes;
        private int Tiempo;
        private Decimal InteresFinal;

        public InteresSimple()
        {
            InitializeComponent();
            //this.CenterToScreen();
            this.StartPosition = FormStartPosition.CenterScreen; //inicia la ventana al centro de la pantalla
            cmb_tiempo_AnuMens.SelectedIndex = 0;//el combobox inicia o muestra el elemento en la posicion 0 al iniciar el programa
        }

        //Al posicionar el mouse sobre el objeto especifico este cambiara su color y tamaño de borde 
        //esto con el fin de crear un efecto de entrada o enfoque
        public void RatonMove(object sender, MouseEventArgs e)
        {
            var boton = (Button)sender;
            boton.FlatAppearance.BorderColor = Color.Goldenrod;
            boton.FlatAppearance.BorderSize = 4;
        }

        //tiene la función a través de los eventos del teclado y tiene lugar cuando el puntero sale del foco del componente
        public void RatonLeave(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            boton.FlatAppearance.BorderColor = Color.Black;
            boton.FlatAppearance.BorderSize = 2;

        }

        //public void RatonLeave(object sender, MouseEventArgs e)
        //{
        //    var boton = (Button)sender;
        //    boton.FlatAppearance.BorderColor = Color.Black;
        //}


        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //SI EL COMBOCOX ES DE:
            //DIAS 5/365
            //MESES 5/12
            //TRIMESTRES 5/400
            //SEMESTRES
            //AÑOS


            //si el campo capInicial esta vacio debe mostrar un msj que pida ingresar los valores
            if(String.IsNullOrEmpty(txt_capInicial.Text) || String.IsNullOrEmpty(txt_tasaInteres.Text) || String.IsNullOrEmpty(txt_tiempo.Text) || txt_capInicial.Text == "0.00" || txt_tasaInteres.Text == "0.0" || txt_tiempo.Text == "0")
            {
                //Msg personalizado 
                MessageBox.Show("¡Ingrese los valores que desea calcular!", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //sino se procedera a lo siguiente                
            else
            {
                //Capital Inicial
                //CapitalIni = Convert.ToDouble(txt_capInicial.Text);
                CapitalIni = Convert.ToDecimal(txt_capInicial.Text);

                //Tasa de interés fórmula a utilizar: (I/100)
                //Interes = Convert.ToDouble(txt_tasaInteres.Text);
                Interes = Convert.ToDecimal(txt_tasaInteres.Text);

                //Tiempo (Dias,Meses,Trimestres,Semestres,Años)
                Tiempo = int.Parse(txt_tiempo.Text);

                //Determina el resultado en base al tiempo seleccionado
                //Crea una nueva variable con el valor seleccionado en el cmbox
                String name = cmb_tiempo_AnuMens.Text;

                switch (name)
                {                ////Fórmula para obtener el IF (CapIni * (I/100) * Tiempo)
                    case "Dias":
                        InteresFinal = Convert.ToDecimal(CapitalIni * (Interes / 365) * Tiempo);
                        break;

                    case "Meses":
                        InteresFinal = Convert.ToDecimal(CapitalIni * (Interes / 12) * Tiempo);
                        break;

                    case "Bimestres":
                        InteresFinal = Convert.ToDecimal(CapitalIni * (Interes / 600) * Tiempo);
                        break;

                    case "Trimestres":
                        InteresFinal = Convert.ToDecimal(CapitalIni * (Interes / 400) * Tiempo);
                        break;

                    case "Semestres":
                        InteresFinal = Convert.ToDecimal(CapitalIni * (Interes / 200) * Tiempo);
                        break;

                    case "Años":
                        InteresFinal = Convert.ToDecimal(CapitalIni * (Interes / 100) * Tiempo);
                        break;

                    default:
                        MessageBox.Show("¡¡¡Elija una opción de la lista!!!");
                        break;
                }

                //El contenedor pasara a mostrar el valor de la variable InteresFinal
                txt_is_Total.Text = InteresFinal.ToString("Q 0,0.00");//Se realiza un formateo del texto en donde se indica el formato de salida requerido
            }
        }

        //metodo para limpiar los campos
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            cmb_tiempo_AnuMens.SelectedIndex = 0;
            txt_capInicial.Text = "0.00";
            txt_tasaInteres.Text = "0.0";
            txt_tiempo.Text = "0";
            txt_is_Total.Text = "Q 0,0.00";
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
