using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public  class UC2QueueOperations
    {
        Node head = null;
        internal void Enqueue(int data) //inserting element from begining
        {
            Node node = new Node(data);

            // If queue is empty, then new node is front and rear both  
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }

        //internal void Dequeue() //deleting element from begining
        //{
        //    Node node = new Node();

        //    if (this.head == null)
        //    {
        //        Console.WriteLine("no elements present ");
        //        return;
        //    }
        //    else
        //    {
        //        Node temp = head;
               
        //        while (this.head != null)
        //        {
        //            this.head = this.head.next;
        //           // this.head.next = node;
        //       // Console.WriteLine("hello", temp);
        //        }
        //        this.head.next = node;
        //        //temp.next = null;
        //       // Console.WriteLine(" {0} elements in queue are:", temp);
        //    }
        //    //this.head = temp.next;
        //    //temp = null;
        //    Console.WriteLine(" {0} elements in queue are:", node.data);
        //}
        internal void display()  //display the element of queue
        {
            Node temp = this.head;
            if (temp == null) //checking the front and rear is null or not
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null) //untill fornt and rear not equal then pro
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
