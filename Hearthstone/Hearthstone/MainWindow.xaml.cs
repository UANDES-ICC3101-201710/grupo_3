
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

        private Jugador jugador1;
        public Jugador Jugador1 { get { return jugador1; } }

        private Jugador jugador2;
        public Jugador Jugador2 { get { return jugador2; } }



        public MainWindow()
        {
            //Datos esbirros


            this.jugador1 = new Jugador();
            this.jugador2 = new Jugador();


            Esbirro Wisp = new Esbirro();
            Wisp.nombre = "Wisp";
            Wisp.costo = 0;
            Wisp.ataque = 1;
            Wisp.defensa = 1;
            Wisp.tipo = "Esbirro";
            Wisp.subtipo = null;
            Wisp.despierto = false;
            Wisp.ataco = false;


            Esbirro MurlocRaider = new Esbirro();

            MurlocRaider.nombre = "Murloc Raider";
            MurlocRaider.costo = 1;
            MurlocRaider.ataque = 2;
            MurlocRaider.defensa = 1;
            MurlocRaider.tipo = "Esbirro";
            MurlocRaider.subtipo = "Murloc";
            MurlocRaider.despierto = false;
            MurlocRaider.ataco = false;


            Esbirro BloodfenRaptor = new Esbirro();

            BloodfenRaptor.nombre = "Bloodfen Raptor";
            BloodfenRaptor.costo = 2;
            BloodfenRaptor.ataque = 3;
            BloodfenRaptor.defensa = 2;
            BloodfenRaptor.tipo = "Esbirro";
            BloodfenRaptor.subtipo = "Bestia";
            BloodfenRaptor.despierto = false;
            BloodfenRaptor.ataco = false;

            Esbirro RiverCrocolisk = new Esbirro();

            RiverCrocolisk.nombre = "River Crocolisk";
            RiverCrocolisk.costo = 2;
            RiverCrocolisk.ataque = 2;
            RiverCrocolisk.defensa = 3;
            RiverCrocolisk.tipo = "Esbirro";
            RiverCrocolisk.subtipo = "Bestia";
            RiverCrocolisk.despierto = false;
            RiverCrocolisk.ataco = false;

            Esbirro MagmaRager = new Esbirro();

            MagmaRager.nombre = "Magma Rager";
            MagmaRager.costo = 3;
            MagmaRager.ataque = 5;
            MagmaRager.defensa = 1;
            MagmaRager.tipo = "Esbirro";
            MagmaRager.subtipo = "Elemental";
            MagmaRager.despierto = false;
            MagmaRager.ataco = false;

            Esbirro ChillwindYeti = new Esbirro();

            ChillwindYeti.nombre = "Chillwind Yeti";
            ChillwindYeti.costo = 4;
            ChillwindYeti.ataque = 4;
            ChillwindYeti.defensa = 5;
            ChillwindYeti.tipo = "Esbirro";
            ChillwindYeti.subtipo = null;
            ChillwindYeti.despierto = false;
            ChillwindYeti.ataco = false;

            Esbirro OasisSnapjaw = new Esbirro();

            OasisSnapjaw.nombre = "Oasis Snapjaw";
            OasisSnapjaw.costo = 4;
            OasisSnapjaw.ataque = 2;
            OasisSnapjaw.defensa = 7;
            OasisSnapjaw.tipo = "Esbirro";
            OasisSnapjaw.subtipo = "Bestia";
            OasisSnapjaw.despierto = false;
            OasisSnapjaw.ataco = false;

            Esbirro BoulderfistOgre = new Esbirro();

            BoulderfistOgre.nombre = "Boulderfist Ogre";
            BoulderfistOgre.costo = 6;
            BoulderfistOgre.ataque = 6;
            BoulderfistOgre.defensa = 7;
            BoulderfistOgre.tipo = "Esbirro";
            BoulderfistOgre.subtipo = null;
            BoulderfistOgre.despierto = false;
            BoulderfistOgre.ataco = false;

            Esbirro WarGolem = new Esbirro();

            WarGolem.nombre = "War Golem";
            WarGolem.costo = 7;
            WarGolem.ataque = 7;
            WarGolem.defensa = 7;
            WarGolem.tipo = "Esbirro";
            WarGolem.subtipo = null;
            WarGolem.despierto = false;
            WarGolem.ataco = false;

            Esbirro CoreHound = new Esbirro();

            CoreHound.nombre = "Core Hound";
            CoreHound.costo = 7;
            CoreHound.ataque = 9;
            CoreHound.defensa = 5;
            CoreHound.tipo = "Esbirro";
            CoreHound.subtipo = "Bestia";
            CoreHound.despierto = false;
            CoreHound.ataco = false;

            Esbirro Wisp2 = new Esbirro();

            Wisp2.nombre = "Wisp";
            Wisp2.costo = 0;
            Wisp2.ataque = 1;
            Wisp2.defensa = 1;
            Wisp2.tipo = "Esbirro";
            Wisp2.subtipo = null;
            Wisp2.despierto = false;
            Wisp2.ataco = false;


            Esbirro MurlocRaider2 = new Esbirro();

            MurlocRaider2.nombre = "Murloc Raider";
            MurlocRaider2.costo = 1;
            MurlocRaider2.ataque = 2;
            MurlocRaider2.defensa = 1;
            MurlocRaider2.tipo = "Esbirro";
            MurlocRaider2.subtipo = "Murloc";
            MurlocRaider2.despierto = false;
            MurlocRaider2.ataco = false;


            Esbirro BloodfenRaptor2 = new Esbirro();

            BloodfenRaptor2.nombre = "Bloodfen Raptor";
            BloodfenRaptor2.costo = 2;
            BloodfenRaptor2.ataque = 3;
            BloodfenRaptor2.defensa = 2;
            BloodfenRaptor2.tipo = "Esbirro";
            BloodfenRaptor2.subtipo = "Bestia";
            BloodfenRaptor2.despierto = false;
            BloodfenRaptor2.ataco = false;

            Esbirro RiverCrocolisk2 = new Esbirro();

            RiverCrocolisk2.nombre = "River Crocolisk";
            RiverCrocolisk2.costo = 2;
            RiverCrocolisk2.ataque = 2;
            RiverCrocolisk2.defensa = 3;
            RiverCrocolisk2.tipo = "Esbirro";
            RiverCrocolisk2.subtipo = "Bestia";
            RiverCrocolisk2.despierto = false;
            RiverCrocolisk2.ataco = false;

            Esbirro MagmaRager2 = new Esbirro();

            MagmaRager2.nombre = "Magma Rager";
            MagmaRager2.costo = 3;
            MagmaRager2.ataque = 5;
            MagmaRager2.defensa = 1;
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
            ChillwindYeti2.subtipo = null;
            ChillwindYeti2.despierto = false;
            ChillwindYeti2.ataco = false;

            Esbirro OasisSnapjaw2 = new Esbirro();

            OasisSnapjaw2.nombre = "Oasis Snapjaw";
            OasisSnapjaw2.costo = 4;
            OasisSnapjaw2.ataque = 2;
            OasisSnapjaw2.defensa = 7;
            OasisSnapjaw2.tipo = "Esbirro";
            OasisSnapjaw2.subtipo = "Bestia";
            OasisSnapjaw2.despierto = false;
            OasisSnapjaw2.ataco = false;

            Esbirro BoulderfistOgre2 = new Esbirro();

            BoulderfistOgre2.nombre = "Boulderfist Ogre";
            BoulderfistOgre2.costo = 6;
            BoulderfistOgre2.ataque = 6;
            BoulderfistOgre2.defensa = 7;
            BoulderfistOgre2.tipo = "Esbirro";
            BoulderfistOgre2.subtipo = null;
            BoulderfistOgre2.despierto = false;
            BoulderfistOgre2.ataco = false;

            Esbirro WarGolem2 = new Esbirro();

            WarGolem2.nombre = "War Golem";
            WarGolem2.costo = 7;
            WarGolem2.ataque = 7;
            WarGolem2.defensa = 7;
            WarGolem2.tipo = "Esbirro";
            WarGolem2.subtipo = null;
            WarGolem2.despierto = false;
            WarGolem2.ataco = false;

            Esbirro CoreHound2 = new Esbirro();

            CoreHound2.nombre = "Core Hound";
            CoreHound2.costo = 7;
            CoreHound2.ataque = 9;
            CoreHound2.defensa = 5;
            CoreHound2.tipo = "Esbirro";
            CoreHound2.subtipo = "Bestia";
            CoreHound2.despierto = false;
            CoreHound2.ataco = false;

            Esbirro Wisp3 = new Esbirro();

            Wisp3.nombre = "Wisp";
            Wisp3.costo = 0;
            Wisp3.ataque = 1;
            Wisp3.defensa = 1;
            Wisp3.tipo = "Esbirro";
            Wisp3.subtipo = null;
            Wisp3.despierto = false;
            Wisp3.ataco = false;


            Esbirro MurlocRaider3 = new Esbirro();

            MurlocRaider3.nombre = "Murloc Raider";
            MurlocRaider3.costo = 1;
            MurlocRaider3.ataque = 2;
            MurlocRaider3.defensa = 1;
            MurlocRaider3.tipo = "Esbirro";
            MurlocRaider3.subtipo = "Murloc";
            MurlocRaider3.despierto = false;
            MurlocRaider3.ataco = false;


            Esbirro BloodfenRaptor3 = new Esbirro();

            BloodfenRaptor3.nombre = "Bloodfen Raptor";
            BloodfenRaptor3.costo = 2;
            BloodfenRaptor3.ataque = 3;
            BloodfenRaptor3.defensa = 2;
            BloodfenRaptor3.tipo = "Esbirro";
            BloodfenRaptor3.subtipo = "Bestia";
            BloodfenRaptor3.despierto = false;
            BloodfenRaptor3.ataco = false;

            Esbirro RiverCrocolisk3 = new Esbirro();

            RiverCrocolisk3.nombre = "River Crocolisk";
            RiverCrocolisk3.costo = 2;
            RiverCrocolisk3.ataque = 2;
            RiverCrocolisk3.defensa = 3;
            RiverCrocolisk3.tipo = "Esbirro";
            RiverCrocolisk3.subtipo = "Bestia";
            RiverCrocolisk3.despierto = false;
            RiverCrocolisk3.ataco = false;

            Esbirro MagmaRager3 = new Esbirro();

            MagmaRager3.nombre = "Magma Rager";
            MagmaRager3.costo = 3;
            MagmaRager3.ataque = 5;
            MagmaRager3.defensa = 1;
            MagmaRager3.tipo = "Esbirro";
            MagmaRager3.subtipo = "Elemental";
            MagmaRager3.despierto = false;
            MagmaRager3.ataco = false;

            Esbirro ChillwindYeti3 = new Esbirro();

            ChillwindYeti3.nombre = "Chillwind Yeti";
            ChillwindYeti3.costo = 4;
            ChillwindYeti3.ataque = 4;
            ChillwindYeti3.defensa = 5;
            ChillwindYeti3.tipo = "Esbirro";
            ChillwindYeti3.subtipo = null;
            ChillwindYeti3.despierto = false;
            ChillwindYeti3.ataco = false;

            Esbirro OasisSnapjaw3 = new Esbirro();

            OasisSnapjaw3.nombre = "Oasis Snapjaw";
            OasisSnapjaw3.costo = 4;
            OasisSnapjaw3.ataque = 2;
            OasisSnapjaw3.defensa = 7;
            OasisSnapjaw3.tipo = "Esbirro";
            OasisSnapjaw3.subtipo = "Bestia";
            OasisSnapjaw3.despierto = false;
            OasisSnapjaw3.ataco = false;

            Esbirro BoulderfistOgre3 = new Esbirro();

            BoulderfistOgre3.nombre = "Boulderfist Ogre";
            BoulderfistOgre3.costo = 6;
            BoulderfistOgre3.ataque = 6;
            BoulderfistOgre3.defensa = 7;
            BoulderfistOgre3.tipo = "Esbirro";
            BoulderfistOgre3.subtipo = null;
            BoulderfistOgre3.despierto = false;
            BoulderfistOgre3.ataco = false;

            Esbirro WarGolem3 = new Esbirro();

            WarGolem3.nombre = "War Golem";
            WarGolem3.costo = 7;
            WarGolem3.ataque = 7;
            WarGolem3.defensa = 7;
            WarGolem3.tipo = "Esbirro";
            WarGolem3.subtipo = null;
            WarGolem3.despierto = false;
            WarGolem3.ataco = false;

            Esbirro CoreHound3 = new Esbirro();

            CoreHound3.nombre = "Core Hound";
            CoreHound3.costo = 7;
            CoreHound3.ataque = 9;
            CoreHound3.defensa = 5;
            CoreHound3.tipo = "Esbirro";
            CoreHound3.subtipo = "Bestia";
            CoreHound3.despierto = false;
            CoreHound3.ataco = false;

            Esbirro Wisp4 = new Esbirro();

            Wisp4.nombre = "Wisp";
            Wisp4.costo = 0;
            Wisp4.ataque = 1;
            Wisp4.defensa = 1;
            Wisp4.tipo = "Esbirro";
            Wisp4.subtipo = null;
            Wisp4.despierto = false;
            Wisp4.ataco = false;


            Esbirro MurlocRaider4 = new Esbirro();

            MurlocRaider4.nombre = "Murloc Raider";
            MurlocRaider4.costo = 1;
            MurlocRaider4.ataque = 2;
            MurlocRaider4.defensa = 1;
            MurlocRaider4.tipo = "Esbirro";
            MurlocRaider4.subtipo = "Murloc";
            MurlocRaider4.despierto = false;
            MurlocRaider4.ataco = false;


            Esbirro BloodfenRaptor4 = new Esbirro();

            BloodfenRaptor4.nombre = "Bloodfen Raptor";
            BloodfenRaptor4.costo = 2;
            BloodfenRaptor4.ataque = 3;
            BloodfenRaptor4.defensa = 2;
            BloodfenRaptor4.tipo = "Esbirro";
            BloodfenRaptor4.subtipo = "Bestia";
            BloodfenRaptor4.despierto = false;
            BloodfenRaptor4.ataco = false;

            Esbirro RiverCrocolisk4 = new Esbirro();

            RiverCrocolisk4.nombre = "River Crocolisk";
            RiverCrocolisk4.costo = 2;
            RiverCrocolisk4.ataque = 2;
            RiverCrocolisk4.defensa = 3;
            RiverCrocolisk4.tipo = "Esbirro";
            RiverCrocolisk4.subtipo = "Bestia";
            RiverCrocolisk4.despierto = false;
            RiverCrocolisk4.ataco = false;

            Esbirro MagmaRager4 = new Esbirro();

            MagmaRager4.nombre = "Magma Rager";
            MagmaRager4.costo = 3;
            MagmaRager4.ataque = 5;
            MagmaRager4.defensa = 1;
            MagmaRager4.tipo = "Esbirro";
            MagmaRager4.subtipo = "Elemental";
            MagmaRager4.despierto = false;
            MagmaRager4.ataco = false;

            Esbirro ChillwindYeti4 = new Esbirro();

            ChillwindYeti4.nombre = "Chillwind Yeti";
            ChillwindYeti4.costo = 4;
            ChillwindYeti4.ataque = 4;
            ChillwindYeti4.defensa = 5;
            ChillwindYeti4.tipo = "Esbirro";
            ChillwindYeti4.subtipo = null;
            ChillwindYeti4.despierto = false;
            ChillwindYeti4.ataco = false;

            Esbirro OasisSnapjaw4 = new Esbirro();

            OasisSnapjaw4.nombre = "Oasis Snapjaw";
            OasisSnapjaw4.costo = 4;
            OasisSnapjaw4.ataque = 2;
            OasisSnapjaw4.defensa = 7;
            OasisSnapjaw4.tipo = "Esbirro";
            OasisSnapjaw4.subtipo = "Bestia";
            OasisSnapjaw4.despierto = false;
            OasisSnapjaw4.ataco = false;

            Esbirro BoulderfistOgre4 = new Esbirro();

            BoulderfistOgre4.nombre = "Boulderfist Ogre";
            BoulderfistOgre4.costo = 6;
            BoulderfistOgre4.ataque = 6;
            BoulderfistOgre4.defensa = 7;
            BoulderfistOgre4.tipo = "Esbirro";
            BoulderfistOgre4.subtipo = null;
            BoulderfistOgre4.despierto = false;
            BoulderfistOgre4.ataco = false;

            Esbirro WarGolem4 = new Esbirro();

            WarGolem4.nombre = "War Golem";
            WarGolem4.costo = 7;
            WarGolem4.ataque = 7;
            WarGolem4.defensa = 7;
            WarGolem4.tipo = "Esbirro";
            WarGolem4.subtipo = null;
            WarGolem4.despierto = false;
            WarGolem4.ataco = false;

            Esbirro CoreHound4 = new Esbirro();

            CoreHound4.nombre = "Core Hound";
            CoreHound4.costo = 7;
            CoreHound4.ataque = 9;
            CoreHound4.defensa = 5;
            CoreHound4.tipo = "Esbirro";
            CoreHound4.subtipo = "Bestia";
            CoreHound4.despierto = false;
            CoreHound4.ataco = false;

            Esbirro Wisp5 = new Esbirro();

            Wisp5.nombre = "Wisp";
            Wisp5.costo = 0;
            Wisp5.ataque = 1;
            Wisp5.defensa = 1;
            Wisp5.tipo = "Esbirro";
            Wisp5.subtipo = null;
            Wisp5.despierto = false;
            Wisp5.ataco = false;


            Esbirro MurlocRaider5 = new Esbirro();

            MurlocRaider5.nombre = "Murloc Raider";
            MurlocRaider5.costo = 1;
            MurlocRaider5.ataque = 2;
            MurlocRaider5.defensa = 1;
            MurlocRaider5.tipo = "Esbirro";
            MurlocRaider5.subtipo = "Murloc";
            MurlocRaider5.despierto = false;
            MurlocRaider5.ataco = false;


            Esbirro BloodfenRaptor5 = new Esbirro();

            BloodfenRaptor5.nombre = "Bloodfen Raptor";
            BloodfenRaptor5.costo = 2;
            BloodfenRaptor5.ataque = 3;
            BloodfenRaptor5.defensa = 2;
            BloodfenRaptor5.tipo = "Esbirro";
            BloodfenRaptor5.subtipo = "Bestia";
            BloodfenRaptor5.despierto = false;
            BloodfenRaptor5.ataco = false;

            Esbirro RiverCrocolisk5 = new Esbirro();

            RiverCrocolisk5.nombre = "River Crocolisk";
            RiverCrocolisk5.costo = 2;
            RiverCrocolisk5.ataque = 2;
            RiverCrocolisk5.defensa = 3;
            RiverCrocolisk5.tipo = "Esbirro";
            RiverCrocolisk5.subtipo = "Bestia";
            RiverCrocolisk5.despierto = false;
            RiverCrocolisk5.ataco = false;

            Esbirro MagmaRager5 = new Esbirro();

            MagmaRager5.nombre = "Magma Rager";
            MagmaRager5.costo = 3;
            MagmaRager5.ataque = 5;
            MagmaRager5.defensa = 1;
            MagmaRager5.tipo = "Esbirro";
            MagmaRager5.subtipo = "Elemental";
            MagmaRager5.despierto = false;
            MagmaRager5.ataco = false;

            Esbirro ChillwindYeti5 = new Esbirro();

            ChillwindYeti5.nombre = "Chillwind Yeti";
            ChillwindYeti5.costo = 4;
            ChillwindYeti5.ataque = 4;
            ChillwindYeti5.defensa = 5;
            ChillwindYeti5.tipo = "Esbirro";
            ChillwindYeti5.subtipo = null;
            ChillwindYeti5.despierto = false;
            ChillwindYeti5.ataco = false;

            Esbirro OasisSnapjaw5 = new Esbirro();

            OasisSnapjaw5.nombre = "Oasis Snapjaw";
            OasisSnapjaw5.costo = 4;
            OasisSnapjaw5.ataque = 2;
            OasisSnapjaw5.defensa = 7;
            OasisSnapjaw5.tipo = "Esbirro";
            OasisSnapjaw5.subtipo = "Bestia";
            OasisSnapjaw5.despierto = false;
            OasisSnapjaw5.ataco = false;

            Esbirro BoulderfistOgre5 = new Esbirro();

            BoulderfistOgre5.nombre = "Boulderfist Ogre";
            BoulderfistOgre5.costo = 6;
            BoulderfistOgre5.ataque = 6;
            BoulderfistOgre5.defensa = 7;
            BoulderfistOgre5.tipo = "Esbirro";
            BoulderfistOgre5.subtipo = null;
            BoulderfistOgre5.despierto = false;
            BoulderfistOgre5.ataco = false;

            Esbirro WarGolem5 = new Esbirro();

            WarGolem5.nombre = "War Golem";
            WarGolem5.costo = 7;
            WarGolem5.ataque = 7;
            WarGolem5.defensa = 7;
            WarGolem5.tipo = "Esbirro";
            WarGolem5.subtipo = null;
            WarGolem5.despierto = false;
            WarGolem5.ataco = false;

            Esbirro CoreHound5 = new Esbirro();

            CoreHound5.nombre = "Core Hound";
            CoreHound5.costo = 7;
            CoreHound5.ataque = 9;
            CoreHound5.defensa = 5;
            CoreHound5.tipo = "Esbirro";
            CoreHound5.subtipo = "Bestia";
            CoreHound5.despierto = false;
            CoreHound5.ataco = false;

            Esbirro Wisp6 = new Esbirro();

            Wisp6.nombre = "Wisp";
            Wisp6.costo = 0;
            Wisp6.ataque = 1;
            Wisp6.defensa = 1;
            Wisp6.tipo = "Esbirro";
            Wisp6.subtipo = null;
            Wisp6.despierto = false;
            Wisp6.ataco = false;


            Esbirro MurlocRaider6 = new Esbirro();

            MurlocRaider6.nombre = "Murloc Raider";
            MurlocRaider6.costo = 1;
            MurlocRaider6.ataque = 2;
            MurlocRaider6.defensa = 1;
            MurlocRaider6.tipo = "Esbirro";
            MurlocRaider6.subtipo = "Murloc";
            MurlocRaider6.despierto = false;
            MurlocRaider6.ataco = false;


            Esbirro BloodfenRaptor6 = new Esbirro();

            BloodfenRaptor6.nombre = "Bloodfen Raptor";
            BloodfenRaptor6.costo = 2;
            BloodfenRaptor6.ataque = 3;
            BloodfenRaptor6.defensa = 2;
            BloodfenRaptor6.tipo = "Esbirro";
            BloodfenRaptor6.subtipo = "Bestia";
            BloodfenRaptor6.despierto = false;
            BloodfenRaptor6.ataco = false;

            Esbirro RiverCrocolisk6 = new Esbirro();

            RiverCrocolisk6.nombre = "River Crocolisk";
            RiverCrocolisk6.costo = 2;
            RiverCrocolisk6.ataque = 2;
            RiverCrocolisk6.defensa = 3;
            RiverCrocolisk6.tipo = "Esbirro";
            RiverCrocolisk6.subtipo = "Bestia";
            RiverCrocolisk6.despierto = false;
            RiverCrocolisk6.ataco = false;

            Esbirro MagmaRager6 = new Esbirro();

            MagmaRager6.nombre = "Magma Rager";
            MagmaRager6.costo = 3;
            MagmaRager6.ataque = 5;
            MagmaRager6.defensa = 1;
            MagmaRager6.tipo = "Esbirro";
            MagmaRager6.subtipo = "Elemental";
            MagmaRager6.despierto = false;
            MagmaRager6.ataco = false;

            Esbirro ChillwindYeti6 = new Esbirro();

            ChillwindYeti6.nombre = "Chillwind Yeti";
            ChillwindYeti6.costo = 4;
            ChillwindYeti6.ataque = 4;
            ChillwindYeti6.defensa = 5;
            ChillwindYeti6.tipo = "Esbirro";
            ChillwindYeti6.subtipo = null;
            ChillwindYeti6.despierto = false;
            ChillwindYeti6.ataco = false;

            Esbirro OasisSnapjaw6 = new Esbirro();

            OasisSnapjaw6.nombre = "Oasis Snapjaw";
            OasisSnapjaw6.costo = 4;
            OasisSnapjaw6.ataque = 2;
            OasisSnapjaw6.defensa = 7;
            OasisSnapjaw6.tipo = "Esbirro";
            OasisSnapjaw6.subtipo = "Bestia";
            OasisSnapjaw6.despierto = false;
            OasisSnapjaw6.ataco = false;

            Esbirro BoulderfistOgre6 = new Esbirro();

            BoulderfistOgre6.nombre = "Boulderfist Ogre";
            BoulderfistOgre6.costo = 6;
            BoulderfistOgre6.ataque = 6;
            BoulderfistOgre6.defensa = 7;
            BoulderfistOgre6.tipo = "Esbirro";
            BoulderfistOgre6.subtipo = null;
            BoulderfistOgre6.despierto = false;
            BoulderfistOgre6.ataco = false;

            Esbirro WarGolem6 = new Esbirro();

            WarGolem6.nombre = "War Golem";
            WarGolem6.costo = 7;
            WarGolem6.ataque = 7;
            WarGolem6.defensa = 7;
            WarGolem6.tipo = "Esbirro";
            WarGolem6.subtipo = null;
            WarGolem6.despierto = false;
            WarGolem6.ataco = false;

            Esbirro CoreHound6 = new Esbirro();

            CoreHound6.nombre = "Core Hound";
            CoreHound6.costo = 7;
            CoreHound6.ataque = 9;
            CoreHound6.defensa = 5;
            CoreHound6.tipo = "Esbirro";
            CoreHound6.subtipo = "Bestia";
            CoreHound6.despierto = false;
            CoreHound6.ataco = false;

            //Datos Moneda
            Hechizo TheCoin = new Hechizo();

            TheCoin.nombre = "The Coin";
            TheCoin.costo = 0;
            TheCoin.tipo = "Hechizo";
            TheCoin.habilidad = "Gana una gema por este Turno";


            jugador1.identificador = 1;
            jugador2.identificador = 2;
            //Jugador1.nombrejugador = Consola1.Nombrejugador(Jugador1);
            //Jugador2.nombrejugador = Consola1.Nombrejugador(Jugador2);
            /*if (Consola1.ElegirHeroe(Jugador1) == 1)
            {
                Jugador1.nombreheroe = "Warrior";
            }
            else
            {
                Jugador1.nombreheroe = "Hunter";
            }

            if (Consola1.ElegirHeroe(Jugador2) == 1)
            {
                Jugador2.nombreheroe = "Warrior";
            }
            else
            {
                Jugador2.nombreheroe = "Hunter";
            }
            */

            //Jugador1.habilidadheroe = Consola1.Asignarhabilidad(Jugador1);
            //Jugador2.habilidadheroe = Consola1.Asignarhabilidad(Jugador2);
            Random rnd = new Random();
            jugador1.turno = 1;
            jugador2.turno = 2;
            int dice = rnd.Next(1, 3);
            //Consola1.Iniciopartida(Jugador1, dice);
            //Consola1.Iniciopartida(Jugador2, dice);

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
            jugador1.CambioMano(Jugador1, rnd);
            jugador2.CambioMano(Jugador2, rnd);
            TheCoin.OtorgarMoneda(Jugador1, dice, TheCoin);
            TheCoin.OtorgarMoneda(Jugador2, dice, TheCoin);


            /*
            
            while (Jugador1.ganper == false && Jugador2.ganper == false)
            {
                if (dice == Jugador1.turno)
                {
                    Jugador1.Jugar(Jugador1, Jugador2);
                    if (dice == 1)
                    {
                        dice = 2;
                    }
                    else
                    {
                        dice = 1;
                    }
                }
                else
                {
                    Jugador2.Jugar(Jugador2, Jugador1);
                    if (dice == 1)
                    {
                        dice = 2;
                    }
                    else
                    {
                        dice = 1;
                    }
                }

            }

          */

            InitializeComponent();

        }


        string HeroeJ1 { get; set; }
        string HeroeJ2 { get; set; }

        public static void SaveGame(Jugador Game)
        {
            Console.WriteLine("Nombre del archivo: ");
            string fileName = Console.ReadLine();
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Game);
            fs.Close();
        }

        public static Jugador LoadGame()
        {
            Console.WriteLine("Nombre del archivo: ");
            string fileName = Console.ReadLine();
            FileStream fs = new FileStream(fileName, FileMode.Open);

            IFormatter formatter = new BinaryFormatter();
            Jugador Game = formatter.Deserialize(fs) as Jugador;
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
            imagen1.Visibility = Visibility.Visible;
            imagen2.Visibility = Visibility.Visible;
            imagen3.Visibility = Visibility.Visible;
            imagen4.Visibility = Visibility.Visible;
            imagen5.Visibility = Visibility.Visible;
            imagen6.Visibility = Visibility.Visible;
            Bcambiar1.Visibility = Visibility.Visible;
            Bcambiar2.Visibility = Visibility.Visible;
            Bcambiar3.Visibility = Visibility.Visible;
            Bcambiar4.Visibility = Visibility.Visible;
            Bcambiar5.Visibility = Visibility.Visible;
            Bcambiar6.Visibility = Visibility.Visible;
            Seguir.Visibility = Visibility.Visible;


            if ((string)nheroe1.Content == "Druid")
            {
                Druid1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Hunter")
            {
                Hunter1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Mage")
            {
                Mage1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Paladin")
            {
                Paladin1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Priest")
            {
                Priest1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Rogue")
            {
                Rogue1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Shaman")
            {
                Shaman1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Warlock")
            {
                Warlock1.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe1.Content == "Warrior")
            {
                Warrior1.Visibility = Visibility.Visible;
            }
            if ((string)nheroe2.Content == "Druid")
            {
                Druid2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Hunter")
            {
                Hunter2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Mage")
            {
                Mage2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Paladin")
            {
                Paladin2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Priest")
            {
                Priest2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Rogue")
            {
                Rogue2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Shaman")
            {
                Shaman2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Warlock")
            {
                Warlock2.Visibility = Visibility.Visible;
            }
            else if ((string)nheroe2.Content == "Warrior")
            {
                Warrior2.Visibility = Visibility.Visible;
            }

            Jug1.Content = label21.Content;
            Jug2.Content = label22.Content;
            Jug1.Visibility = Visibility.Visible;
            Jug2.Visibility = Visibility.Visible;



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
                nheroe2.Content = "Druid";
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

        private void Cambiar1(object sender, RoutedEventArgs e)
        {
            imagen6.Visibility = Visibility.Hidden;
            Bcambiar1.Visibility = Visibility.Hidden;
            Cambio1.Visibility = Visibility.Visible;

        }

        private void Cambiar2(object sender, RoutedEventArgs e)
        {
            imagen4.Visibility = Visibility.Hidden;
            Bcambiar2.Visibility = Visibility.Hidden;
            Cambio2.Visibility = Visibility.Visible;
        }

        private void Cambiar3(object sender, RoutedEventArgs e)
        {
            imagen5.Visibility = Visibility.Hidden;
            Bcambiar3.Visibility = Visibility.Hidden;
            Cambio3.Visibility = Visibility.Visible;
        }

        private void Cambiar4(object sender, RoutedEventArgs e)
        {
            imagen1.Visibility = Visibility.Hidden;
            Bcambiar4.Visibility = Visibility.Hidden;
            Cambio4.Visibility = Visibility.Visible;
        }

        private void Cambiar5(object sender, RoutedEventArgs e)
        {
            imagen2.Visibility = Visibility.Hidden;
            Bcambiar5.Visibility = Visibility.Hidden;
            Cambio5.Visibility = Visibility.Visible;
        }

        private void Cambiar6(object sender, RoutedEventArgs e)
        {
            imagen3.Visibility = Visibility.Hidden;
            Bcambiar6.Visibility = Visibility.Hidden;
            Cambio6.Visibility = Visibility.Visible;
        }

        private void Seguir_Click(object sender, RoutedEventArgs e)
        {
            Cambio1.Visibility = Visibility.Hidden;
            Cambio2.Visibility = Visibility.Hidden;
            Cambio3.Visibility = Visibility.Hidden;
            Cambio4.Visibility = Visibility.Hidden;
            Cambio5.Visibility = Visibility.Hidden;
            Cambio6.Visibility = Visibility.Hidden;
            imagen1.Visibility = Visibility.Hidden;
            imagen2.Visibility = Visibility.Hidden;
            imagen3.Visibility = Visibility.Hidden;
            imagen4.Visibility = Visibility.Hidden;
            imagen5.Visibility = Visibility.Hidden;
            imagen6.Visibility = Visibility.Hidden;
            Bcambiar1.Visibility = Visibility.Hidden;
            Bcambiar2.Visibility = Visibility.Hidden;
            Bcambiar3.Visibility = Visibility.Hidden;
            Bcambiar4.Visibility = Visibility.Hidden;
            Bcambiar5.Visibility = Visibility.Hidden;
            Bcambiar6.Visibility = Visibility.Hidden;

        }
    }
}
