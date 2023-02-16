using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow Inicio;

        public Window1(MainWindow ventanaIncio)
        {
            Inicio = ventanaIncio;
            InitializeComponent();
        }

        

        private void BBB_Click(object sender, RoutedEventArgs e)
        {
            Inicio.Show();
            this.Hide();
        }

        private void W2_Closing(object sender, CancelEventArgs e)
        {
            if (this.Visibility == Visibility.Visible )
            {
                MessageBox.Show("Hola, mensaje al capturar ->  X");
                e.Cancel = true;
                Inicio.Show();
                this.Hide();
            }
        }

        private void BDiag1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if ( fichero.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(fichero.FileName);
            }
            else
            {
                MessageBox.Show(" No se ha selecionado NADA","Nada de nada",MessageBoxButton.OK ,MessageBoxImage.Exclamation);
            }
        }

        private void BDiag2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            fichero.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //fichero.InitialDirectory= @"c:\";
            fichero.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments );
            if (fichero.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(fichero.FileName);
            }
            else
            {
                MessageBox.Show(" No se ha selecionado NADA", "Nada de nada", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BDiag3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            fichero.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fichero.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fichero.Multiselect = true;
            if (fichero.ShowDialog() == true)
            {
                foreach (string ficha in fichero.FileNames )
                {
                    lsFicreros.Items.Add(System.IO.Path.GetFileName(ficha));
                }
            }
            else
            {
                MessageBox.Show(" No se ha selecionado NADA", "Nada de nada", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
