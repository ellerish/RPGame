using System;

namespace RPGame.Hero
{
    class Program
    {
        static void Main(string[] args)
        {

            Mage mage = new Mage("Magica");
            mage.GainExperience(120);
            Console.WriteLine(mage.ToString());

            Warrior wa = new Warrior("Warr");
            Console.WriteLine(wa.ToString());

            Ranger ra = new Ranger("Rrr");
            Console.WriteLine(ra.ToString());


        }
    }
}
