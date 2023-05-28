﻿using System;
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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //SI EL COMBOCOX ES DE:
            //DIAS 5/365
            //MESES 5/12
            //TRIMESTRES 5/400
            //SEMESTRES
            //AÑOS


            //si el campo capInicial esta vacio debe mostrar un msj que pida ingresar los valores
            if(String.IsNullOrEmpty(txt_capInicial.Text) || String.IsNullOrEmpty(txt_tasaInteres.Text) || String.IsNullOrEmpty(txt_tiempo.Text))
            {
                MessageBox.Show("¡¡¡Debe llenar todos los campos!!!");
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

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            txt_capInicial.Clear();
            txt_tasaInteres.Clear();
            txt_tiempo.Clear();
            txt_is_Total.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}