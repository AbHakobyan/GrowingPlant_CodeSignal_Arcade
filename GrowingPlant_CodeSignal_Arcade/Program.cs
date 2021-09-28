using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingPlant_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int up = 6;
            int down = 5;
            int des = 10;
            int n = growingPlant(up, down, des);
            Console.WriteLine(n);
        }

        static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int sum = 0;
            int count = 0;
            while(sum < desiredHeight)
            {
                sum += upSpeed;
                if (sum < desiredHeight)
                {
                    sum -= downSpeed;
                }
                count++;
            }
            return count;
        }
    }
}
