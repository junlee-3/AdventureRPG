namespace AdventureRPG;

public class Player
{
    public static string? Name;
    public static int Health;
    public static string[]? Inventory;
    public static string? PlayerClass;
    
    //Constructor
    public Player(string name, int health, string[] inventory, string playerClass)
    {
        Name = name;
        Health = health;
        Inventory = inventory;
        PlayerClass = playerClass;
    }

    public class Warrior
    {
        public static string[] Attacks = {"Sword Slash", "Shield Bash", "Heavy Swing", "Punch"};

        public static void Attack()
        {
            Console.WriteLine("Choose your attack:");
            foreach (var attack in Attacks)
            {
                Console.WriteLine(attack);
                var chosenAttack = Console.ReadLine();
            
                if (chosenAttack == attack)
                {
                    Console.WriteLine($"You have chosen {attack}");
                }
                else
                {
                    Console.WriteLine("Please choose a valid attack!");
                }
            }
           
        }
    }

    public class Mage
    {
        public static string[] Attacks = { "Fireball", "Ice Shard", "Lightning Bolt", "Heal" };
    }

    public class Archer
    {
        public static string[] Attacks = { "Arrow Shot", "Arrow Volley", "Arrow Barrage", "Heal" };
    }
}