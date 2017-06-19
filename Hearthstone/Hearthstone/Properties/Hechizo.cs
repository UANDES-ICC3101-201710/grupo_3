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
   public class Hechizo : Carta 
    {
        private string Habilidad;


        public string habilidad
        {
            get { return Habilidad; }
            set { Habilidad = value; }
        }

        public void OtorgarMoneda(Jugador jugador, int dice, Hechizo hechizo)
        {
            if (jugador.turno != dice)
            {
                jugador.Mano.Add(hechizo);
            }

        }

        public void HabilidadMoneda(Jugador jugador)
        {
            jugador.gema ++;
            //consola.AumentoGemaMoneda();
        }
    }
}
