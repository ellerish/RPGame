using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    class Ranger : Hero
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
