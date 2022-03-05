using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    public class power2
    {
        public int num = 0;
        public static void pow2()
        {
            
            Console.WriteLine("The Power Value of :"); //input from user
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * 2;                    //num*2 if 2*2==4
            Console.WriteLine(result);              //Op
            Console.ReadLine();
         
        }
        
    }
}
