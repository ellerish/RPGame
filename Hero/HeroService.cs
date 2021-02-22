using RPGame.Items.armor;
using RPGame.Items.ItemSlots;
using RPGame.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    class HeroService: ItemsService
    {
        protected Hero hero;
        protected Armor armor;
       

        public HeroService(Hero hero)
        {
            this.hero = hero;
        }

        public void EquipArmor(Armor armor, Slots slot)
        {
            if (armor.level <= hero.level)
            {
                if (armor.armorType == ArmorType.Cloth)
                {
                    hero.stats.Health += armor.stats.Health;
                    hero.stats.Dexterity += armor.stats.Dexterity;
                    hero.stats.Intelligence += armor.stats.Intelligence;
                }
            }

            else
            {
                Console.Write("You are not on a level to eqiup this");
            }
        }

        public void updateStats()
        {
            
        }

    }
}
