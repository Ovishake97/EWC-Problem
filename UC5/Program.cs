using System;

namespace UC5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caluclating month wages");
            int hrsprsnt = 8, wage = 20, days = 20;
            int monthwage;
            monthwage = hrsprsnt * wage * days;
            Console.WriteLine("Monthly wage: {0}",monthwage);
        }
    }
}
