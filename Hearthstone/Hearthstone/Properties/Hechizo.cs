using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
