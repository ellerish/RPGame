using RPGame.Items.armor;
using RPGame.Items.ItemSlots;
using RPGame.Items.weapons;
using RPGame.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    class HeroService: ItemsService
    {
        protected Hero hero;

        protected int damage;

        /*Armor head;
        Armor body;
        Armor legs;*/

        Slots slots;
        int weaponSlot;
        int armorslot;
        public Stats bonus;

        public HeroService(Hero hero)
        {
            this.hero = hero;
            weaponSlot = 0;
            armorslot = 0;
            bonus = new Stats();
            // bonus;
        }

        public void NewStats(Armor armor)
        {
            bonus.Health = hero.stats.Health += armor.stats.Health;
            bonus.Strength = hero.stats.Strength += armor.stats.Strength;
            bonus.Dexterity = hero.stats.Dexterity += armor.stats.Dexterity;
            bonus.Intelligence = hero.stats.Intelligence += armor.stats.Intelligence;
            //  heroSlot = slots;
            //  Console.WriteLine($"{slots} = {heroSlot}");
            Console.WriteLine($"{hero}");

        }
        public void RemoveOldArmour()
        {
            armorslot = 0;
            Console.WriteLine($"{armorslot}");

        }

        public void EquipArmor(Armor armor, Slots heroSlot)
        {
            if(armor.slot != heroSlot)
            {
                Console.WriteLine($"You can't put {armor.slot} on your {heroSlot}");
                return;
            }

            if (armor.level <= hero.level)
                {
                    if (armor.armorType == ArmorType.Cloth)
                    {
                        NewStats(armor);
                     }
                else if (armor.armorType == ArmorType.Leather)
                    {
                        NewStats(armor);

                    }
                    else if (armor.armorType == ArmorType.Plate)
                    {
                        NewStats(armor);
                    }
                }
            
            else
            {
                Console.Write("You are not on a level to eqiup this armor");
            }
        }


        public void afterEqup()
        {
            Console.WriteLine($"{hero}");
        }

        public void attack()
        {
            //If hero doesnt have a weapon, no damage
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
                    damage =  weapon.baseDamage + hero.stats.Intelligence * 3;
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
                Console.Write("You are not on a level to eqiup this weapon");
            }
        }
    }
}
