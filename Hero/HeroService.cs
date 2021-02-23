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

        int head;
        int body;
        int legs;
        int weaponSlot;


        public HeroService(Hero hero)
        {
            this.hero = hero;
            weaponSlot = 0;
          

        }

        public Boolean ChangeWeapon()
        {
            if(weaponSlot == 1)
            {
                Console.WriteLine("Du må bytte stats");
            } 
            return false;
        }

        //if this slot != null repalce 

        public void EquipArmor(Armor armor, Slots heroSlot)
        {
            if (armor.level <= hero.level)
            {
                if (armor.armorType == ArmorType.Cloth)
                {
                    hero.stats.Health += armor.stats.Health;
                    hero.stats.Dexterity += armor.stats.Dexterity;
                    hero.stats.Intelligence += armor.stats.Intelligence;
                    Console.WriteLine($"{hero}");
                  //  heroSlot = slots;
                  //  Console.WriteLine($"{slots} = {heroSlot}");

                }
                else if(armor.armorType == ArmorType.Leather)
                {
                    hero.stats.Health += armor.stats.Health;
                    hero.stats.Dexterity += armor.stats.Dexterity;
                    hero.stats.Strength += armor.stats.Strength;
                } else if(armor.armorType == ArmorType.Plate)
                {
                    hero.stats.Health += armor.stats.Health;
                    hero.stats.Dexterity += armor.stats.Dexterity;
                    hero.stats.Strength += armor.stats.Strength;
                }
            } else
            {
                Console.Write("You are not on a level to eqiup this armor");
            }
        }

        public void attack()
        {
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
        {       //Check if hero can collect weapon
            if (weapon.level <= hero.level)
            {
                if (weapon.weaponType == WeaponType.Magic)
                {
                    damage =  weapon.baseDamage + hero.stats.Intelligence * 3;
                 //   Console.WriteLine($" {hero}\nAttacking for: { damage}");
                    weaponSlot = 1;
                }
                else if (weapon.weaponType == WeaponType.Meele)
                {
                    double strengthValue = weapon.baseDamage + hero.stats.Strength * 1.5;
                    damage = (int)Math.Floor(strengthValue);
                  //  Console.WriteLine($" {hero}\nAttacking for: { damage}");
                    weaponSlot = 1;

                }
                else if (weapon.weaponType == WeaponType.Ranged)
                {
                    damage = weapon.baseDamage + hero.stats.Dexterity * 2;
                //    Console.WriteLine($" {hero}\nAttacking for: { damage}  ");
                    weaponSlot = 1;

                }
            } else
            {
                Console.Write("You are not on a level to eqiup this weapon");
            }
        }
    }
}
