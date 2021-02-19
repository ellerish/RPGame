using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    class Warrior : Hero
    {
        public Warrior() : base() { }

        public Warrior(string name, int level, int experiencePoints) :
            base(name, level, experiencePoints)
        {
        }

        public override void AddBaseStats(StatsAttributes stats)
        {
            stats.Health = 150;
            stats.Strength = 10;
            stats.Dexterity = 3;
            stats.Intelligence = 1;
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
