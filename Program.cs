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
            queue.InsertSort(new Node { Value = 1 });
            queue.InsertSort(new Node { Value = 3 });
            queue.InsertSort(new Node { Value = 2 });
            queue.Print();
            queue.Change(0, 4);
            queue.Print();
            queue.PrintReverse();
            queue.Print(5);
            Console.ReadLine();
        }
    }
}
