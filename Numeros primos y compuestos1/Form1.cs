using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_primos_y_compuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Numeros()
        {
            //Declaramos las variables
            int inicio;
            int final;
            int contador;

            //Condición que valida el TextBox_Inicial
            if (TextBox_Inicial.Text == "")
            {
                MessageBox.Show("Ingrese un valor Inicial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Condición que valida el TextBox_Final
                if (TextBox_Final.Text == "")
                {
                    MessageBox.Show("Ingrese un valor Final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    /* Método que extrae el valor ingresado en el TextBox_Inicia,
                       y TextBox_Final y lo convierte en un tipo entero y lo almacena 
                       en las variables inicio y final */
                    inicio = Convert.ToInt32(TextBox_Inicial.Text);
                    final = Convert.ToInt32(TextBox_Final.Text);

                    /*Ciclo for que recorre un valor en pensando por el valor almacenado en la
                      Variable inicio hasta el valor almacenado en la variable final */
                    for (int i = inicio; i <= final; i++)
                    {
                        contador = 0;

                        /* Ciclo for que nos ayudara a recorrer el valor almacenado en la variable i
                          para poder evaluar todo los numero que son divisibles por si mismos */
                        for (int j = 1; j <= i; j++)
                        {
                            /* Condición que si i%j es la división para buscar el 
                            residuo y si el residuo es igual a 0 que contador
                            se incremente en 1 */
                            if (i%j==0)
                            {
                                contador++;
                            }
                        }
                        /* Condición que si contador es igual a 2 esto es porque los números
                        primos solo es divisible por 2 número por sí mismo y por 1 */
                        if (contador == 2)
                        {
                            ListBox_Primos.Items.Add(i);
                        }
                        else
                        {
                            ListBox_Compuestos.Items.Add(i);
                        }
                    }
                }
            }
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            Numeros();
        }

        private void Button_Clean_Click(object sender, EventArgs e)
        {
            //limpiamos los controles 
            TextBox_Inicial.Text = "";
            TextBox_Final.Text = "";
            ListBox_Primos.Items.Clear();
            ListBox_Compuestos.Items.Clear();
            TextBox_Inicial.Focus();

        }
    }
}
