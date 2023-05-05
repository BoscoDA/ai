using ANNCodeModtification.Utilites;

namespace ANNCodeModtification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //character has a armor, weapon, shield, helmet
            var curNeuralNetwork = new NeuralNetWork(1, 6);

            Console.WriteLine("Synaptic weights before training:");
            Printer.PrintMatrix(curNeuralNetwork.SynapsesMatrix);
            var trainingInputs = new double[,]
            {
                    {0,0,0,1,0,0 },
                    {0,0,0,0,0,0 },
                    {1,1,1,0,1,1 },

            }; 


            var trainingOutputs = NeuralNetWork.MatrixTranspose(new double[,]
            {
                {
                   1,0,0
                }
            });

            curNeuralNetwork.Train(trainingInputs, trainingOutputs, 1000000);

            Console.WriteLine("\nSynaptic weights after training:");
            Printer.PrintMatrix(curNeuralNetwork.SynapsesMatrix);


            // testing neural networks against a new problem
            var output = curNeuralNetwork.Think(new double[,] { { 0, 0,0, 1, 0, 0 } });


            Console.Write("\nConsidering new problem:");
            Printer.PrintMatrix(output);

            output = curNeuralNetwork.Think(new double[,] { { 0, 1, 1, 0, 0, 0 } });


            Console.Write("\nConsidering new problem:");
            Printer.PrintMatrix(output);

            output = curNeuralNetwork.Think(new double[,] { { 0, 1, 0, 0, 0, 0 } });


            Console.Write("\nConsidering new problem:");
            Printer.PrintMatrix(output);

            Console.Read();


            //Game game = new Game();
            //game.Run();
        }
    }
}