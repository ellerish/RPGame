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

        public Hero() { }

        public Hero(string name)
        {

            this.name = name;
            level = 1;
            experiencePoints = 100;

            stats = new Stats();
        }

        public void GainExperience(int xp)
        {
            int newXp = this.experiencePoints + xp;
            int levelaccess = 200;

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
                $"Level: {level} XP: {experiencePoints}";
        }
    }
}


    //Type Warrior, Ranger, Mage
    //name
    // id
    // Attributes
    // Level : 
    // Experience Points  = XP 




