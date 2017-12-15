﻿using System;
using Zork.Characters;

namespace Zork.Objects
{
    public class Clue : BaseObject
    {
        public Clue(string name, string description) : base(name, description)
        {
        }
        

        public override ConsoleColor Color => ConsoleColor.Cyan;

        public override void PickupObject(Character character)
        {
            base.PickupObject(character);
            if (character is Player player)
            {
                player.Clues.Add(Name);
            }
        }
    }
}
