using System;
using RPG.Models;
using RPG.Control;

namespace RPG.Views
{
    class ViewController
    {
        // attributes
        private GameController gameController;

        // constructor   
        public ViewController(GameController gameController) 
        {
            this.gameController = gameController;
        }

        // methods
        public void Start() 
        {
            Display.line();
            Display.vertLine();
            
            Console.WriteLine("|  Welcome to the RPG game!  |");
            Display.monster();
            Display.vertLine();
            Display.line();

            Console.WriteLine("Enter your player name:");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName, 100);

            // string wizardName = Console.ReadLine();
            // Wizard wizard = new Wizard(wizardName,100);
            
            Console.WriteLine("Enter the monster name:");
            string monsterName = Console.ReadLine();
            Monster monster = new Monster(monsterName, 50);
            
            gameController = new GameController(player, monster);
            gameController.Run();
            
            Console.Write("Thanks for playing!");
            Console.WriteLine(" Enter Ctrl C to quit");
            Console.ReadLine();

        }

    }
}