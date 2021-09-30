using System;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SchoolClass classs = new SchoolClass(5);
            classs[0] = new Learner {Name = "Ivan", LastName = "Ivanov1", MiddleName = "Ivanovich1", Years = 21};
            classs[1] = new Learner {Name = "Ivan", LastName = "Ivanov2", MiddleName = "Ivanovich2", Years = 22};
            classs[2] = new Learner {Name = "Ivan", LastName = "Ivanov3", MiddleName = "Ivanovich3", Years = 23};
            classs[3] = new Learner {Name = "Olga", LastName = "Sidorova", MiddleName = "Victorovna", Years = 20};
            classs[4] = new Learner {Name = "Petya", LastName = "Petrov", MiddleName = "Ivanovich", Years = 25};

         

            Console.WriteLine(classs[0]);
            Console.WriteLine(classs["Ivan"]);

        }
    }
}
