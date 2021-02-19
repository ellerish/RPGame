using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
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

        public override string ToString()
        {
            return $"Item stats for: {name}\nType: {armorType}\n" +
                $"Bonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus strength: {stats.Strength}\nLevel: {level}";
        }
    }
}
