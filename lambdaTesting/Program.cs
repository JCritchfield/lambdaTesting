using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = rand.Next(1, 100);
                //Console.WriteLine(randomNumber);
                intList.Add(randomNumber);
            }

            Console.WriteLine(intList.Find(number => number > 10 && number < 20));
            Console.Read();
        }
    }
}
