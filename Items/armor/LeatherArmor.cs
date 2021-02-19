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

        public override string ToString()
        {
            return $"Item stats for: {name}\nType: {armorType}\n" +
                $"Bonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus strength: {stats.Strength}\nLevel: {level}";
        }
    }
}
