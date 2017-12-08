﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zork;
using Zork.Objects;
using System.Collections.Generic;
using System.Drawing;

namespace ZorkUnitTest
{
    [TestClass]
    public class ObjectDefinitionsUnitTests
    {
        [TestMethod]
        public void AddingHealthPickupsTest()
        {
            int sizex = 5;
            int sizey = 5;
            Maze m = new Maze(5,5,0,0);
            ObjectDefinitions.AddItems(m);
            List<BaseObject> objects = new List<BaseObject>();
            
            for (int x = 0; x < sizex; x++)
            {
                for (int y = 0; y < sizey; y++)
                {
                    objects.AddRange(m[new Point(x, y)].ObjectsInRoom);
                }
            }
            HealthPickup hp=null;
            foreach (var item in objects)
            {
                if(item is HealthPickup)
                {
                    hp = item as HealthPickup;
                    break;
                }
            }
            Assert.IsTrue(hp != null);
        }

        public void AddingCluesPickupsTest()
        {
            int sizex = 5;
            int sizey = 5;
            Maze m = new Maze(5, 5, 0, 0);
            ObjectDefinitions.AddItems(m);
            List<BaseObject> objects = new List<BaseObject>();

            for (int x = 0; x < sizex; x++)
            {
                for (int y = 0; y < sizey; y++)
                {
                    objects.AddRange(m[new Point(x, y)].ObjectsInRoom);
                }
            }
            Clue clue = null;
            foreach (var item in objects)
            {
                if (item is Clue)
                {
                    clue = item as Clue;
                    break;
                }
            }
            Assert.IsTrue(clue != null);

        }

        public void AddingWeaponsTest()
        {
            int sizex = 5;
            int sizey = 5;
            Maze m = new Maze(5, 5, 0, 0);
            ObjectDefinitions.AddItems(m);
            List<BaseObject> objects = new List<BaseObject>();

            for (int x = 0; x < sizex; x++)
            {
                for (int y = 0; y < sizey; y++)
                {
                    objects.AddRange(m[new Point(x, y)].ObjectsInRoom);
                }
            }
            Weapon weapon = null;
            foreach (var item in objects)
            {
                if (item is Weapon)
                {
                    weapon = item as Weapon;
                    break;
                }
            }
            Assert.IsTrue(weapon != null);

        }

        /// <summary>
        /// tests if a a weapon is dropped if the dropchance is 100 percent
        /// </summary>
        [TestMethod]
        public void DropChanceTest()
        {
            Assert.IsTrue(ObjectDefinitions.DropChanceByPercentage(100));
        }

      
    }
}