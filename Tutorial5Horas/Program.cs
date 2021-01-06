using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            String playerInput, cpuInput;
            int cpu;
            Random rand = new Random();
            bool playAgain = true;
            while (playAgain)
            {
                int cpuScore = 0, playerScore = 0;
                while (playerScore < 3 && cpuScore < 3)
                {
                    init:
                    Console.WriteLine("Choose between ROCK, PAPER and SCISSORS");
                    playerInput = Console.ReadLine().ToUpper();
                    cpu = rand.Next(2);
                    if(playerInput != "SCISSORS" && playerInput != "PAPER" && playerInput != "ROCK")
                    {
                        Console.WriteLine("Invalid answer, please try again");
                        goto init;
                    }

                    switch (cpu)
                    {
                        case 0:
                            cpuInput = "ROCK";
                            Console.WriteLine("Cpu choose " + cpuInput);
                            Console.WriteLine("You choose " + playerInput);
                            if (playerInput == "ROCK")
                                Console.WriteLine("Draw");
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("You win");
                                playerScore++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("You lost");
                                cpuScore++;
                            }
                            showScore(playerScore, cpuScore);
                            break;
                        case 1:
                            cpuInput = "PAPER";
                            Console.WriteLine("Cpu choose " + cpuInput);
                            Console.WriteLine("You choose " + playerInput);
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("You lost");
                                cpuScore++;
                            }
                            else if (playerInput == "PAPER")
                                Console.WriteLine("Draw");
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("You win");
                                playerScore++;
                            }
                            showScore(playerScore, cpuScore);
                            break;
                        case 2:
                            cpuInput = "SCISSORS";
                            Console.WriteLine("Cpu choose " + cpuInput);
                            Console.WriteLine("You choose " + playerInput);
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("You win");
                                playerScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("You lost");
                                cpuScore++;
                            }
                            else if (playerInput == "SCISSORS")
                                Console.WriteLine("Draw");
                            showScore(playerScore, cpuScore);
                            break;
                    }
                }
                play:
                Console.WriteLine("Do you want to continue? y/n");
                String answer = Console.ReadLine().ToLower();
                if(answer == "y")
                {
                    playAgain = true;
                }else if(answer == "n")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid response, try again");
                    goto play;
                }
            }

        }

        static void showScore(int a, int b)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("| You " + a + " | Cpu " + b + " |");
            Console.WriteLine("-----------------");
        }
    }
}
