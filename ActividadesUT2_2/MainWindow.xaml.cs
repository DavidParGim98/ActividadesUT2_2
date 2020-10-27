using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ActividadesUT2_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void ComprobarEstado(object sender, RoutedEventArgs e)
        {
            if (Operador_TextBox.Text=="")
            {
                Calcular_Button.IsEnabled = false;
            }
            else
            {
                Calcular_Button.IsEnabled = true;
            }
        }

        private void ClickCalcular_Button(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = int.Parse(OperandoUno_TextBox.Text);
                int y = int.Parse(OperandoDos_TextBox.Text);
                string z = Operador_TextBox.Text;

                switch (z)
                {
                    case "+":
                        Resultado_TextBox.Text = (x + y).ToString();
                        break;
                    case "-":
                        Resultado_TextBox.Text = (x - y).ToString();
                        break;
                    case "*":
                        Resultado_TextBox.Text = (x * y).ToString();
                        break;
                    case "/":
                        if (y == 0)
                        {
                            MessageBox.Show("Revise el segundo operando");
                        }
                        else Resultado_TextBox.Text = (x / y).ToString();
                        break;
                    default:
                        MessageBox.Show("Introduce un operador válido");
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Comprueba los operandos");
            }
        }

        private void ClickLimpiar_Button(object sender, RoutedEventArgs e)
        {
            OperandoUno_TextBox.Clear();
            OperandoDos_TextBox.Clear();
            Operador_TextBox.Clear();
            Resultado_TextBox.Clear();
        }
    }
}
