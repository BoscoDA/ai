namespace Week1Demo
{
    //Fact 0: 1 | Fact 1: Diagonal | Answer 0: Flower | Answer 1: Mushroom | Answer 2: 77
    //Fact 0: 2 | Fact 1: Labradoodle | Answer 0: At Least 6 | Answer 1: Soup | Answer 2: Bee
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();

            Console.ReadKey();
        }
    }
}