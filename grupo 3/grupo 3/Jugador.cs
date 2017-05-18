﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Hearthstone
{
    public class Jugador : IJugadas
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

        public int vida
        {
            get { return Vida; }
            set { Vida = value; }
        }

        public int defensa
        {
            get { return Defensa; }
            set { Defensa = value; }
        }

        public int identificador
        {
            get { return Identificador; }
            set { Identificador = value; }
        }

        public int gema
        {
            get { return Gema; }
            set { Gema = value; }
        }

        public int limitegema
        {
            get { return LimiteGema; }
            set { LimiteGema = value; }
        }

        public string nombrejugador
        {
            get { return Nombrejugador; }
            set { Nombrejugador = value; }
        }

        public bool ganper
        {
            get { return GanPer; }
            set { GanPer = value; }
        }

        public bool habilidadusada
        {
            get { return HabilidadaUsada; }
            set { HabilidadaUsada = value; }
        }


        public int turno
        {
            get { return Turno; }
            set { Turno = value; }
        }

        public string nombreheroe
        {
            get { return Nombreheroe; }
            set { Nombreheroe = value; }
        }

        public string habilidadheroe
        {
            get { return Habilidadheroe; }
            set { Habilidadheroe = value; }
        }

        public void Agregarcartamazo(Carta carta)
        {
            Mazo.Add(carta);
        }

        public void Agregarcartamano(Consola consola)
            //este metodo agrega la carta a la mano y borra la carta en el mazo
        {
            if(Mano.Count == 10)
            {
                consola.Avisarmaxcartamano();
            }
            else
            {
                Mano.Add(Mazo.ElementAt(0));
                Mazo.RemoveAt(0);                 
            }
        }
        //esta funcion pone la carta en el tablerodeljugador y elimina la carta de la mano
        public void Agregarcartalado(Jugador jugador, Consola consola)
        {
            if(Tablerojugador.Count == 7)
            {
                consola.Avisarmaxcartatablero();
                // fin accion

            }
            else
            {
                int indice = consola.EleccionBajarCarta(jugador);
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
                                hechizo.HabilidadMoneda(jugador, consola);
                                jugador.gema = jugador.gema - Mano.ElementAt(indice).costo;
                                Mano.RemoveAt(indice);
                            }
                            else
                            {
                                consola.AvisarMaxGema();
                            }
                        
                        }
                    }
                }
                else
                {
                    consola.Avisaraccioninvalida();
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

        public void Enfrentar(Jugador jugador1, Jugador jugador2, Consola consola)
        {
            //Si ataca al jugador
            
            int indice1 = consola.EleccionAtacante(jugador1);
            if (jugador1.Tablerojugador[indice1].despierto == true)
            {
                if (jugador1.Tablerojugador[indice1].ataco == false)
                {
                    string eleccion = consola.EleccionObjetivo();
                    if (eleccion == "1")
                    {
                        if (jugador2.defensa <= 0)
                        {
                            jugador2.vida -= jugador1.Tablerojugador[indice1].ataque;
                            if (jugador2.vida <= 0)
                            {
                                jugador2.ganper = true;
                                consola.AvisoFindePartida(jugador1);
                            }
                        }
                        else
                        {
                            jugador2.defensa -= jugador1.Tablerojugador[indice1].ataque;
                            if (jugador2.defensa <= 0)
                            {
                                jugador2.vida += jugador2.defensa;
                                jugador2.defensa = 0;
                                if (jugador2.vida <= 0)
                                {
                                    jugador2.ganper = true;
                                    consola.AvisoFindePartida(jugador1);
                                }
                            }
                        }
                        jugador1.Tablerojugador[indice1].ataco = true;
                    }
                    //si ataca a un esbirro oponente
                    else
                    {
                        if (jugador2.Tablerojugador.Count == 0)
                        {
                            consola.AvisarNoAtaqueEsbirro();
                        }
                        else
                        {
                            int indice2 = consola.EleccionEsbirroObjetivo(jugador2);
                            jugador2.Tablerojugador[indice2].defensa -= jugador1.Tablerojugador[indice1].ataque;
                            jugador1.Tablerojugador[indice1].defensa -= jugador2.Tablerojugador[indice2].ataque;
                            jugador1.Tablerojugador[indice1].ataco = true;
                            jugador1.Morir(jugador1, indice1);
                            jugador2.Morir(jugador2, indice2);
                        }
                        
                    }
                    
                }
                else
                {
                    consola.AvisoEsbirroAtaco();
                }
            }
            else
            {
                consola.EsbirroDormido();
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

        public void HabilidadHeroe(Jugador jugador1, Jugador jugador2, Consola consola)
        {
            if (jugador1.habilidadheroe == "ataque" && jugador1.habilidadusada == false)
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                if (jugador2.defensa <= 0)
                {
                    jugador2.vida -= 2;
                    if (jugador2.vida <= 0)
                    {
                        jugador2.ganper = true;
                        consola.AvisoFindePartida(jugador1);
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
                            consola.AvisoFindePartida(jugador1);
                        }
                    }
                }
            }
            else if(jugador1.habilidadheroe != "ataque" && jugador1.habilidadusada == false)
            {
                jugador1.habilidadusada = true;
                jugador1.gema = jugador1.gema - 2;
                jugador1.defensa += 2;
            }
            else
            {
                consola.AvisoHabilidadUsada();
            }
        }

        public void Rendirse(Jugador jugador1, Jugador jugador2, Consola consola)
        {
            jugador1.ganper = true;
            consola.AvisoRendirse(jugador1, jugador2);
        }

        public void Jugar(Jugador jugador1, Jugador jugador2, Consola consola)
        {
            consola.NuevoTurno(jugador1);
            jugador1.Agregarcartamano(consola);
            jugador1.Aumentargema();
            jugador1.Regenerargema();
            jugador1.habilidadusada = false;
            jugador1.Despertar(jugador1);
            
            consola.Imprimirvida(jugador1, jugador2);
            consola.ImprimirDefensa(jugador1, jugador2);
            consola.ImprimirGema(jugador1, jugador2);
            consola.ImprimirMano(jugador1);
            consola.ImprimirEsbirros(jugador1);
            consola.ImprimirEsbirros(jugador2);
            int eleccion = consola.Avisareleccion();
            while (eleccion != 5 && jugador1.ganper == false && jugador2.ganper == false)
            {
                if (eleccion == 1)
                {
                    jugador1.Agregarcartalado(jugador1, consola);
                    consola.Imprimirvida(jugador1, jugador2);
                    consola.ImprimirDefensa(jugador1, jugador2);
                    consola.ImprimirGema(jugador1, jugador2);
                    consola.ImprimirMano(jugador1);
                    consola.ImprimirEsbirros(jugador1);
                    consola.ImprimirEsbirros(jugador2);
                    eleccion = consola.Avisareleccion();
                }
                else if (eleccion == 2)
                {
                    jugador1.Enfrentar(jugador1, jugador2, consola);
                    if (jugador2.vida>0)
                    {
                        consola.Imprimirvida(jugador1, jugador2);
                        consola.ImprimirDefensa(jugador1, jugador2);
                        consola.ImprimirGema(jugador1, jugador2);
                        consola.ImprimirMano(jugador1);
                        consola.ImprimirEsbirros(jugador1);
                        consola.ImprimirEsbirros(jugador2);
                        eleccion = consola.Avisareleccion();
                    }
                }
                else if (eleccion == 3)
                {
                    if (jugador1.gema >= 2)
                    {
                        jugador1.HabilidadHeroe(jugador1, jugador2, consola);
                        if (jugador2.vida > 0)
                        {
                            consola.Imprimirvida(jugador1, jugador2);
                            consola.ImprimirDefensa(jugador1, jugador2);
                            consola.ImprimirGema(jugador1, jugador2);
                            consola.ImprimirMano(jugador1);
                            consola.ImprimirEsbirros(jugador1);
                            consola.ImprimirEsbirros(jugador2);
                            eleccion = consola.Avisareleccion();
                        }
                    }
                    else
                    {
                        consola.Avisaraccioninvalida();
                        consola.Imprimirvida(jugador1, jugador2);
                        consola.ImprimirDefensa(jugador1, jugador2);
                        consola.ImprimirGema(jugador1, jugador2);
                        consola.ImprimirMano(jugador1);
                        consola.ImprimirEsbirros(jugador1);
                        consola.ImprimirEsbirros(jugador2);
                        eleccion = consola.Avisareleccion();
                    }

                }
                else if (eleccion == 4)
                {
                    jugador1.Rendirse(jugador1, jugador2, consola);
                }
              //finalizar el turno
            }
        }

        public void CambioMano(Jugador jugador, Consola consola, Random rnd)
        {
            int count = 0;
            int cambiarcarta;
            int cartacambiar;
            cambiarcarta = consola.CambiarMano(jugador);

            while (count <= 2 && cambiarcarta != 2)
            {
                cartacambiar = consola.AvisarCambioMano(jugador);
                jugador.Agregarcartamazo(jugador.Mano[cartacambiar]);
                jugador.Mano.RemoveAt(cartacambiar);
                count++;
                if (count <= 2)
                {
                    cambiarcarta = consola.CambiarMano(jugador);
                }
                
            }
            jugador.Shuffle(rnd);
            while (count >0)
            {
                jugador.Agregarcartamano(consola);
                count--;
            }

            consola.ImprimirMano(jugador);
        }
    }
}