using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Butterfly butterfly = new Butterfly();
            cat.ShowPoperties();
            dog.ShowPoperties();
            butterfly.ShowPoperties();
            Console.ReadLine();
        }
    }
}
