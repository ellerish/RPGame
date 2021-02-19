using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
    interface IArmors
    {
        //BAseBonus 

        //CalculateBonus scale level

        void InitBonus(Stats bonus);
        void LevelBonus(Stats bonus, int level);

        void SetSlotType(ArmorType s);
       
        //ScaleCalulation
    }
}
