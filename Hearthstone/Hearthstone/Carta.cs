using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Hearthstone
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
