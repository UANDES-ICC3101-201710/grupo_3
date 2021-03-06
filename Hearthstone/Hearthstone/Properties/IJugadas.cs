﻿using System;
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
    public interface IJugadas
    {
        void Agregarcartamazo(Carta carta);

        void Agregarcartamano();

        void Agregarcartalado(Jugador jugador, int indice);

        void Aumentargema();

        void Regenerargema();

        void Shuffle(Random rnd);

        void HabilidadHeroe(Jugador jugador1, Jugador jugador2, int indiceJ1, int indiceJ2, int eleccion);

        void Enfrentar(Jugador jugador1, Jugador jugador2, int indicej1, int indicej2, int eleccion, int dice);

        void Despertar(Jugador jugador);

        void Morir(Jugador jugador, int indice);

        void Rendirse(Jugador jugador1, Jugador jugador2);

        void CambioMano(Jugador jugador, Random rnd, Carta carta, int i);



    }
}
