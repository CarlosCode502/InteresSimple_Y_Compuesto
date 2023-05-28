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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Establece la ventana al centro de la pantalla al iniciar el programa
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_interesSimple_Click(object sender, EventArgs e) 
        {
            //Se crea una instancia del form IS
            InteresSimple IS = new InteresSimple();
            IS.ShowDialog();//se muestra el form en un cuadro de dialogo
        }

        private void btn_interesCompuesto_Click(object sender, EventArgs e)
        {          
            //instancia del form IC
            InteresCompuesto IC = new InteresCompuesto();
            IC.ShowDialog();//cuadro de dialogo
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();//se cierra el programa 
        }
    }
}
