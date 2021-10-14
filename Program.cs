using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleQueue
{
    public class Program
    {
        public static void Main()
        {
            BattleQueue queue = new BattleQueue();

            Console.WriteLine("Inserting in sorted manner: ");
            //
            queue.InsertSort(new Node { Value = 1 });
            queue.InsertSort(new Node { Value = 3 });
            queue.InsertSort(new Node { Value = 2 });
            queue.Print();

            Console.WriteLine("Change value at index 0 (head) to 4: ");
            //
            queue.Change(0, 4);
            queue.Print();

            Console.WriteLine("Print in reverse (from tail): ");
            queue.PrintReverse();

            Console.WriteLine("Print elements continuously as desired by param: ");
            queue.Print(5);
            Console.ReadLine();
        }
    }
}
