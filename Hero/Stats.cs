using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    public class Stats
    {
        public int Health { get; set; }
        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Intelligence { get; set; }

        public Stats()
        {
        }

        public Stats(int health, int strength, int dexterity, int intelligence)
        {
            Health = health;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
