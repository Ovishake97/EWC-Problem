using System;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R1 = new Random();
            Random R2 = new Random();
            int emp = R1.Next(1, 3);
            int b = R2.Next(1, 3);
            switch (emp) {
                case 1:
                    {
                        Console.WriteLine("Present");
                        switch (b)
                        {
                            case 1: Console.WriteLine("Parttime employee,wage=80"); break;
                            case 2: Console.WriteLine("Fulltime employee,wage=160"); break;
                        }
                        break;
                    }
                case 2: 
                        Console.WriteLine("Absent");break;
                    
            } 
            }
        }
    }

