using DoublyLinked;
using System;
using GHEAPI;
using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;
using System.IO;

namespace DisplayUI
{
    class Program
    {
        static void Main(string[] args)
        {

            GHEAPIService sc = new GHEAPIService();
            //sc.AssignPendingToCommit();
            //sc.AuthenticateUserAsync();
            Task<List<string>> commits = sc.GetAllCommits();
            commits.Wait(10000);
            DoubleLinkedList list = new DoubleLinkedList();
            foreach (string commit in commits.Result)
            {
                string[] broken_str = commit.Split(' ');
                foreach (var sub_str in broken_str)
                {
                    list.Push(sub_str);
                }
            }

            Console.WriteLine("Linked List before sorting ");
            list.PrintList(list.Head);
            Console.WriteLine("\nLinked List after sorting");
            list.QuickSort(list.Head);
            list.PrintList(list.Head);
            Console.WriteLine("\nLinked List after sorting and count the occurrences");
            list.OccurancesOfElement(list.Head);
            //while (true)
            //{
            //    Console.WriteLine("1.Display List");

            //    Console.WriteLine("2.Insert in empty list ");

            //    Console.WriteLine("3.Insert a node in the Beggining of list");

            //    Console.WriteLine("4.Insert a node at the end of list");

            //    Console.WriteLine("5.Insert a node after a specified node");

            //    Console.WriteLine("6.Insert a node befor a specified node");

            //    Console.WriteLine("7.Delete first node");

            //    Console.WriteLine("8.Delete last node");

            //    Console.WriteLine("9.Delete any node");

            //    Console.WriteLine("10.Reverse the list");

            //    Console.WriteLine("11.search for an element");

            //    Console.WriteLine("12.Quit");

            //    Console.Write("Enter your choice : ");
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    if (choice == 12)
            //        break;
            //    switch (choice)
            //    {
            //        case 1:
            //            list.DisplayList();
            //            break;

            //        case 2:
            //            Console.Write("Enter the element to be inserted : ");
            //            data = Convert.ToInt32(Console.ReadLine());
            //            list.InsertInEmptyList(data);
            //            break;

            //        case 3:
            //            Console.Write("Enter the element to be inserted : ");
            //            data = Convert.ToInt32(Console.ReadLine());
            //            list.InsertInBeginning(data);
            //            break;

            //        case 4:
            //            Console.Write("Enter the element to be inserted : ");
            //            data = Convert.ToInt32(Console.ReadLine());
            //            list.InsertAtEnd(data);
            //            break;

            //        case 5:
            //            Console.Write("Enter the element to be inserted : ");
            //            data = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Enter the element after which to insert : ");
            //            x = Convert.ToInt32(Console.ReadLine());
            //            list.InsertAfter(data, x);
            //            break;

            //        case 6:
            //            Console.Write("Enter the element to be inserted : ");
            //            data = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Enter the element before which to insert : ");
            //            x = Convert.ToInt32(Console.ReadLine());
            //            list.InsertBefore(data, x);
            //            break;

            //        case 7:
            //            list.DeleteFirstNode();
            //            break;

            //        case 8:
            //            list.DeleteLastNode();
            //            break;

            //        case 9:
            //            Console.Write("Enter the element to be deleted : ");
            //            data = Convert.ToInt32(Console.ReadLine());
            //            list.DeleteNode(data);
            //            break;

            //        case 10:
            //            list.ReverseList();
            //            break;

            //        case 11:
            //            Console.WriteLine("Enter the element to be searched : ");
            //            data = Convert.ToInt32(Console.ReadLine());
            //            list.Search(data);
            //            break;

            //        default:
            //            Console.WriteLine("Wrong choice");
            //            break;
            //    }
            //    Console.WriteLine();
            //    //list.QuickSort(list.Head);
            //}
            //Console.WriteLine("Exiting");
        }
    }
}
