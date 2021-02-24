using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Armor
{
    //Parent class Armor
    public abstract class Armor
    {
        protected string name;

        public int level;

        public Stats stats;

        //Sets type: Cloth, Leather, Armor
        public ArmorType armorType;

        public Slots slot;

        public Armor() { }

        public Armor(string name, Slots slot)
        {
            this.name = name;
            level = 1;
            stats = new Stats();
            this.slot = slot;
        }

        //All amors generate baseStats(Attributes)
        protected abstract void SetBaseStats();

        //All amors has a type(Type of armor)
        protected abstract void SetArmorType();


    }
}
