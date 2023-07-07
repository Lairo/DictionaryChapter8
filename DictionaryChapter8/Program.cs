using System;
using System.Collections.Generic;

namespace DictionaryChapter8
{
    class Program
    {
        static void Main()
        {
            //Dictionary<int, RetiredPlayer> retiredYankees = new Dictionary<int, RetiredPlayer>()
            //{
            //    {3, new RetiredPlayer("Babe Ruth", 1948)},
            //    {4, new RetiredPlayer("Lou Gehrig", 1939)},
            //    {5, new RetiredPlayer("Joe DiMaggio", 1952)},
            //    {7, new RetiredPlayer("Mickey Mantle", 1969)},
            //    {8, new RetiredPlayer("Yogi Berra", 1972)},
            //    {10, new RetiredPlayer("Phil Rizzuto", 1985)},
            //    {23, new RetiredPlayer("Don Mattingly", 1997)},
            //    {42, new RetiredPlayer("Jackie Robinson", 1993)},
            //    {44, new RetiredPlayer("Reggie Jackson", 1993)},
            //};

            //foreach (int jerseyNumber in retiredYankees.Keys)
            //{
            //    RetiredPlayer player = retiredYankees[jerseyNumber];
            //    Console.WriteLine($"{player.Name} #{jerseyNumber} retired in {player.YearRetired}");
            //}

            //Queue<string> myQueue = new Queue<string>();
            //myQueue.Enqueue("First in line");
            //myQueue.Enqueue("second in line");
            //myQueue.Enqueue("third in line");
            //myQueue.Enqueue("last in line");

            //Console.WriteLine($"Peek() returned:\n{myQueue.Peek()}");
            //Console.WriteLine($"The first Dequeue(): returned:\n{myQueue.Dequeue()}");
            //Console.WriteLine($"The second Dequeue(): returned:\n{myQueue.Dequeue()}");

            //Console.WriteLine($"Count before Clear():\n{myQueue.Count}");
            //myQueue.Clear();
            //Console.WriteLine($"Count after Clear():\n{myQueue.Count}");

            Stack<string> myStack = new Stack<string>();
            myStack.Push("first in line");
            myStack.Push("second in line");
            myStack.Push("third in line");
            myStack.Push("last in line");

            Queue<string> myQueue = new Queue<string>(myStack);
            List<string> myList = new List<string>(myQueue);
            Stack<string> anotherStack = new Stack<string>(myList);

            Console.WriteLine($@"myQueue has {myQueue.Count} items
myList has {myList.Count} items
anotherStack has {anotherStack.Count} items");
        }
    }
}
