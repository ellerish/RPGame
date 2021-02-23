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
            Mage mage = new Mage("Magica");
            mage.GainExperience(4000);
            Console.WriteLine(mage.ToString());
           
            ClothArmor armor = new ClothArmor("protecting shit");
            armor.ScaleStatsByLevelAndSlot(2, Slots.Legs);
            Console.WriteLine(armor.ToString());

            MagicWeapon magic = new MagicWeapon("MagicWeapon");
            magic.LevelScale(20);

            MagicWeapon magic2 = new MagicWeapon("MagicWeapon2");
            magic.LevelScale(1);
            MeleeWeapon meele = new MeleeWeapon("I'm meeele");
            meele.LevelScale(5);

            HeroService service = new HeroService(mage);
            service.attack();
           // service.EquipArmor(armor, Slots.Body);
            service.EquipWeapon(magic);
            service.attack();
            /*service.EquipWeapon(magic2);
            service.EquipWeapon(meele);
            service.attack();


         /*   //mage.EquipArmor(armor, Slots.Body);
            HeroService serive = new HeroService(mage);
            serive.EquipArmor(armor, Slots.Body);

            MagicWeapon magic = new MagicWeapon("MagicWeapon");
            magic.LevelScale(1);
            Console.WriteLine(magic.ToString());

            serive.EquipWeapon(magic);

            MeleeWeapon meele = new MeleeWeapon("I'm meeele");
            meele.LevelScale(5);
            Console.WriteLine(meele.ToString());


            Warrior wa = new Warrior("Warr");
            wa.GainExperience(464);
            HeroService heroservice = new HeroService(wa);
            heroservice.EquipWeapon(meele);



          /*  Warrior wa = new Warrior("Warr");
            wa.GainExperience(464);
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

   


            PlateArmor armorP = new PlateArmor("I'm plate");
            armorP.ScaleStatsByLevelAndSlot(15, Slots.Body);
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
