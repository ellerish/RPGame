using RPGame.Items.ItemSlots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.armor
{
    class LeatherArmor : Armor
    {

        public LeatherArmor() : base() { }

        public LeatherArmor(string name) : base(name)
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

        public void ScaleStatsByLevelAndSlot(int level, Slots slot)
        {
            double result = (stats.Health + 8 * level) * (int)slot / 100;
            stats.Health = (int)Math.Floor(result);

            double resultDex = (stats.Dexterity + 2 * level) * (int)slot / 100;
            stats.Dexterity = (int)Math.Floor(resultDex);

            double resultStrength = (stats.Strength + 1 * level) * (int)slot / 100;
            stats.Strength = (int)Math.Floor(resultStrength);
            this.level = level;
        }

        public override string ToString()
        {
            return $"Item stats for: {name}\nType: {armorType}\n" +
                $"Bonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus strength: {stats.Strength}\nLevel: {level}";
        }
    }
}
