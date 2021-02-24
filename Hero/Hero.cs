using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    //Parent class
    public abstract class Hero
    {
        protected string name;

        public Stats stats;

        //Start level = 1
        public int level;

        //Start = 0;
        protected int experiencePoints;

        //Xp to next level value. 1 -> 2 = 100
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

        //Calculate xpToNext after getting experience points.
        protected int GetXpToNext()
        {
            return xpToNext - experiencePoints;
        }

        //Calcualate xp demand per level
        protected void XpPerLevel()
        {
            int expo = level - 1;
            double resXpToNext = Math.Pow(1.1, expo) * 100;
            xpToNext = (int) Math.Floor(resXpToNext);
        }

        // Check if xp is enough to level up
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
            //Check if can level up based on XpToNext value
            while(CanLevelUp())
            {
                LevelUp();//Call method to level up, each hero has different stats
                level += 1;
                experiencePoints -= xpToNext;  //Subtract xp for each level up
                XpPerLevel(); //Calculate new Xp to next value;
            }
        }

        //Set starts Stats(Attributes). All hero's has start values
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





