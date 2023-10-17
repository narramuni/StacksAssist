using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            StackPro stack = new StackPro();
            Console.WriteLine("length of stack=" + stack.getLengthOfStack());
            if (stack.peek() == null)
                Console.WriteLine("Stack contains nothing");
            for (int i = 0; i < 10; i++)
            {
                Node n = new Node();
                n.Data = i.ToString();
                stack.push(n);
                Console.WriteLine("stack Length=" + stack.getLengthOfStack());
            }

            Node node = stack.pop();
            if (node != null)

                Console.WriteLine("Popped " + node.Data);

            node = stack.pop();
            if (node != null)
                Console.WriteLine("Popped " + node.Data);

            Console.WriteLine("Stack Contents: " + stack.listContents());
            Console.ReadLine(); 

        }
    }
}




