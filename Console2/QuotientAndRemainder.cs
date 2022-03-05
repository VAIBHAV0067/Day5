using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    public class QuotientAndRemainder
    {
        public static void CalcutatedQuotientAndRemainder()
        {
            int dividend = 50, divisor = 8;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend: {0}, Divisor: {1}", dividend, divisor);
            Console.WriteLine("Dividend:" + dividend + " Divisor:" + divisor);
            Console.WriteLine("Quotient: {0}", quotient);
            Console.WriteLine("Remainder: {0}", remainder);

        }
        
        
    }
}
