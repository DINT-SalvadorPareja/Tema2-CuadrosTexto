using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            NombreTextBox.Tag = 1;
            ApellidoTextBox.Tag = 2;
            AyudaNombreTextBlock.Visibility = Visibility.Hidden;
            AyudaApellidoTextBlock.Visibility = Visibility.Hidden;
            AyudaEdadTextBlock.Visibility = Visibility.Hidden;


        }

        private void PulsadoF1(object sender, KeyEventArgs e)
        {
            

            TextBox cajaTexto = sender as TextBox;

            if (Keyboard.IsKeyDown(Key.F1))
            {
                switch(cajaTexto.Tag)
                {
                    case 1:
                        AyudaNombreTextBlock.Visibility = Visibility.Visible;
                        cajaTexto.Tag = 3;
                        break;
                    case 2:
                        AyudaApellidoTextBlock.Visibility = Visibility.Visible;
                        cajaTexto.Tag = 4;
                        break;
                    case 3:
                        AyudaNombreTextBlock.Visibility = Visibility.Hidden;
                        
                        cajaTexto.Tag = 1;
                        break;
                    case 4:
                        
                        AyudaApellidoTextBlock.Visibility = Visibility.Hidden;
                        cajaTexto.Tag = 2;
                        break;
                }
                
            }
        }

        private void PulsadoF2(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.F2))
            {
                
                if(Regex.IsMatch(EdadTextBox.Text, @"\d") == false)
                {
                    AyudaEdadTextBlock.Visibility = Visibility.Visible;

                }
                else
                {
                    AyudaEdadTextBlock.Visibility = Visibility.Hidden;
                }

            }

        }
    }
}
