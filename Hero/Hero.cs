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
                this.level += 1;
                this.experiencePoints = newXp;
            }
        }
        protected abstract void SetStartsStats();

        protected abstract void LevelUp();


        //get currentsstats + extra sats 
        //setLevel current level + 1?

        public override string ToString()
        {
            return $"Name: {this.name} HP: {this.stats.Health}" +
                $"Strength: {this.stats.Strength} Dexterity: {this.stats.Dexterity} " +
                $"Intelligence: {this.stats.Strength } " +
                $"Level: {this.level} XP: {this.experiencePoints}";
        }
    }
}


    //Type Warrior, Ranger, Mage
    //name
    // id
    // Attributes
    // Level : 
    // Experience Points  = XP 




