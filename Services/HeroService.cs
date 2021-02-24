using RPGame.Items.Armor;
using RPGame.Items.Weapon;
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

        //init with 0, can have 1
        protected int weaponSlot;
        protected Stats bonus;

        //init with 0, hero can have 1 of each
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

        //Generates new stats(attributes) to hero.
        public void NewStats(Armor armor)
        {

            //Replace armorStats (attributes) if exist
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

        //Remove stats(attributes) from hero when replacing armor
        public void RemoveExistingArmour()
        {
            hero.stats.Health -= bonus.Health; 
            hero.stats.Strength -= bonus.Strength;
            hero.stats.Dexterity -= bonus.Dexterity;
            hero.stats.Intelligence -= bonus.Intelligence;
        }
        //Sets the different armorSlot to 1 if right slotType is collected
        public void SlotToHero(Armor armor)
        {
            if (armor.slot == Slots.Head)
            {
                NewStats(armor);
                headArmor = 1;
            }
            else if (armor.slot == Slots.Body)
            {
                NewStats(armor);
                bodyArmor = 1;
            }
            else if (armor.slot == Slots.Legs)
            {
                NewStats(armor);
                legArmor = 1;
            }

        }
        //Equip armor
        public void EquipArmor(Armor armor, Slots heroSlot)
        {
            //if Hero try to sets armor slot to a different slot
            if(armor.slot != heroSlot)
            {
                Console.WriteLine($"You can't put {armor.slot} on your {heroSlot}");
                return;
            }
            //Can't equip if armour level is higher than hero level
            if (armor.level <= hero.level)
            {
                //based on type, calculate new slots for hero
                if (armor.armorType == ArmorType.Cloth)
                {
                    SlotToHero(armor); 
                }
                else if (armor.armorType == ArmorType.Leather)
                {
                    SlotToHero(armor);
                }
                else if (armor.armorType == ArmorType.Plate)
                {
                    SlotToHero(armor);
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
