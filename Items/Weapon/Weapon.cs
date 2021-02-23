using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.weapons
{
    //Parent class Weapon
    public abstract class Weapon
    {
        protected string name;

        //All weapons starts at level 1
        public int level;

        protected Stats stats;

        public WeaponType weaponType;

        public int baseDamage;

        public Weapon() { }

        public Weapon(string name)
        {
            this.name = name;
            level = 1;
        }

        //All weapon has a baseDamage value
        protected abstract void SetBaseDamage();

        //Sets type: Magic, Melee, Ranged 
        protected abstract void SetWeaponType();

        public override string ToString()
        {
            return $"\nItem stats for: {name}\nWeapon Type: {weaponType}\n" +
                $"Level: {level}\nDamage: {baseDamage}";
        }
    }
}

