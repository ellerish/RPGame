using RPGame.Hero;
using RPGame.Items.Armor;
using RPGame.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Services
{
    interface ItemsService
    {
        void EquipArmor(Armor armor, Slots slot);
        void EquipWeapon(Weapon weapon);
    }
}
