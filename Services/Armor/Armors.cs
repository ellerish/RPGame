using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
    interface IArmors
    {
        //BAseBonus 
        void InitBonus(Stats bonus);
        void LevelBonus(Stats bonus, int level);

        void SetSlotType(SlotType s);
       
        //ScaleCalulation
    }
}
