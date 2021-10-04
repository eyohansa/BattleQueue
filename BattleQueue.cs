using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleQueue
{
    public class BattleQueue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void Insert(Node newNode)
        {
            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
        }

        public void Change(int index, int value)
        {
            var iterator = Head;
            if (iterator != null)
            {
                while(index != 0)
                {
                    iterator = iterator.Next;
                    index--;
                }
                iterator.Value = value;
            }
        }

        public void InsertSort(Node newNode)
        {
            var iterator = Head;
            if (iterator == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                iterator = Head;
                ///
                /// TODO: INSERT THEN PUT IN ORDER
                ///
            }
        }

        public void Print()
        {
            var iterator = Head;
            if (iterator != null)
            {
                Console.Write(iterator.Value);
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                    Console.Write($" {iterator.Value}");
                }
            }
            Console.WriteLine(" <<");
        }

        public void PrintReverse()
        {
            var iterator = Tail;
            if (iterator != null)
            {
                Console.Write(iterator.Value);
                while (iterator.Previous != null)
                {
                    iterator = iterator.Previous;
                    Console.Write($" {iterator.Value}");
                }
                Console.WriteLine(" >>");
            }
        }

        public void Print(int count)
        {
            var iterator = Head;
            if (iterator != null && count > 0)
            {
                Console.Write(iterator.Value);
                count--;
                while (count > 0)
                {
                    if (iterator.Next != null)
                        iterator = iterator.Next;
                    else
                        iterator = Head;
                    Console.Write($" {iterator.Value}");
                    count--;
                }
            }
            Console.WriteLine(" <<");
        }
    }
}
