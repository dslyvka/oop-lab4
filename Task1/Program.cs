using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();   
            parent.Show("aaaa", 9, true);

            Child child = new Child();
            child.Show("bbb", 10, false);

            Console.ReadLine();
        }
    }
}
