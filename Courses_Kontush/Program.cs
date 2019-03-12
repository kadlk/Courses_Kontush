using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses_Kontush
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
            TimeSpan time = DateTime.Now.TimeOfDay;

            if (time.Hours >= 9 && time.Hours <= 12)
            {
                Console.WriteLine("Good morning guys");
            }
            else if ((time.Hours >= 12 && time.Hours <= 15))
            {
                Console.WriteLine("Good day, guys");
            }
            else
            {
                Console.WriteLine("Good evening, guys");
            }

            Console.Read();
        }
    }
}
