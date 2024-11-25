using System;
namespace HauntedHouseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome, brave adventurer, to the Haunted Mansion of the Nun!");
            Console.ResetColor();

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("You have 5 levels to survive. Will you make it out alive?");

                int level = 1;
                bool gameOver = false;
                int health = 100;

                while (level <= 5 && !gameOver)
                {
                    switch (level)
                    {
                        case 1:
                            gameOver = Level1(ref health);
                            break;
                        case 2:
                            gameOver = Level2(ref health);
                            break;
                        case 3:
                            gameOver = Level3(ref health);
                            break;
                        case 4:
                            gameOver = Level4(ref health);
                            break;
                        case 5:
                            gameOver = Level5(ref health);
                            break;
                    }

                    if (!gameOver)
                    {
                        level++;
                    }
                }

                if (!gameOver)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations! You survived the haunted house!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over! You didn't survive the haunted house.");
                    Console.ResetColor();
                }

                Console.Write("Would you like to play again? (y/n): ");
                string input = Console.ReadLine().ToLower();

                playAgain = input == "y";
            }
        }

        static bool Level1(ref int health)
        {
            Console.WriteLine("You're standing in front of the creepy mansion.");
            Console.WriteLine("Do you want to enter through the creaky front door (1) or the rusty back door (2)?");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You entered through the front door. You hear eerie whispers.");
                health -= 10;
                Console.WriteLine($"Health: {health}");
                return false;
            }
            else if (choice == 2)
            {
                Console.WriteLine("You entered through the back door. You see cobwebs everywhere!");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over.");
                return true;
            }
        }

        static bool Level2(ref int health)
        {
            Console.WriteLine("You're walking down the dark hallway.");
            Console.WriteLine("Do you want to turn on the flickering lights (1) or keep moving forward (2)?");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You turned on the lights. You see a ghostly figure!");
                health -= 20;
                Console.WriteLine($"Health: {health}");
                return false;
            }
            else if (choice == 2)
            {
                Console.WriteLine("You kept moving forward. You fell into a trap! Game over.");
                health = 0;
                Console.WriteLine($"Health: {health}");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over.");
                return true;
            }
        }

        static bool Level3(ref int health)
        {
            Console.WriteLine("You're in a room with two mysterious doors.");
            Console.WriteLine("Do you want to open door 1 (1) or door 2 (2)?");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You opened door 1. You found a health potion!");
                health += 20;
                Console.WriteLine($"Health: {health}");
                return false;
            }
            else if (choice == 2)
            {
                Console.WriteLine("You opened door 2. You see a nun! Game over.");
                health = 0;
                Console.WriteLine($"Health: {health}");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over.");
                return true;
            }
        }

        static bool Level4(ref int health)
        {
            Console.WriteLine("You're in a room with a locked door.");
            Console.WriteLine("Do you want to use the key (1) or search for another way (2)?");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You used the key. The door unlocked!");
                return false;
            }
            else if (choice == 2)
            {
                Console.WriteLine("You searched for another way. You found nothing! Game over.");
                health = 0;
                Console.WriteLine($"Health: {health}");
                return true;
            }
        }
    }
}
