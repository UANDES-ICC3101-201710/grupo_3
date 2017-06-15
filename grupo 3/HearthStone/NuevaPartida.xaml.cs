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
    /// Lógica de interacción para NuevaPartida.xaml
    /// </summary>
    public partial class NuevaPartida : Window
    {
        

        public NuevaPartida()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Jugador1 = textBox.Text;
            string Jugador2 = textBox1.Text;
            ElegirHeroe EH = new ElegirHeroe();
            EH.Show();
            this.Close();

        }


        public string Jugador1
        {
            get
            {
                return Jugador1;
            }
            set
            {
                Jugador1 = value;
            }
        }

        public string Jugador2
        {
            get
            {
                return Jugador2;
            }
            set
            {
                Jugador2 = value;
            }
        }


    }
}
