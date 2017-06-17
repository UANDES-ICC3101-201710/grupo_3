using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone
{
    public interface IJugadas
    {
        void Agregarcartamazo(Carta carta);

        void Agregarcartamano();

        void Agregarcartalado(Jugador jugador);

        void Aumentargema();

        void Regenerargema();

        void Shuffle(Random rnd);

        void HabilidadHeroe(Jugador jugador1, Jugador jugador2);

        void Enfrentar(Jugador jugador1, Jugador jugador2);

        void Jugar(Jugador jugador1, Jugador jugador2);

        void Despertar(Jugador jugador);

        void Morir(Jugador jugador, int indice);

        void Rendirse(Jugador jugador1, Jugador jugador2);

        void CambioMano(Jugador jugador, Random rnd);



    }
}
