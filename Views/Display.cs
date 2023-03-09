using System;

namespace RPG.Views
{
    public static class Display
    {

        // display methods
        public static void line()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("");
        }

        public static void vertLine()
        {
            Console.Write("|");
            for (int i = 0; i < 28; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

        }

        public static void monster()
        {
            // This prints the figure below
            Console.WriteLine("|                            |");
            Console.WriteLine("|           .-.              |");  
            Console.WriteLine("|          (o o)             |");
            Console.WriteLine("|          | o |             |");
            Console.WriteLine("|          |   |             |");
            Console.WriteLine("|          '---'             |");
            Console.WriteLine("|                            |");
        }

        public static void Actions(string name) 
        {
            // calculate spaces to add to name field
            int numSpaces = 20 -name.Length;
            line();
            vertLine();
            Console.WriteLine("|    Choose your action,     |");
            Console.WriteLine("|        {0}"+ new string(' ', numSpaces)+"|", name);
            vertLine();
            Console.WriteLine("|        (1) AttacK          |");
            Console.WriteLine("|        (2) Defend          |");
            Console.WriteLine("|        (3) Heal            |");
            Console.WriteLine("|        (4) Quit            |");
            vertLine();
            line();
        }

        public static int TwentyDie()
        {
            Random random = new Random();
            int roll = random.Next(1, 21);

            Console.WriteLine("  _____");
            Console.WriteLine(" /     \\");
            Console.WriteLine("/       \\");
            Console.WriteLine("|   {0}   |", roll.ToString().PadLeft(2));
            Console.WriteLine("\\       /");
            Console.WriteLine(" \\_____/");

            return roll;
        }
    }
}