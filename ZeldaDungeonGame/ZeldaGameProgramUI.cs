using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaDungeonGame
{
    class ZeldaGameProgramUI
    {
        static int linksHearts = 18;
        static int linksAttack = 2;
        static string linksChoice;


        static int enemyHealth = 8;
        static int enemyAttack = 1;
        static int ganonsHealth = 10;
        static int ganonsAttack = 1;
        static void Main(string[] args)


        {
            StartUp();
            AttackLoop();

            
        }

        private static void StartUp()
        {
            Console.WriteLine("Welcome Link, there are many enemies lurking in forest, use your fairy and weapons to escape,");
            Console.WriteLine("You are in the Forest of Time, you hear a couple of enemies approach...");
            Console.ReadLine();
          
        }

        private static void AttackLoop()
        {
            do
            {
                Console.WriteLine("You currently have " + linksHearts + "hearts left");
                Console.WriteLine("The enemy has" + enemyHealth + "hearts left");
                Console.WriteLine("Will you use your sword or defend with your shield?");
                linksChoice = Console.ReadLine(); Console.WriteLine();



                if (linksChoice == "sword")
                {
                    Random rand = new Random();
                    int Moblin = (rand.Next(1, 5) * linksAttack);
                    enemyHealth = enemyHealth - Moblin;

                    Console.WriteLine("The Moblin throws his club at you!");
                    Random random = new Random();
                    int Bokoblin = (random.Next(1, 5) * enemyAttack);
                    linksHearts = linksHearts - Bokoblin;

                    Console.WriteLine("You hit the Moblin, it took {0} damage!", Moblin);

                    Console.WriteLine("Link took {0} damage from the Bokoblin!", Bokoblin);

                }
                else if (linksChoice == "shield")
                {
                    Console.WriteLine("The Bokoblin attacks you!");
                    Random rand = new Random();
                    int Bokoblin = (rand.Next(1, 5) * enemyAttack);
                    linksHearts = linksHearts - Bokoblin / 2;

                    Console.WriteLine("Link took {0} hearts from the Bokoblin!", Bokoblin / 2);

                }
                else
                {
                    Console.WriteLine("You hear a fairy nearby...");
                }
            } while (linksHearts > 0 && enemyHealth > 0);

            if (enemyHealth <= 0)
            {
                Console.WriteLine("You defeated the enemy!");
                Console.ReadLine();
            }

            else if (linksHearts <= 0)
            {
                Console.WriteLine("You lost all your hearts!");
                Console.ReadLine();
            }

            if (enemyHealth <= 0)
            {
                Console.WriteLine("You proceed to Ganon's tower");
                Console.ReadLine();
                AttackGanonLoop();

            }

            void AttackGanonLoop()
            {
                do
                {
                    Console.WriteLine("You currently have " + linksHearts + "hearts left");
                    Console.WriteLine("Ganon has" + ganonsHealth + "hearts left");
                    Console.WriteLine("Will you use your sword or defend with your shield?");
                    linksChoice = Console.ReadLine(); Console.WriteLine();



                    if (linksChoice == "sword")
                    {
                        Random rand = new Random();
                        int Ganon = (rand.Next(1, 5) * linksAttack);
                        ganonsHealth = ganonsHealth - Ganon;

                        Console.WriteLine("Ganon uses his dark magic on you!");
                        Random random = new Random();
                        int Ganon1 = (random.Next(1, 5) * ganonsAttack);
                        linksHearts = linksHearts - Ganon;

                        Console.WriteLine("You hit Ganon, it took {0} damage!", Ganon);

                        Console.WriteLine("Link took {0} damage from Ganon!", Ganon);

                    }
                    else if (linksChoice == "shield")
                    {
                        Console.WriteLine("Ganon throws his weapon!");
                        Random rand = new Random();
                        int Ganon = (rand.Next(1, 5) * ganonsAttack);
                        linksHearts = linksHearts - Ganon / 2;

                        Console.WriteLine("Link took {0} hearts from Ganon!", Ganon / 2);

                    }
                    else
                    {
                        Console.WriteLine("You hear a fairy nearby...");
                    }
                } while (linksHearts > 0 && ganonsHealth > 0);

                if (ganonsHealth <= 0)
                {
                    Console.WriteLine("You defeated Ganon and Hyrule returned to it's peaceful state!");
                    Console.ReadLine();
                }

                else if (linksHearts <= 0)
                {
                    Console.WriteLine("You lost all your hearts!");
                    Console.ReadLine();
                }
            }
        }
    }

}