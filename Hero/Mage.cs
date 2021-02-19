using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    public class Mage: Hero
    {
        public Mage(): base() { }

        public Mage(string name, int level, int experiencePoints): 
            base(name, level, experiencePoints)
        {

        }
        public override void AddBaseStats(StatsAttributes stats)
        {
            stats.Health = 100;
            stats.Strength = 2;
            stats.Dexterity = 3;
            stats.Intelligence = 10;
            Console.WriteLine($"HP: {stats.Health}" +
                $" Strenght: {stats.Strength} Dexterity : {stats.Dexterity}" +
                $" Intelligence: {stats.Intelligence} ");

            return;
        }


        public override void LevelUp()
        {
            throw new NotImplementedException();
        }

        //Attributes level 1
        //Health = 100HP
        //STrength = 2
        //Dexterity = 3
        // Intelligence = 10

    }
}
