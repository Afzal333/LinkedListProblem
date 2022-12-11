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
            LinkedListQueue queue=new LinkedListQueue();
            LinkedListStack stack = new LinkedListStack();
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
                                   "7.Search Node Position\n" +
                                   "8.List Size\n"+
                                   "9.Delete Node At particular Position\n"+
                                   "10.Insert Node at Particular Existing Position\n"+
                                   "11.Add in Queue\n"+
                                   "12.Display Queue\n"+
                                   "13.Remove from Queue\n"+
                                   "14.Add in Stack\n"+
                                   "15.Display Stack\n"+
                                   "16.Display First Element\n"+
                                   "17.Remove First Element\n"+
                                   "18.Exit\n");
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
                        Console.WriteLine("Enter the Position present in List to Delete");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNodeAtParticularPosition(list.Search(delete));
                        break;
                    case 10:
                        Console.WriteLine("Enter the Position present in List to Insert");
                        int Insert = Convert.ToInt32(Console.ReadLine());
                        int position = list.Search(Insert);
                        Console.WriteLine("Enter the value to Insert");
                        int value = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtParticuarPosition(position + 1, value);
                        break;
                    case 11:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        break;
                    case 12:
                        queue.Display();
                        break;
                    case 13:
                        queue.Dequeue();
                        break;
                    case 14:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        break;
                    case 15:
                        stack.Display();
                        break;
                    case 16:
                        stack.Peek();
                        break;
                    case 17:
                        stack.Pop();
                        break;
                    case 18:
                        flag = false;
                        break;
                }

            }
        }
    }
}
