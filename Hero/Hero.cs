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

        protected double XptoNext;

        public Hero() { }

        public Hero(string name)
        {

            this.name = name;
            level = 1;
            experiencePoints = 0;
            XptoNext = 100;

            stats = new Stats();
        }
        
        // XP to next 
        public void xpTo()
        {
            if(level == 1)
            {
                XptoNext = 100;

            }
            int ch = level - 1;
            double res = Math.Pow(1.1, ch);
            Console.WriteLine(res);
            XptoNext = XptoNext * res;
        }
            

        public void GainExperience(int xp)
        {
            int newXp = this.experiencePoints + xp;
            int levelaccess = 100; //method for each level access

           
            
            if (newXp >= levelaccess)
            {
                LevelUp();
                level += 1;
                experiencePoints = newXp;
            }
        }
        protected abstract void SetStartsStats();

        protected abstract void LevelUp();

        public override string ToString()
        {
            return $"Name: {name} HP: {stats.Health}" +
                $" Strength: {stats.Strength} Dexterity: {stats.Dexterity} " +
                $"Intelligence: {stats.Strength } " +
                $"Level: {level} XP: {experiencePoints}" +
                $"XPtoNext: {XptoNext}";
        }
    }
}


    //Type Warrior, Ranger, Mage
    //name
    // id
    // Attributes
    // Level : 
    // Experience Points  = XP 




