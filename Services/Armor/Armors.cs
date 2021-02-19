using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
    interface IArmors
    {
        //BAseBonus 
        void initBonus(StatsAttributes bonus);
        void levelBonus(StatsAttributes bonus, int level);

        void setSlotType(SlotType s);
       
        //ScaleCalulation
    }
}
