using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Armor
{
    //Parent class Armor
    public abstract class Armor
    {
        protected string Name { get; set; }

        public int Level { get; set; }

        public Stats stats;

        //Sets type: Cloth, Leather, Armor
        public ArmorType armorType;

        public Slots ArmorSlot { get; set; }

        public Armor() { }

        public Armor(string name, Slots slot)
        {
            Name = name;
            Level = 1;
            stats = new Stats();
            ArmorSlot = slot;
        }

        //All amors generate baseStats(Attributes)
        protected abstract void SetBaseStats();

        //All amors has a type(Type of armor)
        protected abstract void SetArmorType();


    }
}
