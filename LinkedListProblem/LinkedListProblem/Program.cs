using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Welcome to the LinkedList Operations");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select the operation to perform\n" +
                                   "1.Create LinkedList\n" +
                                   "2.Display\n" +
                                   "3.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                }

            }
        }
    }
}
