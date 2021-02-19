using System;
using System.Collections.Generic;
using System.Text;

namespace RPGame.Hero
{
    public abstract class Hero
    {
        public String Name { get; set; }

      //  public Attributes Attributes { get; set; }
        public int Level { get; set; }

        public int ExperiencePoints { get; set; }

        public Hero() { }

         public Hero(string name, int level, int experiencePoints) {
           // 
             Name = name;
            // Attributes = new Attributes(0,0,0,0);
             Level = level;
             ExperiencePoints = experiencePoints;
         }

         public abstract void AddBaseStats(StatsAttributes stats);

          public abstract void LevelUp();
     
       
    }


    //Type Warrior, Ranger, Mage
    //name
    // id
    // Attributes
    // Level : 
    // Experience Points  = XP 
}
