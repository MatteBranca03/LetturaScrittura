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

namespace LetturaScrittura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i;
            int n = int.Parse(txtNumero.Text);
            if (n < 0)
            {
                MessageBox.Show("Il numero iserito è minore di 0", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int[] array = new int[n];
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1,7);
                    
                }

                lblRisultato.Content = "[";

                for (i = 0; i < array.Length; i++)
                {

                    lblRisultato.Content += $"{array[i]}";
                    if (i< array.Length-1)
                    {
                        lblRisultato.Content += ",";
                    }


                }


                lblRisultato.Content += "]";






            }
        }
    }
}