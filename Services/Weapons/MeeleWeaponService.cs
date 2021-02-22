using RPGame.Hero;
using RPGame.Items.weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame
{
    class MeeleWeaponService 
    {
        public void DamagedDealt()
        {

            Stats stats = new Stats();
            double result = stats.Strength * 1.5;
            int damageDealt = (int)Math.Floor(result);

            // char.strength.Value * 1.5;



        }

     /*   public void LevelScale(int level)
        {
            int dam = 15 + (2 * level);
           // return dam;
            Console.WriteLine($"Damage delt Meele: {dam}");
        }*/


    }
}
