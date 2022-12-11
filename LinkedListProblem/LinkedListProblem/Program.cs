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
            Console.WriteLine("\nWelcome to the LinkedList Operations");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select the operation to perform\n" +
                                   "1.Create LinkedList\n" +
                                   "2.Display\n" +
                                   "3.Add Data In Reverse Order\n"+
                                   "4.Insert Data At Particular Position\n" +
                                   "5.Remove First Element\n" +
                                   "6.Remove Last Node\n" +
                                   "7. Search Node Position\n" +
                                   "8.List Size\n"+
                                   "9.Exit\n");
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
                        list.RemoveLastNode();                        
                        break;
                    case 7:
                        Console.WriteLine("Enter the Value present in List to find Position");
                        int option = Convert.ToInt32(Console.ReadLine());
                        int find = list.Search(option);
                        Console.WriteLine("The Position of Node in LinkedList is " + find);
                        break;
                    case 8:
                        list.Size();
                        break;
                    case 9:
                        flag = false;
                        break;
                }

            }
        }
    }
}
