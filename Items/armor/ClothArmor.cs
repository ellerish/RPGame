using RPGame.Items.ItemSlots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.armor
{
    class ClothArmor : Armor
    {

        public ClothArmor() : base() { }

        public ClothArmor(string name, Slots slot) : base(name, slot)
        {
            SetBaseStats();
            SetArmorType();
        }

        protected override void SetArmorType()
        {
            armorType = ArmorType.Cloth;
        }

        protected override void SetBaseStats()
        {
            stats.Health = 10;
            stats.Dexterity = 1;
            stats.Intelligence = 3;
        }

        public void ScaleStatsByLevel(int level)
        {
            stats.Health += 5 * level;
            stats.Dexterity += 1 * level;
            stats.Intelligence += 2 * level;
            this.level = level;
        }

        public void ScaleStatsByLevelAndSlot(int level)
        {          
            double result = (stats.Health + 5 * level) * (int)slot/100;
            stats.Health = (int)Math.Floor (result);

            double resultDex = (stats.Dexterity + 1 * level) * (int)slot / 100;
            stats.Dexterity = (int) Math.Floor(resultDex);

            double resultInt = (stats.Intelligence + 2 * level) * (int)slot / 100;
            stats.Intelligence = (int) Math.Floor(resultInt);

            this.level = level;
        }

        public override string ToString()
        {
            return $"\nItem stats for: {name}\nType: {armorType}\n" +
                $"Slot : {slot}\nBonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus intelligence: {stats.Intelligence}\nLevel: {level}";
        }

    }

}
