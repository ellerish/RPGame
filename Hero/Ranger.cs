using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    class Ranger : Hero
    {
        public Ranger() : base() { }

        public Ranger(string name, int level, int experiencePoints) :
            base(name, level, experiencePoints)
        {
        }

        public override void AddBaseStats(StatsAttributes stats)
        {
            stats.Health = 120;
            stats.Strength = 5;
            stats.Dexterity = 10;
            stats.Intelligence = 2;
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
