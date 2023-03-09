using System;

namespace RPG.Models
{
    public class Player
    {
        // attributes
        protected string name;
        protected int health;
        protected bool isAlive = true;

        public Player(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        // getter and setters
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public bool Alive
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
        }

        public int Attack()
        {
            Console.WriteLine("I am {0} and I have {1} health points", this.name, this.health);
            if (!this.isAlive == false)
            {
                Console.WriteLine($"{this.name} is alive!");
            }
            // Dice
            return 10;
        }

        public int Defend()
        {
            Console.WriteLine($"{Name} blocks the attack");
            Health = Health - 10;
            return Health;
        }

        public int Heal()
        {
            Console.WriteLine($"{Name} heals");
            return 10;
        }

        public int TakeDamage(int damage)
        {
            Console.WriteLine($"{Name} is hit!");
            Health = Health - damage;
            Console.WriteLine($"{this.name} has {this.health} health points");
            return 10;            
        }

        public bool IsDead()
        {
            bool alive = (Alive) ? true : false;
            return alive;
        }

    }

    // class Player : Wizard
    // {
    //     public int Zap()
    //     {
    //         Console.WriteLine($"{Name} zaps it with a magic wand!");

    //         return 100;
    //     }
    // }
}