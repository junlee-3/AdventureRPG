using System;

namespace AdventureRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure RPG!");

            Console.WriteLine("What is your name?");
            Player.Name = Console.ReadLine();
            Player.Health = 100;
            Player.Inventory = new string[10];
            
            Console.WriteLine($"Welcome! {Player.Name}");
            Console.WriteLine("Choose Your Class of Player! (Warrior, Mage, or Archer)");
            Player.PlayerClass = Console.ReadLine();

            switch (Player.PlayerClass)
            {
                case "Mage":
                    Console.WriteLine("You are a Mage! Your Attacks are:");
                    foreach (var attack in Player.Mage.Attacks)
                    {
                        Console.WriteLine($"Your Attacks are {attack}");
                    }
                    break;
                
                case "Warrior":
                    Console.WriteLine("You are a Warrior!");
                    foreach (var attack in Player.Warrior.Attacks)
                    {
                        Console.WriteLine($"Your Attacks are {attack}");
                    }
                    
                    break;
                case "Archer":
                    Console.WriteLine("You are an Archer!");
                    foreach(var attack in Player.Archer.Attacks)
                    {
                        Console.WriteLine($"Your Attacks are {attack}");
                    }
                    break;
                default:
                    Console.WriteLine("Please choose a valid class of player, use the correct spelling!");
                    break;
            }
            
            Console.WriteLine("You have encountered a monster! Time to battle!");
            Player.Warrior.Attack();
        } 
    }
}