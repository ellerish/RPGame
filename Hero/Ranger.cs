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
    public class Ranger : Hero
    {
        public Ranger() : base() { }

        public Ranger(string name) : base(name)
        {
            SetStartsStats();
        }

        protected override void LevelUp()
        {
            stats.Health += 20;
            stats.Strength += 2;
            stats.Dexterity += 5;
            stats.Intelligence += 1;
        }
    
        protected override void SetStartsStats()
        {
            stats.Health = 120;
            stats.Strength = 5;
            stats.Dexterity = 10;
            stats.Intelligence = 2;
        }

    }
}
