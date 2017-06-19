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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Hearthstone
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
}
