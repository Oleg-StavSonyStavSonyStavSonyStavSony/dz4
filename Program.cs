using System;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SchoolClass classs = new SchoolClass(5);
            classs[0] = new Learner {Name = "Ivan", LastName = "Ivanov", MiddleName = "Ivanovich", Years = 20};
            Console.WriteLine(classs[0]);

        }
    }
}
