using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.weapons
{
    class MagicWeapon : Weapon
    {

        public MagicWeapon() : base() { }

        public MagicWeapon(string name) : base(name)
        {
            SetWeaponType();
            SetBaseDamage();
        }
        protected override void SetBaseDamage()
        {
            baseDamage = 25;
        }

        protected override void SetWeaponType()
        {
            weaponType = WeaponType.Magic;
        }

        public void LevelScale(int level)
        {
            this.baseDamage = baseDamage + (2 * level);
            this.level = level;
        }
    }
}
