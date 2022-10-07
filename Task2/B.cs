using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    internal class B
    {
        public virtual void method1()
        {
            Console.WriteLine("I am method 1");
        }

        public virtual void method2()
        {
            Console.WriteLine("I am method 2");
        }

        public virtual void method3()
        {
            Console.WriteLine("I am method 3");
        }

        public virtual void ShowMethods()
        {
            Console.WriteLine(this.GetType().Name);

            foreach (var method in this.GetType().GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}
