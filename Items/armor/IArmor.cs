using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
     public interface IArmor
    {
         String Name { get; }
         void BaseBonus();

        //Void scale(Sats stas)

         SlotType GetSlotType();
        //Fits into armor
        //Has a name 
        //Bonus to attributes depending   on type of armor and where
    }
}
