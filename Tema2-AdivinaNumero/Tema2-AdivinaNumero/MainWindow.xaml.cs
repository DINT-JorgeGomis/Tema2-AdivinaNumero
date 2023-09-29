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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int NumeroRandom;
        public MainWindow()
        {
            NumeroRandom = new Random().Next(0, 101);
            InitializeComponent();
        }

        private void Comprobar(object sender, RoutedEventArgs e)
        {
            Respuesta.Foreground = new SolidColorBrush(Colors.Red);
            if (int.TryParse(Caja.Text, out int result))
            {
                if (result == NumeroRandom) {
                    Respuesta.Content = "ES CORRECTO!!";
                    Respuesta.Foreground = new SolidColorBrush(Colors.Green);
                } else
                {
                    Respuesta.Content = "NO ES CORRECTO";
                }
            } else
            {
                Respuesta.Content = "NO ES UN NÚMERO!!";
            }
        }

        private void Reiniciar(object sender, RoutedEventArgs e)
        {
            NumeroRandom = new Random().Next(0, 101);
            Respuesta.Content = "";
        }
    }
}
