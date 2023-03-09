using System;

namespace RPG.Models
{
    public class Monster
    {
        // attributes
        protected string name;
        protected int health;
        protected bool isAlive = true;
        // Keeps track of the number of instances
        public static int instanceCount = 0;

        // Constructors
        public Monster(string name, int health)
        {
            this.name = name;
            this.health = health;
            instanceCount++;
        }
        // Finalizer: when object instance is made null, count is decreased
        ~Monster()
        {
            instanceCount--;
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
            //Console.WriteLine("I am {0} and I have {1} health points", this.name, this.health);
            if (!this.isAlive == false) 
            {
                Console.WriteLine($"{Name} is alive!");
            }
            // Dice
            return 10;
        }

        public int Defend()
        {
            Console.WriteLine($"{Name} blocks the attack");
            return 10;
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
            Console.WriteLine($"{Name} has {Health} hp remaining");
            return Health;            
        }

        public bool IsDead()
        {
            if (Health <= 0) 
            {
                Alive = false;
            }

            bool alive = (Alive) ? true : false;
            Console.WriteLine($"{Name} is {alive}");
            return alive;
        }
        
        public static int GetInstanceCount()
        {
            return instanceCount;
        }

    }
}