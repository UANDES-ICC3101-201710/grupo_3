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
    [Serializable]
    public class Esbirro : Carta
    {
        private int Ataque;
        private int Defensa;
        private int MaxDefensa;
        private string SubTipo;
        private bool Despierto;
        private bool Ataco;
       

        public int ataque
        {
            get { return Ataque; }
            set { Ataque = value; }
        }

        public int defensa
        {
            get { return Defensa; }
            set { Defensa = value;}
        }

        public int maxdefensa
        {
            get { return MaxDefensa; }
            set { MaxDefensa = value; }
        }

        public string subtipo
        {
            get { return SubTipo; }
            set { SubTipo = value; }
        }

        public bool despierto
        {
            get { return Despierto; }
            set { Despierto = value;
              
            }
        }

        public bool ataco
        {
            get { return Ataco; }
            set { Ataco = value;
              
            }
        }

        public void TotemHeal(Jugador jugador1)
        {
            foreach (Esbirro esbirro in jugador1.Tablerojugador)
            {
                if (esbirro.defensa < esbirro.maxdefensa)
                {
                    esbirro.defensa += 1;
                }
            }
        }
    }
}
