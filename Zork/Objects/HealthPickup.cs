﻿using System;
using Zork.Characters;

namespace Zork.Objects
{
    public class HealthPickup : UseableObject
    {
        private int _potency;

        /// <summary>
        /// How many hitpoints are restored upon usage.
        /// </summary>
        public int Potency
        {
            get { return _potency; }
        }

        public override ConsoleColor Color => ConsoleColor.Red;

        public HealthPickup(string name, int potency, string description) : base(name, description)
        {
            _potency = potency;
        }

        public override void UseObject(Character c)
        {
            c.Health = Math.Min(c.MaxHealth, c.Health + Potency);
            if(c is Player && c.Health <= 0)
            {
                Player player = (c as Player);
                player.Die();
                return;
            }
            Console.WriteLine("Ahhh that's refreshing! Health:" + c.Health);
            c.Inventory.Remove(this);
        }
    }
}
