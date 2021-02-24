using RPGame.Hero;
using RPGame.Items.Armor;
using RPGame.Items.Weapon;
using System;

namespace RPGame
{
    /*
     * Demostrating creation of various heros and items.
     * Demonstrating heros equip items/attack
     */
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("----Demo: Generate some characters----");

                 Mage magica = new Mage("Magica-Raspotina");
                 magica.GainExperience(210); 
                 Console.WriteLine($"\nMage details: {magica}");

                 Warrior war = new Warrior("M - The unshackled");
                 war.GainExperience(2500);
                 Console.WriteLine($"\nWarrior details: {war}");

                 Ranger rag = new Ranger("Nico Rock");
                 rag.GainExperience(1080);
                 Console.WriteLine($"\nRanger details: {rag}");

                 Console.WriteLine("\n----Demo: Generate some items----");

                 MagicWeapon magicWeapon = new MagicWeapon("MagicWeapon");
                 Console.WriteLine($"\nMagic Weapon details: {magicWeapon}");
                 magicWeapon.LevelScale(2);
                 Console.WriteLine($"\nMagic Weapon details on level 2: {magicWeapon}");

                 MeleeWeapon meele = new MeleeWeapon("Infinity Edge");
                 meele.LevelScale(11);
                 Console.WriteLine($"\nMeele Weapon details on level 11: {meele}");

                 RangedWeapon rangedWeapon = new RangedWeapon("Beyond distance");
                 rangedWeapon.LevelScale(4);
                 Console.WriteLine($"\nRanged Weapon details on level 4: {rangedWeapon}");

                 ClothArmor armorMask = new ClothArmor("Abyssal Mask", Slots.Head);
                 armorMask.ScaleStatsByLevelAndSlot(6);
                 Console.WriteLine($"\nCloth armor: {armorMask}");

                 PlateArmor armorPlate = new PlateArmor("Bramble Vest", Slots.Body);
                 armorPlate.ScaleStatsByLevelAndSlot(3);
                 Console.WriteLine($"\nPlate armor: {armorPlate}");

                 LeatherArmor armorLeather = new LeatherArmor("Legwraps ", Slots.Legs);
                 armorLeather.ScaleStatsByLevelAndSlot(8);
                 Console.WriteLine($"\nLeather armor: {armorLeather}");

                 ClothArmor clothPants = new ClothArmor("El Pj Pants", Slots.Legs);
                 clothPants.ScaleStatsByLevelAndSlot(1);
                 Console.WriteLine($"\nCloth armor: {clothPants}");

                 Console.WriteLine("\n----Demo: Hero's eqiup some items----");

                 HeroService warriorGame = new HeroService(war);
                 warriorGame.EquipWeapon(meele);
                 Console.WriteLine("\n----Warrior equips ClothAmor lvl 6:Head:----");
                 warriorGame.EquipArmor(armorMask);
                 Console.WriteLine("\n----Warrior equips PlateArmor lvl 3: Body----");
                 warriorGame.EquipArmor(armorPlate);
                 Console.WriteLine("\n----Warrior equips LeatherArmor lvl 8: Legs----");
                 warriorGame.EquipArmor(armorLeather);
                 warriorGame.NewStats();

                 Console.WriteLine("\n----Warrior equips ClothArmor: Legs again----");
                 warriorGame.EquipArmor(clothPants);
                 warriorGame.NewStats();

                 Console.WriteLine("\n----Demo: Hero's can't eqiup item with higher level----");
                 HeroService magicaGame = new HeroService(magica);
                 magicaGame.EquipWeapon(meele);

                 Console.WriteLine("\n----Demo: Hero:Warrior attacking with weapon: meele----");
                 warriorGame.Attack();
                 Console.WriteLine("\n----Demo: Hero's attacking without weapon----");
                 magicaGame.Attack();
               
        }

    }
}
