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

        protected int weaponSlot;
        protected Stats bonus;

        protected int legArmor;
        protected int bodyArmor;
        protected int headArmor;

        public HeroService(Hero hero)
        {
            this.hero = hero;
            weaponSlot = 0;
            bonus = new Stats();
            headArmor = 0;
            bodyArmor = 0;
            legArmor = 0;
        }

        public void NewStats(Armor armor)
        {
            if(headArmor != 0)
            {
                RemoveExistingArmour();
               
            } else if(bodyArmor != 0)
            {
                RemoveExistingArmour();
            } else if (legArmor != 0)
            {
                RemoveExistingArmour();
            }
            bonus.Health = armor.stats.Health;
            bonus.Strength = armor.stats.Strength;
            bonus.Dexterity = armor.stats.Dexterity;
            bonus.Intelligence = armor.stats.Intelligence;
            hero.stats.Health += bonus.Health;
            hero.stats.Strength += bonus.Strength;
            hero.stats.Dexterity += bonus.Dexterity;
            hero.stats.Intelligence += bonus.Intelligence;
            Console.WriteLine($"{hero}");
        }

        public void RemoveExistingArmour()
        {
            hero.stats.Health -= bonus.Health; 
            hero.stats.Strength -= bonus.Strength;
            hero.stats.Dexterity -= bonus.Dexterity;
            hero.stats.Intelligence -= bonus.Intelligence;
        }

        public void SlotToHero(Armor armor)
        {
            if (armor.slot == Slots.Head)
            {
                headArmor = 1;
            }
            else if (armor.slot == Slots.Body)
            {
                bodyArmor = 1;
            }
            else if (armor.slot == Slots.Legs)
            {
                legArmor = 1;
            }

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

        public void Attack()
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
                Console.Write("\nYou are not on a level to eqiup this weapon");
            }
        }
    }
}
