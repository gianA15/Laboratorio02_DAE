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

namespace Laboratorio02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            //Window1 window = new Window1();
            //this.Close();
            //window.Show();

            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Password;

  
            if (AutenticarUsuario(nombreUsuario, contraseña))
            { 
                MessageBox.Show("Inicio de sesión exitoso");
                Window1 window = new Window1();
                this.Close();
                window.Show();
            }
            else
            { 
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }

        private void txtBorrar_texto(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Usuario")
            {
                textBox.Text = string.Empty;
            }
        }

        private bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            return nombreUsuario == "gian" && contraseña == "123456";
        }
    }
}
