using RPGame.Hero;
using RPGame.Items.armor;
using RPGame.Items.ItemSlots;
using RPGame.Items.weapons;
using System;

namespace RPGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Warrior wa = new Warrior("Warr");
            wa.GainExperience(1200);
            //  wa.GainExperience(200);

           // wa.LevelCheck(464);
            //wa.GainExperience(200);
            //  wa.GainExperience(30);
            // wa.xpTo();
            Console.WriteLine(wa.ToString());

            MeleeWeapon meele = new MeleeWeapon("I'm meeele");
            meele.LevelScale(5);
            Console.WriteLine(meele.ToString());

            RangedWeapon rangedWeapon = new RangedWeapon("Im rangedweapon");
            rangedWeapon.LevelScale(10);
            Console.WriteLine(rangedWeapon.ToString());

            MagicWeapon magic = new MagicWeapon("MagicWeapon");
            magic.LevelScale(5);
            Console.WriteLine(magic.ToString());

            ClothArmor armor = new ClothArmor("protecting shit");
            armor.ScaleStatsByLevel(10, Slots.Legs);
            Console.WriteLine(armor.ToString());


            PlateArmor armorP = new PlateArmor("I'm plate");
            armorP.ScaleStatsByLevel(5, Slots.Body);
            Console.WriteLine(armorP.ToString());


            /* Mage mage = new Mage("Magica");
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

             MagicWeapon magic = new MagicWeapon("I'm magic");
             Console.WriteLine(magic.ToString());

             MeleeWeapon meele = new MeleeWeapon("I'm meeele");
             Console.WriteLine(meele.ToString());
            */
        }

    }
}
