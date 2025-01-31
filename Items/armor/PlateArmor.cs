﻿using RPGame.Items.Armor;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Armor
{
    //Inherit from parent: Armor
    class PlateArmor : Armor
    {
        public PlateArmor() : base() { }

        //Sets type and base attributes(stats) on creation
        public PlateArmor(string name, Slots slot) : base(name, slot)
        {
            SetBaseStats();
            SetArmorType();
        }

        protected override void SetArmorType()
        {
            armorType = ArmorType.Plate;
        }

        protected override void SetBaseStats()
        {
            stats.Health = 30;
            stats.Dexterity = 1;
            stats.Strength = 3;
        }

        //Calculate new attributes(stats) based on level and slot
        public void ScaleStatsByLevelAndSlot(int level)
        {
            double result = (stats.Health + 12 * level) * (int)ArmorSlot / 100;
            stats.Health = (int)Math.Floor(result);

            double resultDex = (stats.Dexterity + 1 * level) * (int)ArmorSlot / 100;
            stats.Dexterity = (int)Math.Floor(resultDex);

            double resultStrength = (stats.Strength + 2 * level) * (int)ArmorSlot / 100;
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
