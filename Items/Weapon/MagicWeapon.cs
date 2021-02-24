using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.Weapon
{
    //Inherit from base: Weapon

    class MagicWeapon : Weapon
    {
        public MagicWeapon() : base() { }

        public MagicWeapon(string name) : base(name)
        {
            SetWeaponType();
            SetBaseDamage();
        }
        //init base damage
        protected override void SetBaseDamage()
        {
            baseDamage = 25;
        }

        protected override void SetWeaponType()
        {
            weaponType = WeaponType.Magic;
        }

        public int LevelScale(int level)
        {
            baseDamage += (2 * level);
            this.level = level;
            return baseDamage;
        }

        public int DamageScale()
        {
            return 3 * stats.Intelligence;
        }

         
    }
}
