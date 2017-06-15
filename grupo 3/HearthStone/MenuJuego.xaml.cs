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
    /// Lógica de interacción para MenuJuego.xaml
    /// </summary>
    public partial class MenuJuego : Window
    {
        public MenuJuego()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NuevaPartida NP = new NuevaPartida();
            NP.Show();
            this.Close();

            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Collapsed;
        }
    }
}
