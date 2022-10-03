using System;
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

namespace Tema2_CuadrosTexto
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

        private void PulsadoF1(object sender, KeyEventArgs e)
        {
            AyudaApellidoTextBlock.Text = "";
            AyudaNombreTextBlock.Text = "";
            Random rnd = new Random();
            if (Keyboard.IsKeyDown(Key.F1))
            {
                int random = rnd.Next(1, 3);
                if(random == 1)
                {
                    AyudaApellidoTextBlock.Text = "Introduzca su apellido";
                }
                else if(random == 2)
                {
                    AyudaNombreTextBlock.Text = "Introduzca su nombre";
                }
                
            }
        }
    }
}
