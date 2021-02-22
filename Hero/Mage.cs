using RPGame.Items.armor;
using RPGame.Items.ItemSlots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    public class Mage: Hero
    {
        public Mage(): base() { }

        public Mage(string name) : base(name)
        {
           SetStartsStats();
        }

        protected override void LevelUp()
        {
            stats.Health +=  15;
            stats.Strength += 1;
            stats.Dexterity +=  2;
            stats.Intelligence += 5;
        }

        protected override void SetStartsStats()
        {
              stats.Health = 100;
              stats.Strength = 2;
              stats.Dexterity = 3;
              stats.Intelligence = 10;

        }
    }
}
