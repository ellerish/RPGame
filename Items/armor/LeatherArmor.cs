﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Armor
{
    //Inherit from parent: Armor
    class LeatherArmor : Armor
    {

        public LeatherArmor() : base() { }

        //Sets type and base attributes(stats) on creation
        public LeatherArmor(string name, Slots slot) : base(name, slot)
        {
            SetBaseStats();
            SetArmorType();
        }

        protected override void SetArmorType()
        {
            armorType = ArmorType.Leather;
        }

        protected override void SetBaseStats()
        {
            stats.Health = 20;
            stats.Dexterity = 3;
            stats.Strength = 1;
        }

        //Calculate new attributes(stats) based on level and slot
        public void ScaleStatsByLevelAndSlot(int level)
        {
            double result = (stats.Health + 8 * level) * (int)ArmorSlot / 100;
            stats.Health = (int)Math.Floor(result);

            double resultDex = (stats.Dexterity + 2 * level) * (int)ArmorSlot / 100;
            stats.Dexterity = (int)Math.Floor(resultDex);

            double resultStrength = (stats.Strength + 1 * level) * (int)ArmorSlot / 100;
            stats.Strength = (int)Math.Floor(resultStrength);
            this.Level = level;
        }

        public override string ToString()
        {
            return $"\nItem stats for: {Name}\nType: {armorType}\n" +
                $"Slot : {ArmorSlot}\nBonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus strength: {stats.Strength}\nLevel: {Level}";
        }
    }
}
