using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class UC1StackPushPop
    {
        private Node top;  //Node type of top is variable 

        public UC1StackPushPop() //here constructor to initialize value to current instance top variable 
        {
            this.top = null;
        }
        internal void push(int value) //pushing the value into top of the stack
        {
            Node node = new Node(value);  //here node is created and to occuepied the memory and store the data
            if (this.top == null)
            {
                node.next = null; //node initialized to the null
            }
            else
            {
                node.next = this.top;  //node point to the top of the stack
            }
            this.top = node;  //node to assigned to the top of stack
            Console.WriteLine(" {0} push to stack ", value);
        }
        //internal void peek()  //To dislay the top of the stack
        //{
        //    if (this.top == null)
        //    {
        //        Console.WriteLine("\n Stack is empty..");
        //        return;
        //    }
        //    Console.WriteLine("\n {0} is top of the stack. ", this.top.data); //To dislay the top of the stack
        //}

        //internal void pop()  //here delete the element into the top of the stack
        //{
        //    if (this.top == null)
        //    {
        //        Console.WriteLine("\n Stack is Empty, Stack of top Not delete.");
        //        return;
        //    }
        //    Console.WriteLine("\n Data popped {0} in Stack of top. ", this.top.data); //actual popped data display
        //    this.top = this.top.next; //increment top of stack
        //}
        internal void display()  //display the all stack of the data
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " "); //actual display the data in  stack of top
                temp = temp.next;
            }
        }
        internal void peek()  //To dislay the top of the stack
        {
            if (this.top == null)
            {
                Console.WriteLine("\n Stack is empty..");
                return;
            }
            Console.WriteLine("\n {0} is top of the stack. ", this.top.data); //To dislay the top of the stack
        }

        internal void pop()  //here delete the element into the top of the stack
        {
            if (this.top == null)
            {
                Console.WriteLine("\n Stack is Empty, Stack of top Not delete.");
                return;
            }
            Console.WriteLine("\n Data popped {0} in Stack of top. ", this.top.data); //actual popped data display
            this.top = this.top.next; //increment top of stack
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}
