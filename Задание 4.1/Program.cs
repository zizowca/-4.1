using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите число N больше 0");
            int N = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int n=1; n <= 2*N-1; n+=2)
            {
             Sum += n;
            }
            Console.WriteLine("{0}", Sum);
            Console.ReadKey();
        }
    }
}
