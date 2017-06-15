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

namespace HearthStone
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [Serializable]
        public abstract class Carta
        {
            private string Nombre;
            private int Costo;
            private string Tipo;

            public string nombre
            {
                get { return Nombre; }
                set { Nombre = value; }
            }

            public int costo
            {
                get { return Costo; }
                set { Costo = value; }
            }

            public string tipo
            {
                get { return Tipo; }
                set { Tipo = value; }
            }

        }
        

        public MainWindow()
        {
            InitializeComponent();
            
        }


        string NombreJ1 { get; set; }
        string NombreJ2 { get; set; }
        string HeroeJ1 { get; set; }
        string HeroeJ2 { get; set; }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Logo_HS_png.Visibility = Visibility.Hidden;
            JUGAR.Visibility = Visibility.Hidden;
            NuevaPartida.Visibility = Visibility.Visible;
            CargarPartida.Visibility = Visibility.Visible;
        }

        private void NuevaPartida_Click(object sender, RoutedEventArgs e)
        {
            CargarPartida.Visibility = Visibility.Hidden;
            NuevaPartida.Visibility = Visibility.Hidden;
            Label1.Visibility = Visibility.Visible;
            tb1.Visibility = Visibility.Visible;
            tb2.Visibility = Visibility.Visible;
            jugador1.Visibility = Visibility.Visible;
            label2.Visibility = Visibility.Visible;
            Siguiente.Visibility = Visibility.Visible;
        }

        private void NombreJugadores(object sender, RoutedEventArgs e)
        {
            NombreJ1 = tb1.Text;
            NombreJ2 = tb2.Text;

            Label1.Visibility = Visibility.Hidden;
            tb1.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
            jugador1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            Siguiente.Visibility = Visibility.Hidden;
            EH.Visibility = Visibility.Visible;
            label21.Visibility = Visibility.Visible;
            label22.Visibility = Visibility.Visible;
            comboBox.Visibility = Visibility.Visible;
            comboBox1.Visibility = Visibility.Visible;
            Jugar.Visibility = Visibility.Visible;
            HabilidadJ1.Visibility = Visibility.Visible;
            HabilidadJ2.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Visible;
            label1.Visibility = Visibility.Visible;

        }

        private void SeleccionHeroes(object sender, RoutedEventArgs e)
        {
            //HeroeJ1 = comboBox.Text;
            //HeroeJ2 = comboBox1.Text;

            EH.Visibility = Visibility.Hidden;
            label21.Visibility = Visibility.Hidden;
            label22.Visibility = Visibility.Hidden;
            comboBox.Visibility = Visibility.Hidden;
            comboBox1.Visibility = Visibility.Hidden;
            Jugar.Visibility = Visibility.Hidden;
            HabilidadJ1.Visibility = Visibility.Hidden;
            HabilidadJ2.Visibility = Visibility.Hidden;
            label.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;


        }


        private void CargarPartida_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBoxItem cbi = (ComboBoxItem)comboBox.SelectedItem;
            string HeroeJ1 = cbi.Content.ToString();

            if (HeroeJ1 == "Druid")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if (HeroeJ1 == "Hunter")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if (HeroeJ1 == "Mage")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if (HeroeJ1 == "Paladin")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if (HeroeJ1 == "Priest")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if (HeroeJ1 == "Rogue")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if (HeroeJ1 == "Shaman")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if (HeroeJ1 == "Warlock")
            {
                HabilidadJ1.Content = HeroeJ1;
            }
            else if(HeroeJ1 == "Warrior")
            {
                HabilidadJ1.Content = HeroeJ1;
            }

        }
        
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)comboBox1.SelectedItem;
            string HeroeJ2 = cbi.Content.ToString();
            HabilidadJ2.Content = HeroeJ2;

            if (HeroeJ2 == "Druid")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Hunter")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Mage")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Paladin")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Priest")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Rouge")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Shaman")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Warlock")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
            else if (HeroeJ2 == "Warrior")
            {
                HabilidadJ2.Content = HeroeJ2;
            }
        }
    }
}
