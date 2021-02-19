using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.armor
{
    class ClothArmor : Armor
    {

        public ClothArmor() : base() { }

        public ClothArmor(string name) : base(name)
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
            stats.Dexterity = 3;
            stats.Intelligence = 3;
        }

        public override string ToString()
        {
            return $"Item stats for: {name}\nType: {armorType}\n" +
                $"Bonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus intelligence: {stats.Intelligence}\nLevel: {level}";
        }

    }

}
