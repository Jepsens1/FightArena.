using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FightArena
{
    class GUI
    {
        Logic logic = new Logic();
        //Creating a list of heroes
        public void HeroList()
        {

            logic.heroes.Add(new Heroes("Kung fu Harry", 4, 5, 120));
            logic.heroes.Add(new Heroes("Superhunden Dino", 6, 2, 70));
            logic.heroes.Add(new Heroes("Hurtig Karl", 5, 3, 90));
            logic.heroes.Add(new Heroes("Gift Gunner", 4, 5, 80));
            logic.heroes.Add(new Heroes("Minimusen Mikkel", 9, 9, 40));
            logic.heroes.Add(new Heroes("Katten tiger", 3, 4, 35));
            logic.heroes.Add(new Heroes("Gummigeden Ivan", 6, 8, 70));
            logic.heroes.Add(new Heroes("Elgen Egon", 5, 4, 90));

        }
        public void MainMenu()
        {
            //Calling herolist method and then creating a random, and then give player and enemy a random hero from the list
            HeroList();
            Random r = new Random(Guid.NewGuid().GetHashCode());
            Player player = new Player(logic.heroes[r.Next(1, logic.heroes.Count)]);
            Enemy enemy = new Enemy(logic.heroes[r.Next(1, logic.heroes.Count)]);
            Console.WriteLine("Welcome to fight arena");
            Console.WriteLine($"First match is going to be between {player.Name} and {enemy.Name}");
            Console.WriteLine("Press 1 to begin");
            //Making try and catch so the program wont crash and asking user to press 1 to start the fight
            try
            {
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    //calling fighting method from logic class
                    Console.Clear();
                    while (player.BeenKilled == false && enemy.BeenKilled == false)
                    {
                        Console.WriteLine(logic.Fighting(player, enemy));
                    }
                }
                else
                {
                    //If input wrong
                    Console.WriteLine("Wrong input try again");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MainMenu();
                }
            }
            //Throws a exception if user does not input number 
            catch (Exception)
            {

                Console.WriteLine("Wrong input");
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu();
            }



        }

    }
}
