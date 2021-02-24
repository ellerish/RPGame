using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Weapon
{
    //Inherit from parent: Weapon
    class MeleeWeapon : Weapon
    {
        public MeleeWeapon() : base() { }

        public MeleeWeapon(string name) : base(name)
        {
            SetWeaponType();
            SetBaseDamage();
        }
        protected override void SetBaseDamage()
        {
            baseDamage = 15;
        }

        protected override void SetWeaponType()
        {
            weaponType = WeaponType.Meele;
        }

        public int LevelScale(int level)
        {
            baseDamage += (2 * level);
            this.level = level;
            return baseDamage;
        }

        public int DamageScale()
        {
            return (int)1.5 * stats.Strength;
        }

    }
}
