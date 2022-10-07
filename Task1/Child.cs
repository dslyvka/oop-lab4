using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Child : Parent
    {
        Random random = new Random();

        public override void Show(params object[] items)
        {
            foreach (var item in items)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.WriteLine($"item type: {item.GetType()} - item value: {item}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
