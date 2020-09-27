using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation problem in master branch");
            Random rnd = new Random();
            int empno = rnd.Next(0, 2);
            if (empno == 0)
            {
                Console.WriteLine("Present");
                Random rdm = new Random();
                int b = rdm.Next(0, 2);
                if (b == 0)
                {
                    Console.WriteLine("Part time employee");
                    int pwage, hrs = 4, phwage = 20;
                    pwage = hrs * phwage;
                    Console.WriteLine("Wage is: {0}", pwage);
                }
            }
            else {
                Console.WriteLine("Absent");
            }
            
            
        }
    }
}
