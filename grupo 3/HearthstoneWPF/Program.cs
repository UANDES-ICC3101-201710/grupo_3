﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Proyecto.Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos esbirros


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

            Consola Consola1 = new Consola();
            Consola1.Bienvenida();
            Jugador Jugador1 = new Jugador();
            Jugador Jugador2 = new Jugador();
            Jugador1.identificador = 1;
            Jugador2.identificador = 2;
            Jugador1.nombrejugador = Consola1.Nombrejugador(Jugador1);
            Jugador2.nombrejugador = Consola1.Nombrejugador(Jugador2);
            if(Consola1.ElegirHeroe(Jugador1)==1)
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

            Jugador1.habilidadheroe = Consola1.Asignarhabilidad(Jugador1);
            Jugador2.habilidadheroe = Consola1.Asignarhabilidad(Jugador2);
            Random rnd = new Random();
            Jugador1.turno = 1;
            Jugador2.turno = 2;
            int dice = rnd.Next(1, 3);
            Consola1.Iniciopartida(Jugador1, dice);
            Consola1.Iniciopartida(Jugador2, dice);
            
            Jugador1.vida = 30;
            Jugador2.vida = 30;
            Jugador1.gema = 0;
            Jugador2.gema = 0;
            Jugador1.limitegema = 0;
            Jugador2.limitegema = 0;
            Jugador1.ganper = false;
            Jugador2.ganper = false;
            Jugador1.habilidadusada = false;
            Jugador1.habilidadusada = false;

            Jugador1.Agregarcartamazo(MurlocRaider);
            Jugador1.Agregarcartamazo(Wisp);
            Jugador1.Agregarcartamazo(BloodfenRaptor);
            Jugador1.Agregarcartamazo(RiverCrocolisk);
            Jugador1.Agregarcartamazo(MagmaRager);
            Jugador1.Agregarcartamazo(ChillwindYeti);
            Jugador1.Agregarcartamazo(OasisSnapjaw);
            Jugador1.Agregarcartamazo(BoulderfistOgre);
            Jugador1.Agregarcartamazo(WarGolem);
            Jugador1.Agregarcartamazo(CoreHound);
            Jugador2.Agregarcartamazo(MurlocRaider2);
            Jugador2.Agregarcartamazo(Wisp2);
            Jugador2.Agregarcartamazo(BloodfenRaptor2);
            Jugador2.Agregarcartamazo(RiverCrocolisk2);
            Jugador2.Agregarcartamazo(MagmaRager2);
            Jugador2.Agregarcartamazo(ChillwindYeti2);
            Jugador2.Agregarcartamazo(OasisSnapjaw2);
            Jugador2.Agregarcartamazo(BoulderfistOgre2);
            Jugador2.Agregarcartamazo(WarGolem2);
            Jugador2.Agregarcartamazo(CoreHound2);

            Jugador1.Agregarcartamazo(MurlocRaider3);
            Jugador1.Agregarcartamazo(Wisp3);
            Jugador1.Agregarcartamazo(BloodfenRaptor3);
            Jugador1.Agregarcartamazo(RiverCrocolisk3);
            Jugador1.Agregarcartamazo(MagmaRager3);
            Jugador1.Agregarcartamazo(ChillwindYeti3);
            Jugador1.Agregarcartamazo(OasisSnapjaw3);
            Jugador1.Agregarcartamazo(BoulderfistOgre3);
            Jugador1.Agregarcartamazo(WarGolem3);
            Jugador1.Agregarcartamazo(CoreHound3);
            Jugador2.Agregarcartamazo(MurlocRaider4);
            Jugador2.Agregarcartamazo(Wisp4);
            Jugador2.Agregarcartamazo(BloodfenRaptor4);
            Jugador2.Agregarcartamazo(RiverCrocolisk4);
            Jugador2.Agregarcartamazo(MagmaRager4);
            Jugador2.Agregarcartamazo(ChillwindYeti4);
            Jugador2.Agregarcartamazo(OasisSnapjaw4);
            Jugador2.Agregarcartamazo(BoulderfistOgre4);
            Jugador2.Agregarcartamazo(WarGolem4);
            Jugador2.Agregarcartamazo(CoreHound4);

            Jugador1.Agregarcartamazo(MurlocRaider5);
            Jugador1.Agregarcartamazo(Wisp5);
            Jugador1.Agregarcartamazo(BloodfenRaptor5);
            Jugador1.Agregarcartamazo(RiverCrocolisk5);
            Jugador1.Agregarcartamazo(MagmaRager5);
            Jugador1.Agregarcartamazo(ChillwindYeti5);
            Jugador1.Agregarcartamazo(OasisSnapjaw5);
            Jugador1.Agregarcartamazo(BoulderfistOgre5);
            Jugador1.Agregarcartamazo(WarGolem5);
            Jugador1.Agregarcartamazo(CoreHound5);
            Jugador2.Agregarcartamazo(MurlocRaider6);
            Jugador2.Agregarcartamazo(Wisp6);
            Jugador2.Agregarcartamazo(BloodfenRaptor6);
            Jugador2.Agregarcartamazo(RiverCrocolisk6);
            Jugador2.Agregarcartamazo(MagmaRager6);
            Jugador2.Agregarcartamazo(ChillwindYeti6);
            Jugador2.Agregarcartamazo(OasisSnapjaw6);
            Jugador2.Agregarcartamazo(BoulderfistOgre6);
            Jugador2.Agregarcartamazo(WarGolem6);
            Jugador2.Agregarcartamazo(CoreHound6);

            Jugador1.Shuffle(rnd);
            Jugador2.Shuffle(rnd);
            Jugador1.Agregarcartamano(Consola1);
            Jugador1.Agregarcartamano(Consola1);
            Jugador1.Agregarcartamano(Consola1);
            Jugador2.Agregarcartamano(Consola1);
            Jugador2.Agregarcartamano(Consola1);
            Jugador2.Agregarcartamano(Consola1);
            Jugador1.CambioMano(Jugador1, Consola1, rnd);
            Jugador2.CambioMano(Jugador2, Consola1, rnd);
            TheCoin.OtorgarMoneda(Jugador1, dice, TheCoin);
            TheCoin.OtorgarMoneda(Jugador2, dice, TheCoin);




            while (Jugador1.ganper == false && Jugador2.ganper == false)
            {
                if (dice == Jugador1.turno)
                {
                    Jugador1.Jugar(Jugador1, Jugador2, Consola1);
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
                    Jugador2.Jugar(Jugador2, Jugador1, Consola1);
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

            Console.ReadLine();
            
        }

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
        //Este es un comentario de prueba
    }
}
