
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {


        Juego juego = new Juego();
        Random rnd = new Random();
        string CTJ1 = "";
        string CTJ2 = "";
        int IJ1;
        int IJ2;
        int DAJ1;
        int DAJ2;
        int ataquearmaJ1 = 0;
        int ataquearmaJ2 = 0;
        int armausadaJ1 = 0;
        int armausadaJ2 = 0;
        int HabPriestJ1 = 0;
        int HabPriestJ2 = 0;
        int HabDruidMageJ1 = 0;
        int HabDruidMageJ2 = 0;
        int eleccion = 0;

        public MainWindow()
        {


            InitializeComponent();

        }

        public void IniciarJuego()
        {
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();


            //Datos esbirros

            Esbirro Wisp = new Esbirro();
            Wisp.nombre = "Wisp";
            Wisp.costo = 0;
            Wisp.ataque = 1;
            Wisp.defensa = 1;
            Wisp.maxdefensa = 1;
            Wisp.tipo = "Esbirro";
            Wisp.subtipo = null;
            Wisp.despierto = false;
            Wisp.ataco = false;


            Esbirro MurlocRaider = new Esbirro();

            MurlocRaider.nombre = "Murloc Raider";
            MurlocRaider.costo = 1;
            MurlocRaider.ataque = 2;
            MurlocRaider.defensa = 1;
            MurlocRaider.maxdefensa = 1;
            MurlocRaider.tipo = "Esbirro";
            MurlocRaider.subtipo = "Murloc";
            MurlocRaider.despierto = false;
            MurlocRaider.ataco = false;


            Esbirro BloodfenRaptor = new Esbirro();

            BloodfenRaptor.nombre = "Bloodfen Raptor";
            BloodfenRaptor.costo = 2;
            BloodfenRaptor.ataque = 3;
            BloodfenRaptor.defensa = 2;
            BloodfenRaptor.maxdefensa = 2;
            BloodfenRaptor.tipo = "Esbirro";
            BloodfenRaptor.subtipo = "Bestia";
            BloodfenRaptor.despierto = false;
            BloodfenRaptor.ataco = false;

            Esbirro RiverCrocolisk = new Esbirro();

            RiverCrocolisk.nombre = "River Crocolisk";
            RiverCrocolisk.costo = 2;
            RiverCrocolisk.ataque = 2;
            RiverCrocolisk.defensa = 3;
            RiverCrocolisk.maxdefensa = 3;
            RiverCrocolisk.tipo = "Esbirro";
            RiverCrocolisk.subtipo = "Bestia";
            RiverCrocolisk.despierto = false;
            RiverCrocolisk.ataco = false;

            Esbirro MagmaRager = new Esbirro();

            MagmaRager.nombre = "Magma Rager";
            MagmaRager.costo = 3;
            MagmaRager.ataque = 5;
            MagmaRager.defensa = 1;
            MagmaRager.maxdefensa = 1;
            MagmaRager.tipo = "Esbirro";
            MagmaRager.subtipo = "Elemental";
            MagmaRager.despierto = false;
            MagmaRager.ataco = false;

            Esbirro ChillwindYeti = new Esbirro();

            ChillwindYeti.nombre = "Chillwind Yeti";
            ChillwindYeti.costo = 4;
            ChillwindYeti.ataque = 4;
            ChillwindYeti.defensa = 5;
            ChillwindYeti.maxdefensa = 5;
            ChillwindYeti.tipo = "Esbirro";
            ChillwindYeti.subtipo = null;
            ChillwindYeti.despierto = false;
            ChillwindYeti.ataco = false;

            Esbirro OasisSnapjaw = new Esbirro();

            OasisSnapjaw.nombre = "Oasis Snapjaw";
            OasisSnapjaw.costo = 4;
            OasisSnapjaw.ataque = 2;
            OasisSnapjaw.defensa = 7;
            OasisSnapjaw.maxdefensa = 7;
            OasisSnapjaw.tipo = "Esbirro";
            OasisSnapjaw.subtipo = "Bestia";
            OasisSnapjaw.despierto = false;
            OasisSnapjaw.ataco = false;

            Esbirro BoulderfistOgre = new Esbirro();

            BoulderfistOgre.nombre = "Boulderfist Ogre";
            BoulderfistOgre.costo = 6;
            BoulderfistOgre.ataque = 6;
            BoulderfistOgre.defensa = 7;
            BoulderfistOgre.maxdefensa = 7;
            BoulderfistOgre.tipo = "Esbirro";
            BoulderfistOgre.subtipo = null;
            BoulderfistOgre.despierto = false;
            BoulderfistOgre.ataco = false;

            Esbirro WarGolem = new Esbirro();

            WarGolem.nombre = "War Golem";
            WarGolem.costo = 7;
            WarGolem.ataque = 7;
            WarGolem.defensa = 7;
            WarGolem.maxdefensa = 7;
            WarGolem.tipo = "Esbirro";
            WarGolem.subtipo = null;
            WarGolem.despierto = false;
            WarGolem.ataco = false;

            Esbirro CoreHound = new Esbirro();

            CoreHound.nombre = "Core Hound";
            CoreHound.costo = 7;
            CoreHound.ataque = 9;
            CoreHound.defensa = 5;
            CoreHound.maxdefensa = 5;
            CoreHound.tipo = "Esbirro";
            CoreHound.subtipo = "Bestia";
            CoreHound.despierto = false;
            CoreHound.ataco = false;

            Esbirro Wisp2 = new Esbirro();

            Wisp2.nombre = "Wisp";
            Wisp2.costo = 0;
            Wisp2.ataque = 1;
            Wisp2.defensa = 1;
            Wisp2.maxdefensa = 1;
            Wisp2.tipo = "Esbirro";
            Wisp2.subtipo = null;
            Wisp2.despierto = false;
            Wisp2.ataco = false;


            Esbirro MurlocRaider2 = new Esbirro();

            MurlocRaider2.nombre = "Murloc Raider";
            MurlocRaider2.costo = 1;
            MurlocRaider2.ataque = 2;
            MurlocRaider2.defensa = 1;
            MurlocRaider2.maxdefensa = 1;
            MurlocRaider2.tipo = "Esbirro";
            MurlocRaider2.subtipo = "Murloc";
            MurlocRaider2.despierto = false;
            MurlocRaider2.ataco = false;


            Esbirro BloodfenRaptor2 = new Esbirro();

            BloodfenRaptor2.nombre = "Bloodfen Raptor";
            BloodfenRaptor2.costo = 2;
            BloodfenRaptor2.ataque = 3;
            BloodfenRaptor2.defensa = 2;
            BloodfenRaptor2.maxdefensa = 2;
            BloodfenRaptor2.tipo = "Esbirro";
            BloodfenRaptor2.subtipo = "Bestia";
            BloodfenRaptor2.despierto = false;
            BloodfenRaptor2.ataco = false;

            Esbirro RiverCrocolisk2 = new Esbirro();

            RiverCrocolisk2.nombre = "River Crocolisk";
            RiverCrocolisk2.costo = 2;
            RiverCrocolisk2.ataque = 2;
            RiverCrocolisk2.defensa = 3;
            RiverCrocolisk2.maxdefensa = 3;
            RiverCrocolisk2.tipo = "Esbirro";
            RiverCrocolisk2.subtipo = "Bestia";
            RiverCrocolisk2.despierto = false;
            RiverCrocolisk2.ataco = false;

            Esbirro MagmaRager2 = new Esbirro();

            MagmaRager2.nombre = "Magma Rager";
            MagmaRager2.costo = 3;
            MagmaRager2.ataque = 5;
            MagmaRager2.defensa = 1;
            MagmaRager2.maxdefensa = 1;
            MagmaRager2.tipo = "Esbirro";
            MagmaRager2.subtipo = "Elemental";
            MagmaRager2.despierto = false;
            MagmaRager2.ataco = false;

            Esbirro ChillwindYeti2 = new Esbirro();

            ChillwindYeti2.nombre = "Chillwind Yeti";
            ChillwindYeti2.costo = 4;
            ChillwindYeti2.ataque = 4;
            ChillwindYeti2.defensa = 5;
            ChillwindYeti2.tipo = "Esbirro";
            ChillwindYeti2.maxdefensa = 5;
            ChillwindYeti2.subtipo = null;
            ChillwindYeti2.despierto = false;
            ChillwindYeti2.ataco = false;

            Esbirro OasisSnapjaw2 = new Esbirro();

            OasisSnapjaw2.nombre = "Oasis Snapjaw";
            OasisSnapjaw2.costo = 4;
            OasisSnapjaw2.ataque = 2;
            OasisSnapjaw2.defensa = 7;
            OasisSnapjaw2.maxdefensa = 7;
            OasisSnapjaw2.tipo = "Esbirro";
            OasisSnapjaw2.subtipo = "Bestia";
            OasisSnapjaw2.despierto = false;
            OasisSnapjaw2.ataco = false;

            Esbirro BoulderfistOgre2 = new Esbirro();

            BoulderfistOgre2.nombre = "Boulderfist Ogre";
            BoulderfistOgre2.costo = 6;
            BoulderfistOgre2.ataque = 6;
            BoulderfistOgre2.defensa = 7;
            BoulderfistOgre2.maxdefensa = 7;
            BoulderfistOgre2.tipo = "Esbirro";
            BoulderfistOgre2.subtipo = null;
            BoulderfistOgre2.despierto = false;
            BoulderfistOgre2.ataco = false;

            Esbirro WarGolem2 = new Esbirro();

            WarGolem2.nombre = "War Golem";
            WarGolem2.costo = 7;
            WarGolem2.ataque = 7;
            WarGolem2.defensa = 7;
            WarGolem2.maxdefensa = 7;
            WarGolem2.tipo = "Esbirro";
            WarGolem2.subtipo = null;
            WarGolem2.despierto = false;
            WarGolem2.ataco = false;

            Esbirro CoreHound2 = new Esbirro();

            CoreHound2.nombre = "Core Hound";
            CoreHound2.costo = 7;
            CoreHound2.ataque = 9;
            CoreHound2.defensa = 5;
            CoreHound2.maxdefensa = 5;
            CoreHound2.tipo = "Esbirro";
            CoreHound2.subtipo = "Bestia";
            CoreHound2.despierto = false;
            CoreHound2.ataco = false;

            Esbirro Wisp3 = new Esbirro();

            Wisp3.nombre = "Wisp";
            Wisp3.costo = 0;
            Wisp3.ataque = 1;
            Wisp3.defensa = 1;
            Wisp3.maxdefensa = 1;
            Wisp3.tipo = "Esbirro";
            Wisp3.subtipo = null;
            Wisp3.despierto = false;
            Wisp3.ataco = false;


            Esbirro MurlocRaider3 = new Esbirro();

            MurlocRaider3.nombre = "Murloc Raider";
            MurlocRaider3.costo = 1;
            MurlocRaider3.ataque = 2;
            MurlocRaider3.defensa = 1;
            MurlocRaider3.maxdefensa = 1;
            MurlocRaider3.tipo = "Esbirro";
            MurlocRaider3.subtipo = "Murloc";
            MurlocRaider3.despierto = false;
            MurlocRaider3.ataco = false;


            Esbirro BloodfenRaptor3 = new Esbirro();

            BloodfenRaptor3.nombre = "Bloodfen Raptor";
            BloodfenRaptor3.costo = 2;
            BloodfenRaptor3.ataque = 3;
            BloodfenRaptor3.defensa = 2;
            BloodfenRaptor3.maxdefensa = 2;
            BloodfenRaptor3.tipo = "Esbirro";
            BloodfenRaptor3.subtipo = "Bestia";
            BloodfenRaptor3.despierto = false;
            BloodfenRaptor3.ataco = false;

            Esbirro RiverCrocolisk3 = new Esbirro();

            RiverCrocolisk3.nombre = "River Crocolisk";
            RiverCrocolisk3.costo = 2;
            RiverCrocolisk3.ataque = 2;
            RiverCrocolisk3.defensa = 3;
            RiverCrocolisk3.maxdefensa = 3;
            RiverCrocolisk3.tipo = "Esbirro";
            RiverCrocolisk3.subtipo = "Bestia";
            RiverCrocolisk3.despierto = false;
            RiverCrocolisk3.ataco = false;

            Esbirro MagmaRager3 = new Esbirro();

            MagmaRager3.nombre = "Magma Rager";
            MagmaRager3.costo = 3;
            MagmaRager3.ataque = 5;
            MagmaRager3.defensa = 1;
            MagmaRager3.maxdefensa = 1;
            MagmaRager3.tipo = "Esbirro";
            MagmaRager3.subtipo = "Elemental";
            MagmaRager3.despierto = false;
            MagmaRager3.ataco = false;

            Esbirro ChillwindYeti3 = new Esbirro();

            ChillwindYeti3.nombre = "Chillwind Yeti";
            ChillwindYeti3.costo = 4;
            ChillwindYeti3.ataque = 4;
            ChillwindYeti3.defensa = 5;
            ChillwindYeti3.maxdefensa = 5;
            ChillwindYeti3.tipo = "Esbirro";
            ChillwindYeti3.subtipo = null;
            ChillwindYeti3.despierto = false;
            ChillwindYeti3.ataco = false;

            Esbirro OasisSnapjaw3 = new Esbirro();

            OasisSnapjaw3.nombre = "Oasis Snapjaw";
            OasisSnapjaw3.costo = 4;
            OasisSnapjaw3.ataque = 2;
            OasisSnapjaw3.defensa = 7;
            OasisSnapjaw3.maxdefensa = 7;
            OasisSnapjaw3.tipo = "Esbirro";
            OasisSnapjaw3.subtipo = "Bestia";
            OasisSnapjaw3.despierto = false;
            OasisSnapjaw3.ataco = false;

            Esbirro BoulderfistOgre3 = new Esbirro();

            BoulderfistOgre3.nombre = "Boulderfist Ogre";
            BoulderfistOgre3.costo = 6;
            BoulderfistOgre3.ataque = 6;
            BoulderfistOgre3.defensa = 7;
            BoulderfistOgre3.maxdefensa = 7;
            BoulderfistOgre3.tipo = "Esbirro";
            BoulderfistOgre3.subtipo = null;
            BoulderfistOgre3.despierto = false;
            BoulderfistOgre3.ataco = false;

            Esbirro WarGolem3 = new Esbirro();

            WarGolem3.nombre = "War Golem";
            WarGolem3.costo = 7;
            WarGolem3.ataque = 7;
            WarGolem3.defensa = 7;
            WarGolem3.maxdefensa = 7;
            WarGolem3.tipo = "Esbirro";
            WarGolem3.subtipo = null;
            WarGolem3.despierto = false;
            WarGolem3.ataco = false;

            Esbirro CoreHound3 = new Esbirro();

            CoreHound3.nombre = "Core Hound";
            CoreHound3.costo = 7;
            CoreHound3.ataque = 9;
            CoreHound3.defensa = 5;
            CoreHound3.maxdefensa = 5;
            CoreHound3.tipo = "Esbirro";
            CoreHound3.subtipo = "Bestia";
            CoreHound3.despierto = false;
            CoreHound3.ataco = false;

            Esbirro Wisp4 = new Esbirro();

            Wisp4.nombre = "Wisp";
            Wisp4.costo = 0;
            Wisp4.ataque = 1;
            Wisp4.defensa = 1;
            Wisp4.maxdefensa = 1;
            Wisp4.tipo = "Esbirro";
            Wisp4.subtipo = null;
            Wisp4.despierto = false;
            Wisp4.ataco = false;


            Esbirro MurlocRaider4 = new Esbirro();

            MurlocRaider4.nombre = "Murloc Raider";
            MurlocRaider4.costo = 1;
            MurlocRaider4.ataque = 2;
            MurlocRaider4.defensa = 1;
            MurlocRaider4.maxdefensa = 1;
            MurlocRaider4.tipo = "Esbirro";
            MurlocRaider4.subtipo = "Murloc";
            MurlocRaider4.despierto = false;
            MurlocRaider4.ataco = false;


            Esbirro BloodfenRaptor4 = new Esbirro();

            BloodfenRaptor4.nombre = "Bloodfen Raptor";
            BloodfenRaptor4.costo = 2;
            BloodfenRaptor4.ataque = 3;
            BloodfenRaptor4.defensa = 2;
            BloodfenRaptor4.maxdefensa = 2;
            BloodfenRaptor4.tipo = "Esbirro";
            BloodfenRaptor4.subtipo = "Bestia";
            BloodfenRaptor4.despierto = false;
            BloodfenRaptor4.ataco = false;

            Esbirro RiverCrocolisk4 = new Esbirro();

            RiverCrocolisk4.nombre = "River Crocolisk";
            RiverCrocolisk4.costo = 2;
            RiverCrocolisk4.ataque = 2;
            RiverCrocolisk4.defensa = 3;
            RiverCrocolisk4.maxdefensa = 3;
            RiverCrocolisk4.tipo = "Esbirro";
            RiverCrocolisk4.subtipo = "Bestia";
            RiverCrocolisk4.despierto = false;
            RiverCrocolisk4.ataco = false;

            Esbirro MagmaRager4 = new Esbirro();

            MagmaRager4.nombre = "Magma Rager";
            MagmaRager4.costo = 3;
            MagmaRager4.ataque = 5;
            MagmaRager4.defensa = 1;
            MagmaRager4.maxdefensa = 1;
            MagmaRager4.tipo = "Esbirro";
            MagmaRager4.subtipo = "Elemental";
            MagmaRager4.despierto = false;
            MagmaRager4.ataco = false;

            Esbirro ChillwindYeti4 = new Esbirro();

            ChillwindYeti4.nombre = "Chillwind Yeti";
            ChillwindYeti4.costo = 4;
            ChillwindYeti4.ataque = 4;
            ChillwindYeti4.defensa = 5;
            ChillwindYeti4.maxdefensa = 5;
            ChillwindYeti4.tipo = "Esbirro";
            ChillwindYeti4.subtipo = null;
            ChillwindYeti4.despierto = false;
            ChillwindYeti4.ataco = false;

            Esbirro OasisSnapjaw4 = new Esbirro();

            OasisSnapjaw4.nombre = "Oasis Snapjaw";
            OasisSnapjaw4.costo = 4;
            OasisSnapjaw4.ataque = 2;
            OasisSnapjaw4.defensa = 7;
            OasisSnapjaw4.maxdefensa = 7;
            OasisSnapjaw4.tipo = "Esbirro";
            OasisSnapjaw4.subtipo = "Bestia";
            OasisSnapjaw4.despierto = false;
            OasisSnapjaw4.ataco = false;

            Esbirro BoulderfistOgre4 = new Esbirro();

            BoulderfistOgre4.nombre = "Boulderfist Ogre";
            BoulderfistOgre4.costo = 6;
            BoulderfistOgre4.ataque = 6;
            BoulderfistOgre4.defensa = 7;
            BoulderfistOgre4.maxdefensa = 7;
            BoulderfistOgre4.tipo = "Esbirro";
            BoulderfistOgre4.subtipo = null;
            BoulderfistOgre4.despierto = false;
            BoulderfistOgre4.ataco = false;

            Esbirro WarGolem4 = new Esbirro();

            WarGolem4.nombre = "War Golem";
            WarGolem4.costo = 7;
            WarGolem4.ataque = 7;
            WarGolem4.defensa = 7;
            WarGolem4.maxdefensa = 7;
            WarGolem4.tipo = "Esbirro";
            WarGolem4.subtipo = null;
            WarGolem4.despierto = false;
            WarGolem4.ataco = false;

            Esbirro CoreHound4 = new Esbirro();

            CoreHound4.nombre = "Core Hound";
            CoreHound4.costo = 7;
            CoreHound4.ataque = 9;
            CoreHound4.defensa = 5;
            CoreHound4.maxdefensa = 5;
            CoreHound4.tipo = "Esbirro";
            CoreHound4.subtipo = "Bestia";
            CoreHound4.despierto = false;
            CoreHound4.ataco = false;

            Esbirro Wisp5 = new Esbirro();

            Wisp5.nombre = "Wisp";
            Wisp5.costo = 0;
            Wisp5.ataque = 1;
            Wisp5.defensa = 1;
            Wisp5.maxdefensa = 1;
            Wisp5.tipo = "Esbirro";
            Wisp5.subtipo = null;
            Wisp5.despierto = false;
            Wisp5.ataco = false;


            Esbirro MurlocRaider5 = new Esbirro();

            MurlocRaider5.nombre = "Murloc Raider";
            MurlocRaider5.costo = 1;
            MurlocRaider5.ataque = 2;
            MurlocRaider5.defensa = 1;
            MurlocRaider5.maxdefensa = 1;
            MurlocRaider5.tipo = "Esbirro";
            MurlocRaider5.subtipo = "Murloc";
            MurlocRaider5.despierto = false;
            MurlocRaider5.ataco = false;


            Esbirro BloodfenRaptor5 = new Esbirro();

            BloodfenRaptor5.nombre = "Bloodfen Raptor";
            BloodfenRaptor5.costo = 2;
            BloodfenRaptor5.ataque = 3;
            BloodfenRaptor5.defensa = 2;
            BloodfenRaptor5.maxdefensa = 2;
            BloodfenRaptor5.tipo = "Esbirro";
            BloodfenRaptor5.subtipo = "Bestia";
            BloodfenRaptor5.despierto = false;
            BloodfenRaptor5.ataco = false;

            Esbirro RiverCrocolisk5 = new Esbirro();

            RiverCrocolisk5.nombre = "River Crocolisk";
            RiverCrocolisk5.costo = 2;
            RiverCrocolisk5.ataque = 2;
            RiverCrocolisk5.defensa = 3;
            RiverCrocolisk5.maxdefensa = 3;
            RiverCrocolisk5.tipo = "Esbirro";
            RiverCrocolisk5.subtipo = "Bestia";
            RiverCrocolisk5.despierto = false;
            RiverCrocolisk5.ataco = false;

            Esbirro MagmaRager5 = new Esbirro();

            MagmaRager5.nombre = "Magma Rager";
            MagmaRager5.costo = 3;
            MagmaRager5.ataque = 5;
            MagmaRager5.defensa = 1;
            MagmaRager5.maxdefensa = 1;
            MagmaRager5.tipo = "Esbirro";
            MagmaRager5.subtipo = "Elemental";
            MagmaRager5.despierto = false;
            MagmaRager5.ataco = false;

            Esbirro ChillwindYeti5 = new Esbirro();

            ChillwindYeti5.nombre = "Chillwind Yeti";
            ChillwindYeti5.costo = 4;
            ChillwindYeti5.ataque = 4;
            ChillwindYeti5.defensa = 5;
            ChillwindYeti5.maxdefensa = 5;
            ChillwindYeti5.tipo = "Esbirro";
            ChillwindYeti5.subtipo = null;
            ChillwindYeti5.despierto = false;
            ChillwindYeti5.ataco = false;

            Esbirro OasisSnapjaw5 = new Esbirro();

            OasisSnapjaw5.nombre = "Oasis Snapjaw";
            OasisSnapjaw5.costo = 4;
            OasisSnapjaw5.ataque = 2;
            OasisSnapjaw5.defensa = 7;
            OasisSnapjaw5.maxdefensa = 7;
            OasisSnapjaw5.tipo = "Esbirro";
            OasisSnapjaw5.subtipo = "Bestia";
            OasisSnapjaw5.despierto = false;
            OasisSnapjaw5.ataco = false;

            Esbirro BoulderfistOgre5 = new Esbirro();

            BoulderfistOgre5.nombre = "Boulderfist Ogre";
            BoulderfistOgre5.costo = 6;
            BoulderfistOgre5.ataque = 6;
            BoulderfistOgre5.defensa = 7;
            BoulderfistOgre5.maxdefensa = 7;
            BoulderfistOgre5.tipo = "Esbirro";
            BoulderfistOgre5.subtipo = null;
            BoulderfistOgre5.despierto = false;
            BoulderfistOgre5.ataco = false;

            Esbirro WarGolem5 = new Esbirro();

            WarGolem5.nombre = "War Golem";
            WarGolem5.costo = 7;
            WarGolem5.ataque = 7;
            WarGolem5.defensa = 7;
            WarGolem5.maxdefensa = 7;
            WarGolem5.tipo = "Esbirro";
            WarGolem5.subtipo = null;
            WarGolem5.despierto = false;
            WarGolem5.ataco = false;

            Esbirro CoreHound5 = new Esbirro();

            CoreHound5.nombre = "Core Hound";
            CoreHound5.costo = 7;
            CoreHound5.ataque = 9;
            CoreHound5.defensa = 5;
            CoreHound5.maxdefensa = 5;
            CoreHound5.tipo = "Esbirro";
            CoreHound5.subtipo = "Bestia";
            CoreHound5.despierto = false;
            CoreHound5.ataco = false;

            Esbirro Wisp6 = new Esbirro();

            Wisp6.nombre = "Wisp";
            Wisp6.costo = 0;
            Wisp6.ataque = 1;
            Wisp6.defensa = 1;
            Wisp6.maxdefensa = 1;
            Wisp6.tipo = "Esbirro";
            Wisp6.subtipo = null;
            Wisp6.despierto = false;
            Wisp6.ataco = false;


            Esbirro MurlocRaider6 = new Esbirro();

            MurlocRaider6.nombre = "Murloc Raider";
            MurlocRaider6.costo = 1;
            MurlocRaider6.ataque = 2;
            MurlocRaider6.defensa = 1;
            MurlocRaider6.maxdefensa = 1;
            MurlocRaider6.tipo = "Esbirro";
            MurlocRaider6.subtipo = "Murloc";
            MurlocRaider6.despierto = false;
            MurlocRaider6.ataco = false;


            Esbirro BloodfenRaptor6 = new Esbirro();

            BloodfenRaptor6.nombre = "Bloodfen Raptor";
            BloodfenRaptor6.costo = 2;
            BloodfenRaptor6.ataque = 3;
            BloodfenRaptor6.defensa = 2;
            BloodfenRaptor6.maxdefensa = 2;
            BloodfenRaptor6.tipo = "Esbirro";
            BloodfenRaptor6.subtipo = "Bestia";
            BloodfenRaptor6.despierto = false;
            BloodfenRaptor6.ataco = false;

            Esbirro RiverCrocolisk6 = new Esbirro();

            RiverCrocolisk6.nombre = "River Crocolisk";
            RiverCrocolisk6.costo = 2;
            RiverCrocolisk6.ataque = 2;
            RiverCrocolisk6.defensa = 3;
            RiverCrocolisk6.maxdefensa = 3;
            RiverCrocolisk6.tipo = "Esbirro";
            RiverCrocolisk6.subtipo = "Bestia";
            RiverCrocolisk6.despierto = false;
            RiverCrocolisk6.ataco = false;

            Esbirro MagmaRager6 = new Esbirro();

            MagmaRager6.nombre = "Magma Rager";
            MagmaRager6.costo = 3;
            MagmaRager6.ataque = 5;
            MagmaRager6.defensa = 1;
            MagmaRager6.maxdefensa = 1;
            MagmaRager6.tipo = "Esbirro";
            MagmaRager6.subtipo = "Elemental";
            MagmaRager6.despierto = false;
            MagmaRager6.ataco = false;

            Esbirro ChillwindYeti6 = new Esbirro();

            ChillwindYeti6.nombre = "Chillwind Yeti";
            ChillwindYeti6.costo = 4;
            ChillwindYeti6.ataque = 4;
            ChillwindYeti6.defensa = 5;
            ChillwindYeti6.maxdefensa = 5;
            ChillwindYeti6.tipo = "Esbirro";
            ChillwindYeti6.subtipo = null;
            ChillwindYeti6.despierto = false;
            ChillwindYeti6.ataco = false;

            Esbirro OasisSnapjaw6 = new Esbirro();

            OasisSnapjaw6.nombre = "Oasis Snapjaw";
            OasisSnapjaw6.costo = 4;
            OasisSnapjaw6.ataque = 2;
            OasisSnapjaw6.defensa = 7;
            OasisSnapjaw6.maxdefensa = 7;
            OasisSnapjaw6.tipo = "Esbirro";
            OasisSnapjaw6.subtipo = "Bestia";
            OasisSnapjaw6.despierto = false;
            OasisSnapjaw6.ataco = false;

            Esbirro BoulderfistOgre6 = new Esbirro();

            BoulderfistOgre6.nombre = "Boulderfist Ogre";
            BoulderfistOgre6.costo = 6;
            BoulderfistOgre6.ataque = 6;
            BoulderfistOgre6.defensa = 7;
            BoulderfistOgre6.maxdefensa = 7;
            BoulderfistOgre6.tipo = "Esbirro";
            BoulderfistOgre6.subtipo = null;
            BoulderfistOgre6.despierto = false;
            BoulderfistOgre6.ataco = false;

            Esbirro WarGolem6 = new Esbirro();

            WarGolem6.nombre = "War Golem";
            WarGolem6.costo = 7;
            WarGolem6.ataque = 7;
            WarGolem6.defensa = 7;
            WarGolem6.maxdefensa = 7;
            WarGolem6.tipo = "Esbirro";
            WarGolem6.subtipo = null;
            WarGolem6.despierto = false;
            WarGolem6.ataco = false;

            Esbirro CoreHound6 = new Esbirro();

            CoreHound6.nombre = "Core Hound";
            CoreHound6.costo = 7;
            CoreHound6.ataque = 9;
            CoreHound6.defensa = 5;
            CoreHound.maxdefensa = 5;
            CoreHound6.tipo = "Esbirro";
            CoreHound6.subtipo = "Bestia";
            CoreHound6.despierto = false;
            CoreHound6.ataco = false;




            jugador1.identificador = 1;
            jugador2.identificador = 2;


            Random rnd = new Random();
            jugador1.turno = 1;
            jugador2.turno = 2;
            int dice = rnd.Next(1, 3);


            jugador1.vida = 30;
            jugador2.vida = 30;
            jugador1.gema = 0;
            jugador2.gema = 0;
            jugador1.limitegema = 0;
            jugador2.limitegema = 0;
            jugador1.ganper = false;
            jugador2.ganper = false;
            jugador1.habilidadusada = false;
            jugador1.habilidadusada = false;

            jugador1.Agregarcartamazo(MurlocRaider);
            jugador1.Agregarcartamazo(Wisp);
            jugador1.Agregarcartamazo(BloodfenRaptor);
            jugador1.Agregarcartamazo(RiverCrocolisk);
            jugador1.Agregarcartamazo(MagmaRager);
            jugador1.Agregarcartamazo(ChillwindYeti);
            jugador1.Agregarcartamazo(OasisSnapjaw);
            jugador1.Agregarcartamazo(BoulderfistOgre);
            jugador1.Agregarcartamazo(WarGolem);
            jugador1.Agregarcartamazo(CoreHound);
            jugador2.Agregarcartamazo(MurlocRaider2);
            jugador2.Agregarcartamazo(Wisp2);
            jugador2.Agregarcartamazo(BloodfenRaptor2);
            jugador2.Agregarcartamazo(RiverCrocolisk2);
            jugador2.Agregarcartamazo(MagmaRager2);
            jugador2.Agregarcartamazo(ChillwindYeti2);
            jugador2.Agregarcartamazo(OasisSnapjaw2);
            jugador2.Agregarcartamazo(BoulderfistOgre2);
            jugador2.Agregarcartamazo(WarGolem2);
            jugador2.Agregarcartamazo(CoreHound2);

            jugador1.Agregarcartamazo(MurlocRaider3);
            jugador1.Agregarcartamazo(Wisp3);
            jugador1.Agregarcartamazo(BloodfenRaptor3);
            jugador1.Agregarcartamazo(RiverCrocolisk3);
            jugador1.Agregarcartamazo(MagmaRager3);
            jugador1.Agregarcartamazo(ChillwindYeti3);
            jugador1.Agregarcartamazo(OasisSnapjaw3);
            jugador1.Agregarcartamazo(BoulderfistOgre3);
            jugador1.Agregarcartamazo(WarGolem3);
            jugador1.Agregarcartamazo(CoreHound3);
            jugador2.Agregarcartamazo(MurlocRaider4);
            jugador2.Agregarcartamazo(Wisp4);
            jugador2.Agregarcartamazo(BloodfenRaptor4);
            jugador2.Agregarcartamazo(RiverCrocolisk4);
            jugador2.Agregarcartamazo(MagmaRager4);
            jugador2.Agregarcartamazo(ChillwindYeti4);
            jugador2.Agregarcartamazo(OasisSnapjaw4);
            jugador2.Agregarcartamazo(BoulderfistOgre4);
            jugador2.Agregarcartamazo(WarGolem4);
            jugador2.Agregarcartamazo(CoreHound4);

            jugador1.Agregarcartamazo(MurlocRaider5);
            jugador1.Agregarcartamazo(Wisp5);
            jugador1.Agregarcartamazo(BloodfenRaptor5);
            jugador1.Agregarcartamazo(RiverCrocolisk5);
            jugador1.Agregarcartamazo(MagmaRager5);
            jugador1.Agregarcartamazo(ChillwindYeti5);
            jugador1.Agregarcartamazo(OasisSnapjaw5);
            jugador1.Agregarcartamazo(BoulderfistOgre5);
            jugador1.Agregarcartamazo(WarGolem5);
            jugador1.Agregarcartamazo(CoreHound5);
            jugador2.Agregarcartamazo(MurlocRaider6);
            jugador2.Agregarcartamazo(Wisp6);
            jugador2.Agregarcartamazo(BloodfenRaptor6);
            jugador2.Agregarcartamazo(RiverCrocolisk6);
            jugador2.Agregarcartamazo(MagmaRager6);
            jugador2.Agregarcartamazo(ChillwindYeti6);
            jugador2.Agregarcartamazo(OasisSnapjaw6);
            jugador2.Agregarcartamazo(BoulderfistOgre6);
            jugador2.Agregarcartamazo(WarGolem6);
            jugador2.Agregarcartamazo(CoreHound6);

            jugador1.Shuffle(rnd);
            jugador2.Shuffle(rnd);
            jugador1.Agregarcartamano();
            jugador1.Agregarcartamano();
            jugador1.Agregarcartamano();
            jugador2.Agregarcartamano();
            jugador2.Agregarcartamano();
            jugador2.Agregarcartamano();

            if (jugador1.turno == dice)
            {
                jugador2.Agregarcartamano();
            }
            else
            {
                jugador1.Agregarcartamano();
            }


            juego.jugador1 = jugador1;
            juego.jugador2 = jugador2;
            juego.dice = dice;


        }

        public static void SaveGame(Juego Game)
        {
            Console.WriteLine("Nombre del archivo: ");
            string fileName = Console.ReadLine();
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Game);
            fs.Close();
        }

        public static Juego LoadGame()
        {
            Console.WriteLine("Nombre del archivo: ");
            string fileName = Console.ReadLine();
            FileStream fs = new FileStream(fileName, FileMode.Open);

            IFormatter formatter = new BinaryFormatter();
            Juego Game = formatter.Deserialize(fs) as Juego;
            fs.Close();
            return Game;

        }

        private void BotonInicio_Click(object sender, RoutedEventArgs e)
        {
            BotonInicio.Visibility = Visibility.Hidden;
            Fondoinicio.Visibility = Visibility.Hidden;
            Imagen2.Visibility = Visibility.Visible;
            Cargar_Partida.Visibility = Visibility.Visible;
            Partida_Nueva.Visibility = Visibility.Visible;

        }

        private void Partida_Nueva_Click(object sender, RoutedEventArgs e)
        {
            Cargar_Partida.Visibility = Visibility.Hidden;
            Partida_Nueva.Visibility = Visibility.Hidden;
            Label1.Visibility = Visibility.Visible;
            tb1.Visibility = Visibility.Visible;
            tb2.Visibility = Visibility.Visible;
            njugador1.Visibility = Visibility.Visible;
            njugador2.Visibility = Visibility.Visible;
            Siguiente.Visibility = Visibility.Visible;


        }

        private void Cargar_Partida_Click(object sender, RoutedEventArgs e)
        {
            Cargar_Partida.Visibility = Visibility.Hidden;
            Partida_Nueva.Visibility = Visibility.Hidden;


        }

        private void NombreJugadores(object sender, RoutedEventArgs e)
        {
            label21.Content = tb1.Text;
            label22.Content = tb2.Text;
            Label1.Visibility = Visibility.Hidden;
            tb1.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
            njugador1.Visibility = Visibility.Hidden;
            njugador2.Visibility = Visibility.Hidden;
            Siguiente.Visibility = Visibility.Hidden;
            EH.Visibility = Visibility.Visible;
            label21.Visibility = Visibility.Visible;
            label22.Visibility = Visibility.Visible;
            comboBox.Visibility = Visibility.Visible;
            comboBox1.Visibility = Visibility.Visible;
            Jugar.Visibility = Visibility.Visible;
            HabilidadJ1.Visibility = Visibility.Visible;
            HabilidadJ2.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Visible;
            label1.Visibility = Visibility.Visible;




        }

        private void SeleccionHeroes(object sender, RoutedEventArgs e)
        {

            IniciarJuego();
            EH.Visibility = Visibility.Hidden;
            label21.Visibility = Visibility.Hidden;
            label22.Visibility = Visibility.Hidden;
            comboBox.Visibility = Visibility.Hidden;
            comboBox1.Visibility = Visibility.Hidden;
            Jugar.Visibility = Visibility.Hidden;
            HabilidadJ1.Visibility = Visibility.Hidden;
            HabilidadJ2.Visibility = Visibility.Hidden;
            label.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            Tablero.Visibility = Visibility.Visible;
            Imagen2.Visibility = Visibility.Hidden;
            g1.Visibility = Visibility.Visible;
            g2.Visibility = Visibility.Visible;
            gritosj1.Visibility = Visibility.Visible;
            gritosj2.Visibility = Visibility.Visible;
            RendirseJ1.Visibility = Visibility.Visible;
            RendirseJ2.Visibility = Visibility.Visible;

            Comenzar2.Visibility = Visibility.Visible;


            Jug1.Content = label21.Content;
            Jug2.Content = label22.Content;

            Jug1.Visibility = Visibility.Visible;
            Jug2.Visibility = Visibility.Visible;

            CambioC1.Visibility = Visibility.Visible;
            CambioC2.Visibility = Visibility.Visible;
            CambioC3.Visibility = Visibility.Visible;

            CambioC8.Visibility = Visibility.Visible;

            BotonHeroeJ1.Visibility = Visibility.Visible;
            BotonHeroeJ2.Visibility = Visibility.Visible;
            BotonHabilidadHeroeJ1.Visibility = Visibility.Visible;
            BotonHabilidadHeroeJ2.Visibility = Visibility.Visible;
            LabelVidaJ1.Visibility = Visibility.Visible;
            LabelVidaJ2.Visibility = Visibility.Visible;
            LabelGemasJ1.Visibility = Visibility.Visible;
            LabelGemasJ2.Visibility = Visibility.Visible;

            MostrarCartasCambiot1(juego.jugador1);


            juego.jugador1.nombrejugador = Jug1.Content.ToString();
            juego.jugador2.nombrejugador = Jug2.Content.ToString();



            if ((string)nheroe1.Content == "Druid")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Druid.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadDruid.png")));
                juego.jugador1.nombreheroe = "Druid";
                juego.jugador1.habilidadheroe = "Shapeshift";
            }

            else if ((string)nheroe1.Content == "Hunter")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Hunter.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadHunter.png")));
                juego.jugador1.nombreheroe = "Hunter";
                juego.jugador1.habilidadheroe = "Steady Shot";
            }
            else if ((string)nheroe1.Content == "Mage")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Mage.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadMage.png")));
                juego.jugador1.nombreheroe = "Mage";
                juego.jugador1.habilidadheroe = "Fireblast";
            }
            else if ((string)nheroe1.Content == "Paladin")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Paladin.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadPaladin.png")));
                juego.jugador1.nombreheroe = "Paladin";
                juego.jugador1.habilidadheroe = "Reinforce";
            }
            else if ((string)nheroe1.Content == "Priest")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Priest.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadPriest.png")));
                juego.jugador1.nombreheroe = "Priest";
                juego.jugador1.habilidadheroe = "Lesser Heal";
            }
            else if ((string)nheroe1.Content == "Rogue")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Rogue.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadRogue.png")));
                juego.jugador1.nombreheroe = "Rogue";
                juego.jugador1.habilidadheroe = "Dagger Mastery";
            }
            else if ((string)nheroe1.Content == "Shaman")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Shaman.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadShaman.png")));
                juego.jugador1.nombreheroe = "Shaman";
                juego.jugador1.habilidadheroe = "Totemic Call";
            }
            else if ((string)nheroe1.Content == "Warlock")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Warlock.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadWarlock.png")));
                juego.jugador1.nombreheroe = "Warlock";
                juego.jugador1.habilidadheroe = "Life Tap";
            }
            else if ((string)nheroe1.Content == "Warrior")
            {
                BotonHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ1), "Recursos/Heroes/Warrior.png")));
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadWarrior.png")));
                juego.jugador1.nombreheroe = "Warrior";
                juego.jugador1.habilidadheroe = "Armor Up!";
            }
            if ((string)nheroe2.Content == "Druid")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Druid.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadDruid.png")));
                juego.jugador2.nombreheroe = "Druid";
                juego.jugador2.habilidadheroe = "Shapeshift";
            }
            else if ((string)nheroe2.Content == "Hunter")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Hunter.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadHunter.png")));
                juego.jugador2.nombreheroe = "Hunter";
                juego.jugador2.habilidadheroe = "Steady Shot";
            }
            else if ((string)nheroe2.Content == "Mage")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Mage.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadMage.png")));
                juego.jugador2.nombreheroe = "Mage";
                juego.jugador2.habilidadheroe = "Fireblast";
            }
            else if ((string)nheroe2.Content == "Paladin")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Paladin.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadPaladin.png")));
                juego.jugador2.nombreheroe = "Paladin";
                juego.jugador2.habilidadheroe = "Reinforce";
            }
            else if ((string)nheroe2.Content == "Priest")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Priest.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadPriest.png")));
                juego.jugador2.nombreheroe = "Priest";
                juego.jugador2.habilidadheroe = "Lesser Heal";
            }
            else if ((string)nheroe2.Content == "Rogue")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Rogue.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadRogue.png")));
                juego.jugador2.nombreheroe = "Rogue";
                juego.jugador2.habilidadheroe = "Dagger Mastery";
            }
            else if ((string)nheroe2.Content == "Shaman")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Shaman.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadShaman.png")));
                juego.jugador2.nombreheroe = "Shaman";
                juego.jugador2.habilidadheroe = "Totemic Call";
            }
            else if ((string)nheroe2.Content == "Warlock")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Warlock.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadWarlock.png")));
                juego.jugador2.nombreheroe = "Warlock";
                juego.jugador2.habilidadheroe = "Life Tap";
            }
            else if ((string)nheroe2.Content == "Warrior")
            {
                BotonHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHeroeJ2), "Recursos/Heroes/Warrior.png")));
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadWarrior.png")));
                juego.jugador2.nombreheroe = "Warrior";
                juego.jugador2.habilidadheroe = "Armor Up!";
            }

            Jug1.Content = label21.Content;
            Jug2.Content = label22.Content;
            Jug1.Visibility = Visibility.Visible;
            Jug2.Visibility = Visibility.Visible;
            MessageBox.Show("Seleccione las cartas que quiere cambiar");



        }

        private void CargarPartida_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBoxItem cbi = (ComboBoxItem)comboBox.SelectedItem;
            string HeroeJ1 = cbi.Content.ToString();

            if (HeroeJ1 == "Druid")
            {
                nheroe1.Content = "Druid";
                HabilidadJ1.Content = "+1 en ataque por su turno \ny +1 de armadura";
            }
            else if (HeroeJ1 == "Hunter")
            {
                nheroe1.Content = "Hunter";
                HabilidadJ1.Content = "Le hace 2 de daño \nal heroe enemigo";
            }
            else if (HeroeJ1 == "Mage")
            {
                nheroe1.Content = "Mage";
                HabilidadJ1.Content = "Puede hacer 1 de daño\n(Heroe enemigo o esbirro)";
            }
            else if (HeroeJ1 == "Paladin")
            {
                nheroe1.Content = "Paladin";
                HabilidadJ1.Content = "Obtiene un soldado 1/1";
            }
            else if (HeroeJ1 == "Priest")
            {
                nheroe1.Content = "Priest";
                HabilidadJ1.Content = "Recupera 2 de vida";
            }
            else if (HeroeJ1 == "Rogue")
            {
                nheroe1.Content = "Rogue";
                HabilidadJ1.Content = "Obtiene una daga 1/2";
            }
            else if (HeroeJ1 == "Shaman")
            {
                nheroe1.Content = "Shaman";
                HabilidadJ1.Content = "Puede obtener un totem con\n2 de vida o con 1/1";
            }
            else if (HeroeJ1 == "Warlock")
            {
                nheroe1.Content = "Warlock";
                HabilidadJ1.Content = "Pierde 2 puntos de vida\npara robar una carta del mazo";
            }
            else if (HeroeJ1 == "Warrior")
            {
                nheroe1.Content = "Warrior";
                HabilidadJ1.Content = "Obtiene +2 de armadura";
            }

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)comboBox1.SelectedItem;
            string HeroeJ2 = cbi.Content.ToString();
            HabilidadJ2.Content = HeroeJ2;

            if (HeroeJ2 == "Druid")
            {
                nheroe2.Content = "Druid";
                HabilidadJ2.Content = "+1 en ataque por su turno \ny +1 de armadura";

            }
            else if (HeroeJ2 == "Hunter")
            {
                nheroe2.Content = "Hunter";
                HabilidadJ2.Content = "Le hace 2 de daño \nal heroe enemigo";
            }
            else if (HeroeJ2 == "Mage")
            {
                nheroe2.Content = "Mage";
                HabilidadJ2.Content = "Puede hacer 1 de daño\n(Heroe enemigo o esbirro)";
            }
            else if (HeroeJ2 == "Paladin")
            {
                nheroe2.Content = "Paladin";
                HabilidadJ2.Content = "Obtiene un soldado 1/1";
            }
            else if (HeroeJ2 == "Priest")
            {
                nheroe2.Content = "Priest";
                HabilidadJ2.Content = "Recupera 2 de vida";
            }
            else if (HeroeJ2 == "Rogue")
            {
                nheroe2.Content = "Rogue";
                HabilidadJ2.Content = "Obtiene una daga 1/2";
            }
            else if (HeroeJ2 == "Shaman")
            {
                nheroe2.Content = "Shaman";
                HabilidadJ2.Content = "Puede obtener un totem \ncon 2 de vida o con 1/1";
            }
            else if (HeroeJ2 == "Warlock")
            {
                nheroe2.Content = "Warlock";
                HabilidadJ2.Content = "Pierde 2 puntos de vida\n para robar una carta del mazo";
            }
            else if (HeroeJ2 == "Warrior")
            {
                nheroe2.Content = "Warrior";
                HabilidadJ2.Content = "Obtiene +2 de armadura";
            }

        }

        private void gritosj1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cb = (ComboBoxItem)gritosj1.SelectedItem;
            string opcion2 = cb.Content.ToString();


            if (opcion2 == "Saludar")
            {
                MessageBox.Show("Hola maldito...");
            }
            else if (opcion2 == "Amenaza")
            {
                MessageBox.Show("Mi furia caera sobre ti");
            }
            else if (opcion2 == "Buena Jugada")
            {
                MessageBox.Show("Esa es una buena jugada");
            }
            else if (opcion2 == "Burla")
            {
                MessageBox.Show("Hahaha pobre idiota");
            }
        }

        private void gritosj2_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cb1 = (ComboBoxItem)gritosj2.SelectedItem;
            string opcion1 = cb1.Content.ToString();


            if (opcion1 == "Saludar")
            {
                MessageBox.Show("Hola maldito...");
            }
            else if (opcion1 == "Amenaza")
            {
                MessageBox.Show("Mi furia caera sobre ti");
            }
            else if (opcion1 == "Buena Jugada")
            {
                MessageBox.Show("Esa es una buena jugada");
            }
            else if (opcion1 == "Burla")
            {
                MessageBox.Show("Hahaha pobre idiota");
            }
        }

        private void Seguir_Click(object sender, RoutedEventArgs e)
        {
            if (juego.dice == 1)
            {
                juego.dice = 2;
            }
            else
            {
                juego.dice = 1;
            }
            if (juego.jugador1.turno == juego.dice)
            {
                Reniciar(juego.jugador1, juego.jugador2);
                LabelGemasJ1.Content = juego.jugador1.gema;
                LabelVidaJ1.Content = juego.jugador1.vida;
                armausadaJ1 = 0;
                BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/Habilidad" + juego.jugador1.nombreheroe + ".png")));
                BotonHabilidadHeroeJ2.Visibility = Visibility.Hidden;
                BotonArmaJ2.Visibility = Visibility.Hidden;
                BotonHabilidadHeroeJ1.Visibility = Visibility.Visible;
                BotonArmaJ1.Visibility = Visibility.Visible;
                actualizarimagenes();
            }
            else
            {
                Reniciar(juego.jugador2, juego.jugador1);
                LabelGemasJ2.Content = juego.jugador2.gema;
                LabelVidaJ2.Content = juego.jugador2.vida;
                armausadaJ2 = 0;
                BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/Habilidad" + juego.jugador2.nombreheroe + ".png")));
                BotonHabilidadHeroeJ2.Visibility = Visibility.Visible;
                BotonArmaJ2.Visibility = Visibility.Visible;
                BotonHabilidadHeroeJ1.Visibility = Visibility.Hidden;
                BotonArmaJ1.Visibility = Visibility.Hidden;
                actualizarimagenes();

            }
        }

        public void MostrarCartasCambiot1(Jugador jugador)
        {
            if (jugador.Mano.Count == 3)
            {
                CambioC8.Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < jugador.Mano.Count; i++)
            {
                if (jugador.Mano[i].nombre == "Wisp")
                {
                    String Direccion = "Recursos/Wisp.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }


                }
                else if (jugador.Mano[i].nombre == "Murloc Raider")
                {
                    String Direccion = "Recursos/Murlocraider.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }


                }
                else if (jugador.Mano[i].nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Recursos/BloodfenRaptor.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }



                }
                else if (jugador.Mano[i].nombre == "River Crocolisk")
                {
                    String Direccion = "Recursos/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }

                }
                else if (jugador.Mano[i].nombre == "Magma Rager")
                {
                    String Direccion = "Recursos/Magmarager.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }


                }
                else if (jugador.Mano[i].nombre == "Chillwind Yeti")
                {
                    String Direccion = "Recursos/Chillwindyeti.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }

                }
                else if (jugador.Mano[i].nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Recursos/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }

                }
                else if (jugador.Mano[i].nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Recursos/Boulderfistogre.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }

                }
                else if (jugador.Mano[i].nombre == "War Golem")
                {
                    String Direccion = "Recursos/Wargolem.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }
                }
                else if (jugador.Mano[i].nombre == "Core Hound")
                {
                    String Direccion = "Recursos/Corehound.png";
                    if (i == 0)
                    {
                        CambioC1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC8), Direccion)));
                    }

                }


            }
        }

        public void MostrarCartasCambiot2(Jugador jugador)
        {
            if (jugador.Mano.Count == 3)
            {
                CambioC7.Visibility = Visibility.Hidden;
            }


            for (int i = 0; i < jugador.Mano.Count; i++)
            {
                if (jugador.Mano[i].nombre == "Wisp")
                {
                    String Direccion = "Recursos/Wisp.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }

                }
                else if (jugador.Mano[i].nombre == "Murloc Raider")
                {
                    String Direccion = "Recursos/Murlocraider.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }


                }
                else if (jugador.Mano[i].nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Recursos/BloodfenRaptor.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }


                }
                else if (jugador.Mano[i].nombre == "River Crocolisk")
                {
                    String Direccion = "Recursos/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }
                }
                else if (jugador.Mano[i].nombre == "Magma Rager")
                {
                    String Direccion = "Recursos/Magmarager.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }

                }
                else if (jugador.Mano[i].nombre == "Chillwind Yeti")
                {
                    String Direccion = "Recursos/Chillwindyeti.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }
                }
                else if (jugador.Mano[i].nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Recursos/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }
                }
                else if (jugador.Mano[i].nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Recursos/Boulderfistogre.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }
                }
                else if (jugador.Mano[i].nombre == "War Golem")
                {
                    String Direccion = "Recursos/Wargolem.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }
                }
                else if (jugador.Mano[i].nombre == "Core Hound")
                {
                    String Direccion = "Recursos/Corehound.png";
                    if (i == 0)
                    {
                        CambioC4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC4), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CambioC5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC5), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CambioC6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC6), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CambioC7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CambioC7), Direccion)));
                    }
                }


            }
        }

        public void OtorgarMoneda()
        {
            //Datos Moneda
            Hechizo TheCoin = new Hechizo();

            TheCoin.nombre = "The Coin";
            TheCoin.costo = 0;
            TheCoin.tipo = "Hechizo";
            TheCoin.habilidad = "Gana una gema por este Turno";
            TheCoin.OtorgarMoneda(juego.jugador1, juego.dice, TheCoin);
            TheCoin.OtorgarMoneda(juego.jugador2, juego.dice, TheCoin);

        }

        private void ActualizarTableroJ1(List<Esbirro> tablero)
        {
            for (int i = 0; i < tablero.Count; i++)
            {
                if (tablero[i].nombre == "Wisp")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Wisp.png")));
                    }

                }
                else if (tablero[i].nombre == "Murloc Raider")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Murlocraider.png")));
                    }

                }
                else if (tablero[i].nombre == "Bloodfen Raptor")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }

                }
                else if (tablero[i].nombre == "River Crocolisk")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }



                }
                else if (tablero[i].nombre == "Magma Rager")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Magmarager.png")));
                    }

                }
                else if (tablero[i].nombre == "Chillwind Yeti")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Chillwindyeti.png")));
                    }

                }
                else if (tablero[i].nombre == "Oasis Snapjaw")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }

                }
                else if (tablero[i].nombre == "Boulderfist Ogre")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Boulderfistogre.png")));
                    }

                }
                else if (tablero[i].nombre == "War Golem")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Wargolem.png")));
                    }

                }
                else if (tablero[i].nombre == "Core Hound")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Corehound.png")));
                    }

                }
                else if (tablero[i].nombre == "Silver Hand Recruit")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Silverhand.png")));
                    }

                }
                else if (tablero[i].nombre == "Healing Totem")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Healingtotem.png")));
                    }

                }
                else if (tablero[i].nombre == "Searing Totem")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Searingtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Healingtotem.png")));
                    }

                }
                else if (tablero[i].nombre == "Stoneclaw Totem")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                }
                else if (tablero[i].nombre == "Wraith Of Air Totem")
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/airtotem.png")));
                    }

                }
                else if (tablero.Count() == 0)
                {
                    if (i == 0)
                    {
                        CT1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J1), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J1), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J1), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J1), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J1), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J1), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J1), "/Recursos/Cartas/Vacio.png")));
                    }
                }

            }
        }

        private void ActualizarTableroJ2(List<Esbirro> tablero)
        {
            for (int i = 0; i < tablero.Count; i++)
            {
                if (tablero[i].nombre == "Wisp")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Wisp.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Wisp.png")));
                    }

                }
                else if (tablero[i].nombre == "Murloc Raider")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Murlocraider.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Murlocraider.png")));
                    }

                }
                else if (tablero[i].nombre == "Bloodfen Raptor")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Bloodfenraptor.png")));
                    }

                }
                else if (tablero[i].nombre == "River Crocolisk")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Rivercrocolisk.png")));
                    }



                }
                else if (tablero[i].nombre == "Magma Rager")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Magmarager.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Magmarager.png")));
                    }

                }
                else if (tablero[i].nombre == "Chillwind Yeti")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Chillwindyeti.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Chillwindyeti.png")));
                    }

                }
                else if (tablero[i].nombre == "Oasis Snapjaw")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Oasissnapjaw.png")));
                    }

                }
                else if (tablero[i].nombre == "Boulderfist Ogre")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Boulderfistogre.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Boulderfistogre.png")));
                    }

                }
                else if (tablero[i].nombre == "War Golem")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Wargolem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Wargolem.png")));
                    }

                }
                else if (tablero[i].nombre == "Core Hound")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Corehound.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Corehound.png")));
                    }

                }
                else if (tablero[i].nombre == "Silver Hand Recruit")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Silverhand.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Silverhand.png")));
                    }

                }
                else if (tablero[i].nombre == "Healing Totem")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Healingtotem.png")));
                    }

                }
                else if (tablero[i].nombre == "Searing Totem")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Searingtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Healingtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Healingtotem.png")));
                    }

                }
                else if (tablero[i].nombre == "Stoneclaw Totem")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Stoneclawtotem.png")));
                    }
                }
                else if (tablero[i].nombre == "Wraith Of Air Totem")
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/airtotem.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/airtotem.png")));
                    }

                }
                else if (tablero.Count() == 0)
                {
                    if (i == 0)
                    {
                        CT1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT1J2), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 1)
                    {
                        CT2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT2J2), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 2)
                    {
                        CT3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT3J2), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 3)
                    {
                        CT4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT4J2), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 4)
                    {
                        CT5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT5J2), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 5)
                    {
                        CT6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT6J2), "/Recursos/Cartas/Vacio.png")));
                    }
                    else if (i == 6)
                    {
                        CT7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CT7J2), "/Recursos/Cartas/Vacio.png")));
                    }
                }

            }


        }

        private void CambioC1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.CambioMano(juego.jugador1, rnd, juego.jugador1.Mano[0], 0);
            CambioC1.Visibility = Visibility.Hidden;
        }

        private void CambioC2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.CambioMano(juego.jugador1, rnd, juego.jugador1.Mano[1], 1);
            CambioC2.Visibility = Visibility.Hidden;
        }

        private void CambioC3_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.CambioMano(juego.jugador1, rnd, juego.jugador1.Mano[2], 2);
            CambioC3.Visibility = Visibility.Hidden;
        }

        private void CambioC4_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.CambioMano(juego.jugador2, rnd, juego.jugador2.Mano[0], 0);
            CambioC4.Visibility = Visibility.Hidden;
        }

        private void CambioC5_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.CambioMano(juego.jugador2, rnd, juego.jugador2.Mano[1], 1);
            CambioC5.Visibility = Visibility.Hidden;

        }

        private void CambioC6_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.CambioMano(juego.jugador2, rnd, juego.jugador2.Mano[2], 2);
            CambioC6.Visibility = Visibility.Hidden;
        }

        private void CambioC7_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.CambioMano(juego.jugador2, rnd, juego.jugador2.Mano[3], 3);
            CambioC7.Visibility = Visibility.Hidden;
        }

        private void CambioC8_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.CambioMano(juego.jugador1, rnd, juego.jugador1.Mano[3], 3);
            CambioC8.Visibility = Visibility.Hidden;
        }

        private void cartasennull()
        {
            CM1J1.Background = null;
            CM2J1.Background = null;
            CM3J1.Background = null;
            CM4J1.Background = null;
            CM5J1.Background = null;
            CM6J1.Background = null;
            CM7J1.Background = null;
            CM8J1.Background = null;
            CM9J1.Background = null;
            CM10J1.Background = null;

            CM1J2.Background = null;
            CM2J2.Background = null;
            CM3J2.Background = null;
            CM4J2.Background = null;
            CM5J2.Background = null;
            CM6J2.Background = null;
            CM7J2.Background = null;
            CM8J2.Background = null;
            CM9J2.Background = null;
            CM10J2.Background = null;

            CT1J1.Background = null;
            CT2J1.Background = null;
            CT3J1.Background = null;
            CT4J1.Background = null;
            CT5J1.Background = null;
            CT6J1.Background = null;
            CT7J1.Background = null;


            CT1J2.Background = null;
            CT2J2.Background = null;
            CT3J2.Background = null;
            CT4J2.Background = null;
            CT5J2.Background = null;
            CT6J2.Background = null;
            CT7J2.Background = null;

        }

        private void visibilidadcartas()
        {
            CambioC1.Visibility = Visibility.Hidden;
            CambioC2.Visibility = Visibility.Hidden;
            CambioC3.Visibility = Visibility.Hidden;
            CambioC4.Visibility = Visibility.Hidden;
            CambioC5.Visibility = Visibility.Hidden;
            CambioC6.Visibility = Visibility.Hidden;
            CambioC7.Visibility = Visibility.Hidden;
            CambioC8.Visibility = Visibility.Hidden;

            if(juego.jugador1.turno == juego.dice)
            {
                if (CM1J1.Background != null)
                {
                    CM1J1.Visibility = Visibility.Visible;
                }

                if (CM2J1.Background != null)
                {
                    CM2J1.Visibility = Visibility.Visible;
                }

                if (CM3J1.Background != null)
                {
                    CM3J1.Visibility = Visibility.Visible;
                }

                if (CM4J1.Background != null)
                {
                    CM4J1.Visibility = Visibility.Visible;
                }

                if (CM5J1.Background != null)
                {
                    CM5J1.Visibility = Visibility.Visible;
                }

                if (CM6J1.Background != null)
                {
                    CM6J1.Visibility = Visibility.Visible;
                }

                if (CM7J1.Background != null)
                {
                    CM7J1.Visibility = Visibility.Visible;
                }

                if (CM8J1.Background != null)
                {
                    CM8J1.Visibility = Visibility.Visible;
                }

                if (CM9J1.Background != null)
                {
                    CM9J1.Visibility = Visibility.Visible;
                }

                if (CM10J1.Background != null)
                {
                    CM10J1.Visibility = Visibility.Visible;
                }
            }

            else
            {
                if (CM1J2.Background != null)
                {
                    CM1J2.Visibility = Visibility.Visible;
                }

                if (CM2J2.Background != null)
                {
                    CM2J2.Visibility = Visibility.Visible;
                }

                if (CM3J2.Background != null)
                {
                    CM3J2.Visibility = Visibility.Visible;
                }

                if (CM4J2.Background != null)
                {
                    CM4J2.Visibility = Visibility.Visible;
                }

                if (CM5J2.Background != null)
                {
                    CM5J2.Visibility = Visibility.Visible;
                }

                if (CM6J2.Background != null)
                {
                    CM6J2.Visibility = Visibility.Visible;
                }

                if (CM7J2.Background != null)
                {
                    CM7J2.Visibility = Visibility.Visible;
                }

                if (CM8J2.Background != null)
                {
                    CM8J2.Visibility = Visibility.Visible;
                }

                if (CM9J2.Background != null)
                {
                    CM9J2.Visibility = Visibility.Visible;
                }

                if (CM10J2.Background != null)
                {
                    CM10J2.Visibility = Visibility.Visible;
                }
            }
            

            if (CT1J2.Background != null)
            {
                CT1J2.Visibility = Visibility.Visible;
            }

            if (CT2J2.Background != null)
            {
                CT2J2.Visibility = Visibility.Visible;
            }

            if (CT3J2.Background != null)
            {
                CT3J2.Visibility = Visibility.Visible;
            }

            if (CT4J2.Background != null)
            {
                CT4J2.Visibility = Visibility.Visible;
            }

            if (CT5J2.Background != null)
            {
                CT5J2.Visibility = Visibility.Visible;
            }

            if (CT6J2.Background != null)
            {
                CT6J2.Visibility = Visibility.Visible;
            }

            if (CT7J2.Background != null)
            {
                CT7J2.Visibility = Visibility.Visible;
            }


            if (CT1J1.Background != null)
            {
                CT1J1.Visibility = Visibility.Visible;
            }

            if (CT2J1.Background != null)
            {
                CT2J1.Visibility = Visibility.Visible;
            }

            if (CT3J1.Background != null)
            {
                CT3J1.Visibility = Visibility.Visible;
            }

            if (CT4J1.Background != null)
            {
                CT4J1.Visibility = Visibility.Visible;
            }

            if (CT5J1.Background != null)
            {
                CT5J1.Visibility = Visibility.Visible;
            }

            if (CT6J1.Background != null)
            {
                CT6J1.Visibility = Visibility.Visible;
            }

            if (CT7J1.Background != null)
            {
                CT7J1.Visibility = Visibility.Visible;
            }


        }

        private void actualizarimagenes()
        {
            cartasennull();
            if(juego.jugador1.turno==juego.dice)
            {
                Manoj1(juego.jugador1.Mano);
                CM1J2.Visibility = Visibility.Hidden;
                CM2J2.Visibility = Visibility.Hidden;
                CM3J2.Visibility = Visibility.Hidden;
                CM4J2.Visibility = Visibility.Hidden;
                CM5J2.Visibility = Visibility.Hidden;
                CM6J2.Visibility = Visibility.Hidden;
                CM7J2.Visibility = Visibility.Hidden;
                CM8J2.Visibility = Visibility.Hidden;
                CM9J2.Visibility = Visibility.Hidden;
                CM10J2.Visibility = Visibility.Hidden;
            }
            else
            {
                Manoj2(juego.jugador2.Mano);
                CM1J1.Visibility = Visibility.Hidden;
                CM2J1.Visibility = Visibility.Hidden;
                CM3J1.Visibility = Visibility.Hidden;
                CM4J1.Visibility = Visibility.Hidden;
                CM5J1.Visibility = Visibility.Hidden;
                CM6J1.Visibility = Visibility.Hidden;
                CM7J1.Visibility = Visibility.Hidden;
                CM8J1.Visibility = Visibility.Hidden;
                CM9J1.Visibility = Visibility.Hidden;
                CM10J1.Visibility = Visibility.Hidden;
            }

            if (DAJ1 <= 0)
            {
                BotonArmaJ1.Visibility = Visibility.Hidden;
            }

            if (DAJ2 <= 0)
            {
                BotonArmaJ2.Visibility = Visibility.Hidden;
            }

            if (juego.jugador1.defensa <= 0)
            {
                Escudo1.Visibility = Visibility.Hidden;
                LabelArmorJ1.Visibility = Visibility.Hidden;
            }

            if (juego.jugador2.defensa <= 0)
            {
                Escudo2.Visibility = Visibility.Hidden;
                LabelArmorJ2.Visibility = Visibility.Hidden;
            }

            ActualizarTableroJ1(juego.jugador1.Tablerojugador);
            ActualizarTableroJ2(juego.jugador2.Tablerojugador);
            visibilidadcartas();

            vidaesbirros();
            ctvisibles();
            cmvisibles();

        }

        private void Manoj1(List<Carta> mano)
        {
            for (int i = 0; i < mano.Count; i++)
            {
                if (mano[i].nombre == "Wisp")
                {
                    String Direccion = "Recursos/Wisp.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Murloc Raider")
                {
                    String Direccion = "Recursos/Murlocraider.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Recursos/Bloodfenraptor.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "River Crocolisk")
                {
                    String Direccion = "Recursos/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Magma Rager")
                {
                    String Direccion = "Recursos/Magmarager.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Chillwind Yeti")
                {
                    String Direccion = "Recursos/Chillwindyeti.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Recursos/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Recursos/Boulderfistogre.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "War Golem")
                {
                    String Direccion = "Recursos/Wargolem.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Core Hound")
                {
                    String Direccion = "Recursos/Corehound.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Silver hand recruit")
                {
                    String Direccion = "Recursos/Silverhand.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Healing Totem")
                {
                    String Direccion = "Recursos/Healingtotem.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Searing Totem")
                {
                    String Direccion = "Recursos/Searingtotem.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Stoneclaw Totem")
                {
                    String Direccion = "Recursos/Stoneclawtotem.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Wraith Of Air Totem")
                {
                    String Direccion = "Recursos/Airtotem.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Wicked Knife")
                {
                    String Direccion = "Recursos/Wickedknife.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Poisoned Dagger")
                {
                    String Direccion = "Recursos/Poisoneddagger.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano[i].nombre == "The Coin")
                {
                    String Direccion = "Recursos/Thecoin.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }
                else if (mano.Count() == 0)
                {
                    String Direccion = "Recursos/Vacio.png";
                    if (i == 0)
                    {
                        CM1J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J1), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J1), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J1), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J1), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J1), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J1), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J1), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J1), Direccion)));
                    }
                    else
                    {
                        CM10J1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J1), Direccion)));
                    }
                }


            }
        }

        private void Manoj2(List<Carta> mano)
        {
            for (int i = 0; i < mano.Count; i++)
            {
                if (mano[i].nombre == "Wisp")
                {
                    String Direccion = "Recursos/Wisp.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Murloc Raider")
                {
                    String Direccion = "Recursos/Murlocraider.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Recursos/Bloodfenraptor.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "River Crocolisk")
                {
                    String Direccion = "Recursos/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Magma Rager")
                {
                    String Direccion = "Recursos/Magmarager.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Chillwind Yeti")
                {
                    String Direccion = "Recursos/Chillwindyeti.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Recursos/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Recursos/Boulderfistogre.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "War Golem")
                {
                    String Direccion = "Recursos/Wargolem.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Core Hound")
                {
                    String Direccion = "Recursos/Corehound.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Silver hand recruit")
                {
                    String Direccion = "Recursos/Silverhand.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Healing Totem")
                {
                    String Direccion = "Recursos/Healingtotem.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Searing Totem")
                {
                    String Direccion = "Recursos/Searingtotem.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Stoneclaw Totem")
                {
                    String Direccion = "Recursos/Stoneclawtotem.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Wraith Of Air Totem")
                {
                    String Direccion = "Recursos/Airtotem.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Wicked Knife")
                {
                    String Direccion = "Recursos/Wickedknife.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "Poisoned Dagger")
                {
                    String Direccion = "Recursos/Poisoneddagger.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano[i].nombre == "The Coin")
                {
                    String Direccion = "Recursos/Thecoin.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }
                else if (mano.Count() == 0)
                {
                    String Direccion = "Recursos/Vacio.png";
                    if (i == 0)
                    {
                        CM1J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM1J2), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CM2J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM2J2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CM3J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM3J2), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CM4J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM4J2), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CM5J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM5J2), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CM6J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM6J2), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CM7J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM7J2), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CM8J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM8J2), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CM9J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM9J2), Direccion)));
                    }
                    else
                    {
                        CM10J2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CM10J2), Direccion)));
                    }
                }


            }
        }

        private void BotonHabilidadHeroeJ1_Click(object sender, RoutedEventArgs e)
        {
            if (juego.jugador1.nombreheroe == "Druid")
            {
                //falta el ataque por el turno
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    HabDruidMageJ1 = 1;
                    BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador1.nombreheroe == "Hunter")
            {
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                    LabelGemasJ1.Content = juego.jugador1.gema;
                    LabelVidaJ2.Content = juego.jugador2.vida;
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    actualizarimagenes();
                    BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador1.nombreheroe == "Mage")
            {
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    HabDruidMageJ1 = 1;
                    BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
                    
            }

            if (juego.jugador1.nombreheroe == "Paladin")
            {
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    if (juego.jugador1.Tablerojugador.Count == 7)
                    {
                        MessageBox.Show("No puedes utilizar la habilidad de heroe");
                    }
                    else
                    {
                        juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                        LabelGemasJ1.Content = juego.jugador1.gema;
                        actualizarimagenes();
                        BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                    }
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador1.nombreheroe == "Priest")
            {
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    HabPriestJ1 = 1;
                    BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador1.nombreheroe == "Rogue")
            {
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    juego.jugador1.habilidadusada = true;
                    juego.jugador1.gema = juego.jugador1.gema - 2;
                    LabelGemasJ1.Content = juego.jugador1.gema;
                    DAJ1 = 2;
                    armausadaJ1 = 0;
                    BotonArmaJ1.Visibility = Visibility.Visible;
                    actualizarimagenes();
                    BotonArmaJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonArmaJ1), "Recursos/Wickedknife.png")));
                    BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }

            }

            if (juego.jugador1.nombreheroe == "Shaman")
            {
                //falta el metodo del Healing Totem
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    if (juego.jugador1.Tablerojugador.Count == 7)
                    {
                        MessageBox.Show("No puedes utilizar la habilidad de heroe");
                    }
                    else
                    {
                        juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                        LabelGemasJ1.Content = juego.jugador1.gema;
                        actualizarimagenes();
                        BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                    }
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador1.nombreheroe == "Warlock")
            {
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                    LabelGemasJ1.Content = juego.jugador1.gema;
                    LabelVidaJ1.Content = juego.jugador1.vida;
                    actualizarimagenes();
                    BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
                    
            }

            if (juego.jugador1.nombreheroe == "Warrior")
            {
                if (juego.jugador1.habilidadusada == false && juego.jugador1.gema >= 2)
                {
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                    LabelGemasJ1.Content = juego.jugador1.gema;
                    Escudo1.Visibility = Visibility.Visible;
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    actualizarimagenes();
                    BotonHabilidadHeroeJ1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ1), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }
        }
   
        private void BotonHabilidadHeroeJ2_Click(object sender, RoutedEventArgs e)
        {
            if (juego.jugador2.nombreheroe == "Druid")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)
                {
                    HabDruidMageJ2 = 1;
                    BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador2.nombreheroe == "Hunter")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)
                {
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                    LabelGemasJ2.Content = juego.jugador2.gema;
                    LabelVidaJ1.Content = juego.jugador1.vida;
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    actualizarimagenes();
                    BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador2.nombreheroe == "Mage")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)
                {
                    HabDruidMageJ2 = 1;
                    BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }
           
            if (juego.jugador2.nombreheroe == "Paladin")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)

                {
                    if (juego.jugador2.Tablerojugador.Count == 7)
                    {
                        MessageBox.Show("No puedes utilizar la habilidad de heroe");
                    }
                    else
                    {
                        juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                        LabelGemasJ2.Content = juego.jugador2.gema;
                        actualizarimagenes();
                        BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                    }
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
                   
            }

            if (juego.jugador2.nombreheroe == "Priest")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)
                {
                    HabPriestJ2 = 1;
                    BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador2.nombreheroe == "Rogue")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)
                {
                    juego.jugador2.habilidadusada = true;
                    juego.jugador2.gema = juego.jugador2.gema - 2;
                    LabelGemasJ2.Content = juego.jugador2.gema;
                    DAJ2 = 2;
                    armausadaJ2 = 0;
                    BotonArmaJ2.Visibility = Visibility.Visible;
                    actualizarimagenes();
                    BotonArmaJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonArmaJ2), "Recursos/Wickedknife.png")));
                    BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador2.nombreheroe == "Shaman")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)

                {
                    if (juego.jugador2.Tablerojugador.Count == 7)
                    {
                        MessageBox.Show("No puedes utilizar la habilidad de heroe");
                    }
                    else
                    {
                        juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                        LabelGemasJ2.Content = juego.jugador2.gema;
                        actualizarimagenes();
                        BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                    }
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador2.nombreheroe == "Warlock")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)
                {
                    juego.jugador1.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                    LabelGemasJ2.Content = juego.jugador2.gema;
                    LabelVidaJ2.Content = juego.jugador2.vida;
                    actualizarimagenes();
                    BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }

            if (juego.jugador2.nombreheroe == "Warrior")
            {
                if (juego.jugador2.habilidadusada == false && juego.jugador2.gema >= 2)
                {
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                    LabelGemasJ2.Content = juego.jugador2.gema;
                    Escudo2.Visibility = Visibility.Visible;
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    actualizarimagenes();
                    BotonHabilidadHeroeJ2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(BotonHabilidadHeroeJ2), "Recursos/HabilidadHeroe/HabilidadUsada.png")));
                }
                else
                {
                    MessageBox.Show("No puedes utilizar la habilidad de heroe");
                }
            }
        }

        private void CM1J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 0);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM2J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 1);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM3J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 2);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM4J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 3);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM5J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 4);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM6J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 5);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM7J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 6);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM8J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 7);
            actualizarimagenes();
        }
        private void CM9J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 8);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM10J1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Agregarcartalado(juego.jugador1, 9);
            LabelGemasJ1.Content = juego.jugador1.gema;
            actualizarimagenes();
        }
        private void CM1J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 0);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM2J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 1);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM3J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 2);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM4J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 3);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM5J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 4);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM6J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 5);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM7J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 6);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM8J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 7);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM9J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 8);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }
        private void CM10J2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Agregarcartalado(juego.jugador2, 9);
            LabelGemasJ2.Content = juego.jugador2.gema;
            actualizarimagenes();
        }

        private void Reniciar(Jugador jugador, Jugador jugador2)
        {
            jugador.Agregarcartamano();
            jugador.Aumentargema();
            jugador.Regenerargema();
            jugador.habilidadusada = false;
            jugador.Despertar(jugador);
            foreach (Esbirro esbirro in jugador2.Tablerojugador)
            {
                if (esbirro.nombre == "Healing Totem")
                {
                    esbirro.TotemHeal(jugador2);
                }
            } 
            
            
        }

        private void CT1J1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ1 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ2 == 1)
            {
                if (armausadaJ2 == 0)
                {
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }

        }

        private void CT2J1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ1 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ2 == 1)
            {
                if (armausadaJ2 == 0)
                {
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 1, 0, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 1, 0, 0);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 1, 0);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT3J1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ1 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ2 == 1)
            {
                if (armausadaJ2 == 0)
                {
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 2, 0, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 2, 0, 0);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 2, 0);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT4J1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ1 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ2 == 1)
            {       
                if (armausadaJ2 == 0)
                {
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 3, 0, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 3, 0, 0);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 3, 0);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT5J1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ1 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ2 == 1)
            {  
                if (armausadaJ2 == 0)
                {
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 4, 0, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 4, 0, 0);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 4, 0);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT6J1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ1 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ2 == 1)
            {         
                if (armausadaJ2 == 0)
                {
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 5, 0, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 5, 0, 0);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 5, 0);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT7J1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ1 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ2 == 1)
            {               
                if (armausadaJ2 == 0)
                {
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 6, 0, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                actualizarimagenes();

            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 6, 0, 0);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 6, 0);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT1J2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ2 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ1 == 1)
            { 
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 0);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 0);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT2J2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ2 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ1 == 1)
            {       
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 1, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 1, 0, 0);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 1, 0);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT3J2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ2 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ1 == 1)
            {               
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 2, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 2, 0, 0);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 2, 0);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT4J2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ2 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ1 == 1)
            {            
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 3, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 3, 0, 0);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 3, 0);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT5J2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ2 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ1 == 1)
            {               
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 4, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 4, 0, 0);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 4, 0);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT6J2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ2 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ1 == 1)
            {              
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 5, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 5, 0, 0);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 5, 0);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void CT7J2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            CTJ2 = button.Name;
            if (CTJ1 != "" && CTJ2 != "")
            {
                enfrentamiento(CTJ1, CTJ2);
            }
            else if (ataquearmaJ1 == 1)
            {               
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 6, 0);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 6, 0, 0);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 6, 0);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                actualizarimagenes();
            }
        }

        private void enfrentamiento(string j1, string j2)
        {

            if (j1 == "CT1J1")
            {
                IJ1 = 0;
            }

            else if (j1 == "CT2J1")
            {
                IJ1 = 1;
            }

            else if (j1 == "CT3J1")
            {
                IJ1 = 2;
            }

            else if (j1 == "CT4J1")
            {
                IJ1 = 3;
            }

            else if (j1 == "CT5J1")
            {
                IJ1 = 4;
            }

            else if (j1 == "CT6J1")
            {
                IJ1 = 5;
            }

            else if (j1 == "CT7J1")
            {
                IJ1 = 6;
            }

            if (j2 == "CT1J2")
            {
                IJ2 = 0;
            }

            else if (j2 == "CT2J2")
            {
                IJ2 = 1;
            }

            else if (j2 == "CT3J2")
            {
                IJ2 = 2;
            }

            else if (j2 == "CT4J2")
            {
                IJ2 = 3;
            }

            else if (j2 == "CT5J2")
            {
                IJ2 = 4;
            }

            else if (j2 == "CT6J2")
            {
                IJ2 = 5;
            }

            else if (j2 == "CT7J2")
            {
                IJ2 = 6;
            }

            if (juego.jugador1.turno == juego.dice)
            {
                eleccion = 0;
                juego.jugador1.Enfrentar(juego.jugador1, juego.jugador2, IJ1, IJ2, eleccion, juego.dice);
            }

            else
            {
                eleccion = 0;
                juego.jugador2.Enfrentar(juego.jugador2, juego.jugador1, IJ2, IJ1, eleccion, juego.dice);
            }

            actualizarimagenes();
            CTJ1 = "";
            CTJ2 = "";
        }

        private void Comenzar_Click(object sender, RoutedEventArgs e)
        {
            Seguir.Visibility = Visibility.Visible;
            Comenzar.Visibility = Visibility.Hidden;
            Comenzar2.Visibility = Visibility.Hidden;
            OtorgarMoneda();
            if (juego.jugador1.turno == juego.dice)
            {
                Reniciar(juego.jugador1, juego.jugador2);
                LabelGemasJ1.Content = juego.jugador1.gema;
                LabelVidaJ1.Content = juego.jugador1.vida;
            }
            else
            {
                Reniciar(juego.jugador2, juego.jugador1);
                LabelGemasJ2.Content = juego.jugador2.gema;
                LabelVidaJ2.Content = juego.jugador2.vida;
            }

            actualizarimagenes();
        }

        private void BotonArmaJ1_Click(object sender, RoutedEventArgs e)
        {
            ataquearmaJ1 = 1;
        }

        private void BotonArmaJ2_Click(object sender, RoutedEventArgs e)
        {
            ataquearmaJ2 = 1;
        }

        private void vidaesbirros()
        {
            GE1J1.Visibility = Visibility.Hidden;
            LE1J1.Visibility = Visibility.Hidden;
            GE2J1.Visibility = Visibility.Hidden;
            LE2J1.Visibility = Visibility.Hidden;
            GE3J1.Visibility = Visibility.Hidden;
            LE3J1.Visibility = Visibility.Hidden;
            GE4J1.Visibility = Visibility.Hidden;
            LE4J1.Visibility = Visibility.Hidden;
            GE5J1.Visibility = Visibility.Hidden;
            LE5J1.Visibility = Visibility.Hidden;
            GE6J1.Visibility = Visibility.Hidden;
            LE6J1.Visibility = Visibility.Hidden;
            GE7J1.Visibility = Visibility.Hidden;
            LE7J1.Visibility = Visibility.Hidden;

            GE1J2.Visibility = Visibility.Hidden;
            LE1J2.Visibility = Visibility.Hidden;
            GE2J2.Visibility = Visibility.Hidden;
            LE2J2.Visibility = Visibility.Hidden;
            GE3J2.Visibility = Visibility.Hidden;
            LE3J2.Visibility = Visibility.Hidden;
            GE4J2.Visibility = Visibility.Hidden;
            LE4J2.Visibility = Visibility.Hidden;
            GE5J2.Visibility = Visibility.Hidden;
            LE5J2.Visibility = Visibility.Hidden;
            GE6J2.Visibility = Visibility.Hidden;
            LE6J2.Visibility = Visibility.Hidden;
            GE7J2.Visibility = Visibility.Hidden;
            LE7J2.Visibility = Visibility.Hidden;

            if (CT1J1.Background != null)
            {

                GE1J1.Visibility = Visibility.Visible;
                LE1J1.Visibility = Visibility.Visible;
                LE1J1.Content = juego.jugador1.Tablerojugador[0].defensa;
            }
            if (CT2J1.Background != null)
            {
                GE2J1.Visibility = Visibility.Visible;
                LE2J1.Visibility = Visibility.Visible;
                LE2J1.Content = juego.jugador1.Tablerojugador[1].defensa;
            }
            if (CT3J1.Background != null)
            {
                GE3J1.Visibility = Visibility.Visible;
                LE3J1.Visibility = Visibility.Visible;
                LE3J1.Content = juego.jugador1.Tablerojugador[2].defensa;
            }
            if (CT4J1.Background != null)
            {
                GE4J1.Visibility = Visibility.Visible;
                LE4J1.Visibility = Visibility.Visible;
                LE4J1.Content = juego.jugador1.Tablerojugador[3].defensa;
            }
            if (CT5J1.Background != null)
            {
                GE5J1.Visibility = Visibility.Visible;
                LE5J1.Visibility = Visibility.Visible;
                LE5J1.Content = juego.jugador1.Tablerojugador[4].defensa;
            }
            if (CT6J1.Background != null)
            {
                GE6J1.Visibility = Visibility.Visible;
                LE6J1.Visibility = Visibility.Visible;
                LE6J1.Content = juego.jugador1.Tablerojugador[5].defensa;
            }
            if (CT7J1.Background != null)
            {
                GE7J1.Visibility = Visibility.Visible;
                LE7J1.Visibility = Visibility.Visible;
                LE7J1.Content = juego.jugador1.Tablerojugador[6].defensa;
            }
            if (CT1J2.Background != null)
            {
                GE1J2.Visibility = Visibility.Visible;
                LE1J2.Visibility = Visibility.Visible;
                LE1J2.Content = juego.jugador2.Tablerojugador[0].defensa;
            }
            if (CT2J2.Background != null)
            {
                GE2J2.Visibility = Visibility.Visible;
                LE2J2.Visibility = Visibility.Visible;
                LE2J2.Content = juego.jugador2.Tablerojugador[1].defensa;
            }
            if (CT3J2.Background != null)
            {
                GE3J2.Visibility = Visibility.Visible;
                LE3J2.Visibility = Visibility.Visible;
                LE3J2.Content = juego.jugador2.Tablerojugador[2].defensa;
            }
            if (CT4J2.Background != null)
            {
                GE4J2.Visibility = Visibility.Visible;
                LE4J2.Visibility = Visibility.Visible;
                LE4J2.Content = juego.jugador2.Tablerojugador[3].defensa;
            }
            if (CT5J2.Background != null)
            {
                GE5J2.Visibility = Visibility.Visible;
                LE5J2.Visibility = Visibility.Visible;
                LE5J2.Content = juego.jugador2.Tablerojugador[4].defensa;
            }
            if (CT6J2.Background != null)
            {
                GE6J2.Visibility = Visibility.Visible;
                LE6J2.Visibility = Visibility.Visible;
                LE6J2.Content = juego.jugador2.Tablerojugador[5].defensa;
            }
            if (CT7J2.Background != null)
            {
                GE7J2.Visibility = Visibility.Visible;
                LE7J2.Visibility = Visibility.Visible;
                LE7J2.Content = juego.jugador2.Tablerojugador[6].defensa;
            }

        }

        private void cmvisibles()
        {
            if (juego.jugador1.turno == juego.dice)
            {
                if (juego.jugador1.Mano.Count == 0)
                {
                    CM1J1.Visibility = Visibility.Hidden;
                    CM2J1.Visibility = Visibility.Hidden;
                    CM3J1.Visibility = Visibility.Hidden;
                    CM4J1.Visibility = Visibility.Hidden;
                    CM5J1.Visibility = Visibility.Hidden;
                    CM6J1.Visibility = Visibility.Hidden;
                    CM7J1.Visibility = Visibility.Hidden;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador1.Mano.Count == 1)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Hidden;
                    CM3J1.Visibility = Visibility.Hidden;
                    CM4J1.Visibility = Visibility.Hidden;
                    CM5J1.Visibility = Visibility.Hidden;
                    CM6J1.Visibility = Visibility.Hidden;
                    CM7J1.Visibility = Visibility.Hidden;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador1.Mano.Count == 2)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Hidden;
                    CM4J1.Visibility = Visibility.Hidden;
                    CM5J1.Visibility = Visibility.Hidden;
                    CM6J1.Visibility = Visibility.Hidden;
                    CM7J1.Visibility = Visibility.Hidden;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador1.Mano.Count == 3)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Hidden;
                    CM5J1.Visibility = Visibility.Hidden;
                    CM6J1.Visibility = Visibility.Hidden;
                    CM7J1.Visibility = Visibility.Hidden;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador1.Mano.Count == 4)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Visible;
                    CM5J1.Visibility = Visibility.Hidden;
                    CM6J1.Visibility = Visibility.Hidden;
                    CM7J1.Visibility = Visibility.Hidden;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador1.Mano.Count == 5)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Visible;
                    CM5J1.Visibility = Visibility.Visible;
                    CM6J1.Visibility = Visibility.Hidden;
                    CM7J1.Visibility = Visibility.Hidden;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador1.Mano.Count == 6)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Visible;
                    CM5J1.Visibility = Visibility.Visible;
                    CM6J1.Visibility = Visibility.Visible;
                    CM7J1.Visibility = Visibility.Hidden;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador1.Mano.Count == 7)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Visible;
                    CM5J1.Visibility = Visibility.Visible;
                    CM6J1.Visibility = Visibility.Visible;
                    CM7J1.Visibility = Visibility.Visible;
                    CM8J1.Visibility = Visibility.Hidden;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador1.Mano.Count == 8)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Visible;
                    CM5J1.Visibility = Visibility.Visible;
                    CM6J1.Visibility = Visibility.Visible;
                    CM7J1.Visibility = Visibility.Visible;
                    CM8J1.Visibility = Visibility.Visible;
                    CM9J1.Visibility = Visibility.Hidden;
                    CM10J1.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador1.Mano.Count == 9)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Visible;
                    CM5J1.Visibility = Visibility.Visible;
                    CM6J1.Visibility = Visibility.Visible;
                    CM7J1.Visibility = Visibility.Visible;
                    CM8J1.Visibility = Visibility.Visible;
                    CM9J1.Visibility = Visibility.Visible;
                    CM10J1.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador1.Mano.Count == 10)
                {
                    CM1J1.Visibility = Visibility.Visible;
                    CM2J1.Visibility = Visibility.Visible;
                    CM3J1.Visibility = Visibility.Visible;
                    CM4J1.Visibility = Visibility.Visible;
                    CM5J1.Visibility = Visibility.Visible;
                    CM6J1.Visibility = Visibility.Visible;
                    CM7J1.Visibility = Visibility.Visible;
                    CM8J1.Visibility = Visibility.Visible;
                    CM9J1.Visibility = Visibility.Visible;
                    CM10J1.Visibility = Visibility.Visible;
                }
            }

            else
            {
                if (juego.jugador2.Mano.Count == 0)
                {
                    CM1J2.Visibility = Visibility.Hidden;
                    CM2J2.Visibility = Visibility.Hidden;
                    CM3J2.Visibility = Visibility.Hidden;
                    CM4J2.Visibility = Visibility.Hidden;
                    CM5J2.Visibility = Visibility.Hidden;
                    CM6J2.Visibility = Visibility.Hidden;
                    CM7J2.Visibility = Visibility.Hidden;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador2.Mano.Count == 1)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Hidden;
                    CM3J2.Visibility = Visibility.Hidden;
                    CM4J2.Visibility = Visibility.Hidden;
                    CM5J2.Visibility = Visibility.Hidden;
                    CM6J2.Visibility = Visibility.Hidden;
                    CM7J2.Visibility = Visibility.Hidden;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador2.Mano.Count == 2)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Hidden;
                    CM4J2.Visibility = Visibility.Hidden;
                    CM5J2.Visibility = Visibility.Hidden;
                    CM6J2.Visibility = Visibility.Hidden;
                    CM7J2.Visibility = Visibility.Hidden;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador2.Mano.Count == 3)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Hidden;
                    CM5J2.Visibility = Visibility.Hidden;
                    CM6J2.Visibility = Visibility.Hidden;
                    CM7J2.Visibility = Visibility.Hidden;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador2.Mano.Count == 4)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Visible;
                    CM5J2.Visibility = Visibility.Hidden;
                    CM6J2.Visibility = Visibility.Hidden;
                    CM7J2.Visibility = Visibility.Hidden;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador2.Mano.Count == 5)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Visible;
                    CM5J2.Visibility = Visibility.Visible;
                    CM6J2.Visibility = Visibility.Hidden;
                    CM7J2.Visibility = Visibility.Hidden;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador2.Mano.Count == 6)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Visible;
                    CM5J2.Visibility = Visibility.Visible;
                    CM6J2.Visibility = Visibility.Visible;
                    CM7J2.Visibility = Visibility.Hidden;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador2.Mano.Count == 7)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Visible;
                    CM5J2.Visibility = Visibility.Visible;
                    CM6J2.Visibility = Visibility.Visible;
                    CM7J2.Visibility = Visibility.Visible;
                    CM8J2.Visibility = Visibility.Hidden;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }

                else if (juego.jugador2.Mano.Count == 8)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Visible;
                    CM5J2.Visibility = Visibility.Visible;
                    CM6J2.Visibility = Visibility.Visible;
                    CM7J2.Visibility = Visibility.Visible;
                    CM8J2.Visibility = Visibility.Visible;
                    CM9J2.Visibility = Visibility.Hidden;
                    CM10J2.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador2.Mano.Count == 9)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Visible;
                    CM5J2.Visibility = Visibility.Visible;
                    CM6J2.Visibility = Visibility.Visible;
                    CM7J2.Visibility = Visibility.Visible;
                    CM8J2.Visibility = Visibility.Visible;
                    CM9J2.Visibility = Visibility.Visible;
                    CM10J2.Visibility = Visibility.Hidden;
                }
                else if (juego.jugador2.Mano.Count == 10)
                {
                    CM1J2.Visibility = Visibility.Visible;
                    CM2J2.Visibility = Visibility.Visible;
                    CM3J2.Visibility = Visibility.Visible;
                    CM4J2.Visibility = Visibility.Visible;
                    CM5J2.Visibility = Visibility.Visible;
                    CM6J2.Visibility = Visibility.Visible;
                    CM7J2.Visibility = Visibility.Visible;
                    CM8J2.Visibility = Visibility.Visible;
                    CM9J2.Visibility = Visibility.Visible;
                    CM10J2.Visibility = Visibility.Visible;
                }
            }


        }

        private void ctvisibles()
        {
            if (juego.jugador1.Tablerojugador.Count == 0)
            {
                CT1J1.Visibility = Visibility.Hidden;
                CT2J1.Visibility = Visibility.Hidden;
                CT3J1.Visibility = Visibility.Hidden;
                CT4J1.Visibility = Visibility.Hidden;
                CT5J1.Visibility = Visibility.Hidden;
                CT6J1.Visibility = Visibility.Hidden;
                CT7J1.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador1.Tablerojugador.Count == 1)
            {
                CT1J1.Visibility = Visibility.Visible;
                CT2J1.Visibility = Visibility.Hidden;
                CT3J1.Visibility = Visibility.Hidden;
                CT4J1.Visibility = Visibility.Hidden;
                CT5J1.Visibility = Visibility.Hidden;
                CT6J1.Visibility = Visibility.Hidden;
                CT7J1.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador1.Tablerojugador.Count == 2)
            {
                CT1J1.Visibility = Visibility.Visible;
                CT2J1.Visibility = Visibility.Visible;
                CT3J1.Visibility = Visibility.Hidden;
                CT4J1.Visibility = Visibility.Hidden;
                CT5J1.Visibility = Visibility.Hidden;
                CT6J1.Visibility = Visibility.Hidden;
                CT7J1.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador1.Tablerojugador.Count == 3)
            {
                CT1J1.Visibility = Visibility.Visible;
                CT2J1.Visibility = Visibility.Visible;
                CT3J1.Visibility = Visibility.Visible;
                CT4J1.Visibility = Visibility.Hidden;
                CT5J1.Visibility = Visibility.Hidden;
                CT6J1.Visibility = Visibility.Hidden;
                CT7J1.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador1.Tablerojugador.Count == 4)
            {
                CT1J1.Visibility = Visibility.Visible;
                CT2J1.Visibility = Visibility.Visible;
                CT3J1.Visibility = Visibility.Visible;
                CT4J1.Visibility = Visibility.Visible;
                CT5J1.Visibility = Visibility.Hidden;
                CT6J1.Visibility = Visibility.Hidden;
                CT7J1.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador1.Tablerojugador.Count == 5)
            {
                CT1J1.Visibility = Visibility.Visible;
                CT2J1.Visibility = Visibility.Visible;
                CT3J1.Visibility = Visibility.Visible;
                CT4J1.Visibility = Visibility.Visible;
                CT5J1.Visibility = Visibility.Visible;
                CT6J1.Visibility = Visibility.Hidden;
                CT7J1.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador1.Tablerojugador.Count == 6)
            {
                CT1J1.Visibility = Visibility.Visible;
                CT2J1.Visibility = Visibility.Visible;
                CT3J1.Visibility = Visibility.Visible;
                CT4J1.Visibility = Visibility.Visible;
                CT5J1.Visibility = Visibility.Visible;
                CT6J1.Visibility = Visibility.Visible;
                CT7J1.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador1.Tablerojugador.Count == 7)
            {
                CT1J1.Visibility = Visibility.Visible;
                CT2J1.Visibility = Visibility.Visible;
                CT3J1.Visibility = Visibility.Visible;
                CT4J1.Visibility = Visibility.Visible;
                CT5J1.Visibility = Visibility.Visible;
                CT6J1.Visibility = Visibility.Visible;
                CT7J1.Visibility = Visibility.Visible;
            }

            if (juego.jugador2.Tablerojugador.Count == 0)
            {
                CT1J2.Visibility = Visibility.Hidden;
                CT2J2.Visibility = Visibility.Hidden;
                CT3J2.Visibility = Visibility.Hidden;
                CT4J2.Visibility = Visibility.Hidden;
                CT5J2.Visibility = Visibility.Hidden;
                CT6J2.Visibility = Visibility.Hidden;
                CT7J2.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador2.Tablerojugador.Count == 1)
            {
                CT1J2.Visibility = Visibility.Visible;
                CT2J2.Visibility = Visibility.Hidden;
                CT3J2.Visibility = Visibility.Hidden;
                CT4J2.Visibility = Visibility.Hidden;
                CT5J2.Visibility = Visibility.Hidden;
                CT6J2.Visibility = Visibility.Hidden;
                CT7J2.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador2.Tablerojugador.Count == 2)
            {
                CT1J2.Visibility = Visibility.Visible;
                CT2J2.Visibility = Visibility.Visible;
                CT3J2.Visibility = Visibility.Hidden;
                CT4J2.Visibility = Visibility.Hidden;
                CT5J2.Visibility = Visibility.Hidden;
                CT6J2.Visibility = Visibility.Hidden;
                CT7J2.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador2.Tablerojugador.Count == 3)
            {
                CT1J2.Visibility = Visibility.Visible;
                CT2J2.Visibility = Visibility.Visible;
                CT3J2.Visibility = Visibility.Visible;
                CT4J2.Visibility = Visibility.Hidden;
                CT5J2.Visibility = Visibility.Hidden;
                CT6J2.Visibility = Visibility.Hidden;
                CT7J2.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador2.Tablerojugador.Count == 4)
            {
                CT1J2.Visibility = Visibility.Visible;
                CT2J2.Visibility = Visibility.Visible;
                CT3J2.Visibility = Visibility.Visible;
                CT4J2.Visibility = Visibility.Visible;
                CT5J2.Visibility = Visibility.Hidden;
                CT6J2.Visibility = Visibility.Hidden;
                CT7J2.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador2.Tablerojugador.Count == 5)
            {
                CT1J2.Visibility = Visibility.Visible;
                CT2J2.Visibility = Visibility.Visible;
                CT3J2.Visibility = Visibility.Visible;
                CT4J2.Visibility = Visibility.Visible;
                CT5J2.Visibility = Visibility.Visible;
                CT6J2.Visibility = Visibility.Hidden;
                CT7J2.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador2.Tablerojugador.Count == 6)
            {
                CT1J2.Visibility = Visibility.Visible;
                CT2J2.Visibility = Visibility.Visible;
                CT3J2.Visibility = Visibility.Visible;
                CT4J2.Visibility = Visibility.Visible;
                CT5J2.Visibility = Visibility.Visible;
                CT6J2.Visibility = Visibility.Visible;
                CT7J2.Visibility = Visibility.Hidden;
            }
            else if (juego.jugador2.Tablerojugador.Count == 7)
            {
                CT1J2.Visibility = Visibility.Visible;
                CT2J2.Visibility = Visibility.Visible;
                CT3J2.Visibility = Visibility.Visible;
                CT4J2.Visibility = Visibility.Visible;
                CT5J2.Visibility = Visibility.Visible;
                CT6J2.Visibility = Visibility.Visible;
                CT7J2.Visibility = Visibility.Visible;
            }
        }

        private void BotonHeroeJ1_Click(object sender, RoutedEventArgs e)
        {
            eleccion = 1;
            IJ2 = -1;

            if (CTJ2 == "CT1J2")
            {
                IJ2 = 0;
            }

            else if (CTJ2 == "CT2J2")
            {
                IJ2 = 1;
            }

            else if (CTJ2 == "CT3J2")
            {
                IJ2 = 2;
            }

            else if (CTJ2 == "CT4J2")
            {
                IJ2 = 3;
            }

            else if (CTJ2 == "CT5J2")
            {
                IJ2 = 4;
            }

            else if (CTJ2 == "CT6J2")
            {
                IJ2 = 5;
            }

            else if (CTJ2 == "CT7J2")
            {
                IJ2 = 6;
            }

            if (IJ2 != -1 && ataquearmaJ2 != 1)
            {
                juego.jugador2.Enfrentar(juego.jugador2, juego.jugador1, IJ2, IJ1, eleccion, juego.dice);
                LabelVidaJ1.Content = juego.jugador1.vida;
                LabelArmorJ1.Content = juego.jugador1.defensa;
                actualizarimagenes();
            }

            else if (ataquearmaJ2 == 1)
            {
                if (armausadaJ2 == 0)
                {
                    DAJ2 -= 1;
                    ataquearmaJ2 = 0;
                    juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 1);
                } 
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ2 = 1;
                LabelArmorJ1.Content = juego.jugador1.defensa;
                LabelVidaJ1.Content = juego.jugador1.vida;
                actualizarimagenes();
            }
            else if (HabPriestJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 1);
                HabPriestJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                LabelVidaJ1.Content = juego.jugador1.vida;
                actualizarimagenes();
            }
            else if (HabDruidMageJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 1);
                HabDruidMageJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                if (juego.jugador2.nombreheroe == "Druid")
                {
                    LabelArmorJ2.Content = juego.jugador2.defensa;
                    LabelArmorJ2.Visibility = Visibility.Visible;
                    Escudo2.Visibility = Visibility.Visible;
                }
                LabelArmorJ1.Content = juego.jugador1.defensa;
                LabelVidaJ1.Content = juego.jugador1.vida;
                actualizarimagenes();
            }

            CTJ2 = "";

        }

        private void BotonHeroeJ2_Click(object sender, RoutedEventArgs e)
        {
            eleccion = 1;
            IJ1 = -1;

            if (CTJ1 == "CT1J1")
            {
                IJ1 = 0;
            }

            else if (CTJ1 == "CT2J1")
            {
                IJ1 = 1;
            }

            else if (CTJ1 == "CT3J1")
            {
                IJ2 = 1;
            }

            else if (CTJ1 == "CT4J1")
            {
                IJ1 = 3;
            }

            else if (CTJ1 == "CT5J1")
            {
                IJ1 = 4;
            }

            else if (CTJ1 == "CT6J1")
            {
                IJ1 = 5;
            }

            else if (CTJ1 == "CT7J1")
            {
                IJ1 = 6;
            }

            if (IJ1 != -1 && ataquearmaJ1 != 1)
            {
                juego.jugador1.Enfrentar(juego.jugador1, juego.jugador2, IJ1, IJ2, eleccion, juego.dice);
                LabelVidaJ2.Content = juego.jugador2.vida;
                LabelArmorJ2.Content = juego.jugador2.defensa;
                actualizarimagenes();
                
            }

            if (ataquearmaJ1 == 1)
            {
                
                if (armausadaJ1 == 0)
                {
                    DAJ1 -= 1;
                    ataquearmaJ1 = 0;
                    juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 1);
                }
                else
                {
                    MessageBox.Show("Ya utilisaste tu arma por este turno");
                }
                armausadaJ1 = 1;
                LabelArmorJ2.Content = juego.jugador2.defensa;
                LabelVidaJ2.Content = juego.jugador2.vida;
                actualizarimagenes();
            }
            else if (HabPriestJ2 == 1)
            {
                juego.jugador2.HabilidadHeroe(juego.jugador2, juego.jugador1, 0, 0, 1);
                HabPriestJ2 = 0;
                LabelGemasJ2.Content = juego.jugador2.gema;
                LabelVidaJ2.Content = juego.jugador1.vida;
                actualizarimagenes();
            }
            else if (HabDruidMageJ1 == 1)
            {
                juego.jugador1.HabilidadHeroe(juego.jugador1, juego.jugador2, 0, 0, 1);
                HabDruidMageJ1 = 0;
                LabelGemasJ1.Content = juego.jugador1.gema;
                if (juego.jugador1.nombreheroe == "Druid")
                {
                    LabelArmorJ1.Content = juego.jugador1.defensa;
                    LabelArmorJ1.Visibility = Visibility.Visible;
                    Escudo1.Visibility = Visibility.Visible;
                }
                LabelArmorJ2.Content = juego.jugador2.defensa;
                LabelVidaJ2.Content = juego.jugador2.vida;
                actualizarimagenes();
            }

            CTJ1 = "";
            
        }

        private void Comenzar2_Click(object sender, RoutedEventArgs e)
        {

            CambioC4.Visibility = Visibility.Visible;
            CambioC5.Visibility = Visibility.Visible;
            CambioC6.Visibility = Visibility.Visible;
            CambioC7.Visibility = Visibility.Visible;

            MostrarCartasCambiot2(juego.jugador2);

            CambioC1.Visibility = Visibility.Hidden;
            CambioC2.Visibility = Visibility.Hidden;
            CambioC3.Visibility = Visibility.Hidden;
            CambioC8.Visibility = Visibility.Hidden;

            Comenzar.Visibility = Visibility.Visible;
            Comenzar2.Visibility = Visibility.Hidden;
            MessageBox.Show("Seleccione las cartas que quiere cambiar");
        }

        private void RendirseJ2_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador2.Rendirse(juego.jugador2, juego.jugador1);

        }

        private void RendirseJ1_Click(object sender, RoutedEventArgs e)
        {
            juego.jugador1.Rendirse(juego.jugador1, juego.jugador2);
        }
    }
}
