using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {                                       // NET22 Niklas Hagelin
            int difficulty, guess;
            string restart = "";
            bool run = true;

            while (run)
            {
                int guessCount = 0;

                Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök." +
                    "\nVilken svårighetsgrad vill du ha? Välj mellan 1, 2 och 3");
                difficulty = ReadIntFromConsole();

                //Generates a secret random number and take input from user.
                //Gives diffrent responses in case 1 and near or far responses in case 2 & 3.
                //If guesscount is more then 4 or same as random number ask to play again.
                switch (difficulty)
                {
                    case 1:
                        Random rand = new Random();
                        int randomNum = rand.Next(1, 10);

                        Console.WriteLine("Lycka till! Jag tänker på ett tal mellan 1 och 10, vilket tänker jag på?");
                        guess = ReadIntFromConsole();

                        CheckGuess(randomNum, guess);
                        while (guessCount < 4 && guess != randomNum)
                        {
                            Console.WriteLine("Gissa igen!");
                            guess = ReadIntFromConsole();
                            guessCount++;
                            CheckGuess(randomNum, guess);
                        }
                        if (guess == randomNum)
                        {
                            Console.WriteLine("\nVill du spela igen? [Y/N]");
                            restart = Console.ReadLine();
                            if (restart == "Y")
                            {
                                run = true;
                            }
                            else if (restart == "N")
                            {
                                run = false;
                            }
                            else if (restart != "N" && restart != "Y")
                            {
                                run = false;
                            }
                        }
                        if (guessCount == 4 && guess != randomNum)
                        {
                            Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                            Console.WriteLine("Vill du spela igen? [Y/N]");
                            restart = Console.ReadLine();
                            if (restart == "Y")
                            {
                                run = true;
                            }
                            else if (restart == "N")
                            {
                                run = false;
                            }
                            else if (restart != "N" && restart != "Y")
                            {
                                run = false;
                            }


                        }
                        break;
                    case 2:
                        Random rand2 = new Random();
                        int randomNum2 = rand2.Next(1, 25);

                        Console.WriteLine("Lycka till! Jag tänker på ett tal mellan 1 och 25, vilket tänker jag på?");
                        guess = ReadIntFromConsole();

                        CheckCloseOrFar(randomNum2, guess);
                        while (guessCount < 4 && guess != randomNum2)
                        {
                            Console.WriteLine("Gissa igen!");
                            guess = ReadIntFromConsole();
                            guessCount++;
                            CheckCloseOrFar(randomNum2, guess);
                        }
                        if (guess == randomNum2)
                        {
                            Console.WriteLine("\nVill du spela igen? [Y/N]");
                            restart = Console.ReadLine();
                            if (restart == "Y")
                            {
                                run = true;
                            }
                            else if (restart == "N")
                            {
                                run = false;
                            }
                            else if (restart != "N" && restart != "Y")
                            {
                                run = false;
                            }
                        }
                        if (guessCount == 4 && guess != randomNum2)
                        {
                            Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!\n");
                            Console.WriteLine("\nVill du spela igen? [Y/N]");
                            restart = Console.ReadLine();
                            if (restart == "Y")
                            {
                                run = true;
                            }
                            else if (restart == "N")
                            {
                                run = false;
                            }
                            else if (restart != "N" && restart != "Y")
                            {
                                run = false;
                            }
                        }
                        break;
                    case 3:
                        Random rand3 = new Random();
                        int randomNum3 = rand3.Next(1, 50);

                        Console.WriteLine("Lycka till! Jag tänker på ett tal mellan 1 och 50, vilket tänker jag på?");
                        guess = ReadIntFromConsole();

                        CheckCloseOrFar(randomNum3, guess);
                        while (guessCount < 4 && guess != randomNum3)
                        {
                            Console.WriteLine("Gissa igen!");
                            guess = ReadIntFromConsole();
                            guessCount++;
                            CheckCloseOrFar(randomNum3, guess);
                        }
                        if (guess == randomNum3)
                        {
                            Console.WriteLine("\nVill du spela igen? [Y/N]");
                            restart = Console.ReadLine();
                            if (restart == "Y")
                            {
                                run = true;
                            }
                            else if (restart == "N")
                            {
                                run = false;
                            }
                            else if (restart != "N" && restart != "Y")
                            {
                                run = false;
                            }
                        }
                        if (guessCount == 4 && guess != randomNum3)
                        {
                            Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!\n");
                            Console.WriteLine("\nVill du spela igen? [Y/N]");
                            restart = Console.ReadLine();
                            if (restart == "Y")
                            {
                                run = true;
                            }
                            else if (restart == "N")
                            {
                                run = false;
                            }
                            else if (restart != "N" && restart != "Y")
                            {
                                run = false;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("\nDu måste skriva antingen 1, 2 eller 3.\n");
                        break;
                }
            }


        }
        static void CheckGuess(int i, int j) //Check guess and random number.
        {
            Random re = new Random();
            int randomRespons = re.Next(0, 3);
            string[] lowRespons = new string[4] { "Hah! de va lågt!", "Men nuså, högre får du gå",
                    "Tyvärr du gissade för lågt!", "Haha, kan du inte räkna högre än så?" };
            string[] highRespons = new string[4] { "Tyvärr du gissade för högt!", "Skärpning, nu är du för högt",
                "Kan du inte lägre siffror? Då är det kört", "Hahah okej, du får gissa lite lägre" };
            if (i > j)
            {

                Console.WriteLine(lowRespons[randomRespons]);
            }
            else if (i < j)
            {
                Console.WriteLine(highRespons[randomRespons]);
            }
            else
            {
                Console.WriteLine("Woho! Du gjorde det!");
            }
        }
        private static int ReadIntFromConsole() //Prevent input error.
        {
            int myresoult;
            while (!int.TryParse(Console.ReadLine(), out myresoult))
            {
                Console.WriteLine("\nDu måste ange ett heltal\n");
            }
            return myresoult;
        }
        public static void CheckCloseOrFar(int c, int h) //Check if guess is close to the random number.
        {
            if (c == h)
            {
                Console.WriteLine("Woho! Du gjorde det!");
            }
            else if (Math.Abs(c - h) <= 3 && -3 <= (c - h))
            {
                Random close = new Random();
                int closeRandom = close.Next(0, 2);
                string[] closeRespons = new string[] { "Det bränns!", "Nu är du nära!", "Nära!" };
                Console.WriteLine(closeRespons[closeRandom]);
            }
            else
            {
                Random far = new Random();
                int farRandom = far.Next(0, 2);
                string[] farRespons = new string[] { "Långt ifrån!", "Nu är det kallt!", "Du är ute och cyklar!" };
                Console.WriteLine(farRespons[farRandom]);
            }
        }
    }
}
