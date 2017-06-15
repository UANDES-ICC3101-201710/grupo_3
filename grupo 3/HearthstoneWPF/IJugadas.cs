using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Hearthstone
{
    public interface IJugadas
    {
        void Agregarcartamazo(Carta carta);

        void Agregarcartamano(Consola consola);

        void Agregarcartalado(Jugador jugador, Consola consola);

        void Aumentargema();

        void Regenerargema();

        void Shuffle(Random rnd);

        void HabilidadHeroe(Jugador jugador1, Jugador jugador2, Consola consola);

        void Enfrentar(Jugador jugador1, Jugador jugador2, Consola consola);

        void Jugar(Jugador jugador1, Jugador jugador2, Consola consola);

        void Despertar(Jugador jugador);

        void Morir(Jugador jugador, int indice);

        void Rendirse(Jugador jugador1, Jugador jugador2, Consola consola);

        void CambioMano(Jugador jugador, Consola consola, Random rnd);



    }
}
