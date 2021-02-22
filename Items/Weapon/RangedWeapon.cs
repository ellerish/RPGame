using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.weapons
{
    class RangedWeapon: Weapon
    {
        public RangedWeapon() : base() { }

        public RangedWeapon(string name) : base(name)
        {
            SetWeaponType();
            SetBaseDamage();
        }
        protected override void SetBaseDamage()
        {
            baseDamage = 5;
        }

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

        public int DamageScale(Stats stats)
        {
            return 2 * stats.Dexterity;
        }
    }
}
