using System;

namespace day4_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int START_POSITION = 0;
            Random rand = new Random();
            const int  NO_PLAY= 0;
            const int LADDER = 1;
            const int SNAKE = 2;
          
                int dieNumber = rand.Next(1, 7);

                if (dieNumber % 3 == LADDER)
                {
                    START_POSITION = START_POSITION + dieNumber;
                }
                else if (dieNumber % 3 == SNAKE && START_POSITION >= dieNumber)
                {
                    START_POSITION = START_POSITION - dieNumber;
                }
                else
                {
                    START_POSITION = START_POSITION + 0;

                }
               
            }






        }
    }

