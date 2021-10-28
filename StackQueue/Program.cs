using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Stack operation Push and Pop:");
            UC1StackPushPop stk = new UC1StackPushPop();
            stk.push(56);
            stk.push(30);
            stk.push(70);
            stk.display();
            stk.peek();
            stk.pop();
            stk.IsEmpty();
            stk.display();
        }
    }
}
