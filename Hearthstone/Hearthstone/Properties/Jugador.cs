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
    public class Jugador : IJugadas, INotifyPropertyChanged
    {
        
        private int Vida;
        private int Defensa;
        private int LimiteGema;
        private int Gema;
        private int Identificador;
        private string Nombrejugador;
        private bool GanPer;
        private bool HabilidadaUsada;
        private int Turno;
        private string Nombreheroe;
        private string Habilidadheroe;
        public List<Carta> Mazo = new List<Carta>();
        public List<Carta> Mano = new List<Carta>();
        public List<Esbirro> Tablerojugador = new List<Esbirro>();

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int vida
        {
            get { return Vida; }
            set { Vida = value;
                OnPropertyChanged();
            }
            
            

        }

    public int defensa
        {
            get { return Defensa; }
            set { Defensa = value;
                OnPropertyChanged();
            }
        }

        public int identificador
        {
            get { return Identificador; }
            set { Identificador = value;
                OnPropertyChanged();
            }

        }

        public int gema
        {
            get { return Gema; }
            set { Gema = value;
                OnPropertyChanged();
            }
        }

        public int limitegema
        {
            get { return LimiteGema; }
            set { LimiteGema = value;
                OnPropertyChanged();
            }
        }

        public string nombrejugador
        {
            get { return Nombrejugador; }
            set { Nombrejugador = value;
                OnPropertyChanged();
            }
        }

        public bool ganper
        {
            get { return GanPer; }
            set { GanPer = value;
                OnPropertyChanged();
            }
        }

        public bool habilidadusada
        {
            get { return HabilidadaUsada; }
            set { HabilidadaUsada = value;
                OnPropertyChanged();
            }
        }


        public int turno
        {
            get { return Turno; }
            set { Turno = value;
                OnPropertyChanged();
            }
        }

        public string nombreheroe
        {
            get { return Nombreheroe; }
            set { Nombreheroe = value;
                OnPropertyChanged();
            }
        }

        public string habilidadheroe
        {
            get { return Habilidadheroe; }
            set { Habilidadheroe = value;
                OnPropertyChanged();
            }
        }

        public void Agregarcartamazo(Carta carta)
        {
            Mazo.Add(carta);
        }

        public void Agregarcartamano()
        //este metodo agrega la carta a la mano y borra la carta en el mazo
        {
            if (Mano.Count == 10)
            {
                MessageBox.Show("Ha llegado al maximo de cartas en la mano");
            }
            else
            {
                Mano.Add(Mazo.ElementAt(0));
                Mazo.RemoveAt(0);
            }
        }

        public void Agregarcartalado(Jugador jugador, int indice)
        {
            if (Tablerojugador.Count == 7)
            {
                MessageBox.Show("Ha llegado al maximo de cartas en el tablero");

            }
            else
            {

                if (Mano.ElementAt(indice).costo <= gema)
                {
                    if (Mano.ElementAt(indice).tipo == "Esbirro")
                    {
                        Carta aux = Mano.ElementAt(indice);
                        if (aux.GetType().Equals(typeof(Esbirro)))
                        {
                            Esbirro esbirro = (Esbirro)aux;
                            Tablerojugador.Add(esbirro);
                            jugador.gema = jugador.gema - Mano.ElementAt(indice).costo;
                            Mano.RemoveAt(indice);
                        }

                        else
                        {

                        }

                    }
                    else
                    {

                        Carta aux = Mano.ElementAt(indice);
                        if (aux.GetType().Equals(typeof(Hechizo)))
                        {
                            Hechizo hechizo = (Hechizo)aux;
                            if (jugador.gema < 10)
                            {
                                hechizo.HabilidadMoneda(jugador);
                                jugador.gema = jugador.gema - Mano.ElementAt(indice).costo;
                                Mano.RemoveAt(indice);
                            }
                            else
                            {
                                MessageBox.Show("Ya tienes el maximo de gema");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No tienes suficiente gema");
                }

            }

        }

        public void Aumentargema()
        {
            if (limitegema < 10)
            {
                limitegema += 1;
            }
        }

        public void Regenerargema()
        {
            gema = limitegema;
        }

        public void Shuffle(Random rnd)
        {
            int n = Mazo.Count;
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                Carta value = Mazo[k];
                Mazo[k] = Mazo[n];
                Mazo[n] = value;
            }
        }

        public void Enfrentar(Jugador jugador1, Jugador jugador2, int indicej1, int indicej2, int eleccion, int dice)
        {
            if (dice == jugador1.turno)
            {
                if (jugador1.Tablerojugador[indicej1].despierto == true)
                {
                    if (jugador1.Tablerojugador[indicej1].ataco == false)
                    {

                        if (eleccion == 1)
                        {
                            if (jugador2.defensa <= 0)
                            {
                                jugador2.vida -= jugador1.Tablerojugador[indicej1].ataque;
                                if (jugador2.vida <= 0)
                                {
                                    jugador2.ganper = true;
                                    MessageBox.Show(jugador1.nombrejugador + " gano la partida");
                                    Application.Current.Shutdown();
                                }
                            }
                            else
                            {
                                jugador2.defensa -= jugador1.Tablerojugador[indicej1].ataque;
                                if (jugador2.defensa <= 0)
                                {
                                    jugador2.vida += jugador2.defensa;
                                    jugador2.defensa = 0;
                                    if (jugador2.vida <= 0)
                                    {
                                        jugador2.ganper = true;
                                        MessageBox.Show(jugador1.nombrejugador + " gano la partida");
                                        Application.Current.Shutdown();
                                    }
                                }
                            }
                            jugador1.Tablerojugador[indicej1].ataco = true;
                        }

                        else
                        {
                            //si ataca a un esbirro oponente

                            jugador2.Tablerojugador[indicej2].defensa -= jugador1.Tablerojugador[indicej1].ataque;
                            jugador1.Tablerojugador[indicej1].defensa -= jugador2.Tablerojugador[indicej2].ataque;
                            jugador1.Tablerojugador[indicej1].ataco = true;
                            jugador1.Morir(jugador1, indicej1);
                            jugador2.Morir(jugador2, indicej2);
                        }



                    }


                    else
                    {
                        MessageBox.Show("Ese esbirro ya ataco");
                    }
                }
                else
                {
                    MessageBox.Show("Ese esbirro esta dormido");
                }

            }
            else
            {
                MessageBox.Show("Puedes atacar solo en tu turno");
            }


        }

        public void Despertar(Jugador jugador)
        {
            foreach (Esbirro esbirro in jugador.Tablerojugador)
            {
                if (esbirro.despierto == false)
                {
                    esbirro.despierto = true;
                }
                esbirro.ataco = false;
            }
        }

        public void Morir(Jugador jugador, int indice)
        { 
                if (jugador.Tablerojugador[indice].defensa <= 0)
                {
                    jugador.Tablerojugador.RemoveAt(indice);
                }
        }

        public void HabilidadHeroe(Jugador jugador1, Jugador jugador2, int indiceJ1, int indiceJ2, int eleccion)
        {
            if (jugador1.habilidadheroe == "Steady Shot")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                if (jugador2.defensa <= 0)
                {
                    jugador2.vida -= 2;
                    if (jugador2.vida <= 0)
                    {
                        jugador2.ganper = true;
                        //avisar fin de partida gano jugador 1
                    }
                }

                else
                {
                    jugador2.defensa -= 2;
                    if (jugador2.defensa <= 0)
                    {
                        jugador2.vida += jugador2.defensa;
                        jugador2.defensa = 0;
                        if (jugador2.vida <= 0)
                        {
                            jugador2.ganper = true;
                            //avisasr fin de partida gano jugador 1
                        }
                    }
                }
            }
            else if (jugador1.habilidadheroe == "Armor Up!")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                jugador1.defensa += 2;
            }
            else if (jugador1.habilidadheroe == "Lesser Heal")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                if (eleccion == 1)
                {
                    if (jugador1.vida <= 28)
                    {
                        jugador1.vida += 2;
                    }
                    else
                    {
                        jugador1.vida = 30;
                    }
                }
                else
                {
                    jugador1.Tablerojugador[indiceJ1].defensa += 2;
                    if (jugador1.Tablerojugador[indiceJ1].defensa >= jugador1.Tablerojugador[indiceJ1].maxdefensa)
                    {
                        jugador1.Tablerojugador[indiceJ1].defensa = jugador1.Tablerojugador[indiceJ1].maxdefensa;
                    }
                }
            }
            else if (jugador1.habilidadheroe == "Life Tap")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                jugador1.Agregarcartamano();
                jugador1.vida = jugador1.vida - 2;
                if (jugador1.vida <= 0)
                {
                    jugador1.ganper = true;
                    //avisar fin de partida
                }
            }
            else if (jugador1.habilidadheroe == "Fireblast")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                if (eleccion == 1)
                {
                    if (jugador2.defensa <= 0)
                    {
                        jugador2.vida -= 1;
                        if (jugador2.vida <= 0)
                        {
                            jugador2.ganper = true;
                            //avisar fin de partida gano jugador 1
                        }
                    }

                    else
                    {
                        jugador2.defensa -= 1;
                        if (jugador2.defensa <= 0)
                        {
                            jugador2.vida += jugador2.defensa;
                            jugador2.defensa = 0;
                            if (jugador2.vida <= 0)
                            {
                                jugador2.ganper = true;
                                //avisasr fin de partida gano jugador 1
                            }
                        }
                    }
                }
                else
                {
                    jugador2.Tablerojugador[indiceJ2].defensa -= 1;
                    jugador2.Morir(jugador2, indiceJ2);
                }
            }
            else if (jugador1.habilidadheroe == "Shapeshift")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                jugador1.defensa = jugador1.defensa + 1;
                if (eleccion == 1)
                {
                    if (jugador2.defensa <= 0)
                    {
                        jugador2.vida -= 1;
                        if (jugador2.vida <= 0)
                        {
                            jugador2.ganper = true;
                            //avisar fin de partida gano jugador 1
                        }
                    }

                    else
                    {
                        jugador2.defensa -= 1;
                        if (jugador2.defensa <= 0)
                        {
                            jugador2.vida += jugador2.defensa;
                            jugador2.defensa = 0;
                            if (jugador2.vida <= 0)
                            {
                                jugador2.ganper = true;
                                //avisasr fin de partida gano jugador 1
                            }
                        }
                    }
                }
                else
                {
                    jugador2.Tablerojugador[indiceJ2].defensa -= 1;
                    jugador2.Morir(jugador2, indiceJ2);
                }
               
            }
            else if (jugador1.habilidadheroe == "Reinforce")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                Esbirro SilverHandRecruit = new Esbirro();
                SilverHandRecruit.nombre = "Silver Hand Recruit";
                SilverHandRecruit.costo = 1;
                SilverHandRecruit.ataque = 1;
                SilverHandRecruit.defensa = 1;
                SilverHandRecruit.tipo = "Esbirro";
                SilverHandRecruit.subtipo = null;
                SilverHandRecruit.despierto = false;
                SilverHandRecruit.ataco = false;
                jugador1.Tablerojugador.Add(SilverHandRecruit);
            }
            else if (jugador1.habilidadheroe == "Dagger Mastery")
            {
                if (eleccion == 1)
                {
                    jugador2.vida -= 1;
                    if (jugador2.vida <= 0)
                    {
                        jugador2.ganper = true;
                    }
                }
                else
                {
                    jugador2.Tablerojugador[indiceJ2].defensa -= 1;
                    jugador2.Morir(jugador2, indiceJ2);
                }
            }
            else if (jugador1.habilidadheroe == "Totemic Call")
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                Esbirro Healingtotem = new Esbirro();
                Healingtotem.nombre = "Healing Totem";
                Healingtotem.costo = 1;
                Healingtotem.ataque = 0;
                Healingtotem.defensa = 2;
                Healingtotem.tipo = "Esbirro";
                Healingtotem.subtipo = null;
                Healingtotem.despierto = false;
                Healingtotem.ataco = false;
                jugador1.Tablerojugador.Add(Healingtotem);
            }
        }

        public void Rendirse(Jugador jugador1, Jugador jugador2)
        {
            jugador1.ganper = true;
            MessageBox.Show(jugador1.nombrejugador + " se rindio. " + jugador2.nombrejugador + " gano la partida");
            Application.Current.Shutdown();
        }

        public void CambioMano(Jugador jugador, Random rnd, Carta carta, int i)
        {

            jugador.Agregarcartamazo(carta);
            jugador.Mano.RemoveAt(i);
            jugador.Shuffle(rnd);
            jugador.Agregarcartamano();
        }
    }
}
