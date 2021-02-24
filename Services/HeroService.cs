using RPGame.Items.Armor;
using RPGame.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    class HeroService
    {
        protected Hero hero;

        protected int damage;

        //init with 0, can have 1
        protected int weaponSlot;
        protected Stats bonus;

        //Dictionary/Collection to store equippedArmor
        public Dictionary<Slots, Armor> EquippedArmor { get; set; } = new Dictionary<Slots, Armor>();

        public HeroService(Hero hero)
        {
            this.hero = hero;
            weaponSlot = 0;
            bonus = new Stats();
        }

        //Generates new stats(attributes) to hero.
        public void NewStats()
        {
            //generate bonus from equippedArmor Collection
            foreach (Armor armor in EquippedArmor.Values)
            {
                bonus.Health = armor.stats.Health;
                bonus.Strength = armor.stats.Strength;
                bonus.Dexterity = armor.stats.Dexterity;
                bonus.Intelligence = armor.stats.Intelligence;
            }
            hero.stats.Health += bonus.Health;
            hero.stats.Strength += bonus.Strength;
            hero.stats.Dexterity += bonus.Dexterity;
            hero.stats.Intelligence += bonus.Intelligence;

            Console.WriteLine($"{hero}\nArmors count: {EquippedArmor.Count}");
        }
       
        //Equip armor
        public void EquipArmor(Armor armor)
        {
            //Can't equip if armour level is higher than hero level
            if (armor.Level <= hero.level)
            {           //replace if exist, else add to generic collection
                if (EquippedArmor.ContainsKey(armor.ArmorSlot))
                {
                    EquippedArmor[armor.ArmorSlot] = armor;
                }
                else
                {   
                EquippedArmor.Add(armor.ArmorSlot, armor);
                }
            }
            else
            {
                Console.Write("You are not on a level to eqiup this armor");
            }
        }

        public void Attack()
        {
            //If a hero doesnt have a weapon, no damage
            if (weaponSlot == 0)
            {
                Console.WriteLine("Attacking for: " + 0);
            }
            else
            {   
                Console.WriteLine($" {hero}\n Attacking for: {damage}");
            }
        }

        public void EquipWeapon(Weapon weapon)
        {       //Check if hero can collect weapon at that level
            if (weapon.level <= hero.level)
            {
                //based on type, calculate damage, set weaponslot to 1
                if (weapon.weaponType == WeaponType.Magic)
                {
                    damage = weapon.baseDamage +  hero.stats.Intelligence * 3;
                }
                else if (weapon.weaponType == WeaponType.Meele)
                {
                    double strengthValue = weapon.baseDamage + hero.stats.Strength * 1.5;
                    damage = (int)Math.Floor(strengthValue);
                }
                else if (weapon.weaponType == WeaponType.Ranged)
                {
                    damage = weapon.baseDamage + hero.stats.Dexterity * 2;
                }
                weaponSlot = 1;
            }
            else
            {   //If hero is not on a level to equip this weapon
                Console.Write("\nYou are not on a level to eqiup this weapon");
            }
        }
    }
}
