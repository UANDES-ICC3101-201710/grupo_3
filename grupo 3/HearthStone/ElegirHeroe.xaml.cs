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

namespace HearthStone
{
    /// <summary>
    /// Lógica de interacción para ElegirHeroe.xaml
    /// </summary>
    public partial class ElegirHeroe : Window
    {
        public ElegirHeroe()
        {
            InitializeComponent();
            
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String H1 = comboBox.Text;
            String H2 = comboBox1.Text;

            
            
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
