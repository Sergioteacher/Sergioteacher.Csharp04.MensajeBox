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

namespace Sergioteacher.Csharp04.MensajeBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window1 ventana1;
        public Window2 ventana2;

        public MainWindow()
        {
            InitializeComponent();
            ventana1 = new Window1(this);
            ventana2 = new Window2(this);
        }

        private void Boton1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola mundo!");
        }

        private void Boton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola mundo!","sms Tipo 2");
        }

        private void Boton3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("Hola mundo!", "sms Tipo 3",MessageBoxButton.YesNoCancel);
            switch(resultado)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Elegido Yes", "sms Box");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Elegido No", "sms Box");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Cancelado -> Naaa","sms Box");
                    break;
            }
        }

        private void Boton4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola mundo!", "sms Tipo 4",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void Boton5_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show(" ¿Quieres ser Cantante? ", "sms Tipo 5", MessageBoxButton.YesNo, MessageBoxImage.Question,MessageBoxResult.No);
            switch (resultado)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show(" A trabajar!!! ", ";-)", MessageBoxButton.OK, MessageBoxImage.Hand);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show(" ¡Te toca bailar! ", ";-)",MessageBoxButton.OK,MessageBoxImage.Warning);
                    break;
                
            }
        }



        
        private void Boton6_Click(object sender, RoutedEventArgs e)
        {
            ventana1.Show();
            this.Hide();
        }
        private void Boton7_Click(object sender, RoutedEventArgs e)
        {
            ventana2.Show();
            this.Hide();
        }


        private void WPrincipal_Activated(object sender, EventArgs e)
        {
            //Background="Cyan"
            Tindi.Background = Brushes.Cyan;
        }

        private void WPrincipal_Deactivated(object sender, EventArgs e)
        {
            Tindi.Background = Brushes.Gray;
        }

        private void WPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show("Hola, mensaje al capturar ->  X");
            e.Cancel =true;
            Application.Current.Shutdown();
        }

        
    }
}
