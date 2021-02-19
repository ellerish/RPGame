using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
    public class StatsAttributes
    {
        public int Health { get; set; }
        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Intelligence { get; set; }
        //public abstract void addHealth(int healt);

        public StatsAttributes()
        {
        }

        public StatsAttributes(int health, int strength, int dexterity, int intelligence)
        {
            Health = health;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
