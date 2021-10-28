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


            //Console.WriteLine("\n UC2StackProblem.");
            //UC1StackPushPop stackProblem = new UC1StackPushPop();
            //stackProblem.push(56);
            //stackProblem.push(30);
            //stackProblem.push(70);
            //stackProblem.peek();
            //stackProblem.display();
            //stackProblem.pop();
            //stackProblem.display();
        }
    }
}
