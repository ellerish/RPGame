using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    public abstract class Hero
    {
        protected string name;

        public Stats stats;
        public int level;

        protected int experiencePoints;

        protected int xpToNext;

        public Hero() { }

        public Hero(string name)
        {

            this.name = name;
            level = 1;
            experiencePoints = 0;
            xpToNext = 100; 

            stats = new Stats();
        }
        public int GetXpToNext()
        {
            return xpToNext - experiencePoints;
        }

        public void XpTo()
        {
            int expo = level - 1;
            double resXpToNext = Math.Pow(1.1, expo) * 100;
            Console.WriteLine(resXpToNext);
            xpToNext = (int) Math.Floor(resXpToNext);
        }

        protected bool CanLevelUp()
        {
            if (xpToNext <= experiencePoints)
            {
                return true;
            }
            return false;
        }

        public void GainExperience(int xp)
        {
            experiencePoints += xp;
            while(CanLevelUp())
            {
                LevelUp();
                level += 1;
                experiencePoints -= xpToNext;
                XpTo();
            }
        }
        protected abstract void SetStartsStats();

        protected abstract void LevelUp();

        public override string ToString()
        {
            return $"\nName: {name}\nHP: {stats.Health}\n" +
                $"Strength: {stats.Strength}\nDexterity: {stats.Dexterity} \n" +
                $"Intelligence: {stats.Intelligence}\n" +
                $"Level: {level} \n" +
                $"XPtoNext: {GetXpToNext()}";
        }
    }
}





