using RPGame.Hero;
using RPGame.Items.ItemSlots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.armor
{
    public abstract class Armor
    {
        protected string name;

        public int level;

        public Stats stats;

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

        protected abstract void SetBaseStats();

        protected abstract void SetArmorType();


    }
}
