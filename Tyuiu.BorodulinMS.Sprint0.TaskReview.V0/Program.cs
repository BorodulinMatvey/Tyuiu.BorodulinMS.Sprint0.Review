using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.BorodulinMS.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int First = 1;
            int Second = 2;
            int Third = 3;

            int res = DataService.Calc(First, Second, Third);

            Console.WriteLine("Произведение суммы чисел " + First + "," + Second + "и" + Third + "на 5 равняется " + res);
            Console.ReadKey();
        }
    }
}
