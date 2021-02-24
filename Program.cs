using RPGame.Hero;
using RPGame.Items.Armor;
using RPGame.Items.Weapon;
using System;

namespace RPGame
{
    /*
     * Demostrating creation of various heros and items.
     * Demonstrating Hero equip items/attack
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

            Ranger rag = new Ranger("Rag Rock");
            rag.GainExperience(1080);
            Console.WriteLine($"\nRanger details: {rag}");


            Console.WriteLine("\n----Demo: Generate some items----");

             MagicWeapon magicWeapon = new MagicWeapon("MagicWeapon");
             Console.WriteLine($"\nMagic Weapon details: {magicWeapon}");
             magicWeapon.LevelScale(2);
             Console.WriteLine($"\nMagic Weapon details with level scale: {magicWeapon}");

             MeleeWeapon meele = new MeleeWeapon("Infinity Edge");
             meele.LevelScale(11);
             Console.WriteLine($"\nMeele Weapon details with level scale: {meele}");

             RangedWeapon rangedWeapon = new RangedWeapon("Beyond distance");
             rangedWeapon.LevelScale(4);
             Console.WriteLine($"\nRanged Weapon details with level scale: {rangedWeapon}");

            
              ClothArmor armorMask = new ClothArmor("Abyssal Mask", Slots.Head);
              armorMask.ScaleStatsByLevelAndSlot(6);
              Console.WriteLine($"\nCloth armor: {armorMask}");

              PlateArmor armorPlate = new PlateArmor("Bramble Vest", Slots.Body);
              armorPlate.ScaleStatsByLevelAndSlot(3);
              Console.WriteLine($"\nPlate armor: {armorPlate}");

              LeatherArmor armorLeather = new LeatherArmor("Legwraps ", Slots.Legs);
              armorLeather.ScaleStatsByLevelAndSlot(8);
              Console.WriteLine($"\nLeather armor: {armorLeather}");

              ClothArmor clothPants = new ClothArmor("Elli Pants", Slots.Legs);
              clothPants.ScaleStatsByLevelAndSlot(1);
              Console.WriteLine($"\nCloth armor: {clothPants}");


               Console.WriteLine("\n----Demo: Hero's eqiup some items----");

               HeroService warriorGame = new HeroService(war);
               warriorGame.EquipWeapon(meele);
               Console.WriteLine("\n----Warrior equips ClothAmor: Head----");
               warriorGame.EquipArmor(armorMask, Slots.Head);
               Console.WriteLine("\n----Warrior equips PlateArmor: Body----");
               warriorGame.EquipArmor(armorPlate, Slots.Body);
               Console.WriteLine("\n----Warrior equips LeatherArmor: Legs----");
               warriorGame.EquipArmor(armorLeather, Slots.Legs);

               Console.WriteLine("\n----Demo: Hero try to put HeadItem on Legs----");
               warriorGame.RemoveExistingArmour();
               warriorGame.EquipArmor(armorMask, Slots.Legs);

               Console.WriteLine("\n----Warrior equips ClothArmor on Legs again----");
               warriorGame.EquipArmor(armorLeather, Slots.Legs);

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
