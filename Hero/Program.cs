using System;

namespace RPGame.Hero
{
    class Program
    {
        static void Main(string[] args)
        {

            Mage mage = new Mage("Magica", 1, 0);
            Ranger ranger = new Ranger("Ragnar", 1, 0);
            Warrior warrior = new Warrior("Warza", 1, 0);
            StatsAttributes stats = new StatsAttributes();

            ranger.AddBaseStats();
            warrior.AddBaseStats();



           
            Console.WriteLine($"Mage created: Name: {mage.Name} Level : {mage.Level} XP: {mage.ExperiencePoints}");
            mage.AddBaseStats();

            Console.WriteLine($"Mage created: Name: {ranger.Name} Stats: HP: {stats.Health}" +
           $" Strenght: {stats.Strength} Dexterity : {stats.Dexterity} Intelligence: {stats.Intelligence} " +
           $"Level : {ranger.Level} XP: {ranger.ExperiencePoints}");

            Console.WriteLine($"Mage created: Name: {warrior.Name} Stats: HP: {stats.Health}" +
        $" Strenght: {stats.Strength} Dexterity : {stats.Dexterity} Intelligence: {stats.Intelligence} " +
                $"Level : {warrior.Level} XP: {warrior.ExperiencePoints}");
        }
    }
}
