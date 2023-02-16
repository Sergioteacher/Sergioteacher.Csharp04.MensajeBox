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
using System.IO;
using Microsoft.Win32;

namespace Sergioteacher.Csharp04.MensajeBox
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow Inicio;

        public Window2(MainWindow ventanaIncio)
        {
            InitializeComponent();
            Inicio = ventanaIncio;
        }

        private void BGuar1_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog ficherito = new SaveFileDialog();
            ficherito.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs|All files (*.*)|*.*";
            if (ficherito.ShowDialog() == true )
            {
                File.WriteAllText(ficherito.FileName, txtEditar.Text);
            }
            else
            {
                MessageBox.Show(" Cancelado ", "Na de na", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        
        private void BGuar2_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog ficherito = new SaveFileDialog();
            ficherito.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs|All files (*.*)|*.*";
            ficherito.InitialDirectory = @"c:\";
            ficherito.AddExtension = true;
            if (ficherito.ShowDialog() == true)
            {
                File.WriteAllText(ficherito.FileName, txtEditar.Text);
            }
            else
            {
                MessageBox.Show(" Cancelado ", "Na de na", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        

        private void W3_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Visibility == Visibility.Visible)
            {
                MessageBox.Show("Hola, mensaje al capturar ->  X");
                e.Cancel = true;
                Inicio.Show();
                this.Hide();
            }
        }
    }
}
