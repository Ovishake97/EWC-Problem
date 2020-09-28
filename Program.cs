using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation problem on master branch");
            Random rnd = new Random();
            int empno = rnd.Next(0, 2);
            if (empno == 1) {
                Console.WriteLine("Present");
            }
            else {
                Console.WriteLine("Absent");
            }
            if (empno == 1) {
                int empsalary = 1;
                int hours = 8; int wage = 20;
                empsalary = hours * wage;
                Console.WriteLine("Daily wage: {0}", empsalary);
            }
        }
    }
}
