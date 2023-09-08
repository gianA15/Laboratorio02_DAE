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
using System.Windows.Shapes;

namespace Laboratorio02
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Ingresos(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Salida(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
        }
        private void btn_Conductores(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Transportistas(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Camiones(object sender, RoutedEventArgs e)
        {
            Window3 window = new Window3();
            window.Show();
        }
        private void btn_Productos(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Cargas(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Ingresos2(object sender, RoutedEventArgs e)
        {


        }
        private void btn_Salidas2(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
