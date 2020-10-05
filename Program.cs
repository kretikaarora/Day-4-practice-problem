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

            int dieNumber=2;
            while (START_POSITION < 100)
            {

                dieNumber = rand.Next(1, 7);

                if (dieNumber % 3 == LADDER)
                {
                    START_POSITION = START_POSITION + dieNumber;
                    if (START_POSITION == 100) break;
                    else if (START_POSITION > 100) START_POSITION -= dieNumber;
                }
                else if (dieNumber % 3 == SNAKE && START_POSITION >= dieNumber)
                {
                    START_POSITION = START_POSITION - dieNumber;
                }
                else
                {
                    START_POSITION = START_POSITION + 0;

                }
                Console.WriteLine("die number is {0}",dieNumber);
                Console.WriteLine("startposition is {0}",START_POSITION);
            }
            Console.WriteLine("die number is {0}", dieNumber);
            Console.WriteLine("The final postion is {0}",START_POSITION);
        }






        }
    }

