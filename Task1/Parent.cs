using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Parent
    {
        public virtual void Show(params object[] items)
        {
            foreach(var item in items)
            {
                Debug.Print($"item: {item}");
            }
        }
    }
}
