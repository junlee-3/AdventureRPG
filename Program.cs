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
            var gameController = new GameController(null, null);
            var viewController = new ViewController(gameController);
            viewController.Start();

            //Console.ReadLine();
        }

    }
}