using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Armor
{
    //Inherit from parent: Armor
    class ClothArmor : Armor
    {

        public ClothArmor() : base() { }

        //Sets type and base attributes(stats) on creation
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
            this.Level = level;
        }

        //Calculate new attributes(stats) based on level and slot
        public void ScaleStatsByLevelAndSlot(int level)
        {          
            double result = (stats.Health + 5 * level) * (int)ArmorSlot/100;
            stats.Health = (int)Math.Floor (result);

            double resultDex = (stats.Dexterity + 1 * level) * (int)ArmorSlot / 100;
            stats.Dexterity = (int) Math.Floor(resultDex);

            double resultInt = (stats.Intelligence + 2 * level) * (int)ArmorSlot / 100;
            stats.Intelligence = (int) Math.Floor(resultInt);

            this.Level = level;
        }

        public override string ToString()
        {
            return $"\nItem stats for: {Name}\nType: {armorType}\n" +
                $"Slot : {ArmorSlot}\nBonus HP: {stats.Health}\nBonus dex: {stats.Dexterity}\n" +
                 $"Bonus intelligence: {stats.Intelligence}\nLevel: {Level}";
        }

    }

}
