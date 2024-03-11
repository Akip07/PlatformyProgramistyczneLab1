using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Item
    {
        int id;
        int value;
        int weight;
        float ratio;

        public Item(int id,int value, int weight)
        {
            this.id = id;
            this.weight = weight;
            this.value = value;
            this.ratio = (float)weight/(float)value;
        }

        public int getId() { return id; }
        public int GetValue() { return value; }
        public int GetWeight() { return weight; }
        public float GetRatio() { return ratio; }


        public void Print()
        {
            Console.WriteLine($"weight: {weight}\tvalue: {value}");
        }
    }

}
