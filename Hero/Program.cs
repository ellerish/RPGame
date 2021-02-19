using System;

namespace RPGame.Hero
{
    class Program
    {
        static void Main(string[] args)
        {

            Mage mage = new Mage("Magica");
            mage.GainExperience(120);
            Console.WriteLine(mage.ToString());

            Warrior wa = new Warrior("Warr");
            Console.WriteLine(wa.ToString());

            Ranger ra = new Ranger("Rrr");
            Console.WriteLine(ra.ToString());

            ClothArmor armor = new ClothArmor("protecting shit");
            Console.WriteLine(armor.ToString());

            LeatherArmor armorL = new LeatherArmor("I'm leather");
            Console.WriteLine(armorL.ToString());

            PlateArmor armorP = new PlateArmor("I'm plate");
            Console.WriteLine(armorP.ToString());

        }
    }
}
