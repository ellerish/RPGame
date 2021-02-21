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
            stats.Dexterity = 1;
            stats.Intelligence = 3;
        }

        public void ScaleStats(int level)
        {
            //runde ned
            double result = (stats.Health + 5 * level) * 0.6;
            stats.Health = (int)Math.Floor (result);

            double resultDex = (stats.Dexterity + 1 * level) * 0.6;
            stats.Dexterity = (int) Math.Floor(resultDex);

            double resultInt = (stats.Intelligence + 2 * level) * 0.6;
            stats.Intelligence = (int) Math.Floor(resultInt);
        }

        public override string ToString()
        {
            return $"Item stats for: {name}\nType: {armorType}\n" +
                $"Bonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus intelligence: {stats.Intelligence}\nLevel: {level}";
        }

    }

}
