using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Game
    {
        int numberone = 10;
        int numbertwo = 200;
        public void start()
        {
            int biggestnumber = numbertwo;

            Console.WriteLine("of " + numberone + " and " + numbertwo + " the biggest number is " + biggestnumber);
            Console.ReadKey();
        }
        int ReturnBiggestNumber(int first,int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
