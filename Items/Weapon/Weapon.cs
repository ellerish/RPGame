using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.weapons
{
    public abstract class Weapon
    {
        protected string name;

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

        protected abstract void SetBaseDamage();

        protected abstract void SetWeaponType();

        public override string ToString()
        {
            return $"\nItem stats for: {name}\nWeapon Type: {weaponType}\n" +
                $"Level: {level}\nDamage: {baseDamage}";
        }
    }
}

