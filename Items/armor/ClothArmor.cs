using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
    class ClothArmor : IArmor
    {
        public ClothArmor()
        {
        }

        //name

        //Base attributes??
        public string Name => throw new NotImplementedException();


        public void BaseBonus(Stats stats)
        {
            stats.Health = 10;
            stats.Intelligence = 3;
            stats.Dexterity = 1;
            stats.Strength = 0;
        }

        public void BaseBonus()
        {
            throw new NotImplementedException();
        }

        public SlotType GetSlotType()
        {
            throw new NotImplementedException();
        }
    }
}
