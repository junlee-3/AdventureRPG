using System;
using RPG.Models;
using RPG.Control;
using RPG.Views;

namespace RPG
{

    internal static class Program
    {
        private static void Main(string[] args)
        {

            //string strang = new string("Jun");
            //Console.WriteLine(strang);
            GameController gameController = new GameController(null, null);
            ViewController viewController = new ViewController(gameController);
            viewController.Start();

            //Console.ReadLine();
        }

    }
}