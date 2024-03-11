using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject1"), InternalsVisibleTo("WinFormsApp1")]

namespace ConsoleApp6
{
    internal class Backpack
    {
        protected internal List<Item> items = new List<Item>();
        int n;
        int seed;

        public Backpack(int n, int seed)
        {
            if (n < 0)
                this.n = n;
            else
                this.n = 0;
            this.seed = seed;
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                int val = random.Next(1, 11);
                int weight = random.Next(1, 11);
                items.Add(new Item(i, val, weight));
            }
        }

        override public string ToString()
        {
            string str =  $"List seed: {seed}\r\nnumber of items: {n}\r\n";
            for (int i = 0;i < items.Count;i++)
            {
                str += $"item {items[i].getId()}\r\tweight: {items[i].GetWeight()}\r\tvalue: {items[i].GetValue()}\r\n";
            }
            return str;
        }

        public Result Solve(int capacity)
        {
            Result result = new Result();
            items.Sort((p, q) => p.GetRatio().CompareTo(q.GetRatio()));
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].GetWeight()+result.GetTotalWeight() > capacity)
                {
                    continue;
                }
                result.Add(items[i]);

            }
            return result;

        }

    }
}
