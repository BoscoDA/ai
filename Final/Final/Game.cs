using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Game
    {
        Player player { get; set; }
        Player bot { get; set; }
        Random random { get; set; }
        NeuralNetWork botNetwork { get; set; }

        NeuralNetWork playerNetwork { get; set; }

        public Game()
        {
            playerNetwork = new NeuralNetWork(1, 6);
            botNetwork = new NeuralNetWork(1, 6);
            random = new Random();
        }

        public void Run()
        {
            List<string> temples = new List<string>()
            {
                "Water",
                "Forest",
                "Fire"
            };

            Console.Write($"\nWhich temple would you like to go to?");
            Console.WriteLine("\nTemples:");

            foreach (var item in temples)
            {
                Console.WriteLine("- " + item);
            }

            string response = Console.ReadLine().ToLower().Trim();
            bool valid = (response == "fire" || response == "water" || response == "forest") ? true : false;

            while (!valid)
            {
                Console.Write($"\n{response} is not a valid choice!\n");

                Console.Write($"\nWhich temple would you like to go to?");
                Console.WriteLine("Temples:");

                foreach (var item in temples)
                {
                    Console.WriteLine("- " + item);
                }
                response = Console.ReadLine().ToLower().Trim();
                valid = (response == "fire" || response == "water" || response == "forest") ? true : false;
            }

            SetupNeuralNetwork(response);

            Console.WriteLine("\nLoading...");
            Console.WriteLine("\n\nCompleted!");

            player = SetupPlayer();

            Fight();

            Console.ReadKey();
        }
        private void Fight()
        {
            var playerThink = playerNetwork.Think(player.Items);
            double playerAtk = Math.Floor(playerThink[0, 0] * 100);

            while (!player.Defeated)
            {
                bot = SetupBot();

                bool playerWin = DetermineWinner(playerAtk);
                if (playerWin)
                {
                    Console.WriteLine($"{player.Name} has defeated the {bot.Name}!");
                    player.Kills++;
                }
                else
                {
                    Console.WriteLine($"{bot.Name} has defeated the {player.Name}!");
                    Console.WriteLine($"{player.Name} defeated {player.Kills} before being defeated.");
                    player.Defeated = true;
                }
            }
        }

        private bool DetermineWinner(double playerAtk)
        {
            double[,]? botThink = botNetwork.Think(bot.Items);

            double botAtk = Math.Floor( botThink[0, 0] * 100);

            double playerDamage = (playerAtk*player.ATK) - (botAtk*bot.DEF);
            double botDamage = (botAtk * player.ATK) - (playerAtk * player.DEF);

            return playerDamage > botDamage;
        }

        private Player SetupPlayer()
        {
            List<string> items = new List<string>()
            {
                "sword",
                "helmet",
                "potion",
                "shield",
                "armor",
                "empty bottle"
            };

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine().Trim();

            double[,] item = new double[1, 6];
            bool pickedItem = false;
            for (int i = 0; i < items.Count; i++)
            {
                if (!pickedItem)
                {
                    Console.Write($"Would you to take the {items[i]}? (Y/N)");

                    string response = Console.ReadLine().ToLower().Trim();
                    bool valid = (response == "y" || response == "n") ? true : false;

                    while (!valid)
                    {
                        Console.Write($"\n{response} is not a valid choice!\n");

                        Console.Write($"\nWould you to take the {items[i]}? (Y/N)");
                        response = Console.ReadLine().ToLower().Trim();
                        valid = (response == "y" || response == "n") ? true : false;
                    }
                    if (response == "y") 
                    { 
                        item[0, i] = 1;
                        pickedItem = true;
                    }
                    else { item[0, i] = 0; }
                }
                

                
                else { item[0, i] = 0; }
            }

            int atk = 10;
            int def = 10;
            int hp = 10;

            return new Player(name, hp, atk, def, item);

        }

        private Player SetupBot()
        {
            double[,] item = new double[1, 6];
            int i = random.Next(0, 6);

            item[0, i] = random.Next(0,2);

            int atk = 10;
            int def = 10;
            int hp = 10;

            return new Player("Monster", hp, atk, def, item);
        }

        private void SetupNeuralNetwork(string temple)
        {
            double[,] playerTrainingInputs = { };
            double[,] playerTrainingOutputs = { };

            double[,] botTrainingInputs = { };
            double[,] botTrainingOutputs = { };

            //hard
            if (temple.ToLower() == "fire")
            {
                playerTrainingInputs = new double[,] 
                { // just 4
                    {0,0,0,1,0,0 },
                    {0,0,0,0,0,0 },
                    {1,1,1,0,1,1 },
                };
                playerTrainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
                {
                   {
                   1,0,0
                    }
                });


                botTrainingInputs = new double[,]
                {
                    {0,0,0,1,0,0 },
                    {0,0,0,0,0,0 },
                    {1,1,1,0,1,1 },


                    //// just 1 or 6
                    //{ 0,0,0,0,0,0 }, //0
                    //{1,0,0,0,0,0 }, //1
                    //{0,0,0,0,0,1 }, //1
                    //{1,0,0,0,0,1 }, //1
                    //{0,1,1,1,1,0 }, //0
                    //{0,1,1,1,0,0 }, //0
                };
                botTrainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
                {
                   {
                     //0,1,1,1,0,0
                     1,0,0
                    }
                });

            }

            //medium
            else if (temple.ToLower() == "forest")
            {
                playerTrainingInputs = new double[,]
                {  //can pick items 1 and 6 to get bonus
                    { 0,0,0,0,0,0 }, //0
                    {1,0,0,0,0,0 }, //1
                    {0,0,0,0,0,1 }, //1
                    {1,0,0,0,0,1 }, //1
                    {0,1,1,1,1,0 }, //0
                    {0,1,1,1,0,0 }, //0
                };
                playerTrainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
                {
                   {
                        0,1,1,1,0,0
                    }
                });


                botTrainingInputs = new double[,]
                {
                    {0,0,0,1,0,0 },
                    {0,0,0,0,0,0 },
                    {1,1,1,0,1,1 },

                    //{ 0,0,0,0,0,0 }, //0
                    //{ 0,0,0,1,0,0 }, //1
                    //{ 1,1,1,1,0,1 }, //1
                    //{ 1,0,0,0,0,1 }, //0
                    //{ 0,0,1,0,0,0 }, //0
                    //{0,0,0,0,0,1 }, //0
                    //{1,0,0,0,0,0 }, //0
                    //{0,1,1,1,1,0 }, //0
                    //{0,1,1,1,0,0 }, //1
                    //{0,1,1,0,1,0 }, //0
                    //{0,1,0,1,1,0 }, //1
                    //{1,1,1,0,0,0 }, //0
                    //{1,1,1,0,1,1 }, //0
                    //{1,1,1,0,0,1 }, //0
                    //{0,1,0,0,0,0 }, //0
                };
                botTrainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
                {
                   {
                        //0,1,1,0,0,0,0,0,1,0,1,0,0,0,0
                         1,0,0
                    }
                });

            }

            //easy
            else if (temple.ToLower() == "water")
            {
                playerTrainingInputs = new double[,]
                {  //can pick items 2,3 or 4 to get bonus
                   { 0,0,0,0,0,0 }, //0
                    {1,1,1,0,0,0}, //1
                    {1,1,1,1,1,1 }, //1
                    {1,1,1,0,1,0 }, //1
                    {1,1,1,0,0,1}, //1
                    {1,0,0,0,0,0}, //0
                    {1,1,0,0,1,1}, //0
                    {1,0,1,0,1,0}, //0
                };
                playerTrainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
                {
                   {
                    0,1,1,1,1,0,0,0
                    }
                });


                botTrainingInputs = new double[,]
                { // just 4
                    {0,0,0,1,0,0 },
                    {0,0,0,0,0,0 },
                    {1,1,1,0,1,1 },
                };
                botTrainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
                {
                   {
                    1,0,0
                    }
                });

            }

            playerNetwork.Train(playerTrainingInputs, playerTrainingOutputs, 1000000);
            botNetwork.Train(botTrainingInputs, botTrainingOutputs, 1000000);
        }
    }
}
