using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteresCompuesto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //ESTE CODIGO SE QUITO YA QUE NO ES NECESARIO OCULTAR LA VENTANA PRINCIPAL
            ////CODIGO PARA EVITAR QUE EL PROGRAMA SE CIERRE AL CERRAR EL MAIN PRINCIPAL
            //Form1 f1 = new Form1();
            //f1.Show();
            //Application.Run();

        }
    }
}
