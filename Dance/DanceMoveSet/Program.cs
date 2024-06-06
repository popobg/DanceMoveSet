namespace DanceMoveSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];

            bool done = false;
            int index = 0;

            while (index < moves.Length && done == false)
            {
                Console.Write("Type a set move, or done if you're finished: ");
                var userMove = Console.ReadLine();

                while (userMove == "" || userMove == null)
                {
                    Console.Write("You didn't type anything. Please type a set move, or done if you're finished: ");
                    userMove = Console.ReadLine();
                }

                if (userMove == "done")
                {
                    done = true;
                }
                else
                {
                    moves[index] = userMove;
                    index++;
                }
            }

            Console.WriteLine("How many times should we repeat the danse?");

            int numberIteration = Convert.ToInt32(Console.ReadLine());

            RepeatMoves(moves, numberIteration);
        }

        public static void RepeatMoves(string[] array, int iteration)
        {
            for (int i = 0; i < iteration; i++)
            {
                Console.WriteLine(string.Join(" ", array));
                Console.WriteLine();
            }
        }
    }
}
