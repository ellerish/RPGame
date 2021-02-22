using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    public abstract class Hero
    {
        protected string name;

        protected Stats stats;
        protected int level;

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
            double res = Math.Pow(1.1, expo) * 100;
            Console.WriteLine(res);
            xpToNext = (int) Math.Floor(res);
        }

        public Boolean CanLevelUp()
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
          //  XptoNext = experiencePoints - XptoNext;

        }
        protected abstract void SetStartsStats();

        protected abstract void LevelUp();

        public override string ToString()
        {
            return $"Name: {name} HP: {stats.Health}" +
                $" Strength: {stats.Strength} Dexterity: {stats.Dexterity} " +
                $"Intelligence: {stats.Intelligence } " +
                $"Level: {level} XP: {experiencePoints}" +
                $"XPtoNext: {GetXpToNext()}";
        }
    }
}





