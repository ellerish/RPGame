using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    class Warrior : Hero
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
