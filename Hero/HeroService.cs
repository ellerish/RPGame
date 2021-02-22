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

        public Slots slots;

       
        public HeroService(Hero hero)
        {
            this.hero = hero;
        }

        public Boolean canEquip()
        {
            return true;
        }


        public void EquipArmor(Armor armor, Slots slot)
        {
            if (armor.level <= hero.level)
            {       
                if (armor.armorType == ArmorType.Cloth)
                {
                    hero.stats.Health += armor.stats.Health;
                    hero.stats.Dexterity += armor.stats.Dexterity;
                    hero.stats.Intelligence += armor.stats.Intelligence;
                    Console.WriteLine($"{hero}");

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
                Console.Write("You are not on a level to eqiup this");
            }
        }
        public void EquipWeapon(Weapon weapon)
        {
            if (weapon.level <= hero.level)
            {
                if (weapon.weaponType == WeaponType.Magic)
                {
                    damage =  weapon.baseDamage + hero.stats.Intelligence * 3;
                    Console.WriteLine($" {hero}\nAttacking for: { damage}");
                } else if (weapon.weaponType == WeaponType.Meele)
                {
                    double strengthValue = weapon.baseDamage + hero.stats.Strength * 1.5;
                    damage = (int)Math.Floor(strengthValue);
                    Console.WriteLine($" {hero}\nAttacking for: { damage}");

                }
                else if (weapon.weaponType == WeaponType.Ranged)
                {
                    damage = weapon.baseDamage + hero.stats.Dexterity * 2;
                    Console.WriteLine($" {hero}\nAttacking for: { damage}  ");
                }
            } else
            {

                Console.Write("You are not on a level to eqiup this");
            }
        }
    }
}
