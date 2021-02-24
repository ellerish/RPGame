using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Weapon
{
    //Inherit from base: Weapon
    class RangedWeapon : Weapon
    {
        public RangedWeapon() : base() { }

        public RangedWeapon(string name) : base(name)
        {
            SetWeaponType();
            SetBaseDamage();
        }
        //init base damage
        protected override void SetBaseDamage()
        {
            baseDamage = 5;
        }

        //init type of weapon
        protected override void SetWeaponType()
        {
            weaponType = WeaponType.Meele;
        }

        public int LevelScale(int level)
        {
            baseDamage += (3 * level);
            this.level = level;
            return baseDamage;
        }

        public int DamageScale()
        {
            return 2 * stats.Dexterity;
        }
    }
}
