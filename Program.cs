using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            int winningPosition = 100;
            int startPosition = 0;
            Random rand = new Random();
            int choice ;
            Console.WriteLine("welcome to snake and ladder simulator");
            Console.WriteLine("Enter the no of players");
            int noOfPlayers = Convert.ToInt32(Console.ReadLine());
            int[] currentPlayersPosition = new int[noOfPlayers];




            int currentPosition = 0;
            for (int i = 0; i < noOfPlayers; i++)
            {
                currentPlayersPosition[i] = 0;
            }

            while (currentPlayersPosition[currentPosition] < winningPosition)
            {
                
                
                do
                {
                    int dieNumber = rand.Next(0, 7);
                    choice = rand.Next(0, 3);
                    switch (choice)
                    {
                        case NO_PLAY:
                            {
                                
                                break;
                            }

                        case LADDER:
                            {
                                if (currentPlayersPosition[currentPosition] + dieNumber > 100)
                                {
                                    continue;

                                }

                                else
                                    currentPlayersPosition[currentPosition] += dieNumber;



                                break;
                            }

                        case SNAKE:
                            {
                                if (currentPlayersPosition[currentPosition] - dieNumber > 0)
                                {
                                    currentPlayersPosition[currentPosition] -= dieNumber;
                                }
                                else
                                    currentPlayersPosition[currentPosition] = startPosition;
                                
                                break;
                            }



                    }
                } while (choice == LADDER);
                if (currentPosition < noOfPlayers - 1) currentPosition++;
                else currentPosition = startPosition;

                for (int i = 0; i < noOfPlayers; i++)
                {
                    Console.WriteLine("Player " + (i + 1) + ", currentPosition " + currentPlayersPosition[i]);
                }
                if (currentPlayersPosition[currentPosition] == 100)
                {
                    Console.WriteLine("player {0} is the winner congratulations",(currentPosition+1));
                }






            }
            
        }

    
            









        }
    }


