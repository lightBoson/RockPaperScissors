namespace PaperStoneScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome the Gamer
            Welcome();
            Gamer human = CreateUser(); 
            int gamePlayNumber = 0;
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Escape)
            {
                Gamer computer = new(RandomGamerName(), GamerType.Computer);
                Gameplay gameplay = new Gameplay(human, computer, gamePlayNumber++);
                Result result = gameplay.startGameplay();

                if (result == Result.FirstWins)
                {
                    Console.WriteLine("Congratulations " + human.getName() + "!");
                }
                else if (result == Result.SecondWins)
                {
                    Console.WriteLine("Congratulations " + computer.getName() + "!");
                }
                else
                {
                    Console.WriteLine("Draw! Nice try, both of you :)");
                }
                Console.WriteLine("If you want to quit press ESCAPE, to continue press any other button");
                info = Console.ReadKey();

            }


        }
        static void Welcome() {
            Console.WriteLine("Welcome to the game!");
        }
        static Gamer CreateUser()
        {
            string userName = "";
            while (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Please provide your name:");
                userName = Console.ReadLine();
            }

            Gamer human = new(userName, GamerType.Human); 
            // Welcome new human gamer
            Console.WriteLine("Good luck " + userName+"!");    

            return human;
        }

        static string RandomGamerName()
        {
            List<string> names = new List<string>() { "Adam", "Robert", "Pierre", "Lucile", "Eva", "Kate" };
            var random = new Random();
            int index = random.Next(names.Count);
            return names[index];
        }
    }

}