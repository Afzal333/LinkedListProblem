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
                                   "3.Add Data In Reverse Order\n"+
                                   "4.Insert Data At Particular Position"+
                                   "5. Remove First Element"+
                                   "6.Exit");
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
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(70);
                        list.Display();
                        list.InsertAtParticuarPosition(1, 30);                        
                        break;
                    case 5:
                        list.RemoveFirstNode();                       
                        break;
                    case 6:
                        flag = false;
                        break;
                }

            }
        }
    }
}
