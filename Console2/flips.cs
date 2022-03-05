using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    public class flips
    {
        public static void CalculatePercentage()
        {
            Console.WriteLine("Please enter the valu for number of fillps");
            int count = 1;
            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int Flip = Convert.ToInt32(Console.ReadLine());

            if (Flip > 0)
            {
                for (int i = 1; i <= Flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);

                     if(number==1)
                    {
                        Head =1;
                      HeadCount += count;
                    
                    }
                    else if(number==0)
                    {
                       Tail =1;
                     TailCount += count;
                    TailCount =TailCount + Tail;
                      }

                    switch (number)
                    {
                        case 0:
                            TailCount++;
                            break;
                        case 1:
                            HeadCount++;
                            break;

                    }
                }
                Console.WriteLine("-------------");
                HeadPercentage = (HeadCount * 100) / Flip;
                TailPercentage = (TailCount * 100) / Flip;
                Console.WriteLine(HeadPercentage);
                Console.WriteLine(TailPercentage);
            }
            else
            {
                Console.WriteLine("Enter Positive Integer");
            }
        }
    }
}
