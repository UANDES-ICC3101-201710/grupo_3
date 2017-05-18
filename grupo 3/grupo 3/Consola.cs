using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Hearthstone
{
    public class Consola
    {
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido a Hearthstone\r\n");
        }

        public string Nombrejugador(Jugador jugador)
        {
            string nombre;

            if(jugador.identificador==1)
            {
                Console.WriteLine("Ingrese el nombre del primer jugador");
                nombre = Console.ReadLine();
                return nombre;
            }
            else
            {
                Console.WriteLine("\r\nIngrese el nombre del segundo jugador");
                nombre = Console.ReadLine();
                return nombre;
            }
        }
        public int ElegirHeroe(Jugador jugador)
        {
            string nombre;
            Console.WriteLine("\r\n" + jugador.nombrejugador + ": Eliga Heroe (Ingrese el numero de Heroe)");
            Console.WriteLine("1) Warrior");
            Console.WriteLine("2) Hunter");
            nombre = Console.ReadLine();
            int eleccion = Int32.Parse(nombre);
            while (eleccion != 1 && eleccion != 2)
            {
                Console.WriteLine("\r\n" + "Opcion invalida");
                Console.WriteLine("\r\n" + jugador.nombrejugador + ": Eliga Heroe (Ingrese el numero de Heroe)");
                Console.WriteLine("1) Warrior");
                Console.WriteLine("2) Hunter");
                nombre = Console.ReadLine();
                eleccion = Int32.Parse(nombre);
            }
            
            return eleccion;

        }

        public string Asignarhabilidad(Jugador jugador)
        {
            string nombre;
            if (jugador.nombreheroe == "Warrior")
            {
                Console.WriteLine("\r\n" + jugador.nombrejugador + " Elegiste Warrior, tu habilidad es tener +2 de armadura");
                nombre = "armadura";
                return nombre;
            }
            else
            {
                Console.WriteLine("\r\n" + jugador.nombrejugador + " Elegiste Hunter, tu habilidad es hacer 2 de daño al Heroe enemigo");
                nombre = "ataque";
                return nombre;
            }
        }

        public void Iniciopartida(Jugador jugador, int dice)
        {
            if (dice == jugador.turno)
            {
                Console.WriteLine("\r\n" + jugador.nombrejugador + " Juega el primer turno");
            }
            else
            {
                Console.WriteLine("\r\n" + jugador.nombrejugador + " Juega el segundo turno");
            }
        }

       
        public void Avisarmaxcartatablero()
        {
            Console.WriteLine("Ya tienes el maximo de esbirros en el tablero");
        }

        public void Avisarmaxcartamano()
        {
            Console.WriteLine("Ya tienes el maximo de cartas en la mano");
        }

        public int EleccionBajarCarta(Jugador jugador)
        {
            int count;
            count = jugador.Mano.Count();
            Console.WriteLine("\r\n" + "Elige que carta quieres usar (Ingrese la posicion de la carta)");
            string eleccion = Console.ReadLine();
            int eleccion2 = Int32.Parse(eleccion);
            while (eleccion2 < 0 || eleccion2 >= count)
            {
                Console.WriteLine("Opcion invalida");
                Console.WriteLine("Elige que carta quieres usar (Ingrese la posicion de la carta)");
                eleccion = Console.ReadLine();
                eleccion2 = Int32.Parse(eleccion);
            }
            return eleccion2;
        }

        public int Avisareleccion()
        {
            Console.WriteLine("\r\n" + "Elige una accion");
            Console.WriteLine("\r\n" + "1) Bajar Carta" + "\r\n" + "2) Atacar" + "\r\n" + 
                "3) Activar Habilidad Heroe"+"\r\n"+"4) Rendirse" + "\r\n" + "5) Terminar turno");
            string eleccion1 = Console.ReadLine();
            int eleccion2 = Int32.Parse(eleccion1);
            while (eleccion2 > 5 || eleccion2 < 1)
            {
                Console.WriteLine("Opcion Invalida");
                Console.WriteLine("\r\n" + "Elige una accion");
                Console.WriteLine("\r\n" + "1) Bajar Carta" + "\r\n" + "2) Atacar" + "\r\n" +
                    "3) Activar Habilidad Heroe" + "\r\n" + "4) Rendirse" + "\r\n" + "5) Pasar turno");
                 eleccion1 = Console.ReadLine();
                 eleccion2 = Int32.Parse(eleccion1);
            }
            return eleccion2;

        }

        public void Avisaraccioninvalida()
        {
            Console.WriteLine( "\r\n" + "No tienes suficientes gemas para esa Accion");
        }

        public int EleccionAtacante(Jugador jugador)
        {
            int count;
            count = jugador.Tablerojugador.Count();
            Console.WriteLine("Elige con que Esbirro quieres atacar (Ingrese la posicion de la carta)");
            string eleccion = Console.ReadLine();
            int eleccion1 = Int32.Parse(eleccion);
            while (eleccion1 < 0 || eleccion1 >= count)
            {
                Console.WriteLine("Opcion invalida");
                Console.WriteLine("Elige con que Esbirro quieres atacar (Ingrese la posicion de la carta)");
                eleccion = Console.ReadLine();
                eleccion1 = Int32.Parse(eleccion);

            }
            return eleccion1;
        }

        public string EleccionObjetivo()
        {
            Console.WriteLine("Elige a tu objetivo" + "\r\n" + "1) Heroe Oponente" + "\r\n" + "2) Esbirro Oponente");
            string eleccion = Console.ReadLine();
            while (eleccion != "1" && eleccion != "2")
            {
                Console.WriteLine("Opcion Invalida");
                Console.WriteLine("Elige a tu objetivo" + "\r\n" + "1) Heroe Oponente" + "\r\n" + "2) Esbirro Oponente");
                eleccion = Console.ReadLine();

            }
            return eleccion;
        }

        public int EleccionEsbirroObjetivo(Jugador jugador)
        {
            int count;
            count = jugador.Tablerojugador.Count();
            Console.WriteLine("\r\n" + "Elige a que Esbirro oponente quieres atacar (Ingrese la posicion de la carta)");
            string eleccion = Console.ReadLine();
            int eleccion1 = Int32.Parse(eleccion);
            while (eleccion1 < 0 || eleccion1 >= count)
            {
                Console.WriteLine("Opcion invalida");
                Console.WriteLine("Elige a que Esbirro oponente quieres atacar (Ingrese la posicion de la carta)");
                eleccion = Console.ReadLine();
                eleccion1 = Int32.Parse(eleccion);

            }
            return eleccion1;
        }

        public void EsbirroDormido()
        {
            Console.WriteLine("Ese Esbirro no puede atacar todavia");
        }

        public void AumentoGemaMoneda()
        {
            Console.WriteLine("Por este turno tienes una gema mas");
        }

        public void AvisoFindePartida(Jugador jugador)
        {
            Console.WriteLine("Fin de la Partida" + "\r\n" + "El ganador es: " + jugador.nombrejugador);
        }

        public void AvisoRendirse(Jugador jugador1, Jugador jugador2)
        {
            Console.WriteLine(jugador1.nombrejugador + " se rindio");
            Console.WriteLine("Fin de la Partida" + "\r\n" + "El ganador es: " + jugador2.nombrejugador);
        }

        public void Imprimirvida(Jugador jugador1, Jugador jugador2)
        {
            Console.WriteLine("\r\n" + "Vida " + jugador1.nombrejugador + ": " + jugador1.vida);
            Console.WriteLine("Vida " + jugador2.nombrejugador + ": " + jugador2.vida);
        }
        public void ImprimirGema(Jugador jugador1, Jugador jugador2)
        {
            Console.WriteLine("Gemas " + jugador1.nombrejugador + ": " + jugador1.gema);
            Console.WriteLine("Gemas " + jugador2.nombrejugador + ": " + jugador2.gema);
        }

        public void ImprimirDefensa(Jugador jugador1, Jugador jugador2)
        {
            Console.WriteLine("Defensa " + jugador1.nombrejugador + ": " + jugador1.defensa);
            Console.WriteLine("Defensa " + jugador2.nombrejugador + ": " + jugador2.defensa);
        }
        public void ImprimirMano(Jugador jugador)
        {
            Console.WriteLine("\r\n" + jugador.nombrejugador + " Cartas en tu mano: ");
            int count = 0;
            foreach (Carta carta in jugador.Mano)
            {
                Carta aux = carta;
                if (aux.GetType().Equals(typeof(Esbirro)))
                {
                    Esbirro esbirro = (Esbirro)aux;
                    
                    Console.WriteLine("\r\n" + count + ") Nombre: " + esbirro.nombre + " | Costo: " + esbirro.costo + " | Tipo: " + esbirro.tipo + " | Subtipo: " + esbirro.subtipo + " | Ataque: " + esbirro.ataque + " | Defensa: " + esbirro.defensa);
                }
                else
                {
                    
                    Console.WriteLine("\r\n" + count + ") Nombre: " + carta.nombre + " | Costo: " + carta.costo + " | Tipo: " + carta.tipo);

                }
                count++;
            }
        }

        public void ImprimirEsbirros(Jugador jugador)
        {
            Console.WriteLine("\r\n" + jugador.nombrejugador + " Esbirros en el tablero: ");
            int count = 0;
            foreach (Esbirro esbirro in jugador.Tablerojugador)
            {
                
                Console.WriteLine("\r\n" + count + ") Nombre: " + esbirro.nombre + " | Costo: " + esbirro.costo + " | Tipo: " + esbirro.tipo + " | Subtipo: " + esbirro.subtipo + " | Ataque: " + esbirro.ataque + " | Defensa: " + esbirro.defensa);
                if (esbirro.despierto == false)
                {
                    Console.WriteLine("Durmiendo");
                }
                else
                {
                    Console.WriteLine("Despierto");
                }
                count++;
            }
        }
        public void NuevoTurno(Jugador jugador)
        {
            Console.WriteLine("\r\n" + "NUEVO TURNO: JUEGA " + jugador.nombrejugador);
        }
        public void AvisoEsbirroAtaco()
        {
            Console.WriteLine("\r\n" + "Ese Esbirro ya ataco");
        }
        public void AvisoHabilidadUsada()
        {
            Console.WriteLine("\r\n" + "La habilidad ya fue usada");
        }
        public int AvisarCambioMano(Jugador jugador)
        { 
            Console.WriteLine("\r\n"+ jugador.nombrejugador + " :Puedes cambiar tu mano inicial (Ingrese la posicion de la carta que quiere cambiar)");
            ImprimirMano(jugador);
            int count = jugador.Mano.Count;
            string eleccion = Console.ReadLine();
            int eleccion1 = Int32.Parse(eleccion);
            

            while (eleccion1 < 0 || eleccion1 > count-1) 
            {
                Console.WriteLine("Opcion invalida");
                Console.WriteLine("\r\n" + jugador.nombrejugador + " :Puedes cambiar tu mano inicial (Ingrese la posicion de la carta que quiere cambiar)");
                ImprimirMano(jugador);
                eleccion = Console.ReadLine();
                eleccion1 = Int32.Parse(eleccion);
               
            }
            return eleccion1;
        }
        public int CambiarMano(Jugador jugador)
        {
            string aviso;
            ImprimirMano(jugador);
            Console.WriteLine("\r\n" + jugador.nombrejugador + " ¿Quieres cambiar tu mano?:");
            Console.WriteLine("1) Cambiar");
            Console.WriteLine("2) No cambiar");
            aviso = Console.ReadLine();
            int aviso1 = Int32.Parse(aviso);
            while(aviso1!=1 && aviso1!=2)
            {
                Console.WriteLine("Opcion invalida");
                ImprimirMano(jugador);
                Console.WriteLine("\r\n" + jugador.nombrejugador + " quieres cambiar tu mano:");
                Console.WriteLine("1) Cambiar");
                Console.WriteLine("2) No cambiar");
                aviso = Console.ReadLine();
                aviso1 = Int32.Parse(aviso);
            }
            return aviso1;
        }
        public void AvisarMaxGema()
        {
            Console.WriteLine("\r\n" + "Ya tienes el maximo de gema, no puedes usar The Coin");
        }
        public void AvisarNoAtaqueEsbirro()
        {
            Console.WriteLine("\r\n" + "Tu oponente no tiene Esbirros en el tablero");
        }
    }



  
}
