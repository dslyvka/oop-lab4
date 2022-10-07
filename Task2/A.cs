using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class A
    {
        private List<B> childrenOfB = new  List<B>();

        public A(B b1, B b2)
        {
            childrenOfB.Add(b1);
            childrenOfB.Add(b2);
        }

        public A(B b1, B b2, B b3)
        {
            childrenOfB.Add(b1);
            childrenOfB.Add(b2);
            childrenOfB.Add(b3);
        }

        public void ShowTree()
        {
            foreach (B children in childrenOfB)
            {
                children.ShowMethods();
            }
        }
    }
}
