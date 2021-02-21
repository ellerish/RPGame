using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Items.weapons

{
    class MeleeWeapon: Weapon
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

        public void LevelScale(int level)
        {
            this.baseDamage = baseDamage + (2 * level);
            this.level = level;
        }
    }
}
