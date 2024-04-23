using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datové_struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[10];
            pole[9] = 1;

            List<int> list = new List<int>();
            list.Add(1);
            list.Remove(1);
            list.RemoveAll((int i) => i == 1);
            list.RemoveAt(0);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int hodnota4 = queue.Peek();
            int hodnota5 = queue.Dequeue();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
        }
    }
}
