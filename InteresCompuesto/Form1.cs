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
            //se muestra el form en un cuadro de dialogo
            IS.ShowDialog();
        }

        private void btn_interesCompuesto_Click(object sender, EventArgs e)
        {          
            //instancia del form IC
            InteresCompuesto IC = new InteresCompuesto();
            //cuadro de dialogo
            IC.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Esta segur@ que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No){}
            else
            {
                Application.Exit();//se cierra el programa 
            }
        }
    }
}
