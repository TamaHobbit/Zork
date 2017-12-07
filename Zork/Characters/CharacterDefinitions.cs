﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Characters
{
    public static class CharacterDefinitions
    {
        private static Player _player = new Player();

        public static Player PlayerCharacter
        {
            get { return _player; }
        }

        private static List<NPC> _npcs = new List<NPC>() {
            new NPC("sherrif_barney", 3, 100, null, "A fat man in a prim black sherrif's uniform. He has a mustache and short brown hair.")
        };

        public static List<NPC> NPCS
        {
            get { return _npcs; }
        }    
    }
}