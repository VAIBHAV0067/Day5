using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    public class LeafYearproject
    {
     public static void leafyear()
        {
            int leap;
            Console.WriteLine("ENTER THE YEAR :- ");
            leap = Convert.ToInt32(Console.ReadLine());
            if (leap % 4 == 0 || leap % 400 == 0)
            {
                Console.WriteLine("these is leaf year ");
            }
            else
            {
                Console.WriteLine("these is not leaf year ");
            }
        }
    }
}
