using System;
using RPG.Models;
using RPG.Views;

namespace RPG.Control 
{
    public class GameController 
    {
        private Player player;
        //private Wizard wizard;
        private Monster monster;
        
        public GameController(Player player, Monster monster) 
        {
            this.player = player;
            //this.wizard = wizard;
            this.monster = monster;
        }
        
        public void Run() 
        {
            // Game Loop
            while (true) 
            {
                
                Display.Actions(player.Name);
                string input = Console.ReadLine();

                // input validation and type conversion
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input - please enter a number");
                }

                // Choice Flow
                switch (choice)
                {
                    //Attack
                    case 1:

                        int damage = Display.TwentyDie();

                        // Check to see if monsters are about
                        int x = Monster.GetInstanceCount();
                        Console.WriteLine($"The number of monsters is {x}");
                        if (monster == null)
                        {
                            Console.WriteLine("There are no monsters to attack");
                            break;
                        }

                        player.Attack();

                        Console.WriteLine("You inflicted {0} hp damage", damage);

                        monster.TakeDamage(damage);
                        
                        if (!monster.IsDead()) 
                        {
                            Console.WriteLine("You defeated the monster!");
                            monster = null;
                            break;
                        }
                        
                        Console.WriteLine("The monster attacks");
                        int monsterDamage = monster.Attack();
                        player.TakeDamage(monsterDamage);
                        
                        if (!player.IsDead()) 
                        {
                            Console.WriteLine("You were defeated by the monster!");
                        }

                        break;

                    // Defend
                    case 2:
                        player.Defend();

                        //     int monsterDamage = monster.Attack();
                        //     player.TakeDamage(monsterDamage);
                            
                        //     if (player.IsDead()) {
                        //         Console.WriteLine("You were defeated by the monster!");
                        //         break;
                        //     }

                        break;

                    // Heal
                    case 3:
                        player.Heal();
                        //     int monsterDamage = monster.Attack();
                        //     player.TakeDamage(monsterDamage);
                            
                        //     if (player.IsDead()) {
                        //         Console.WriteLine("You were defeated by the monster!");
                        //         break;
                        //     }
                        break;
                    // Quit
                    case 4:
                        break;  

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;

                }
                // If we get here, the command was valid and did not quit the loop
                // Console.WriteLine("Command executed successfully");

                // Check if we should break out of the loop
                if (choice == 4)
                {
                    break;
                }

            // end while loop
            }
        }
    }
}