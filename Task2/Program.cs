using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A classA = new A(new ChildB1(), new ChildB2(), new ChildB3());
            classA.ShowTree();
            Console.ReadLine();
        }
    }
}
