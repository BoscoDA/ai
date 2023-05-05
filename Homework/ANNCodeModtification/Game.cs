using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ANNCodeModtification
{
    public class Game
    {
        Player player { get; set; }
        Player bot { get; set; }
        Random random { get; set; }
        NeuralNetWork neuralNetwork { get; set; }

        public Game() 
        {
            neuralNetwork = new NeuralNetWork(1, 6);
            random = new Random();
        }

        public void Run()
        {
            Console.WriteLine("Loading...");

            SetupNeuralNetwork();

            Console.WriteLine("\n\nCompleted!");

            player = SetupPlayer();
            bot = SetupBot();
            ApplyBonusStat();

            Fight();

            Console.ReadKey();
        }
        private void Fight()
        {
            while(player.HP > 0 && bot.HP > 0) 
            {
                Action(player, bot);
                if(player.HP <= 0 || bot.HP <= 0) { break; }
                Action(bot, player);
            }

            if(player.HP <= 0)
            {
                Console.WriteLine("The bot has won!");
            }
            else
            {
                Console.WriteLine("The player has won!");
            }
        }

        private void Action(Player attacker, Player defender)
        {
            var damage = random.Next(attacker.ATK / (defender.DEF/2), attacker.ATK*2 / (defender.DEF/3));
            Console.WriteLine($"{attacker.Name} is attacking {defender.Name}");

            defender.HP -= damage;

            Console.WriteLine($"{attacker.Name} does {damage} Damage to {defender.Name}");
        }

        private void ApplyBonusStat()
        {
            var playerBonus = neuralNetwork.Think(player.Items);
            var botBonus = neuralNetwork.Think(bot.Items);

            int finalPlayer = playerBonus[0,0] >= 0.99 ? 1 : 0;
            int finalBot = botBonus[0, 0] >= 0.99 ? 1 : 0;

            if (finalPlayer == 1 ) 
            {
                player.ATK += random.Next(3,6);
                player.DEF += random.Next(3, 6);
                player.HP += random.Next(3, 6);
            }

            if (finalBot == 1)
            {
                bot.ATK += random.Next(3, 6);
                bot.DEF += random.Next(3, 6);
                bot.HP += random.Next(3, 6);
            }
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

            double[,] item = new double[1,6];

            for (int i = 0; i < items.Count; i++) 
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

                if(response == "y") { item[0,i] = 1; }
                else { item[0,i] = 0; }
            }

            int atk = 10;
            int def = 10;
            int hp = 10;

            return new Player(name, hp, atk, def, item);

        }
        private Player SetupBot()
        {
            double[,] item = new double[1,6];

            for (int i = 0; i < 6; i++)
            {
                item[0,i] = random.Next(0, 2);
            }

            int atk = 10;
            int def = 10;
            int hp = 10;

            return new Player("Jerry", hp, atk, def, item);
        }
        private void SetupNeuralNetwork()
        {
            var trainingInputs = new double[,]
            {
                { 0,0,0,0,0,0 }, //0
                    { 0,0,0,1,0,0 }, //1
                    { 1,1,1,1,0,1 }, //1
                    { 1,0,0,0,0,1 }, //0
                    { 0,0,1,0,0,0 }, //0
                    {0,0,0,0,0,1 }, //0
                    {1,0,0,0,0,0 }, //0
                    {0,1,1,1,1,0 }, //0
                    {0,1,1,1,0,0 }, //1
                    {0,1,1,0,1,0 }, //0
                    {0,1,0,1,1,0 }, //1
                    {1,1,1,0,0,0 }, //0
                    {1,1,1,0,1,1 }, //0
                    {1,1,1,0,0,1 }, //0
                    {0,1,0,0,0,0 }, //0
            };


            var trainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
            {
                {
                   0,1,1,0,0,0,0,0,1,0,1,0,0,0,0
                }
            });

            neuralNetwork.Train(trainingInputs, trainingOutputs, 1000000);
        }
    }
}
