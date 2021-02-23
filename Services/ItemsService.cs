using RPGame.Hero;
using RPGame.Items.armor;
using RPGame.Items.ItemSlots;
using RPGame.Items.weapons;
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
