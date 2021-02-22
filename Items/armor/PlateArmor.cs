using RPGame.Items.ItemSlots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.armor
{
    class PlateArmor : Armor
    {

        public PlateArmor() : base() { }

        public PlateArmor(string name) : base(name)
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

        public void ScaleStatsByLevelAndSlot(int level, Slots slot)
        {
            double result = (stats.Health + 12 * level) * (int)slot / 100;
            stats.Health = (int)Math.Floor(result);

            double resultDex = (stats.Dexterity + 1 * level) * (int)slot / 100;
            stats.Dexterity = (int)Math.Floor(resultDex);

            double resultStrength = (stats.Strength + 2 * level) * (int)slot / 100;
            stats.Strength = (int)Math.Floor(resultStrength);
            this.level = level;
        }

        public override string ToString()
        {
            return $"\nItem stats for: {name}\nType: {armorType}\n" +
                $"Bonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus strength: {stats.Strength}\nLevel: {level}";
        }
    }
}
