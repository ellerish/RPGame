using RPGame.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
    interface IWeapon    {
        //Base damaged
        void DamagedDealt();

        int setDamage(int level);
        String toString();
        int calculateExtraDamage(Stats stas);


        //scale caluclations
    }
}
