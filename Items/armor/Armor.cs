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

        protected int level;

        protected Stats stats;

        protected ArmorType armorType;

        protected Slots slot;

        public Armor() { }

        public Armor(string name)
        {
            this.name = name;
            level = 1;
            stats = new Stats();
        }


        protected abstract void SetBaseStats();

        protected abstract void SetArmorType();

    }
}
