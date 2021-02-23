using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    /*
   * Inherit from Hero.
   * Set start attributes/stats
   * LevelUp - get extra attributes/stats pr level
  */
    public class Warrior : Hero
    {
        public Warrior() : base() { }

        public Warrior(string name) :
            base(name)
        {
            SetStartsStats();
        }

        protected override void LevelUp()
        {
            stats.Health += 30;
            stats.Strength += 5;
            stats.Dexterity += 2;
            stats.Intelligence += 1;
        }

        protected override void SetStartsStats()
        {
            stats.Health = 150;
            stats.Strength = 10;
            stats.Dexterity = 3;
            stats.Intelligence = 1;
        }
    }
}
